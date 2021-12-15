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
    public partial class FormSales : Form
    {
        public FormSales()
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
            string ComandText = "SELECT * FROM Sales";
            DB = new SQLiteDataAdapter(ComandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridViewSales.DataSource = DT;
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

        private void FormSales_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonBackToMainMenu_Click_1(object sender, EventArgs e)
        {
            FormMainMenu formMainMenu = new FormMainMenu();
            formMainMenu.Show();
            this.Close();
        }

        private void Add()
        {
            if (textBoxID.Text != "" && textBoxDevelopment.Text != "" && textBoxCount.Text != "" && textBoxTotalPrice.Text != "" && textBoxDate.Text != "" && textBoxCustomer.Text != "")
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string date = textBoxDate.Text.Substring(6, 4) + textBoxDate.Text.Substring(3, 2) + textBoxDate.Text.Substring(0, 2);
                string ComandText = "INSERT INTO Sales(Development, Count, Total_price, Date, Customer) VALUES ('" + textBoxDevelopment.Text + "','" + textBoxCount.Text + "','" + textBoxTotalPrice.Text + "','" + date + "','" + textBoxCustomer.Text + "')";
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
            if (textBoxID.Text == "" && textBoxDevelopment.Text == "" && textBoxCount.Text == "" && textBoxTotalPrice.Text == "" && textBoxDate.Text == "" && textBoxCustomer.Text != "")
            {
                LoadData();
            }
            else
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string ComandText = "SELECT * FROM Sales WHERE ID LIKE '" + textBoxID.Text + "' OR Development LIKE '" + textBoxDevelopment.Text + "' OR Count LIKE '" + textBoxCount.Text + "' OR Total_price LIKE '" + textBoxTotalPrice.Text + "' OR Date LIKE '" + textBoxDate.Text + "'OR Customer LIKE '" + textBoxCustomer.Text + "'";
                DB = new SQLiteDataAdapter(ComandText, sql_con);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];
                dataGridViewSales.DataSource = DT;
                sql_con.Close();
            }

        }

        private void Change()
        {
            if (textBoxID.Text != "" && textBoxDevelopment.Text != "" && textBoxCount.Text != "" && textBoxTotalPrice.Text != "" && textBoxDate.Text != "" && textBoxCustomer.Text != "")
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string date = textBoxDate.Text.Substring(6, 4) + textBoxDate.Text.Substring(3, 2) + textBoxDate.Text.Substring(0, 2);
                string ComandText = "UPDATE Sales SET Development = '" + textBoxDevelopment.Text + "', Count = '" + textBoxCount.Text + "', Total_price = '" + textBoxTotalPrice.Text + "', Date = '" + date + "', Customer = '" + textBoxCustomer.Text + "' WHERE ID = '" + textBoxID.Text + "'";
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
                string ComandText = "DELETE FROM Sales WHERE ID = '" + textBoxID.Text + "'";
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
            textBoxDevelopment.Text = "";
            textBoxID.Text = "";
            textBoxCount.Text = "";
            textBoxTotalPrice.Text = "";
            textBoxDate.Text = "";
            textBoxCustomer.Text = "";
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

        private void dataGridViewSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxID.Text = dataGridViewSales.SelectedRows[0].Cells[0].Value.ToString();
                textBoxDevelopment.Text = dataGridViewSales.SelectedRows[0].Cells[1].Value.ToString();
                textBoxCount.Text = dataGridViewSales.SelectedRows[0].Cells[2].Value.ToString();
                textBoxTotalPrice.Text = dataGridViewSales.SelectedRows[0].Cells[3].Value.ToString();
                textBoxDate.Text = dataGridViewSales.SelectedRows[0].Cells[4].Value.ToString();
                textBoxCustomer.Text = dataGridViewSales.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch
            {
                Error.error = 5;
                FormError error = new FormError();
                error.ShowDialog();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
