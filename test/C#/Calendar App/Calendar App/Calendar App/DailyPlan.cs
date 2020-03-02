using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar_App
{
    public partial class DailyPlan : Form
    {
        private DateTime date;
        private PlanData Job;
        public DateTime Date { get => date; set => date = value; }
        public PlanData Job1 { get => Job; set => Job = value; }
        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        public DailyPlan(DateTime date, PlanData Job)
        {
            InitializeComponent();
            this.Date = date;
            this.Job1 = Job;
            fPanel.Height = pnJob.Height;
            fPanel.Width = pnJob.Width;
            pnJob.Controls.Add(fPanel);

            dtpkDay.Value = Date;
        }

        void ShowJobByDay(DateTime date)
        {
            fPanel.Controls.Clear();
            if (Job1 != null && Job1.Job != null)
            {
                List<PlanItem> TodayJob = GetJobByDay(date);

                for (int i = 0; i < TodayJob.Count; i++)
                {
                    AddJob(TodayJob[i]);
                }

            }
        }

        void AddJob(PlanItem newJob)
        {
            UCrtAJob aJob = new UCrtAJob(newJob);
            aJob.Deleted += AJob_Deleted;
            aJob.Edited += AJob_Edited;
            fPanel.Controls.Add(aJob);
        }
        private void AJob_Edited(object sender, EventArgs e)
        {
        }

        private void AJob_Deleted(object sender, EventArgs e)
        {
            UCrtAJob uc = sender as UCrtAJob;
            PlanItem deleteJob = uc.Job;
            fPanel.Controls.Remove(uc);
            Job.Job.Remove(deleteJob);
        }

        List<PlanItem> GetJobByDay(DateTime date)
        {
            return Job.Job.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
        }
        private void btnPreDay_Click(object sender, EventArgs e)
        {
            dtpkDay.Value = dtpkDay.Value.AddDays(-1);
        }
        private void btnNextDay_Click(object sender, EventArgs e)
        {
            dtpkDay.Value = dtpkDay.Value.AddDays(1);
        }
        private void dtpkDay_ValueChanged(object sender, EventArgs e)
        {
            ShowJobByDay((sender as DateTimePicker).Value);
        }

        private void mnsAddJob_Click(object sender, EventArgs e)
        {
            PlanItem item = new PlanItem() { Date = dtpkDay.Value };
            Job.Job.Add(item);
            AddJob(item);
        }

        private void mnsJobToday_Click(object sender, EventArgs e)
        {
            dtpkDay.Value = DateTime.Now;
        }
    }
}
