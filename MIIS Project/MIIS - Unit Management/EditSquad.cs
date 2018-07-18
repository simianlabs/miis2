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

    public partial class EditSquad : Form
    {
        // sql connection string
        SQLiteConnection sqlCon = new SQLiteConnection("Data Source=miisdb2.db;Version=3;");
        SQLiteCommand sqlComm = new SQLiteCommand();
        SQLiteDataReader sqlDataReader;

        private string _platoonId;
        private string _squadName;

        private void LoadSquadDetail()
        {
            sqlCon.Open();

            string sqlSelect = "select * from Squads where PlatoonID = @platoonId and SquadName = @squadname LIMIT 0,1";
            using (sqlComm = new SQLiteCommand(sqlSelect, sqlCon))

            {
                sqlComm.Parameters.AddWithValue("@platoonId", _platoonId);
                sqlComm.Parameters.AddWithValue("@squadname", _squadName);

                //MessageBox.Show(sqlSelect, "Updated", MessageBoxButtons.OK);
                using (sqlDataReader = sqlComm.ExecuteReader())
                {
                    if (sqlDataReader.Read())
                    {
                        SquadCallsign.Text = sqlDataReader["SquadCallsign"].ToString();
                        SquadName.Text = sqlDataReader["SquadName"].ToString();
                        SquadSize.Text = sqlDataReader["SquadSize"].ToString();

                    }

                }
            }
            sqlCon.Close();
        }

        public EditSquad(string squadName, string platoonID)
        {
            InitializeComponent();
            this.Text = "Edit squad " + squadName + " from platoon " + platoonID;
            this._platoonId = platoonID;
            this._squadName = squadName;

            LoadSquadDetail();

        }

        private void EditSquad_Load(object sender, EventArgs e)
        {

        }

        private void UpdatePlatoon_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            string sqlUpdate = "Update Squads set SquadName = @name, SquadCallsign = @callsign, SquadSize = @size where PlatoonID = @platoonId and SquadName = @squadname";
            SQLiteCommand sqlComm = new SQLiteCommand(sqlUpdate, sqlCon);
            sqlComm.Parameters.AddWithValue("@callsign", SquadCallsign.Text);
            sqlComm.Parameters.AddWithValue("@name", SquadName.Text);
            sqlComm.Parameters.AddWithValue("@size", SquadSize.Text);
            sqlComm.Parameters.AddWithValue("@platoonId", _platoonId);
            sqlComm.Parameters.AddWithValue("@squadname", _squadName);

            sqlComm.ExecuteNonQuery();
            sqlCon.Close();

            string message = "Squad was updated!";
            MessageBox.Show(message, "Updated", MessageBoxButtons.OK);

            this.Close();
        }

        private void RemoveSquad_Click(object sender, EventArgs e)
        {
            if (RemoveCheck.Checked)
            {
                sqlCon.Open();

                string sqlSelect = "Delete from Squads where PlatoonID = @platoonId and SquadName = @squadname";
                sqlComm = new SQLiteCommand(sqlSelect, sqlCon);
                sqlComm.Parameters.AddWithValue("@platoonId", _platoonId);
                sqlComm.Parameters.AddWithValue("@squadname", _squadName);

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
