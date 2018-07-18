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
using System.Text.RegularExpressions;

namespace MIIS___Unit_Management
{
    public partial class CreateAssignment : Form
    {
        // sql connection string
        SQLiteConnection sqlCon = new SQLiteConnection("Data Source=miisdb2.db;Version=3;");
        SQLiteCommand sqlComm = new SQLiteCommand();

        bool alreadyFocusedFullBriefing = false;
        bool alreadyFocusedBriefDescribtion = false;

        public CreateAssignment()
        {
            InitializeComponent();
        }

        private void StartTime_Click(object sender, EventArgs e)
        {
          
         }

        private void EndTime_Click(object sender, EventArgs e)
        {
            
        }

        private void ResetForm_Click(object sender, EventArgs e)
        {
            // reset all entry fields
            StartTime.Text = "__:__:__";
            EndTime.Text = "__:__:__";
            FullBriefing.Text = string.Empty;
            BriefDescribtion.Text = string.Empty;
        }

        private void StartTime_Leave(object sender, EventArgs e)
        {
 
        }

        private void StoreAssignmentToDB_Click(object sender, EventArgs e)
        {
            // check if all fields are filled
            StartTime.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            EndTime.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (String.IsNullOrEmpty(BriefDescribtion.Text) || String.IsNullOrEmpty(StartTime.Text) || EndTime.Text=="" || SelectType.SelectedIndex < 0)
            {
                string message = "All fields must be filled!";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK);
            }
            else
            {
           
            sqlCon.Open();
            string makeGuid = Guid.NewGuid().ToString();

            StartTime.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            EndTime.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            // create insert
            String sqlInsert = "Insert into Assignments (AssID,UnitAssign,Brief,Type,Start,End,Description) VALUES(@guid,'No unit',@brief, @type,@start,@end,@desc)";
            SQLiteCommand sqlComm = new SQLiteCommand(sqlInsert, sqlCon);
            sqlComm.Parameters.AddWithValue("@guid", makeGuid);
            sqlComm.Parameters.AddWithValue("@brief", BriefDescribtion.Text);
            sqlComm.Parameters.AddWithValue("@type", SelectType.SelectedItem);
            sqlComm.Parameters.AddWithValue("@start", StartDate.Text + " " + StartTime.Text);
            sqlComm.Parameters.AddWithValue("@end", EndDate.Text + " " + EndTime.Text);
            sqlComm.Parameters.AddWithValue("@desc", FullBriefing.Text);

            int resultQuery = sqlComm.ExecuteNonQuery();
            sqlCon.Close();
            if (resultQuery==0)
            {
                string message = "There was a error while storing assignment";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK);  
            } 
            else 
            {
                // reset all entry fields
                StartTime.Text = "__:__:__";
                EndTime.Text = "__:__:__";
                FullBriefing.Text = string.Empty;
                BriefDescribtion.Text = string.Empty;

                string message = "New assignment was created sucessfully";
                MessageBox.Show(message, "Created", MessageBoxButtons.OK);
            }

            }

        }

        private void BriefDescribtion_Click(object sender, EventArgs e)
        {
            if (!alreadyFocusedBriefDescribtion)
            {
                alreadyFocusedBriefDescribtion = true;
                BriefDescribtion.Text = string.Empty;

            }
        }

        private void FullBriefing_Click(object sender, EventArgs e)
        {
            
            if (!alreadyFocusedFullBriefing)
            {
                alreadyFocusedFullBriefing = true;
                FullBriefing.Text = string.Empty;

            }

        }
    }
}
