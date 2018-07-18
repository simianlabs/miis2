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
    public partial class EditPlatoon : Form
    {
        // sql connection string
        SQLiteConnection sqlCon = new SQLiteConnection("Data Source=miisdb2.db;Version=3;");
        SQLiteCommand sqlComm = new SQLiteCommand();
        SQLiteDataReader sqlDataReader;

        private string _platoonId;

        private void LoadPlatoonDetails() 
        {
            sqlCon.Open();

            string sqlSelect = "select * from Platoons where PlatoonID = @platoonId";
            using (sqlComm = new SQLiteCommand(sqlSelect, sqlCon))
            {
                sqlComm.Parameters.AddWithValue("@platoonId", _platoonId);

                using (sqlDataReader = sqlComm.ExecuteReader())
                {
                    if (sqlDataReader.Read())
                    {
                        PlatoonCallsign.Text = sqlDataReader["PlatoonCallsign"].ToString();
                        PlatoonName.Text = sqlDataReader["PlatoonName"].ToString();
                        PlatoonType.SelectedItem = sqlDataReader["PlatoonType"].ToString();

                    }

                }
            }
            sqlCon.Close();
        }

        public EditPlatoon(string platoonID)
        {
            InitializeComponent();
            this._platoonId = platoonID;
            this.Text = "Edit platoon with id: " + _platoonId;
            LoadPlatoonDetails();
        }

        private void EditPlatoon_Load(object sender, EventArgs e)
        {

        }

        private void UpdatePlatoon_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            string sqlUpdate = "Update Platoons set PlatoonName = @name, PlatoonCallsign = @callsign, PlatoonType = @type where PlatoonID = @platoonId";
            SQLiteCommand sqlComm = new SQLiteCommand(sqlUpdate, sqlCon);
            sqlComm.Parameters.AddWithValue("@callsign", PlatoonCallsign.Text);
            sqlComm.Parameters.AddWithValue("@name", PlatoonName.Text);
            sqlComm.Parameters.AddWithValue("@type", PlatoonType.SelectedItem);
            sqlComm.Parameters.AddWithValue("@platoonId", _platoonId);

            sqlComm.ExecuteNonQuery();
            sqlCon.Close();

            string message = "Platoon was updated!";
            MessageBox.Show(message, "Updated", MessageBoxButtons.OK);

            LoadPlatoonDetails();
        }

        private void RemovePlatoon_Click(object sender, EventArgs e)
        {
            if (RemoveCheck.Checked)
            {
                sqlCon.Open();

                string sqlSelect = "Delete from Platoons where PlatoonID = @platoonId; Delete from Squads where PlatoonID = @platoonId";
                sqlComm = new SQLiteCommand(sqlSelect, sqlCon);
                sqlComm.Parameters.AddWithValue("@platoonId", _platoonId);

                sqlComm.ExecuteNonQuery();

                sqlCon.Close();
                this.Close();

            }
            else
            {
                string message = "Checkbox must be checked!";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
