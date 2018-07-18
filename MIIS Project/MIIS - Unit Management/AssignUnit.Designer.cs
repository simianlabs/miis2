namespace MIIS___Unit_Management
{
    partial class AssignUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignUnit));
            this.SelectPlatoonFromList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AssignSelectedUnit = new System.Windows.Forms.Button();
            this.UnAssignUnit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectPlatoonFromList
            // 
            this.SelectPlatoonFromList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SelectPlatoonFromList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectPlatoonFromList.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectPlatoonFromList.FormattingEnabled = true;
            this.SelectPlatoonFromList.Location = new System.Drawing.Point(68, 34);
            this.SelectPlatoonFromList.Name = "SelectPlatoonFromList";
            this.SelectPlatoonFromList.Size = new System.Drawing.Size(213, 22);
            this.SelectPlatoonFromList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(68, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select unit";
            // 
            // AssignSelectedUnit
            // 
            this.AssignSelectedUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AssignSelectedUnit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AssignSelectedUnit.Location = new System.Drawing.Point(120, 62);
            this.AssignSelectedUnit.Name = "AssignSelectedUnit";
            this.AssignSelectedUnit.Size = new System.Drawing.Size(94, 41);
            this.AssignSelectedUnit.TabIndex = 2;
            this.AssignSelectedUnit.Text = "Assign unit";
            this.AssignSelectedUnit.UseVisualStyleBackColor = true;
            this.AssignSelectedUnit.Click += new System.EventHandler(this.AssignSelectedUnit_Click);
            // 
            // UnAssignUnit
            // 
            this.UnAssignUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UnAssignUnit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UnAssignUnit.Location = new System.Drawing.Point(85, 115);
            this.UnAssignUnit.Name = "UnAssignUnit";
            this.UnAssignUnit.Size = new System.Drawing.Size(161, 41);
            this.UnAssignUnit.TabIndex = 3;
            this.UnAssignUnit.Text = "Remove unit assigned";
            this.UnAssignUnit.UseVisualStyleBackColor = true;
            this.UnAssignUnit.Click += new System.EventHandler(this.UnAssignUnit_Click);
            // 
            // AssignUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 168);
            this.Controls.Add(this.UnAssignUnit);
            this.Controls.Add(this.AssignSelectedUnit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectPlatoonFromList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssignUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Assign Unit";
            this.Load += new System.EventHandler(this.AssignUnit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectPlatoonFromList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AssignSelectedUnit;
        private System.Windows.Forms.Button UnAssignUnit;
    }
}