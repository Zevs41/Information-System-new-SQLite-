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
            string ComandText = "";
            if (CheakUser.cheakUser == true)
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
            if (textBoxDevelopment.Text != "" && textBoxPrice.Text != "")
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
                if (CheakUser.cheakUser == true)
                {
                    string ComandText = "SELECT Goods.ID, Development.Name, Goods.Price FROM Goods, Development WHERE (Goods.ID LIKE '" + textBoxID.Text + "' OR Development.Name LIKE '" + textBoxDevelopment.Text + "' OR Goods.Price LIKE '" + textBoxPrice.Text + "') AND Goods.ID LIKE Development.ID";
                    DB = new SQLiteDataAdapter(ComandText, sql_con);
                }
                else
                {
                    string ComandText = "SELECT * FROM Goods WHERE ID LIKE '" + textBoxID.Text + "' OR Development LIKE '" + textBoxDevelopment.Text + "' OR Price LIKE '" + textBoxPrice.Text + "'";
                    DB = new SQLiteDataAdapter(ComandText, sql_con);
                }
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
                string ComandText = "UPDATE Goods SET Development = '" + textBoxDevelopment.Text + "', Price = '" + textBoxPrice.Text + "' WHERE ID = '" + textBoxID.Text + "'";
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
                string ComandText = "DELETE FROM Goods WHERE ID = '" + textBoxID.Text + "'";
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
            if (Convert.ToInt32(User.aceess_Level) > 0)
            {
                this.buttonBackToMainMenu.Text = "Back";
                buttonBuy.Visible = false;
                labelUserData.Visible = false;
            }
            else
            {
                labelUserData.Text = User.surname + " " + User.name + "\n" + User.gmail;
                CheakUser.cheakUser = true;
                buttonFind.Location = new Point(381, 181);
                buttonUp.Location = new Point(381, 217);
                buttonBuy.Location = new Point(381, 253);
                buttonAdd.Visible = false;
                buttonDelete.Visible = false;
                buttonChange.Visible = false;
                this.buttonBackToMainMenu.Text = "Log Out";
            }
            LoadData();
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
                User.ID = "";
                User.aceess_Level = "99";
                User.surname = "";
                User.name = "";
                User.gmail = "";
                FormEntance formEntance = new FormEntance();
                formEntance.Show();
                CheakUser.cheakUser = false;
                this.Close();
            }
        }

        private void Buy()
        {
            FormHelp formCountBuy = new FormHelp();
            formCountBuy.ShowDialog();
            string date;
            DateTime now = DateTime.Now;
            date = now.Year.ToString() + now.Month.ToString() + now.Day.ToString();
            if (textBoxID.Text != "" && textBoxDevelopment.Text != "" && textBoxPrice.Text != "")
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string ComandText = "INSERT INTO Sales(Development, Count, Total_price, Date, Customer) VALUES ('" + textBoxID.Text + "','" + Count.count.ToString() + "','" + Count.count * Convert.ToInt32(textBoxPrice.Text) + "','" + date + "','" + User.ID + "')";
                ExecuteQuery(ComandText);
                Success.success = 2;
                FormSuccess success = new FormSuccess();
                success.ShowDialog();
            }
            else
            {
                Error.error = 1;
                FormError error = new FormError();
                error.ShowDialog();
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridViewGoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxID.Text = dataGridViewGoods.SelectedRows[0].Cells[0].Value.ToString();
                textBoxDevelopment.Text = dataGridViewGoods.SelectedRows[0].Cells[1].Value.ToString();
                textBoxPrice.Text = dataGridViewGoods.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch
            {
                Error.error = 5;
                FormError error = new FormError();
                error.ShowDialog();
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            Help.help = 0;
            Buy();
        }
    }
}
