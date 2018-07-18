namespace MIIS___Unit_Management
{
    partial class CreateNewSquad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewSquad));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ParentPlatoon = new System.Windows.Forms.ComboBox();
            this.SquadCallsign = new System.Windows.Forms.TextBox();
            this.SquadName = new System.Windows.Forms.TextBox();
            this.AddNewSquadToDB = new System.Windows.Forms.Button();
            this.SquadSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(140, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Parent platoon";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(231, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Squad callsign";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(57, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Squad name";
            // 
            // ParentPlatoon
            // 
            this.ParentPlatoon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ParentPlatoon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParentPlatoon.FormattingEnabled = true;
            this.ParentPlatoon.Location = new System.Drawing.Point(78, 45);
            this.ParentPlatoon.Name = "ParentPlatoon";
            this.ParentPlatoon.Size = new System.Drawing.Size(209, 21);
            this.ParentPlatoon.TabIndex = 14;
            // 
            // SquadCallsign
            // 
            this.SquadCallsign.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SquadCallsign.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SquadCallsign.Location = new System.Drawing.Point(193, 98);
            this.SquadCallsign.Name = "SquadCallsign";
            this.SquadCallsign.Size = new System.Drawing.Size(164, 22);
            this.SquadCallsign.TabIndex = 13;
            // 
            // SquadName
            // 
            this.SquadName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SquadName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SquadName.Location = new System.Drawing.Point(23, 98);
            this.SquadName.Name = "SquadName";
            this.SquadName.Size = new System.Drawing.Size(164, 22);
            this.SquadName.TabIndex = 12;
            // 
            // AddNewSquadToDB
            // 
            this.AddNewSquadToDB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddNewSquadToDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddNewSquadToDB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AddNewSquadToDB.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddNewSquadToDB.Location = new System.Drawing.Point(90, 194);
            this.AddNewSquadToDB.Name = "AddNewSquadToDB";
            this.AddNewSquadToDB.Size = new System.Drawing.Size(164, 34);
            this.AddNewSquadToDB.TabIndex = 11;
            this.AddNewSquadToDB.Text = "Create Squad";
            this.AddNewSquadToDB.UseVisualStyleBackColor = true;
            this.AddNewSquadToDB.Click += new System.EventHandler(this.AddNewSquadToDB_Click);
            // 
            // SquadSize
            // 
            this.SquadSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SquadSize.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SquadSize.Location = new System.Drawing.Point(143, 151);
            this.SquadSize.Name = "SquadSize";
            this.SquadSize.Size = new System.Drawing.Size(60, 22);
            this.SquadSize.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(140, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Squad size";
            // 
            // CreateNewSquad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SquadSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParentPlatoon);
            this.Controls.Add(this.SquadCallsign);
            this.Controls.Add(this.SquadName);
            this.Controls.Add(this.AddNewSquadToDB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateNewSquad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Squad";
            this.Load += new System.EventHandler(this.CreateNewSquad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ParentPlatoon;
        private System.Windows.Forms.TextBox SquadCallsign;
        private System.Windows.Forms.TextBox SquadName;
        private System.Windows.Forms.Button AddNewSquadToDB;
        private System.Windows.Forms.TextBox SquadSize;
        private System.Windows.Forms.Label label4;
    }
}