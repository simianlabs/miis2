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
using System.Diagnostics;


namespace MIIS___Unit_Management
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainConsole_Load(object sender, EventArgs e)
        {

            //Beta warning
            //string betaInfo = "This application is currently in beta phase.\n" +
            //"Some features might not work properly if at all.\nIf you find any bugs or issues, please post ticket on project page.\n" +
            //"Suggestion and request might be also posted on support page\n https://sourceforge.net/p/miisp/tickets/";

            //MessageBox.Show(betaInfo, "Bete version", MessageBoxButtons.OK);   
            //

            // sql connection string
            SQLiteConnection sqlCon = new SQLiteConnection("Data Source=miisdb2.db;Version=3;");
            SQLiteCommand sqlComm = new SQLiteCommand();
            SQLiteDataReader sqlDataReader;

            DateTime currentDateTime = DateTime.Now;

            // check if db file exist
            if (File.Exists("miisdb2.db"))
            {
                ConnectionCheck.Text = "-- Connected to Data Source --";
                ConnectionCheck.ForeColor = Color.Green;

                // get ongoing assigments from db
                sqlCon.Open();
                string sqlSelect = "select * from Assignments where start <= '" + currentDateTime + "' and end > '" + currentDateTime + "'";
                sqlComm = new SQLiteCommand(sqlSelect, sqlCon);
                sqlDataReader = sqlComm.ExecuteReader();

                CurrentAssignmentsView.Items.Clear();

                // add assignments to list view CurrentAssignmentsView
                while (sqlDataReader.Read())
                {
                    ListViewItem listEntryNew = new ListViewItem();
                    listEntryNew.Text = sqlDataReader["UnitAssign"].ToString();
                    listEntryNew.SubItems.Add(sqlDataReader["Brief"].ToString());
                    listEntryNew.SubItems.Add(sqlDataReader["Start"].ToString());
                    listEntryNew.SubItems.Add(sqlDataReader["End"].ToString());
                    CurrentAssignmentsView.Items.Add(listEntryNew);
                }

                sqlDataReader.Close();
                sqlDataReader.Dispose();
                sqlCon.Close();

            }
            else
            {
                GoToAssignmentManagement.Enabled = false;
                GoToHQManagement.Enabled = false;
                GoToUnitManagement.Enabled = false;
            }

        }

        private void CurrentAssignmentsView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GoToAssignmentManagement_Click(object sender, EventArgs e)
        {
            AssignmentConsole assignmentConsole = new AssignmentConsole();
            assignmentConsole.ShowDialog();

        }

        private void GoToUnitManagement_Click(object sender, EventArgs e)
        {
            UnitView unitViewConsole = new UnitView();
            unitViewConsole.ShowDialog();
        }

        private void ProjectLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://sourceforge.net/projects/miisp/");
            Process.Start(sInfo);
        }

    }
}
