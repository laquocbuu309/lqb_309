namespace Calendar_App
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nrNotify = new System.Windows.Forms.NumericUpDown();
            this.ckbNotify = new System.Windows.Forms.CheckBox();
            this.btnToDay = new System.Windows.Forms.Button();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMatrix = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSunday = new System.Windows.Forms.Button();
            this.btnSaturday = new System.Windows.Forms.Button();
            this.btnFriday = new System.Windows.Forms.Button();
            this.btnThursday = new System.Windows.Forms.Button();
            this.btnWednesday = new System.Windows.Forms.Button();
            this.btnTuesday = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnPreMonth = new System.Windows.Forms.Button();
            this.btnMonday = new System.Windows.Forms.Button();
            this.tmNotify = new System.Windows.Forms.Timer(this.components);
            this.ntfIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrNotify)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 437);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.btnToDay);
            this.panel3.Controls.Add(this.dtpkDate);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(818, 54);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.nrNotify);
            this.panel6.Controls.Add(this.ckbNotify);
            this.panel6.Location = new System.Drawing.Point(6, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(233, 46);
            this.panel6.TabIndex = 2;
            // 
            // nrNotify
            // 
            this.nrNotify.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nrNotify.Location = new System.Drawing.Point(87, 12);
            this.nrNotify.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nrNotify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrNotify.Name = "nrNotify";
            this.nrNotify.Size = new System.Drawing.Size(50, 20);
            this.nrNotify.TabIndex = 1;
            this.nrNotify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrNotify.ValueChanged += new System.EventHandler(this.nrNotify_ValueChanged);
            // 
            // ckbNotify
            // 
            this.ckbNotify.AutoSize = true;
            this.ckbNotify.Location = new System.Drawing.Point(3, 13);
            this.ckbNotify.Name = "ckbNotify";
            this.ckbNotify.Size = new System.Drawing.Size(78, 17);
            this.ckbNotify.TabIndex = 0;
            this.ckbNotify.Text = "Thông báo";
            this.ckbNotify.UseVisualStyleBackColor = true;
            this.ckbNotify.CheckedChanged += new System.EventHandler(this.ckbNotify_CheckedChanged);
            // 
            // btnToDay
            // 
            this.btnToDay.Location = new System.Drawing.Point(517, 16);
            this.btnToDay.Name = "btnToDay";
            this.btnToDay.Size = new System.Drawing.Size(75, 20);
            this.btnToDay.TabIndex = 1;
            this.btnToDay.Text = "Hôm Nay";
            this.btnToDay.UseVisualStyleBackColor = true;
            this.btnToDay.Click += new System.EventHandler(this.btnToDay_Click);
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(290, 16);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(204, 20);
            this.dtpkDate.TabIndex = 0;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlMatrix);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(3, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 370);
            this.panel2.TabIndex = 0;
            // 
            // pnlMatrix
            // 
            this.pnlMatrix.Location = new System.Drawing.Point(129, 60);
            this.pnlMatrix.Name = "pnlMatrix";
            this.pnlMatrix.Size = new System.Drawing.Size(561, 307);
            this.pnlMatrix.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSunday);
            this.panel4.Controls.Add(this.btnSaturday);
            this.panel4.Controls.Add(this.btnFriday);
            this.panel4.Controls.Add(this.btnThursday);
            this.panel4.Controls.Add(this.btnWednesday);
            this.panel4.Controls.Add(this.btnTuesday);
            this.panel4.Controls.Add(this.btnNextMonth);
            this.panel4.Controls.Add(this.btnPreMonth);
            this.panel4.Controls.Add(this.btnMonday);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(815, 50);
            this.panel4.TabIndex = 0;
            // 
            // btnSunday
            // 
            this.btnSunday.Location = new System.Drawing.Point(611, 3);
            this.btnSunday.Name = "btnSunday";
            this.btnSunday.Size = new System.Drawing.Size(75, 43);
            this.btnSunday.TabIndex = 0;
            this.btnSunday.Text = "Chủ Nhật";
            this.btnSunday.UseVisualStyleBackColor = true;
            // 
            // btnSaturday
            // 
            this.btnSaturday.Location = new System.Drawing.Point(530, 3);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Size = new System.Drawing.Size(75, 43);
            this.btnSaturday.TabIndex = 0;
            this.btnSaturday.Text = "Thứ 7";
            this.btnSaturday.UseVisualStyleBackColor = true;
            // 
            // btnFriday
            // 
            this.btnFriday.Location = new System.Drawing.Point(449, 3);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Size = new System.Drawing.Size(75, 43);
            this.btnFriday.TabIndex = 0;
            this.btnFriday.Text = "Thứ 6";
            this.btnFriday.UseVisualStyleBackColor = true;
            // 
            // btnThursday
            // 
            this.btnThursday.Location = new System.Drawing.Point(368, 3);
            this.btnThursday.Name = "btnThursday";
            this.btnThursday.Size = new System.Drawing.Size(75, 43);
            this.btnThursday.TabIndex = 0;
            this.btnThursday.Text = "Thứ 5";
            this.btnThursday.UseVisualStyleBackColor = true;
            // 
            // btnWednesday
            // 
            this.btnWednesday.Location = new System.Drawing.Point(287, 3);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(75, 43);
            this.btnWednesday.TabIndex = 0;
            this.btnWednesday.Text = "Thứ 4";
            this.btnWednesday.UseVisualStyleBackColor = true;
            // 
            // btnTuesday
            // 
            this.btnTuesday.Location = new System.Drawing.Point(206, 3);
            this.btnTuesday.Name = "btnTuesday";
            this.btnTuesday.Size = new System.Drawing.Size(75, 43);
            this.btnTuesday.TabIndex = 0;
            this.btnTuesday.Text = "Thứ 3";
            this.btnTuesday.UseVisualStyleBackColor = true;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Location = new System.Drawing.Point(723, 3);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(89, 43);
            this.btnNextMonth.TabIndex = 0;
            this.btnNextMonth.Text = "Tháng sau";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // btnPreMonth
            // 
            this.btnPreMonth.Location = new System.Drawing.Point(3, 3);
            this.btnPreMonth.Name = "btnPreMonth";
            this.btnPreMonth.Size = new System.Drawing.Size(89, 43);
            this.btnPreMonth.TabIndex = 0;
            this.btnPreMonth.Text = "Tháng trước";
            this.btnPreMonth.UseVisualStyleBackColor = true;
            this.btnPreMonth.Click += new System.EventHandler(this.btnPreMonth_Click);
            // 
            // btnMonday
            // 
            this.btnMonday.Location = new System.Drawing.Point(125, 3);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Size = new System.Drawing.Size(75, 43);
            this.btnMonday.TabIndex = 0;
            this.btnMonday.Text = "Thứ 2";
            this.btnMonday.UseVisualStyleBackColor = true;
            // 
            // tmNotify
            // 
            this.tmNotify.Enabled = true;
            this.tmNotify.Interval = 10000;
            this.tmNotify.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ntfIcon
            // 
            this.ntfIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfIcon.Icon")));
            this.ntfIcon.Text = "Lập Lịch";
            this.ntfIcon.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 465);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Lịch Làm Việc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrNotify)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown nrNotify;
        private System.Windows.Forms.CheckBox ckbNotify;
        private System.Windows.Forms.Button btnToDay;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMatrix;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSunday;
        private System.Windows.Forms.Button btnSaturday;
        private System.Windows.Forms.Button btnFriday;
        private System.Windows.Forms.Button btnThursday;
        private System.Windows.Forms.Button btnWednesday;
        private System.Windows.Forms.Button btnTuesday;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnPreMonth;
        private System.Windows.Forms.Button btnMonday;
        private System.Windows.Forms.Timer tmNotify;
        private System.Windows.Forms.NotifyIcon ntfIcon;
    }
}

