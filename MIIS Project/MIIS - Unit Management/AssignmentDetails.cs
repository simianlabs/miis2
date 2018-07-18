using System;
using System.IO;
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
    public partial class AssignmentDetails : Form
    {
        // sql connection string
        SQLiteConnection sqlCon = new SQLiteConnection("Data Source=miisdb2.db;Version=3;");
        SQLiteCommand sqlComm = new SQLiteCommand();
        SQLiteDataReader sqlDataReader;

        private string _assignmentId;
        private string unitAssignedID;

        public void GetAssignemtDetails()
        {

            string sqlSelect = "select * from Assignments where AssID = @assid limit 0,1";
            sqlCon.Open();
            using (sqlComm = new SQLiteCommand(sqlSelect, sqlCon))
            {
                sqlComm.Parameters.AddWithValue("@assid", _assignmentId);

                using (sqlDataReader = sqlComm.ExecuteReader())
                {
                    if (sqlDataReader.Read())
                    {


                        DetailBrief.Text = sqlDataReader["Brief"].ToString();
                        DetailEnd.Text = sqlDataReader["End"].ToString();
                        DetailStart.Text = sqlDataReader["Start"].ToString();
                        DetailType.Text = sqlDataReader["Type"].ToString();
                        DetailUnit.Text = sqlDataReader["UnitAssign"].ToString();
                        DetailFull.Text = sqlDataReader["Description"].ToString();
                        unitAssignedID = sqlDataReader["UnitAssign"].ToString();


                    }
                }
            }
            // get platoon name
            //string platoonName;
            string sqlSelectPlatoon = "select * from Platoons where PlatoonID = @platoonid limit 0,1";
            
            using (sqlComm = new SQLiteCommand(sqlSelectPlatoon, sqlCon))
            {
                sqlComm.Parameters.AddWithValue("@platoonid", unitAssignedID);
                using (sqlDataReader = sqlComm.ExecuteReader())
                {
                    if (sqlDataReader.Read())
                    {
                        DetailUnit.Text = sqlDataReader["PlatoonName"].ToString();
                    }
                }
            }
            // get platoon name end
            sqlCon.Close();
        }

        public AssignmentDetails(string assignmentGuID)
        {
            InitializeComponent();
            this._assignmentId = assignmentGuID;
            this.Text = "Details for assignment: " + _assignmentId;
            AssignentIDHidden.Text = assignmentGuID;
            // get details
            
           
            //sqlComm = new SQLiteCommand(sqlSelect, sqlCon);
            //sqlComm.Parameters.AddWithValue("@assid", _assignmentId);   
            //sqlDataReader = sqlComm.ExecuteReader();
            //if (sqlDataReader.Read())
            //{
            //    DetailBrief.Text = sqlDataReader["Brief"].ToString();
            //    DetailEnd.Text = sqlDataReader["End"].ToString();
            //    DetailStart.Text = sqlDataReader["Start"].ToString();
            //    DetailType.Text = sqlDataReader["Type"].ToString();
            //    DetailUnit.Text = sqlDataReader["UnitAssign"].ToString();
            //    DetailFull.Text = sqlDataReader["Description"].ToString();
            //}

            //sqlDataReader.Close();
            //sqlDataReader.Dispose();
            //sqlCon.Close();

            

            string sqlSelect = "select * from Assignments where AssID = @assid limit 0,1";
                sqlCon.Open();
                using (sqlComm = new SQLiteCommand(sqlSelect, sqlCon))
                {
                    sqlComm.Parameters.AddWithValue("@assid", _assignmentId);

                    using (sqlDataReader = sqlComm.ExecuteReader())
                    {
                           if (sqlDataReader.Read())
                            {

                               
                                DetailBrief.Text = sqlDataReader["Brief"].ToString();
                                DetailEnd.Text = sqlDataReader["End"].ToString();
                                DetailStart.Text = sqlDataReader["Start"].ToString();
                                DetailType.Text = sqlDataReader["Type"].ToString();
                                DetailUnit.Text = sqlDataReader["UnitAssign"].ToString();
                                DetailFull.Text = sqlDataReader["Description"].ToString();
                                unitAssignedID = sqlDataReader["UnitAssign"].ToString();


                            }
                    }
                }
                sqlCon.Close();
                GetAssignemtDetails();
            }
        
        

        private void AssignmentDetails_Load(object sender, EventArgs e)
        {

        }

        private void AllowEdit_Click(object sender, EventArgs e)
        {
            DeleteAssignment.Enabled = true;
            SaveChanges.Enabled = true;
            DetailBrief.ReadOnly = false;
            DetailEnd.ReadOnly = false;
            DetailFull.ReadOnly = false;
            DetailStart.ReadOnly = false;
        }

        private void DeleteAssignment_Click(object sender, EventArgs e)
        {
            // delete assignemnt
            
            sqlCon.Open();

            string sqlSelect = "Delete from Assignments where AssID = @assid";
            sqlComm = new SQLiteCommand(sqlSelect, sqlCon);
            sqlComm.Parameters.AddWithValue("@assid", _assignmentId);

            sqlComm.ExecuteNonQuery();
            sqlCon.Close();

            string message = "Assignment was deleted!";
            MessageBox.Show(message, "Deleted", MessageBoxButtons.OK);

            this.Close();
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            string sqlUpdate = "Update Assignments set Brief = @brief, Start = @start, End = @end, Description = @desc where AssID = @assid";
            SQLiteCommand sqlComm = new SQLiteCommand(sqlUpdate, sqlCon);
            sqlComm.Parameters.AddWithValue("@brief", DetailBrief.Text);
            sqlComm.Parameters.AddWithValue("@start", DetailStart.Text);
            sqlComm.Parameters.AddWithValue("@end", DetailEnd.Text);
            sqlComm.Parameters.AddWithValue("@desc", DetailFull.Text);
            sqlComm.Parameters.AddWithValue("@assid", _assignmentId);

            sqlComm.ExecuteNonQuery();
            sqlCon.Close();

            string message = "Assignment was updated!";
            MessageBox.Show(message, "Updated", MessageBoxButtons.OK);
        }

        private void AssignAssignment_Click(object sender, EventArgs e)
        {
            string idForUnitAssign = _assignmentId;
            AssignUnit assigUnit = new AssignUnit(idForUnitAssign);
            assigUnit.ShowDialog();

            GetAssignemtDetails();
            //string message = "Refreshed!" + unitAssignedID;
            //MessageBox.Show(message, "Updated", MessageBoxButtons.OK);
           
        }


    }
}
