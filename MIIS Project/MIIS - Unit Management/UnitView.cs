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
    public partial class UnitView : Form
    {

        // sql connection string
        SQLiteConnection sqlCon = new SQLiteConnection("Data Source=miisdb2.db;Version=3;");
        SQLiteCommand sqlComm = new SQLiteCommand();
        SQLiteDataReader sqlDataReader;

        private void ShowSquadsToList()
        {
            var selectPlatoonID = ViewAllPlatoons.SelectedItems[0].SubItems[3].Text;

            sqlCon.Open();
            string sqlSelect = "select * from Squads Where PlatoonID = '" + selectPlatoonID + "' ORDER by SquadName ASC";
            sqlComm = new SQLiteCommand(sqlSelect, sqlCon);
            sqlDataReader = sqlComm.ExecuteReader();

            ViewAllSquads.Items.Clear();

            while (sqlDataReader.Read())
            {
                ListViewItem listEntryNew = new ListViewItem();
                listEntryNew.Text = sqlDataReader["SquadName"].ToString();
                listEntryNew.SubItems.Add(sqlDataReader["SquadCallsign"].ToString());
                listEntryNew.SubItems.Add(sqlDataReader["SquadSize"].ToString());
                listEntryNew.SubItems.Add(sqlDataReader["PlatoonID"].ToString());
                ViewAllSquads.Items.Add(listEntryNew);
            }


            sqlDataReader.Close();
            sqlDataReader.Dispose();
            sqlCon.Close();
        }

        public UnitView()
        {
            InitializeComponent();
        }

        private void LoadAllPlatoons()
        {
            sqlCon.Open();
            string sqlSelect = "select * from Platoons ORDER by PlatoonName ASC";
            sqlComm = new SQLiteCommand(sqlSelect, sqlCon);
            sqlDataReader = sqlComm.ExecuteReader();

            ViewAllPlatoons.Items.Clear();

            while (sqlDataReader.Read())
            {
                ListViewItem listEntryNew = new ListViewItem();
                listEntryNew.Text = sqlDataReader["PlatoonName"].ToString();
                listEntryNew.SubItems.Add(sqlDataReader["PlatoonCallsign"].ToString());
                listEntryNew.SubItems.Add(sqlDataReader["PlatoonType"].ToString());
                listEntryNew.SubItems.Add(sqlDataReader["PlatoonID"].ToString());
                ViewAllPlatoons.Items.Add(listEntryNew);
            }


            sqlDataReader.Close();
            sqlDataReader.Dispose();
            sqlCon.Close();

        }

        private void UnitView_Load(object sender, EventArgs e)
        {

            LoadAllPlatoons();     


        }

        private void ViewAllPlatoons_Click(object sender, EventArgs e)
        {
            ShowSquadsToList();
        }

        private void CreateNewPlatoon_Click(object sender, EventArgs e)
        {
            CreateNewPlatoon createNewPlatoon = new CreateNewPlatoon();
            createNewPlatoon.ShowDialog();

            LoadAllPlatoons();   

        }

        private void CreateNewSquad_Click(object sender, EventArgs e)
        {
            CreateNewSquad createNewSquad = new CreateNewSquad();
            createNewSquad.ShowDialog();
        }

        private void ViewAllPlatoons_DoubleClick(object sender, EventArgs e)
        {
            EditPlatoon editPlatoon = new EditPlatoon(ViewAllPlatoons.SelectedItems[0].SubItems[3].Text);
            editPlatoon.ShowDialog();
            LoadAllPlatoons(); 

        }

        private void ViewAllSquads_DoubleClick(object sender, EventArgs e)
        {
            EditSquad editSquad = new EditSquad(ViewAllSquads.SelectedItems[0].Text, ViewAllSquads.SelectedItems[0].SubItems[3].Text);
            editSquad.ShowDialog();
            ShowSquadsToList();
        }
    }
}
