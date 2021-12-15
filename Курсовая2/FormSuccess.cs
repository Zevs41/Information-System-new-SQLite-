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
    public partial class FormSuccess : Form
    {
        public FormSuccess()
        {
            InitializeComponent();
            this.labelSuccess.Text = "Success! \n login successful";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void buttonCloseSuccesful_Click(object sender, EventArgs e)
        {
            if (CheakUser.cheakUser == true)
            {
                labelSuccessText.Font = new Font("Rockwell", 14, FontStyle.Regular);
                Success.success = 99;
                this.Close();
            }
            else
            {
                FormMainMenu formMainMenu = new FormMainMenu();
                formMainMenu.Show();
                labelSuccessText.Font = new Font("Rockwell", 14, FontStyle.Regular);
                Success.success = 99;
                this.Close();
            }
        }

        private void FormSuccess_Load(object sender, EventArgs e)
        {
            if (Success.success == 0)
            {
                labelSuccessText.Text = "Authorization \n was successful!";
            }
            if (Success.success == 1)
            {
                labelSuccessText.Text = "Registration \n was successful!";
            }
            if (Success.success == 2)
            {
                labelSuccessText.Font = new Font("Rockwell", 12, FontStyle.Regular);
                labelSuccessText.Text = "Congratulations, \n the key and the download \n link for your product \n have been sent to the gmail!";
            }
        }

        private void labelSuccessText_Click(object sender, EventArgs e)
        {

        }
    }
}
