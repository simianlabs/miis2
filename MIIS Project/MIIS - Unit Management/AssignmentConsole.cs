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
    public partial class AssignmentConsole : Form
    {

        // sql connection string
        SQLiteConnection sqlCon = new SQLiteConnection("Data Source=miisdb2.db;Version=3;");
        SQLiteCommand sqlComm = new SQLiteCommand();
        SQLiteDataReader sqlDataReader;

        DateTime currentDateTime = DateTime.Now;

        private void GetUnitNamesForList()
        {
            sqlCon.Open();
            foreach (ListViewItem item in AssignmentMainView.Items)
            {
                // get platoon name
                string unitAssignedID = item.SubItems[1].Text;
                string sqlSelectPlatoon = "select * from Platoons where PlatoonID = @platoonid limit 0,1";

                using (sqlComm = new SQLiteCommand(sqlSelectPlatoon, sqlCon))
                {
                    sqlComm.Parameters.AddWithValue("@platoonid", unitAssignedID);
                    using (sqlDataReader = sqlComm.ExecuteReader())
                    {
                        if (sqlDataReader.Read())
                        {
                            item.SubItems[1].Text = sqlDataReader["PlatoonName"].ToString();
                        }
                    }
                }
                // get platoon name end

            }
            sqlCon.Close();
        }

        public AssignmentConsole()
        {
            InitializeComponent();
        }

        private void AssignmentConsole_Load(object sender, EventArgs e)
        {

        }

        private void FilterAssignments_Click(object sender, EventArgs e)
        {

            // select filter and create DB select
            sqlCon.Open();

            if (SelectFilter.SelectedIndex > -1)
            {

                if (SelectFilter.SelectedItem.ToString() == "Not assigned")
                {
                    string sqlSelect = "select * from Assignments where UnitAssign = 'No unit' order by start ASC";
                    sqlComm = new SQLiteCommand(sqlSelect, sqlCon);
                }
                else if (SelectFilter.SelectedItem.ToString() == "Assigned")
                {
                    string sqlSelect = "select * from Assignments where UnitAssign != 'No unit' order by start ASC";
                    sqlComm = new SQLiteCommand(sqlSelect, sqlCon);
                }
                else if (SelectFilter.SelectedItem.ToString() == "Planned")
                {
                    string sqlSelect = "select * from Assignments where start > '" + currentDateTime + "' and end > '" + currentDateTime + "' order by start ASC";
                    sqlComm = new SQLiteCommand(sqlSelect, sqlCon);
                }
                else if (SelectFilter.SelectedItem.ToString() == "Ongoing")
                {
                    string sqlSelect = "select * from Assignments where start <= '" + currentDateTime + "' and end > '" + currentDateTime + "' order by end ASC";
                    sqlComm = new SQLiteCommand(sqlSelect, sqlCon);
                }
                else if (SelectFilter.SelectedItem.ToString() == "Past")
                {
                    string sqlSelect = "select * from Assignments where end < '" + currentDateTime + "' order by end DESC";
                    sqlComm = new SQLiteCommand(sqlSelect, sqlCon);
                }
                else if (SelectFilter.SelectedItem.ToString() == "All")
                {
                    string sqlSelect = "select * from Assignments order by AssID DESC";
                    sqlComm = new SQLiteCommand(sqlSelect, sqlCon);
                }
            }
            else
            {
                string sqlSelect = "select * from Assignments order by AssID DESC";
                sqlComm = new SQLiteCommand(sqlSelect, sqlCon);
            }
                        
            sqlDataReader = sqlComm.ExecuteReader();

            AssignmentMainView.Items.Clear();

            // add assignments to list view CurrentAssignmentsView
            while (sqlDataReader.Read())
            {
                ListViewItem listEntryNew = new ListViewItem();
                listEntryNew.Text = sqlDataReader["Type"].ToString();
                listEntryNew.SubItems.Add(sqlDataReader["UnitAssign"].ToString());
                listEntryNew.SubItems.Add(sqlDataReader["Brief"].ToString());
                listEntryNew.SubItems.Add(sqlDataReader["Start"].ToString());
                listEntryNew.SubItems.Add(sqlDataReader["End"].ToString());
                listEntryNew.SubItems.Add(sqlDataReader["AssID"].ToString());
                AssignmentMainView.Items.Add(listEntryNew);
            }

            sqlDataReader.Close();
            sqlDataReader.Dispose();
            sqlCon.Close();

            GetUnitNamesForList();

            
        }

        private void CreateNewAssignment_Click(object sender, EventArgs e)
        {
            CreateAssignment createAssignment = new CreateAssignment();
            createAssignment.ShowDialog();
        }

        private void AssignmentMainView_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show("Selected mission: "+ AssignmentMainView.SelectedItems[0].SubItems[5].Text);
            AssignmentDetails assignmentDetailsForm = new AssignmentDetails(AssignmentMainView.SelectedItems[0].SubItems[5].Text);

            assignmentDetailsForm.ShowDialog();
            //GetUnitNamesForList();
        }


    }
}
