using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar_App
{
    public partial class UCrtAJob : UserControl
    {
        private PlanItem job;
        public PlanItem Job { get => job; set => job = value; }
        public UCrtAJob(PlanItem job)
        {
            InitializeComponent();
            cbJobStatus.DataSource = PlanItem.ListStatus;
            this.Job = job;
            ShowInfo();
        }
        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }
        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }

        void ShowInfo()
        {
            txbJob.Text = job.Job;
            nrFromHour.Value = job.FromTime1.X;
            nrFromMinute.Value = job.FromTime1.Y;
            nrToHour.Value = job.ToTime1.X;
            nrToMinute.Value = job.ToTime1.Y;
            cbJobStatus.SelectedIndex = PlanItem.ListStatus.IndexOf(job.Status1);
            ckbFinishJob.Checked = PlanItem.ListStatus.IndexOf(job.Status1) == (int)EPlanItem.DONE ? true : false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            job.Job = txbJob.Text;
            job.FromTime1 = new Point((int)nrFromHour.Value, (int)nrFromMinute.Value);
            job.ToTime1 = new Point((int)nrToHour.Value, (int)nrToMinute.Value);
            job.Status1 = PlanItem.ListStatus[cbJobStatus.SelectedIndex];
            if (edited != null)
                edited(this, new EventArgs());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (deleted != null)
                deleted(this, new EventArgs());
        }

        private void ckbFinishJob_CheckedChanged(object sender, EventArgs e)
        {
            cbJobStatus.SelectedIndex = ckbFinishJob.Checked ? (int)EPlanItem.DONE : (int)EPlanItem.DOING;
        }
    }
}
