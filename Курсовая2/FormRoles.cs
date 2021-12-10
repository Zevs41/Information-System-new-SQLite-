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
    public partial class FormRoles : Form
    {
        public FormRoles()
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
            string ComandText = "SELECT * FROM Roles";
            DB = new SQLiteDataAdapter(ComandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridViewRoles.DataSource = DT;
            sql_con.Close();
        }

        private void Add()
        {
            if (textBoxID.Text != "" && textBoxLogin.Text != "" && textBoxPass.Text != "" && textBoxSurname.Text != "" && textBoxName.Text != "" && textBoxGmail.Text != "" && textBoxAccessLevel.Text != "")
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string ComandText = "INSERT INTO Roles(Login, Pass, Surname, Name, Gmail, Access_level) VALUES ('" + textBoxLogin.Text + "','" + textBoxPass.Text + "','" + textBoxSurname.Text + "','" + textBoxName.Text + "','" + textBoxGmail.Text + "','" + textBoxAccessLevel.Text + "')";
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
            if (textBoxID.Text == "" && textBoxLogin.Text == "" && textBoxPass.Text == "" && textBoxSurname.Text == "" && textBoxName.Text == "" && textBoxGmail.Text == "" && textBoxAccessLevel.Text == "")
            {
                LoadData();
            }
            else
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string ComandText = "SELECT * FROM Roles WHERE ID LIKE '" + textBoxID.Text + "' OR Login LIKE '" + textBoxLogin.Text + "' OR Pass LIKE '" + textBoxPass.Text + "' OR Surname LIKE '" + textBoxSurname.Text + "' OR Name LIKE '" + textBoxName.Text + "'OR Gmail LIKE '" + textBoxGmail.Text + "'OR Access_level LIKE '" + textBoxAccessLevel.Text + "'";
                DB = new SQLiteDataAdapter(ComandText, sql_con);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];
                dataGridViewRoles.DataSource = DT;
                sql_con.Close();
            }

        }

        private void Change()
        {
            if (textBoxID.Text != "" && textBoxLogin.Text != "" && textBoxPass.Text != "" && textBoxSurname.Text != "" && textBoxName.Text != "" && textBoxGmail.Text != "" && textBoxAccessLevel.Text != "")
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                string ComandText = "UPDATE Roles SET Login = '" + textBoxLogin.Text + "', Pass = '" + textBoxPass.Text + "', Surname = '" + textBoxSurname.Text + "', Name = '" + textBoxName.Text + "', Gmail = '" + textBoxGmail.Text + "', Access_level = '" + textBoxAccessLevel.Text + "' WHERE ID = '" + textBoxID.Text + "'";
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
            textBoxAccessLevel.Text = "";
            textBoxGmail.Text = "";
            textBoxID.Text = "";
            textBoxLogin.Text = "";
            textBoxName.Text = "";
            textBoxPass.Text = "";
            textBoxSurname.Text = "";
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormRoles_Load(object sender, EventArgs e)
        {
            LoadData();
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

        private void dataGridViewRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxID.Text = dataGridViewRoles.SelectedRows[0].Cells[0].Value.ToString();
                textBoxLogin.Text = dataGridViewRoles.SelectedRows[0].Cells[1].Value.ToString();
                textBoxPass.Text = dataGridViewRoles.SelectedRows[0].Cells[2].Value.ToString();
                textBoxSurname.Text = dataGridViewRoles.SelectedRows[0].Cells[3].Value.ToString();
                textBoxName.Text = dataGridViewRoles.SelectedRows[0].Cells[4].Value.ToString();
                textBoxGmail.Text = dataGridViewRoles.SelectedRows[0].Cells[5].Value.ToString();
                textBoxAccessLevel.Text = dataGridViewRoles.SelectedRows[0].Cells[6].Value.ToString();
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
