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
    public partial class FormGoods : Form
    {
        public FormGoods()
        {
            InitializeComponent();
        }

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
            string ComandText = "SELECT Name, Price FROM Goods";
            DB = new SQLiteDataAdapter(ComandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridViewGoods.DataSource = DT;
            sql_con.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void FormGoods_Load(object sender, EventArgs e)
        {
            LoadData();
            if (Convert.ToInt32(User.aceess_Level) > 0)
            {
                this.buttonBackToMainMenu.Text = "Back";
            }
            else
            {
                this.buttonBackToMainMenu.Text = "Log Out";
            }
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(User.aceess_Level) > 0)
            {
                FormMainMenu formMainMenu = new FormMainMenu();
                formMainMenu.Show();
                this.Close();
            }
            else
            {
                User.aceess_Level = "99";
                User.surname = "";
                User.name = "";
                User.gmail = "";
                FormEntance formEntance = new FormEntance();
                formEntance.Show();
                this.Close();

            }
        }
    }
}
