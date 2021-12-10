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
        public bool cheakUser = false;
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
            if (cheakUser == true)
            {
                ComandText = "SELECT Goods.ID, Development.Name, Goods.Price FROM Goods, Development WHERE Goods.ID = Development.ID";
            }
            else
            {
                ComandText = "SELECT * FROM Goods";
            }
            DB = new SQLiteDataAdapter(ComandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridViewGoods.DataSource = DT;
            sql_con.Close();
        }

        private void Add()
        {
            if (textBoxID.Text != "" && textBoxDevelopment.Text != "" && textBoxPrice.Text != "")
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string ComandText = "INSERT INTO Goods(Development, Price) VALUES ('" + textBoxDevelopment.Text + "','" + textBoxPrice.Text + "')";
                ExecuteQuery(ComandText);
                LoadData();
            }
            else
            {
                Error.error = 1;
                FormError error = new FormError();
                error.ShowDialog();
            }
        }

        private void Find()
        {
            if (textBoxID.Text == "" && textBoxID.Text == "" && textBoxDevelopment.Text == "" && textBoxPrice.Text == "")
            {
                LoadData();
            }
            else
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string ComandText = "SELECT * FROM Goods WHERE ID LIKE '" + textBoxID.Text + "' OR Development LIKE '" + textBoxDevelopment.Text + "' OR Price LIKE '" + textBoxPrice.Text + "'";
                DB = new SQLiteDataAdapter(ComandText, sql_con);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];
                dataGridViewGoods.DataSource = DT;
                sql_con.Close();
            }

        }

        private void Change()
        {
            if (textBoxID.Text != "" && textBoxDevelopment.Text != "" && textBoxPrice.Text != "")
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string ComandText = "UPDATE Goods,Development SET Development.Name = '" + textBoxDevelopment.Text + "', Goods.Price = '" + textBoxPrice.Text + "'";
                ExecuteQuery(ComandText);
                LoadData();
            }
            else
            {
                Error.error = 1;
                FormError error = new FormError();
                error.ShowDialog();
            }
        }

        private void Delete()
        {
            if (textBoxID.Text != "")
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string ComandText = "DELETE FROM Roles WHERE ID = '" + textBoxID.Text + "'";
                ExecuteQuery(ComandText);
                LoadData();
            }
            else
            {
                Error.error = 1;
                FormError error = new FormError();
                error.ShowDialog();
            }

        }

        private void Clear()
        {
            textBoxPrice.Text = "";
            textBoxDevelopment.Text = "";
            textBoxID.Text = "";
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
                cheakUser = true;
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
                cheakUser = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            Find();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
