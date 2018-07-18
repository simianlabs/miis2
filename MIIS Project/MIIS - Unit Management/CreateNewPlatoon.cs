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
    public partial class CreateNewPlatoon : Form
    {
        public CreateNewPlatoon()
        {
            InitializeComponent();
        }

        private void CreateNewPlatoon_Load(object sender, EventArgs e)
        {

        }

        private void AddNewPlatoonToDB_Click(object sender, EventArgs e)
        {
            // sql connection string
            SQLiteConnection sqlCon = new SQLiteConnection("Data Source=miisdb2.db;Version=3;");
           
            if (String.IsNullOrEmpty(PlatoonCallsign.Text) || String.IsNullOrEmpty(PlatoonName.Text) || PlatoonType.SelectedIndex < 0)
            {
                string message = "All fields must be filled!";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK);
            } 
            else
            {
                
                sqlCon.Open();
                string makeGuid = Guid.NewGuid().ToString();

                // create insert
                String sqlInsert = "Insert into Platoons (PlatoonID,PlatoonName,PlatoonCallsign,PlatoonType) VALUES(@guid,@name,@callsign,@type)";
                SQLiteCommand sqlComm = new SQLiteCommand(sqlInsert, sqlCon);
                sqlComm.Parameters.AddWithValue("@guid", makeGuid);
                sqlComm.Parameters.AddWithValue("@name", PlatoonName.Text);
                sqlComm.Parameters.AddWithValue("@callsign", PlatoonCallsign.Text);
                sqlComm.Parameters.AddWithValue("@type", PlatoonType.SelectedItem);

                int resultQuery = sqlComm.ExecuteNonQuery();
                sqlCon.Close();
                if (resultQuery == 0)
                {
                    string message = "There was a error while creating Platoon";
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK);
                }
                else
                {
                    string message = "Platoon created!";
                    MessageBox.Show(message, "Success", MessageBoxButtons.OK);
                    PlatoonName.Text = string.Empty;
                    PlatoonCallsign.Text = string.Empty;

                }

            }            
        }
    }
}
