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
    public partial class FormDevelopment : Form
    {
        public FormDevelopment()
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
            string ComandText = "SELECT * FROM Development";
            DB = new SQLiteDataAdapter(ComandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridViewDevelopment.DataSource = DT;
            sql_con.Close();
        }

        private void Add()
        {
            if (textBoxDeveloper.Text !="" && textBoxName.Text != "" && textBoxStatus.Text !="" && textBoxType.Text != "") 
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string ComandText = "INSERT INTO Development(Name, Type, Status, The_Developer) VALUES ('" + textBoxName.Text + "','" + textBoxType.Text + "','" + textBoxStatus.Text + "','" + textBoxDeveloper.Text + "')";
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
            if (textBoxID.Text == "" && textBoxDeveloper.Text == "" && textBoxName.Text == "" && textBoxStatus.Text == "" && textBoxType.Text == "")
            {
                LoadData();
            }
            else
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string ComandText = "SELECT * FROM Development WHERE ID LIKE '" + textBoxID.Text + "' OR Name LIKE '" + textBoxName.Text + "' OR Type LIKE '" + textBoxType.Text + "' OR Status LIKE '" + textBoxStatus.Text + "' OR The_Developer LIKE '" + textBoxDeveloper.Text + "'";
                DB = new SQLiteDataAdapter(ComandText, sql_con);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];
                dataGridViewDevelopment.DataSource = DT;
                sql_con.Close();
            }

        }

        private void Change()
        {
            if (textBoxDeveloper.Text != "" && textBoxName.Text != "" && textBoxStatus.Text != "" && textBoxType.Text != "")
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string ComandText = "UPDATE Development SET Name = '" + textBoxName.Text + "', Type = '" + textBoxType.Text + "', Status = '" + textBoxStatus.Text + "', The_Developer = '" + textBoxDeveloper.Text + "' WHERE ID = '"+ textBoxID.Text +"'";
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
                string ComandText = "DELETE FROM Development WHERE ID = '" + textBoxID.Text + "'";
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
            textBoxID.Text = "";
            textBoxStatus.Text = "";
            textBoxDeveloper.Text = "";
            textBoxName.Text = "";
            textBoxType.Text = "";
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            FormMainMenu formMainMenu = new FormMainMenu();
            formMainMenu.Show();
            this.Close();
        }
        private void FormDevelopment_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            Find();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridViewDevelopment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                textBoxID.Text = dataGridViewDevelopment.SelectedRows[0].Cells[0].Value.ToString(); 
                textBoxName.Text = dataGridViewDevelopment.SelectedRows[0].Cells[1].Value.ToString();
                textBoxType.Text = dataGridViewDevelopment.SelectedRows[0].Cells[2].Value.ToString();
                textBoxStatus.Text = dataGridViewDevelopment.SelectedRows[0].Cells[3].Value.ToString();
                textBoxDeveloper.Text = dataGridViewDevelopment.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch 
            {
                Error.error = 5;
                FormError error = new FormError();
                error.ShowDialog();
            }
        }
    }
}
