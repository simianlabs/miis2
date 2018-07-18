namespace MIIS___Unit_Management
{
    partial class EditPlatoon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPlatoon));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PlatoonType = new System.Windows.Forms.ComboBox();
            this.PlatoonCallsign = new System.Windows.Forms.TextBox();
            this.PlatoonName = new System.Windows.Forms.TextBox();
            this.UpdatePlatoon = new System.Windows.Forms.Button();
            this.RemovePlatoon = new System.Windows.Forms.Button();
            this.RemoveCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(351, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Platoon type";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(181, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Platoon callsign";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Platoon name";
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
            this.PlatoonType.Location = new System.Drawing.Point(354, 28);
            this.PlatoonType.Name = "PlatoonType";
            this.PlatoonType.Size = new System.Drawing.Size(164, 21);
            this.PlatoonType.TabIndex = 14;
            // 
            // PlatoonCallsign
            // 
            this.PlatoonCallsign.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlatoonCallsign.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlatoonCallsign.Location = new System.Drawing.Point(184, 27);
            this.PlatoonCallsign.Name = "PlatoonCallsign";
            this.PlatoonCallsign.Size = new System.Drawing.Size(164, 22);
            this.PlatoonCallsign.TabIndex = 13;
            // 
            // PlatoonName
            // 
            this.PlatoonName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlatoonName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlatoonName.Location = new System.Drawing.Point(14, 27);
            this.PlatoonName.Name = "PlatoonName";
            this.PlatoonName.Size = new System.Drawing.Size(164, 22);
            this.PlatoonName.TabIndex = 12;
            // 
            // UpdatePlatoon
            // 
            this.UpdatePlatoon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UpdatePlatoon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdatePlatoon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UpdatePlatoon.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdatePlatoon.Location = new System.Drawing.Point(184, 55);
            this.UpdatePlatoon.Name = "UpdatePlatoon";
            this.UpdatePlatoon.Size = new System.Drawing.Size(164, 34);
            this.UpdatePlatoon.TabIndex = 11;
            this.UpdatePlatoon.Text = "Update Platoon";
            this.UpdatePlatoon.UseVisualStyleBackColor = true;
            this.UpdatePlatoon.Click += new System.EventHandler(this.UpdatePlatoon_Click);
            // 
            // RemovePlatoon
            // 
            this.RemovePlatoon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RemovePlatoon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemovePlatoon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RemovePlatoon.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemovePlatoon.Location = new System.Drawing.Point(284, 141);
            this.RemovePlatoon.Name = "RemovePlatoon";
            this.RemovePlatoon.Size = new System.Drawing.Size(164, 34);
            this.RemovePlatoon.TabIndex = 18;
            this.RemovePlatoon.Text = "Remove platoon";
            this.RemovePlatoon.UseVisualStyleBackColor = true;
            this.RemovePlatoon.Click += new System.EventHandler(this.RemovePlatoon_Click);
            // 
            // RemoveCheck
            // 
            this.RemoveCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RemoveCheck.AutoSize = true;
            this.RemoveCheck.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveCheck.ForeColor = System.Drawing.Color.Red;
            this.RemoveCheck.Location = new System.Drawing.Point(86, 150);
            this.RemoveCheck.Name = "RemoveCheck";
            this.RemoveCheck.Size = new System.Drawing.Size(166, 19);
            this.RemoveCheck.TabIndex = 19;
            this.RemoveCheck.Text = "I want to remove platoon";
            this.RemoveCheck.UseVisualStyleBackColor = true;
            // 
            // EditPlatoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 186);
            this.Controls.Add(this.RemoveCheck);
            this.Controls.Add(this.RemovePlatoon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlatoonType);
            this.Controls.Add(this.PlatoonCallsign);
            this.Controls.Add(this.PlatoonName);
            this.Controls.Add(this.UpdatePlatoon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditPlatoon";
            this.Text = "EditPlatoon";
            this.Load += new System.EventHandler(this.EditPlatoon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PlatoonType;
        private System.Windows.Forms.TextBox PlatoonCallsign;
        private System.Windows.Forms.TextBox PlatoonName;
        private System.Windows.Forms.Button UpdatePlatoon;
        private System.Windows.Forms.Button RemovePlatoon;
        private System.Windows.Forms.CheckBox RemoveCheck;
    }
}