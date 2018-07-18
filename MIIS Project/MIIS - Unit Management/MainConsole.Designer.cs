namespace MIIS___Unit_Management
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CurrentAssignmentsView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GoToUnitManagement = new System.Windows.Forms.Button();
            this.GoToAssignmentManagement = new System.Windows.Forms.Button();
            this.GoToHQManagement = new System.Windows.Forms.Button();
            this.ConnectionCheck = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProjectLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // CurrentAssignmentsView
            // 
            this.CurrentAssignmentsView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CurrentAssignmentsView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentAssignmentsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.CurrentAssignmentsView.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CurrentAssignmentsView.FullRowSelect = true;
            this.CurrentAssignmentsView.GridLines = true;
            this.CurrentAssignmentsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CurrentAssignmentsView.Location = new System.Drawing.Point(21, 135);
            this.CurrentAssignmentsView.Name = "CurrentAssignmentsView";
            this.CurrentAssignmentsView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CurrentAssignmentsView.Size = new System.Drawing.Size(647, 189);
            this.CurrentAssignmentsView.TabIndex = 0;
            this.CurrentAssignmentsView.UseCompatibleStateImageBehavior = false;
            this.CurrentAssignmentsView.View = System.Windows.Forms.View.Details;
            this.CurrentAssignmentsView.SelectedIndexChanged += new System.EventHandler(this.CurrentAssignmentsView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Assigned unit";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Brief describtion";
            this.columnHeader2.Width = 185;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Scheduled start";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Scheduled end";
            this.columnHeader4.Width = 150;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(330, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "MIIS";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(284, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unit Management";
            // 
            // GoToUnitManagement
            // 
            this.GoToUnitManagement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GoToUnitManagement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GoToUnitManagement.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GoToUnitManagement.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GoToUnitManagement.Location = new System.Drawing.Point(119, 79);
            this.GoToUnitManagement.Name = "GoToUnitManagement";
            this.GoToUnitManagement.Size = new System.Drawing.Size(163, 34);
            this.GoToUnitManagement.TabIndex = 3;
            this.GoToUnitManagement.Text = "Manage Units";
            this.GoToUnitManagement.UseVisualStyleBackColor = true;
            this.GoToUnitManagement.Click += new System.EventHandler(this.GoToUnitManagement_Click);
            // 
            // GoToAssignmentManagement
            // 
            this.GoToAssignmentManagement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GoToAssignmentManagement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GoToAssignmentManagement.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GoToAssignmentManagement.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GoToAssignmentManagement.Location = new System.Drawing.Point(288, 79);
            this.GoToAssignmentManagement.Name = "GoToAssignmentManagement";
            this.GoToAssignmentManagement.Size = new System.Drawing.Size(163, 34);
            this.GoToAssignmentManagement.TabIndex = 4;
            this.GoToAssignmentManagement.Text = "Manage Assignments";
            this.GoToAssignmentManagement.UseVisualStyleBackColor = true;
            this.GoToAssignmentManagement.Click += new System.EventHandler(this.GoToAssignmentManagement_Click);
            // 
            // GoToHQManagement
            // 
            this.GoToHQManagement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GoToHQManagement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GoToHQManagement.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GoToHQManagement.Enabled = false;
            this.GoToHQManagement.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GoToHQManagement.Location = new System.Drawing.Point(457, 79);
            this.GoToHQManagement.Name = "GoToHQManagement";
            this.GoToHQManagement.Size = new System.Drawing.Size(163, 34);
            this.GoToHQManagement.TabIndex = 5;
            this.GoToHQManagement.Text = "Manage HQ";
            this.GoToHQManagement.UseVisualStyleBackColor = true;
            // 
            // ConnectionCheck
            // 
            this.ConnectionCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConnectionCheck.AutoSize = true;
            this.ConnectionCheck.ForeColor = System.Drawing.Color.Red;
            this.ConnectionCheck.Location = new System.Drawing.Point(438, 25);
            this.ConnectionCheck.Name = "ConnectionCheck";
            this.ConnectionCheck.Size = new System.Drawing.Size(171, 13);
            this.ConnectionCheck.TabIndex = 6;
            this.ConnectionCheck.Text = "-- Not connected to Data Source --";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "On going assignments";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "MIIS Version 2 Build Beta 1.2.0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "© 2015 Stefan Monko : skyneo13@gmail.com";
            // 
            // ProjectLink
            // 
            this.ProjectLink.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProjectLink.AutoSize = true;
            this.ProjectLink.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProjectLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ProjectLink.Location = new System.Drawing.Point(356, 341);
            this.ProjectLink.Name = "ProjectLink";
            this.ProjectLink.Size = new System.Drawing.Size(198, 14);
            this.ProjectLink.TabIndex = 10;
            this.ProjectLink.TabStop = true;
            this.ProjectLink.Text = "http://sourceforge.net/projects/miisp/";
            this.ProjectLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ProjectLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ProjectLink_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(697, 388);
            this.Controls.Add(this.ProjectLink);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConnectionCheck);
            this.Controls.Add(this.GoToHQManagement);
            this.Controls.Add(this.GoToAssignmentManagement);
            this.Controls.Add(this.GoToUnitManagement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentAssignmentsView);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Main Console";
            this.Load += new System.EventHandler(this.MainConsole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView CurrentAssignmentsView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GoToUnitManagement;
        private System.Windows.Forms.Button GoToAssignmentManagement;
        private System.Windows.Forms.Button GoToHQManagement;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label ConnectionCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel ProjectLink;

    }
}

