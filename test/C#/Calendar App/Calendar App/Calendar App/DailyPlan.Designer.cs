namespace Calendar_App
{
    partial class DailyPlan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnJob = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsAddJob = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsJobToday = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpkDay = new System.Windows.Forms.DateTimePicker();
            this.btnPreDay = new System.Windows.Forms.Button();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnJob);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 446);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNextDay);
            this.panel2.Controls.Add(this.btnPreDay);
            this.panel2.Controls.Add(this.dtpkDay);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 27);
            this.panel2.TabIndex = 0;
            // 
            // pnJob
            // 
            this.pnJob.Location = new System.Drawing.Point(3, 36);
            this.pnJob.Name = "pnJob";
            this.pnJob.Size = new System.Drawing.Size(954, 407);
            this.pnJob.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsAddJob,
            this.mnsJobToday});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsAddJob
            // 
            this.mnsAddJob.Name = "mnsAddJob";
            this.mnsAddJob.Size = new System.Drawing.Size(73, 20);
            this.mnsAddJob.Text = "Thêm việc";
            this.mnsAddJob.Click += new System.EventHandler(this.mnsAddJob_Click);
            // 
            // mnsJobToday
            // 
            this.mnsJobToday.Name = "mnsJobToday";
            this.mnsJobToday.Size = new System.Drawing.Size(68, 20);
            this.mnsJobToday.Text = "Hôm nay";
            this.mnsJobToday.Click += new System.EventHandler(this.mnsJobToday_Click);
            // 
            // dtpkDay
            // 
            this.dtpkDay.Location = new System.Drawing.Point(350, 3);
            this.dtpkDay.Name = "dtpkDay";
            this.dtpkDay.Size = new System.Drawing.Size(268, 20);
            this.dtpkDay.TabIndex = 0;
            this.dtpkDay.ValueChanged += new System.EventHandler(this.dtpkDay_ValueChanged);
            // 
            // btnPreDay
            // 
            this.btnPreDay.Location = new System.Drawing.Point(3, 3);
            this.btnPreDay.Name = "btnPreDay";
            this.btnPreDay.Size = new System.Drawing.Size(75, 20);
            this.btnPreDay.TabIndex = 1;
            this.btnPreDay.Text = "Hôm qua";
            this.btnPreDay.UseVisualStyleBackColor = true;
            this.btnPreDay.Click += new System.EventHandler(this.btnPreDay_Click);
            // 
            // btnNextDay
            // 
            this.btnNextDay.Location = new System.Drawing.Point(879, 3);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(75, 20);
            this.btnNextDay.TabIndex = 1;
            this.btnNextDay.Text = "Ngày mai";
            this.btnNextDay.UseVisualStyleBackColor = true;
            this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
            // 
            // DailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DailyPlan";
            this.Text = "DailyPlan";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnJob;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DateTimePicker dtpkDay;
        private System.Windows.Forms.ToolStripMenuItem mnsAddJob;
        private System.Windows.Forms.ToolStripMenuItem mnsJobToday;
        private System.Windows.Forms.Button btnPreDay;
        private System.Windows.Forms.Button btnNextDay;
    }
}