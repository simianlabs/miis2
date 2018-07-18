using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MIIS___Unit_Management
{
    public partial class CreateNewSquad : Form
    {
        public CreateNewSquad()
        {
            InitializeComponent();
        }

        private void CreateNewSquad_Load(object sender, EventArgs e)
        {
            // filling COmboBox for parent platoons
            DataTable dt = new DataTable();

            using (SQLiteConnection sqlCon = new SQLiteConnection("Data Source=miisdb2.db;Version=3;"))
            {
                sqlCon.Open();
                string strCmd = "select PlatoonID, PlatoonName from Platoons ORDER by PlatoonName ASC";
                using (SQLiteCommand cmd = new SQLiteCommand(strCmd, sqlCon))
                {
                    SQLiteDataAdapter da = new SQLiteDataAdapter(strCmd, sqlCon);
                    dt = new DataTable("Platoon");
                    da.Fill(dt);
                }

                ParentPlatoon.DisplayMember = "PlatoonName";
                ParentPlatoon.ValueMember = "PlatoonID";
                ParentPlatoon.DataSource = dt;

                sqlCon.Close();
            }
            // filling COmboBox for parent platoons end

            

        }

        private void AddNewSquadToDB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SquadName.Text) || String.IsNullOrEmpty(SquadSize.Text) || String.IsNullOrEmpty(SquadCallsign.Text))
            {
                string message = "All fields must be filled!";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK);
            }
            else
            {

                using (SQLiteConnection sqlCon = new SQLiteConnection("Data Source=miisdb2.db;Version=3;"))
                {
                    sqlCon.Open();
                    

                    // create insert
                    String sqlInsert = "Insert into Squads (PlatoonID,SquadName,SquadCallsign,SquadSize) VALUES(@platonid, @name, @callsign, @size)";
                    SQLiteCommand sqlComm = new SQLiteCommand(sqlInsert, sqlCon);
                    sqlComm.Parameters.AddWithValue("@platonid", ParentPlatoon.SelectedValue);
                    sqlComm.Parameters.AddWithValue("@name", SquadName.Text);
                    sqlComm.Parameters.AddWithValue("@callsign", SquadCallsign.Text);
                    sqlComm.Parameters.AddWithValue("@size", SquadSize.Text);

                    int resultQuery = sqlComm.ExecuteNonQuery();
                    sqlCon.Close();
                    if (resultQuery == 0)
                    {
                        string message = "There was a error while creating Squad";
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        string message = "Squad created!";
                        MessageBox.Show(message, "Success", MessageBoxButtons.OK);
                        SquadName.Text = string.Empty;
                        SquadSize.Text = string.Empty;
                        SquadCallsign.Text = string.Empty;


                    }
                    sqlCon.Close();
                }
            }
        }
    }
}
