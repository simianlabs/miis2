namespace MIIS___Unit_Management
{
    partial class EditSquad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSquad));
            this.RemoveCheck = new System.Windows.Forms.CheckBox();
            this.RemoveSquad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SquadCallsign = new System.Windows.Forms.TextBox();
            this.SquadName = new System.Windows.Forms.TextBox();
            this.UpdatePlatoon = new System.Windows.Forms.Button();
            this.SquadSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RemoveCheck
            // 
            this.RemoveCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RemoveCheck.AutoSize = true;
            this.RemoveCheck.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveCheck.ForeColor = System.Drawing.Color.Red;
            this.RemoveCheck.Location = new System.Drawing.Point(32, 160);
            this.RemoveCheck.Name = "RemoveCheck";
            this.RemoveCheck.Size = new System.Drawing.Size(156, 19);
            this.RemoveCheck.TabIndex = 28;
            this.RemoveCheck.Text = "I want to remove squad";
            this.RemoveCheck.UseVisualStyleBackColor = true;
            // 
            // RemoveSquad
            // 
            this.RemoveSquad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RemoveSquad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveSquad.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RemoveSquad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveSquad.Location = new System.Drawing.Point(234, 151);
            this.RemoveSquad.Name = "RemoveSquad";
            this.RemoveSquad.Size = new System.Drawing.Size(164, 34);
            this.RemoveSquad.TabIndex = 27;
            this.RemoveSquad.Text = "Remove squad";
            this.RemoveSquad.UseVisualStyleBackColor = true;
            this.RemoveSquad.Click += new System.EventHandler(this.RemoveSquad_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(351, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Squad size";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(181, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Squad callsign";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Squad name";
            // 
            // SquadCallsign
            // 
            this.SquadCallsign.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SquadCallsign.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SquadCallsign.Location = new System.Drawing.Point(184, 37);
            this.SquadCallsign.Name = "SquadCallsign";
            this.SquadCallsign.Size = new System.Drawing.Size(164, 22);
            this.SquadCallsign.TabIndex = 22;
            // 
            // SquadName
            // 
            this.SquadName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SquadName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SquadName.Location = new System.Drawing.Point(14, 37);
            this.SquadName.Name = "SquadName";
            this.SquadName.Size = new System.Drawing.Size(164, 22);
            this.SquadName.TabIndex = 21;
            // 
            // UpdatePlatoon
            // 
            this.UpdatePlatoon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UpdatePlatoon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdatePlatoon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UpdatePlatoon.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdatePlatoon.Location = new System.Drawing.Point(184, 65);
            this.UpdatePlatoon.Name = "UpdatePlatoon";
            this.UpdatePlatoon.Size = new System.Drawing.Size(164, 34);
            this.UpdatePlatoon.TabIndex = 20;
            this.UpdatePlatoon.Text = "Update squad";
            this.UpdatePlatoon.UseVisualStyleBackColor = true;
            this.UpdatePlatoon.Click += new System.EventHandler(this.UpdatePlatoon_Click);
            // 
            // SquadSize
            // 
            this.SquadSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SquadSize.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SquadSize.Location = new System.Drawing.Point(354, 37);
            this.SquadSize.Name = "SquadSize";
            this.SquadSize.Size = new System.Drawing.Size(60, 22);
            this.SquadSize.TabIndex = 29;
            // 
            // EditSquad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 210);
            this.Controls.Add(this.SquadSize);
            this.Controls.Add(this.RemoveCheck);
            this.Controls.Add(this.RemoveSquad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SquadCallsign);
            this.Controls.Add(this.SquadName);
            this.Controls.Add(this.UpdatePlatoon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditSquad";
            this.Text = "Edit Squad";
            this.Load += new System.EventHandler(this.EditSquad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox RemoveCheck;
        private System.Windows.Forms.Button RemoveSquad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SquadCallsign;
        private System.Windows.Forms.TextBox SquadName;
        private System.Windows.Forms.Button UpdatePlatoon;
        private System.Windows.Forms.TextBox SquadSize;
    }
}