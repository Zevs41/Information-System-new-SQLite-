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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
            this.labelUserName.Text = "Create \n     a username";
            this.labelPassword.Text = "Create \n     a password";
            this.labelRUserName.Text = "Repeat \n     a password";
            this.textBoxPasswordAdd.PasswordChar = '*';
            this.textBoxRPasswordAdd.PasswordChar = '*';
            this.labelSurname.Text = "Enter \n     a surname";
            this.labelName.Text = "Enter \n     a name";
            this.labelGmail.Text = "Enter \n     a Gmail";
        }


        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        bool cheakp = true;
        bool cheakpr = true;

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
            dataGridViewCheckGmail.DataSource = DT;
            sql_con.Close();
        }

        private void buttonBackToEntance_Click(object sender, EventArgs e)
        {
            FormEntance formEntance = new FormEntance();
            formEntance.Show();
            this.Close();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (textBoxLoginAdd.Text != "" && textBoxNameAdd.Text != "" && textBoxPasswordAdd.Text != "" && textBoxRPasswordAdd.Text != "" && textBoxSurnameAdd.Text != "" && textBoxGmailAdd.Text != "")
            {
                if (textBoxPasswordAdd.Text == textBoxRPasswordAdd.Text)
                {
                    if (textBoxGmailAdd.Text.Contains("@gmail.com") == true)
                    {
                        SetConnection();
                        sql_con.Open();
                        string UserLogin = textBoxLoginAdd.Text;
                        string UserGmail = textBoxGmailAdd.Text;
                        string UserPass = textBoxPasswordAdd.Text;
                        SQLiteCommand sql_cmd = sql_con.CreateCommand();
                        sql_cmd.CommandText = "SELECT * FROM Roles WHERE Gmail = '" + UserGmail + "' OR Pass = '" + UserPass + "' OR Login = '" + UserLogin + "'";
                        DB.SelectCommand = sql_cmd;
                        DS.Reset();
                        DB.Fill(DT);
                        sql_cmd.ExecuteNonQuery();
                        if (DT.Rows.Count == 0)
                        {
                            SetConnection();
                            string txtQuery = "INSERT INTO Roles (Login,Pass,Surname,Name,Gmail,Access_level) VALUES ('" + textBoxLoginAdd.Text + "','" + textBoxPasswordAdd.Text + "','" + textBoxSurnameAdd.Text + "','" + textBoxNameAdd.Text + "','" + textBoxGmailAdd.Text + "','" + 0 + "')";
                            ExecuteQuery(txtQuery);
                            Success.success = 1;
                            User.name = textBoxNameAdd.Text;
                            User.surname = textBoxSurnameAdd.Text;
                            User.aceess_Level = "0";
                            User.gmail = textBoxGmailAdd.Text;
                            FormSuccess formSuccess = new FormSuccess();
                            formSuccess.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            Error.error = 4;
                            FormError formError1 = new FormError();
                            formError1.ShowDialog();
                        }
                        LoadData();
                        sql_con.Close();
                    }
                    else
                    {
                        Error.error = 3;
                        FormError formError1 = new FormError();
                        formError1.ShowDialog();
                    }
                }
                else
                {
                    Error.error = 2;
                    FormError formError1 = new FormError();
                    formError1.ShowDialog();
                }
            }
            else
            {
                Error.error = 1;
                FormError formError1 = new FormError();
                formError1.ShowDialog();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

            LoadData();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonViewPass_Click(object sender, EventArgs e)
        {
            if (cheakp == true)
            {
                this.textBoxPasswordAdd.PasswordChar = '\0';
                cheakp = false;
            }
            else
            {
                this.textBoxPasswordAdd.PasswordChar = '*';
                cheakp = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cheakpr == true)
            {
                this.textBoxRPasswordAdd.PasswordChar = '\0';
                cheakpr = false;
            }
            else
            {
                this.textBoxRPasswordAdd.PasswordChar = '*';
                cheakpr = true;
            }
        }
    }
}
