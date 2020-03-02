using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Calendar_App
{
    public partial class Form1 : Form
    {
        #region Propeties
        private int appTime = 0;
        private List<List<Button>> Matrix;
        private string filePath = "Data.xml";
        public List<List<Button>> Matrix1 { get => Matrix; set => Matrix = value; }
        public PlanData Job { get => job; set => job = value; }

        private PlanData job;

        private List<string> DayOfWeek = new List<string>{ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion
        public Form1()
        {
            InitializeComponent();
            RegistryKey regkey = Registry.CurrentUser.CreateSubKey("Software\\LapLich");
            //mo registry khoi dong cung win
            RegistryKey regstart = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            string keyvalue = "1";
            //string subkey = "Software\\ManhQuyen";
            try
            {
                //chen gia tri key
                regkey.SetValue("Index", keyvalue);
                //regstart.SetValue("taoregistrytronghethong", "E:\\Studing\\Bai Tap\\CSharp\\Channel 4\\bai temp\\tao registry trong he thong\\tao registry trong he thong\\bin\\Debug\\tao registry trong he thong.exe");
                regstart.SetValue("LapLich", Application.StartupPath + "\\Lập lịch.exe");
                ////dong tien trinh ghi key
                //regkey.Close();
            }
            catch
            {
            }
            tmNotify.Start();
            LoadDayMatrix();
            try
            {
                Job = deseriallize(filePath) as PlanData;
            }
            catch
            {
                SetDefaultJob();
            }

        }

        void SetDefaultJob()
        {
            Job = new PlanData();
            Job.Job = new List<PlanItem>();
            Job.Job.Add(new PlanItem() { Date = DateTime.Now, FromTime1 = new Point(5, 0), ToTime1 = new Point(6, 0), Job = "Testing", Status1 = PlanItem.ListStatus[(int)EPlanItem.COMING]});
        }
        void LoadDayMatrix()
        {
            Matrix = new List<List<Button>>();
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.mergin, 0) };
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { Height = Cons.dateButtonHeight, Width = Cons.dateButtonWidth };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.mergin, oldBtn.Location.Y);
                    btn.Click += Btn_Click;
                    pnlMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.mergin, oldBtn.Location.Y + oldBtn.Height) };
            }
            SetDefaultDate();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
                return;
            DailyPlan dailyPlan = new DailyPlan(new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, Convert.ToInt32((sender as Button).Text)), Job);
            dailyPlan.ShowDialog();
        }

        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30;
            }
        }

        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.White;
                }
            }
        }


        void SetDefaultDate()
        {
            dtpkDate.Value = DateTime.Now;
        }
        void AddNumberToMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime userdate = new DateTime(date.Year, date.Month, 1);
            
            int line = 0;

            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = DayOfWeek.IndexOf(userdate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();
                if (IsEqualDate(userdate, DateTime.Now))
                {
                    btn.BackColor = Color.Yellow;
                }
                if (IsEqualDate(userdate, date))
                {
                    btn.BackColor = Color.Aqua;
                }
                if (column >= 6)
                {
                    line++;
                }
                userdate = userdate.AddDays(1);
            }
        }

        bool IsEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }
        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberToMatrixByDate((sender as DateTimePicker).Value);
        }

        private void btnPreMonth_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }

        private void btnToDay_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }

        private void SeriallizeXML(object data, string filePath) // Lưu dữ liệu xuống 
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write); // Mở file xml 
            XmlSerializer sr = new XmlSerializer(typeof(PlanData)); // Tạo seriallize để lưu data xuống file xml

            sr.Serialize(fs, data);
            fs.Close();
        }

        private object deseriallize(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read); // Mở file xml 
            XmlSerializer sr = new XmlSerializer(typeof(PlanData)); // Tạo seriallize để lưu data xuống file xml
            try
            {
                object result = sr.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch (Exception)
            {
                fs.Close();
                throw new NotImplementedException();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SeriallizeXML(job, filePath);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (!ckbNotify.Checked)
                return;
            appTime++;
            if (appTime*10 < Cons.notifyTime)
                return;
            appTime = 0;
            if (job.Job == null)
                return;

            List<PlanItem> todayJob = job.Job.Where(p => p.Date.Year == DateTime.Now.Year && p.Date.Month == DateTime.Now.Month && p.Date.Day == DateTime.Now.Day).ToList();
            ntfIcon.ShowBalloonTip(Cons.timeOutNtf, "Lịch Công Việc", string.Format("Bạn có {0} công việc trong ngày hôm nay",todayJob.Count),ToolTipIcon.Info);
            
        }

        private void nrNotify_ValueChanged(object sender, EventArgs e)
        {
            Cons.notifyTime = (int)nrNotify.Value *60;
        }

        private void ckbNotify_CheckedChanged(object sender, EventArgs e)
        {
            nrNotify.Enabled = !ckbNotify.Checked;
        }
    }
}
