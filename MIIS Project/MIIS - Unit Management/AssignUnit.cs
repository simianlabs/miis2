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
    public partial class AssignUnit : Form
    {
        // sql connection string
        SQLiteConnection sqlCon = new SQLiteConnection("Data Source=miisdb2.db;Version=3;");
        SQLiteCommand sqlComm = new SQLiteCommand();
        //SQLiteDataReader sqlDataReader;

        private string _assignmentId;

        public AssignUnit(string assignmentGuID)
        {
            InitializeComponent();
            this._assignmentId = assignmentGuID;
            this.Text = "Assign unit fot task: " + _assignmentId;
        }

        private void AssignUnit_Load(object sender, EventArgs e)
        {
            // filling COmboBox for  platoons
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

                SelectPlatoonFromList.DisplayMember = "PlatoonName";
                SelectPlatoonFromList.ValueMember = "PlatoonID";
                SelectPlatoonFromList.DataSource = dt;

                sqlCon.Close();
            }
            // filling COmboBox for  platoons end
        }

        private void AssignSelectedUnit_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            string sqlUpdate = "Update Assignments set UnitAssign = @unit where AssID = @assid";
            SQLiteCommand sqlComm = new SQLiteCommand(sqlUpdate, sqlCon);
            sqlComm.Parameters.AddWithValue("@unit", SelectPlatoonFromList.SelectedValue);
            sqlComm.Parameters.AddWithValue("@assid", _assignmentId);

            sqlComm.ExecuteNonQuery();
            sqlCon.Close();

            string message = "Unit assigned for this task!";
            MessageBox.Show(message, "Updated", MessageBoxButtons.OK);
        }

        private void UnAssignUnit_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            string sqlUpdate = "Update Assignments set UnitAssign = 'No unit' where AssID = @assid";
            SQLiteCommand sqlComm = new SQLiteCommand(sqlUpdate, sqlCon);
            sqlComm.Parameters.AddWithValue("@assid", _assignmentId);

            sqlComm.ExecuteNonQuery();
            sqlCon.Close();

            string message = "Unit removed from this task!";
            MessageBox.Show(message, "Updated", MessageBoxButtons.OK);
        }
    }
}
