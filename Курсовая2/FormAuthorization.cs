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

namespace Курсовая2
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
            buttonBackToEntance.BringToFront();
            buttonExit.BringToFront();
        }
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        bool cheak;


        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=dbKursach.db;Version=3;Compress=True;");
        }

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();
            string UserLogin = textBoxLogin.Text;
            string UserPass = textBoxPass.Text;
            SQLiteCommand sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = "SELECT * FROM Roles WHERE Login = '" + UserLogin + "' AND Pass = '" + UserPass + "'";
            DB.SelectCommand = sql_cmd;
            DS.Reset();
            DB.Fill(DT);
            sql_cmd.ExecuteNonQuery();
            if (DT.Rows.Count > 0)
            {
                User.surname = DT.Rows[0].ItemArray[3].ToString();
                User.name = DT.Rows[0].ItemArray[4].ToString();
                User.gmail = DT.Rows[0].ItemArray[5].ToString();
                
                User.aceess_Level = DT.Rows[0].ItemArray[6].ToString();
                Success.success = 0;
                FormSuccess formSuccess0 = new FormSuccess();
                formSuccess0.Show();
                this.Close();
            }
            else
            {
                Error.error = 0;
                FormError formError1 = new FormError();
                formError1.Show();
            }
            LoadData();
            sql_con.Close();
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
            string ComandText = "SELECT * FROM Roles";
            DB = new SQLiteDataAdapter(ComandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridViewCheck.DataSource = DT;
            sql_con.Close();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        private void FormAuthorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            sql_con.Close();
        }

        private void FormAuthorization_Load_1(object sender, EventArgs e)
        {
            this.textBoxPass.PasswordChar = '*';
            cheak = true;
            LoadData();
            this.textBoxLogin.AutoSize = false;
            this.textBoxPass.AutoSize = false;
        }

        private void buttonBackToEntance_Click(object sender, EventArgs e)
        {
            FormEntance formEntance = new FormEntance();
            formEntance.Show();
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonViewPass_Click(object sender, EventArgs e)
        {
            if (cheak == true)
            {
                this.textBoxPass.PasswordChar = '\0';
                cheak = false;
            }
            else
            {
                this.textBoxPass.PasswordChar = '*';
                cheak = true;
            }
        }
    }
}
