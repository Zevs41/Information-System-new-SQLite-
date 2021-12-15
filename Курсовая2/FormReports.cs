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
using System.IO;

namespace Курсовая2
{
    public partial class FormReports : Form
    {
        public FormReports()
        {
            InitializeComponent();
        }
        FormHelp formHelp = new FormHelp();
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=dbKursach.db;Version=3;Compress=True;");
        }

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string ComandText = "";
            ComandText = "SELECT * FROM Sales WHERE Date LIKE '____" +Month.month+ "%'";
            DB = new SQLiteDataAdapter(ComandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridViewReports.DataSource = DT;
            sql_con.Close();
        }

        private void CountCustomers()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string ComandText = "";
            ComandText = "SELECT * FROM Roles WHERE Access_level = '" +0+ "'";
            DB = new SQLiteDataAdapter(ComandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridViewReports.DataSource = DT;
            sql_con.Close();
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            FormMainMenu frmMain = new FormMainMenu();
            frmMain.Show();
            this.Close();
        }

        private void CountCustomerPerMonth() 
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string ComandText = "";
            ComandText = "SELECT * FROM Roles WHERE Registration_date LIKE '____" + Month.month + "%'";
            DB = new SQLiteDataAdapter(ComandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridViewReports.DataSource = DT;
            sql_con.Close();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDevelopment_Click(object sender, EventArgs e)
        {
            Help.help = 1;            
            formHelp.ShowDialog();
            if (Month.month > 12 || 0 > Month.month)
            {
                Error.error = 6;
                FormError formError = new FormError();
                formError.ShowDialog();
            }
            else
            {
                LoadData();
                int monthluProeceds = 0;
                Help.help = 2;
                formHelp.ShowDialog();
                FileStream fs = new FileStream(FileName.fileName + "Report.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                for (int i = 0; i < dataGridViewReports.Rows.Count-1; i++)
                {
                    monthluProeceds = monthluProeceds + Convert.ToInt32(dataGridViewReports[3,i].Value.ToString());
                }
                sw.WriteLine("За "+ Month.month + " меясц было заработано " +  monthluProeceds + " р.");
                sw.Close();
            }
        }

        private void buttonNumberOfUsers_Click(object sender, EventArgs e)
        {
            CountCustomers();
            Help.help = 2;
            formHelp.ShowDialog();
            int countCustomers = 0;
            FileStream fs = new FileStream(FileName.fileName + "Report.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < dataGridViewReports.Rows.Count - 1; i++)
            {
                countCustomers++;
            }
            sw.WriteLine("На текущее время: " + DateTime.Now + " было зарегестрировано " + countCustomers.ToString() + " пользователей");
            sw.Close();
        }

        private void buttonNumberPerMomnth_Click(object sender, EventArgs e)
        {
            Help.help = 1;
            formHelp.ShowDialog();
            if (Month.month > 12 || 0 > Month.month)
            {
                Error.error = 6;
                FormError formError = new FormError();
                formError.ShowDialog();
            }
            else
            {
                CountCustomerPerMonth();
                int NumberPerMomnth = 0;
                Help.help = 2;
                formHelp.ShowDialog();
                FileStream fs = new FileStream(FileName.fileName + "Repoer.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                for (int i = 0; i < dataGridViewReports.Rows.Count - 1; i++)
                {
                    NumberPerMomnth++;
                }
                sw.WriteLine("За " + Month.month + " меясц было зарегестрировано " + NumberPerMomnth.ToString() + " пользователей");
                sw.Close();
            }
        }
    }
}
