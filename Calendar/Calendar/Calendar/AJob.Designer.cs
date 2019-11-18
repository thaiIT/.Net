namespace Calendar
{
    partial class AJob
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nmToMinute = new System.Windows.Forms.NumericUpDown();
            this.nmToHours = new System.Windows.Forms.NumericUpDown();
            this.nmFromMinute = new System.Windows.Forms.NumericUpDown();
            this.nmFromHours = new System.Windows.Forms.NumericUpDown();
            this.ckbDone = new System.Windows.Forms.CheckBox();
            this.txbJob = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmToMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromHours)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ckbDone);
            this.panel1.Controls.Add(this.txbJob);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nmToMinute);
            this.panel2.Controls.Add(this.nmToHours);
            this.panel2.Controls.Add(this.nmFromMinute);
            this.panel2.Controls.Add(this.nmFromHours);
            this.panel2.Location = new System.Drawing.Point(206, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 34);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đến";
            // 
            // nmToMinute
            // 
            this.nmToMinute.Location = new System.Drawing.Point(226, 5);
            this.nmToMinute.Name = "nmToMinute";
            this.nmToMinute.Size = new System.Drawing.Size(45, 20);
            this.nmToMinute.TabIndex = 3;
            // 
            // nmToHours
            // 
            this.nmToHours.Location = new System.Drawing.Point(175, 5);
            this.nmToHours.Name = "nmToHours";
            this.nmToHours.Size = new System.Drawing.Size(45, 20);
            this.nmToHours.TabIndex = 2;
            // 
            // nmFromMinute
            // 
            this.nmFromMinute.Location = new System.Drawing.Point(65, 6);
            this.nmFromMinute.Name = "nmFromMinute";
            this.nmFromMinute.Size = new System.Drawing.Size(45, 20);
            this.nmFromMinute.TabIndex = 1;
            // 
            // nmFromHours
            // 
            this.nmFromHours.Location = new System.Drawing.Point(14, 7);
            this.nmFromHours.Name = "nmFromHours";
            this.nmFromHours.Size = new System.Drawing.Size(45, 20);
            this.nmFromHours.TabIndex = 0;
            // 
            // ckbDone
            // 
            this.ckbDone.AutoSize = true;
            this.ckbDone.Location = new System.Drawing.Point(3, 11);
            this.ckbDone.Name = "ckbDone";
            this.ckbDone.Size = new System.Drawing.Size(15, 14);
            this.ckbDone.TabIndex = 4;
            this.ckbDone.UseVisualStyleBackColor = true;
            this.ckbDone.CheckedChanged += new System.EventHandler(this.ckbDone_CheckedChanged);
            // 
            // txbJob
            // 
            this.txbJob.Location = new System.Drawing.Point(24, 10);
            this.txbJob.Name = "txbJob";
            this.txbJob.Size = new System.Drawing.Size(176, 20);
            this.txbJob.TabIndex = 3;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(486, 10);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(613, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(694, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AJob";
            this.Size = new System.Drawing.Size(787, 46);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmToMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckbDone;
        private System.Windows.Forms.TextBox txbJob;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmToMinute;
        private System.Windows.Forms.NumericUpDown nmToHours;
        private System.Windows.Forms.NumericUpDown nmFromMinute;
        private System.Windows.Forms.NumericUpDown nmFromHours;
    }
}
