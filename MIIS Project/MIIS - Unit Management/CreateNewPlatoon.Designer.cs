namespace MIIS___Unit_Management
{
    partial class CreateNewPlatoon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewPlatoon));
            this.AddNewPlatoonToDB = new System.Windows.Forms.Button();
            this.PlatoonName = new System.Windows.Forms.TextBox();
            this.PlatoonCallsign = new System.Windows.Forms.TextBox();
            this.PlatoonType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNewPlatoonToDB
            // 
            this.AddNewPlatoonToDB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddNewPlatoonToDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddNewPlatoonToDB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AddNewPlatoonToDB.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddNewPlatoonToDB.Location = new System.Drawing.Point(186, 85);
            this.AddNewPlatoonToDB.Name = "AddNewPlatoonToDB";
            this.AddNewPlatoonToDB.Size = new System.Drawing.Size(164, 34);
            this.AddNewPlatoonToDB.TabIndex = 4;
            this.AddNewPlatoonToDB.Text = "Create Platoon";
            this.AddNewPlatoonToDB.UseVisualStyleBackColor = true;
            this.AddNewPlatoonToDB.Click += new System.EventHandler(this.AddNewPlatoonToDB_Click);
            // 
            // PlatoonName
            // 
            this.PlatoonName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlatoonName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlatoonName.Location = new System.Drawing.Point(16, 42);
            this.PlatoonName.Name = "PlatoonName";
            this.PlatoonName.Size = new System.Drawing.Size(164, 22);
            this.PlatoonName.TabIndex = 5;
            // 
            // PlatoonCallsign
            // 
            this.PlatoonCallsign.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlatoonCallsign.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlatoonCallsign.Location = new System.Drawing.Point(186, 42);
            this.PlatoonCallsign.Name = "PlatoonCallsign";
            this.PlatoonCallsign.Size = new System.Drawing.Size(164, 22);
            this.PlatoonCallsign.TabIndex = 6;
            // 
            // PlatoonType
            // 
            this.PlatoonType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlatoonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlatoonType.FormattingEnabled = true;
            this.PlatoonType.Items.AddRange(new object[] {
            "Infantry",
            "Mechanized",
            "Armored",
            "Recon",
            "Special Forces",
            "Command",
            "Engineer",
            "Artillery",
            "Military police",
            "Inteligence"});
            this.PlatoonType.Location = new System.Drawing.Point(356, 43);
            this.PlatoonType.Name = "PlatoonType";
            this.PlatoonType.Size = new System.Drawing.Size(164, 21);
            this.PlatoonType.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Platoon name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(183, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Platoon callsign";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(353, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Platoon type";
            // 
            // CreateNewPlatoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 144);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlatoonType);
            this.Controls.Add(this.PlatoonCallsign);
            this.Controls.Add(this.PlatoonName);
            this.Controls.Add(this.AddNewPlatoonToDB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateNewPlatoon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Platoon";
            this.Load += new System.EventHandler(this.CreateNewPlatoon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewPlatoonToDB;
        private System.Windows.Forms.TextBox PlatoonName;
        private System.Windows.Forms.TextBox PlatoonCallsign;
        private System.Windows.Forms.ComboBox PlatoonType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}