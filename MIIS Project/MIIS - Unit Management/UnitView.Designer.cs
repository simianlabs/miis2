namespace MIIS___Unit_Management
{
    partial class UnitView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitView));
            this.ViewAllPlatoons = new System.Windows.Forms.ListView();
            this.Platoon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Callsign = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlatoonID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateNewPlatoon = new System.Windows.Forms.Button();
            this.CreateNewSquad = new System.Windows.Forms.Button();
            this.ViewAllSquads = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ViewAllPlatoons
            // 
            this.ViewAllPlatoons.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ViewAllPlatoons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Platoon,
            this.Callsign,
            this.Type,
            this.PlatoonID});
            this.ViewAllPlatoons.FullRowSelect = true;
            this.ViewAllPlatoons.GridLines = true;
            this.ViewAllPlatoons.Location = new System.Drawing.Point(23, 54);
            this.ViewAllPlatoons.Name = "ViewAllPlatoons";
            this.ViewAllPlatoons.Size = new System.Drawing.Size(361, 322);
            this.ViewAllPlatoons.TabIndex = 0;
            this.ViewAllPlatoons.UseCompatibleStateImageBehavior = false;
            this.ViewAllPlatoons.View = System.Windows.Forms.View.Details;
            this.ViewAllPlatoons.Click += new System.EventHandler(this.ViewAllPlatoons_Click);
            this.ViewAllPlatoons.DoubleClick += new System.EventHandler(this.ViewAllPlatoons_DoubleClick);
            // 
            // Platoon
            // 
            this.Platoon.Text = "Platoon";
            this.Platoon.Width = 98;
            // 
            // Callsign
            // 
            this.Callsign.Text = "Callsign";
            this.Callsign.Width = 120;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 100;
            // 
            // PlatoonID
            // 
            this.PlatoonID.Text = "ID";
            this.PlatoonID.Width = 0;
            // 
            // CreateNewPlatoon
            // 
            this.CreateNewPlatoon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreateNewPlatoon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateNewPlatoon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CreateNewPlatoon.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateNewPlatoon.Location = new System.Drawing.Point(266, 12);
            this.CreateNewPlatoon.Name = "CreateNewPlatoon";
            this.CreateNewPlatoon.Size = new System.Drawing.Size(118, 36);
            this.CreateNewPlatoon.TabIndex = 4;
            this.CreateNewPlatoon.Text = "Create Platoon";
            this.CreateNewPlatoon.UseVisualStyleBackColor = true;
            this.CreateNewPlatoon.Click += new System.EventHandler(this.CreateNewPlatoon_Click);
            // 
            // CreateNewSquad
            // 
            this.CreateNewSquad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreateNewSquad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateNewSquad.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CreateNewSquad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateNewSquad.Location = new System.Drawing.Point(405, 12);
            this.CreateNewSquad.Name = "CreateNewSquad";
            this.CreateNewSquad.Size = new System.Drawing.Size(118, 36);
            this.CreateNewSquad.TabIndex = 5;
            this.CreateNewSquad.Text = "Create Squad";
            this.CreateNewSquad.UseVisualStyleBackColor = true;
            this.CreateNewSquad.Click += new System.EventHandler(this.CreateNewSquad_Click);
            // 
            // ViewAllSquads
            // 
            this.ViewAllSquads.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ViewAllSquads.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ViewAllSquads.FullRowSelect = true;
            this.ViewAllSquads.GridLines = true;
            this.ViewAllSquads.Location = new System.Drawing.Point(405, 54);
            this.ViewAllSquads.Name = "ViewAllSquads";
            this.ViewAllSquads.Size = new System.Drawing.Size(280, 322);
            this.ViewAllSquads.TabIndex = 6;
            this.ViewAllSquads.UseCompatibleStateImageBehavior = false;
            this.ViewAllSquads.View = System.Windows.Forms.View.Details;
            this.ViewAllSquads.DoubleClick += new System.EventHandler(this.ViewAllSquads_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Squad";
            this.columnHeader1.Width = 101;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Callsign";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PlatoonID";
            this.columnHeader4.Width = 0;
            // 
            // UnitView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 388);
            this.Controls.Add(this.ViewAllSquads);
            this.Controls.Add(this.CreateNewSquad);
            this.Controls.Add(this.CreateNewPlatoon);
            this.Controls.Add(this.ViewAllPlatoons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnitView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unit View";
            this.Load += new System.EventHandler(this.UnitView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ViewAllPlatoons;
        private System.Windows.Forms.ColumnHeader Platoon;
        private System.Windows.Forms.ColumnHeader Callsign;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.Button CreateNewPlatoon;
        private System.Windows.Forms.Button CreateNewSquad;
        private System.Windows.Forms.ListView ViewAllSquads;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader PlatoonID;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}