namespace MIIS___Unit_Management
{
    partial class AssignmentConsole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignmentConsole));
            this.SelectFilter = new System.Windows.Forms.ComboBox();
            this.FilterAssignments = new System.Windows.Forms.Button();
            this.CreateNewAssignment = new System.Windows.Forms.Button();
            this.AssignmentMainView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectFilter
            // 
            this.SelectFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SelectFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectFilter.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectFilter.FormattingEnabled = true;
            this.SelectFilter.Items.AddRange(new object[] {
            "Not assigned",
            "Assigned",
            "Planned",
            "Ongoing",
            "Past",
            "All"});
            this.SelectFilter.Location = new System.Drawing.Point(135, 12);
            this.SelectFilter.Name = "SelectFilter";
            this.SelectFilter.Size = new System.Drawing.Size(121, 23);
            this.SelectFilter.TabIndex = 1;
            // 
            // FilterAssignments
            // 
            this.FilterAssignments.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FilterAssignments.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FilterAssignments.Location = new System.Drawing.Point(262, 12);
            this.FilterAssignments.Name = "FilterAssignments";
            this.FilterAssignments.Size = new System.Drawing.Size(123, 23);
            this.FilterAssignments.TabIndex = 2;
            this.FilterAssignments.Text = "Show assignments";
            this.FilterAssignments.UseVisualStyleBackColor = true;
            this.FilterAssignments.Click += new System.EventHandler(this.FilterAssignments_Click);
            // 
            // CreateNewAssignment
            // 
            this.CreateNewAssignment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreateNewAssignment.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateNewAssignment.Location = new System.Drawing.Point(408, 12);
            this.CreateNewAssignment.Name = "CreateNewAssignment";
            this.CreateNewAssignment.Size = new System.Drawing.Size(173, 23);
            this.CreateNewAssignment.TabIndex = 3;
            this.CreateNewAssignment.Text = "Create new assignment";
            this.CreateNewAssignment.UseVisualStyleBackColor = true;
            this.CreateNewAssignment.Click += new System.EventHandler(this.CreateNewAssignment_Click);
            // 
            // AssignmentMainView
            // 
            this.AssignmentMainView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AssignmentMainView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.AssignmentMainView.FullRowSelect = true;
            this.AssignmentMainView.GridLines = true;
            this.AssignmentMainView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AssignmentMainView.Location = new System.Drawing.Point(12, 41);
            this.AssignmentMainView.MultiSelect = false;
            this.AssignmentMainView.Name = "AssignmentMainView";
            this.AssignmentMainView.Size = new System.Drawing.Size(673, 326);
            this.AssignmentMainView.TabIndex = 4;
            this.AssignmentMainView.UseCompatibleStateImageBehavior = false;
            this.AssignmentMainView.View = System.Windows.Forms.View.Details;
            this.AssignmentMainView.DoubleClick += new System.EventHandler(this.AssignmentMainView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            this.columnHeader1.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Unit assigned";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Descrition";
            this.columnHeader3.Width = 191;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Start";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "End";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(37, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter selection:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "* Double click on assignment to show details";
            // 
            // AssignmentConsole
            // 
            this.ClientSize = new System.Drawing.Size(697, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AssignmentMainView);
            this.Controls.Add(this.CreateNewAssignment);
            this.Controls.Add(this.FilterAssignments);
            this.Controls.Add(this.SelectFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssignmentConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View assignments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.ComboBox SelectFilter;
        private System.Windows.Forms.Button FilterAssignments;
        private System.Windows.Forms.Button CreateNewAssignment;
        private System.Windows.Forms.ListView AssignmentMainView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;

    }
}