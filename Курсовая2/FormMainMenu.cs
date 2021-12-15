using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая2
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            User.aceess_Level = "99";
            User.surname = "";
            User.name = "";
            User.gmail = "";
            FormEntance formEntance = new FormEntance();
            formEntance.Show();
            this.Close();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            labelUserData.Text = User.surname + " " + User.name + "\n" + User.gmail;
            if (Convert.ToInt32(User.aceess_Level) == 0)
            {
                FormGoods goods = new FormGoods();
                goods.Show();
                this.Close();
            }
            if (Convert.ToInt32(User.aceess_Level) == 1)
            {
                buttonRoles.Visible = false;
                this.Size = new Size(643, 200);
                buttonLogOut.Location = new Point(18, 12);
                buttonExit.Location = new Point(555, 12);
            }
        }

        private void buttonRoles_Click(object sender, EventArgs e)
        {
            FormRoles formRoles = new FormRoles();
            formRoles.Show();
            this.Close();
        }

        private void buttonDevelopment_Click(object sender, EventArgs e)
        {
            FormDevelopment formDevelopment = new FormDevelopment();
            formDevelopment.Show();
            this.Close();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            FormSales formSales = new FormSales();
            formSales.Show();
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGoods_Click(object sender, EventArgs e)
        {
            FormGoods formGoods = new FormGoods();
            formGoods.Show();
            this.Close();
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            FormReports formReports = new FormReports();
            formReports.Show();
            this.Close();
        }
    }
}
