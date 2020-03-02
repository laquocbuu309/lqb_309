namespace Calendar_App
{
    partial class UCrtAJob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ckbFinishJob = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.cbJobStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nrToMinute = new System.Windows.Forms.NumericUpDown();
            this.nrFromMinute = new System.Windows.Forms.NumericUpDown();
            this.nrToHour = new System.Windows.Forms.NumericUpDown();
            this.nrFromHour = new System.Windows.Forms.NumericUpDown();
            this.txbJob = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrToMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrFromMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrToHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrFromHour)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbFinishJob
            // 
            this.ckbFinishJob.AutoSize = true;
            this.ckbFinishJob.Location = new System.Drawing.Point(3, 7);
            this.ckbFinishJob.Name = "ckbFinishJob";
            this.ckbFinishJob.Size = new System.Drawing.Size(15, 14);
            this.ckbFinishJob.TabIndex = 0;
            this.ckbFinishJob.UseVisualStyleBackColor = true;
            this.ckbFinishJob.CheckedChanged += new System.EventHandler(this.ckbFinishJob_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txbJob);
            this.panel1.Controls.Add(this.ckbFinishJob);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 35);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnChange);
            this.panel2.Controls.Add(this.cbJobStatus);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nrToMinute);
            this.panel2.Controls.Add(this.nrFromMinute);
            this.panel2.Controls.Add(this.nrToHour);
            this.panel2.Controls.Add(this.nrFromHour);
            this.panel2.Location = new System.Drawing.Point(454, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 35);
            this.panel2.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(419, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 20);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(364, 5);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(45, 20);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Sửa";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // cbJobStatus
            // 
            this.cbJobStatus.FormattingEnabled = true;
            this.cbJobStatus.Location = new System.Drawing.Point(235, 4);
            this.cbJobStatus.Name = "cbJobStatus";
            this.cbJobStatus.Size = new System.Drawing.Size(123, 21);
            this.cbJobStatus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đến";
            // 
            // nrToMinute
            // 
            this.nrToMinute.Location = new System.Drawing.Point(188, 5);
            this.nrToMinute.Name = "nrToMinute";
            this.nrToMinute.Size = new System.Drawing.Size(41, 20);
            this.nrToMinute.TabIndex = 0;
            // 
            // nrFromMinute
            // 
            this.nrFromMinute.Location = new System.Drawing.Point(61, 5);
            this.nrFromMinute.Name = "nrFromMinute";
            this.nrFromMinute.Size = new System.Drawing.Size(41, 20);
            this.nrFromMinute.TabIndex = 0;
            // 
            // nrToHour
            // 
            this.nrToHour.Location = new System.Drawing.Point(141, 5);
            this.nrToHour.Name = "nrToHour";
            this.nrToHour.Size = new System.Drawing.Size(41, 20);
            this.nrToHour.TabIndex = 0;
            // 
            // nrFromHour
            // 
            this.nrFromHour.Location = new System.Drawing.Point(14, 5);
            this.nrFromHour.Name = "nrFromHour";
            this.nrFromHour.Size = new System.Drawing.Size(41, 20);
            this.nrFromHour.TabIndex = 0;
            // 
            // txbJob
            // 
            this.txbJob.Location = new System.Drawing.Point(24, 4);
            this.txbJob.Name = "txbJob";
            this.txbJob.Size = new System.Drawing.Size(424, 20);
            this.txbJob.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // UCrtAJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCrtAJob";
            this.Size = new System.Drawing.Size(929, 41);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrToMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrFromMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrToHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrFromHour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbFinishJob;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ComboBox cbJobStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nrToMinute;
        private System.Windows.Forms.NumericUpDown nrFromMinute;
        private System.Windows.Forms.NumericUpDown nrToHour;
        private System.Windows.Forms.NumericUpDown nrFromHour;
        private System.Windows.Forms.TextBox txbJob;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}
