namespace MIIS___Unit_Management
{
    partial class CreateAssignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAssignment));
            this.ResetForm = new System.Windows.Forms.Button();
            this.StoreAssignmentToDB = new System.Windows.Forms.Button();
            this.SelectType = new System.Windows.Forms.ComboBox();
            this.BriefDescribtion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FullBriefing = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.MaskedTextBox();
            this.EndTime = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // ResetForm
            // 
            this.ResetForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResetForm.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResetForm.Location = new System.Drawing.Point(474, 87);
            this.ResetForm.Name = "ResetForm";
            this.ResetForm.Size = new System.Drawing.Size(75, 23);
            this.ResetForm.TabIndex = 0;
            this.ResetForm.Text = "Reset fields";
            this.ResetForm.UseVisualStyleBackColor = true;
            this.ResetForm.Click += new System.EventHandler(this.ResetForm_Click);
            // 
            // StoreAssignmentToDB
            // 
            this.StoreAssignmentToDB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StoreAssignmentToDB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StoreAssignmentToDB.Location = new System.Drawing.Point(581, 78);
            this.StoreAssignmentToDB.Name = "StoreAssignmentToDB";
            this.StoreAssignmentToDB.Size = new System.Drawing.Size(95, 37);
            this.StoreAssignmentToDB.TabIndex = 1;
            this.StoreAssignmentToDB.Text = "Create";
            this.StoreAssignmentToDB.UseVisualStyleBackColor = true;
            this.StoreAssignmentToDB.Click += new System.EventHandler(this.StoreAssignmentToDB_Click);
            // 
            // SelectType
            // 
            this.SelectType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SelectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectType.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectType.FormattingEnabled = true;
            this.SelectType.Items.AddRange(new object[] {
            "Combat patrol",
            "Clearing patrol",
            "Standing patrol",
            "Reconnaissance patrol",
            "Defence patrol",
            "Sentry duty",
            "QRF",
            "Hearts and minds",
            "Search and Rescue",
            "Search and Destroy",
            "LRRP",
            "Direct Action",
            "Force recon",
            "Sniper",
            "Intelligence"});
            this.SelectType.Location = new System.Drawing.Point(12, 83);
            this.SelectType.Name = "SelectType";
            this.SelectType.Size = new System.Drawing.Size(121, 22);
            this.SelectType.TabIndex = 2;
            // 
            // BriefDescribtion
            // 
            this.BriefDescribtion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BriefDescribtion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BriefDescribtion.Location = new System.Drawing.Point(12, 31);
            this.BriefDescribtion.Name = "BriefDescribtion";
            this.BriefDescribtion.Size = new System.Drawing.Size(673, 22);
            this.BriefDescribtion.TabIndex = 3;
            this.BriefDescribtion.Text = "Required";
            this.BriefDescribtion.Click += new System.EventHandler(this.BriefDescribtion_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Brief description (max 100 char)";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Assignment type";
            // 
            // StartDate
            // 
            this.StartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StartDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate.Location = new System.Drawing.Point(217, 85);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(99, 20);
            this.StartDate.TabIndex = 6;
            // 
            // EndDate
            // 
            this.EndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EndDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDate.Location = new System.Drawing.Point(322, 85);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(99, 20);
            this.EndDate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(217, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Planned start";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(322, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Planned end";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(175, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(175, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "Time:";
            // 
            // FullBriefing
            // 
            this.FullBriefing.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FullBriefing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullBriefing.Location = new System.Drawing.Point(12, 149);
            this.FullBriefing.Name = "FullBriefing";
            this.FullBriefing.Size = new System.Drawing.Size(673, 227);
            this.FullBriefing.TabIndex = 14;
            this.FullBriefing.Text = "This field is optional, but recommanded";
            this.FullBriefing.Click += new System.EventHandler(this.FullBriefing_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(602, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Full briefing";
            // 
            // StartTime
            // 
            this.StartTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StartTime.Location = new System.Drawing.Point(231, 111);
            this.StartTime.Mask = "00:00:00";
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(57, 20);
            this.StartTime.TabIndex = 16;
            // 
            // EndTime
            // 
            this.EndTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EndTime.Location = new System.Drawing.Point(343, 111);
            this.EndTime.Mask = "00:00:00";
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(57, 20);
            this.EndTime.TabIndex = 17;
            // 
            // CreateAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 388);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FullBriefing);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BriefDescribtion);
            this.Controls.Add(this.SelectType);
            this.Controls.Add(this.StoreAssignmentToDB);
            this.Controls.Add(this.ResetForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAssignment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateAssignment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResetForm;
        private System.Windows.Forms.Button StoreAssignmentToDB;
        private System.Windows.Forms.ComboBox SelectType;
        private System.Windows.Forms.TextBox BriefDescribtion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox FullBriefing;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox StartTime;
        private System.Windows.Forms.MaskedTextBox EndTime;
    }
}