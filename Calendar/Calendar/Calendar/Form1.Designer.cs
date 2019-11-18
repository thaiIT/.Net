namespace Calendar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlMatrix = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSunday = new System.Windows.Forms.Button();
            this.btnSaturday = new System.Windows.Forms.Button();
            this.btnFriday = new System.Windows.Forms.Button();
            this.btnThusday = new System.Windows.Forms.Button();
            this.btnWednesday = new System.Windows.Forms.Button();
            this.btnTuesday = new System.Windows.Forms.Button();
            this.btnMonday = new System.Windows.Forms.Button();
            this.btnPreviours = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nmNotify = new System.Windows.Forms.NumericUpDown();
            this.ckbNotify = new System.Windows.Forms.CheckBox();
            this.btnToDay = new System.Windows.Forms.Button();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNotify)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(22, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 396);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlMatrix);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 351);
            this.panel3.TabIndex = 1;
            // 
            // pnlMatrix
            // 
            this.pnlMatrix.Location = new System.Drawing.Point(125, 81);
            this.pnlMatrix.Name = "pnlMatrix";
            this.pnlMatrix.Size = new System.Drawing.Size(645, 267);
            this.pnlMatrix.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnNext);
            this.panel4.Controls.Add(this.btnSunday);
            this.panel4.Controls.Add(this.btnSaturday);
            this.panel4.Controls.Add(this.btnFriday);
            this.panel4.Controls.Add(this.btnThusday);
            this.panel4.Controls.Add(this.btnWednesday);
            this.panel4.Controls.Add(this.btnTuesday);
            this.panel4.Controls.Add(this.btnMonday);
            this.panel4.Controls.Add(this.btnPreviours);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(888, 72);
            this.panel4.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(789, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 66);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Tháng sau";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSunday
            // 
            this.btnSunday.Location = new System.Drawing.Point(692, 3);
            this.btnSunday.Name = "btnSunday";
            this.btnSunday.Size = new System.Drawing.Size(75, 66);
            this.btnSunday.TabIndex = 7;
            this.btnSunday.Text = "Chủ nhật";
            this.btnSunday.UseVisualStyleBackColor = true;
            // 
            // btnSaturday
            // 
            this.btnSaturday.Location = new System.Drawing.Point(597, 3);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Size = new System.Drawing.Size(75, 66);
            this.btnSaturday.TabIndex = 6;
            this.btnSaturday.Text = "Thứ 7";
            this.btnSaturday.UseVisualStyleBackColor = true;
            // 
            // btnFriday
            // 
            this.btnFriday.Location = new System.Drawing.Point(502, 3);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Size = new System.Drawing.Size(75, 66);
            this.btnFriday.TabIndex = 5;
            this.btnFriday.Text = "Thứ 6";
            this.btnFriday.UseVisualStyleBackColor = true;
            // 
            // btnThusday
            // 
            this.btnThusday.Location = new System.Drawing.Point(407, 3);
            this.btnThusday.Name = "btnThusday";
            this.btnThusday.Size = new System.Drawing.Size(75, 66);
            this.btnThusday.TabIndex = 4;
            this.btnThusday.Text = "Thứ 5";
            this.btnThusday.UseVisualStyleBackColor = true;
            // 
            // btnWednesday
            // 
            this.btnWednesday.Location = new System.Drawing.Point(312, 3);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(75, 66);
            this.btnWednesday.TabIndex = 3;
            this.btnWednesday.Text = "Thứ 4";
            this.btnWednesday.UseVisualStyleBackColor = true;
            // 
            // btnTuesday
            // 
            this.btnTuesday.Location = new System.Drawing.Point(217, 3);
            this.btnTuesday.Name = "btnTuesday";
            this.btnTuesday.Size = new System.Drawing.Size(75, 66);
            this.btnTuesday.TabIndex = 2;
            this.btnTuesday.Text = "Thứ 3";
            this.btnTuesday.UseVisualStyleBackColor = true;
            // 
            // btnMonday
            // 
            this.btnMonday.Location = new System.Drawing.Point(122, 3);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Size = new System.Drawing.Size(75, 66);
            this.btnMonday.TabIndex = 1;
            this.btnMonday.Text = "Thứ 2";
            this.btnMonday.UseVisualStyleBackColor = true;
            // 
            // btnPreviours
            // 
            this.btnPreviours.Location = new System.Drawing.Point(18, 3);
            this.btnPreviours.Name = "btnPreviours";
            this.btnPreviours.Size = new System.Drawing.Size(75, 66);
            this.btnPreviours.TabIndex = 0;
            this.btnPreviours.Text = "Tháng trước";
            this.btnPreviours.UseVisualStyleBackColor = true;
            this.btnPreviours.Click += new System.EventHandler(this.btnPreviours_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.btnToDay);
            this.panel2.Controls.Add(this.dtpkDate);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 33);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.nmNotify);
            this.panel6.Controls.Add(this.ckbNotify);
            this.panel6.Location = new System.Drawing.Point(7, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(232, 26);
            this.panel6.TabIndex = 2;
            // 
            // nmNotify
            // 
            this.nmNotify.Location = new System.Drawing.Point(97, 3);
            this.nmNotify.Name = "nmNotify";
            this.nmNotify.Size = new System.Drawing.Size(120, 20);
            this.nmNotify.TabIndex = 1;
            // 
            // ckbNotify
            // 
            this.ckbNotify.AutoSize = true;
            this.ckbNotify.Location = new System.Drawing.Point(14, 4);
            this.ckbNotify.Name = "ckbNotify";
            this.ckbNotify.Size = new System.Drawing.Size(78, 17);
            this.ckbNotify.TabIndex = 0;
            this.ckbNotify.Text = "Thông báo";
            this.ckbNotify.UseVisualStyleBackColor = true;
            // 
            // btnToDay
            // 
            this.btnToDay.Location = new System.Drawing.Point(746, 3);
            this.btnToDay.Name = "btnToDay";
            this.btnToDay.Size = new System.Drawing.Size(75, 23);
            this.btnToDay.TabIndex = 1;
            this.btnToDay.Text = "Hôm nay";
            this.btnToDay.UseVisualStyleBackColor = true;
            this.btnToDay.Click += new System.EventHandler(this.btnToDay_Click);
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(513, 6);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(200, 20);
            this.dtpkDate.TabIndex = 0;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 421);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập lịch công việc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNotify)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlMatrix;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSunday;
        private System.Windows.Forms.Button btnSaturday;
        private System.Windows.Forms.Button btnFriday;
        private System.Windows.Forms.Button btnThusday;
        private System.Windows.Forms.Button btnWednesday;
        private System.Windows.Forms.Button btnTuesday;
        private System.Windows.Forms.Button btnMonday;
        private System.Windows.Forms.Button btnPreviours;
        private System.Windows.Forms.Button btnToDay;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown nmNotify;
        private System.Windows.Forms.CheckBox ckbNotify;
    }
}

