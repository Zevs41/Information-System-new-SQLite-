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
    public partial class FormError : Form
    {
        public FormError()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        

        private void buttonCloseError1_Click(object sender, EventArgs e)
        {
            Error.error = 99;
            this.Close();
        }

        private void FormError1_Load(object sender, EventArgs e)
        {
            if (Error.error == 0)
            {
                labelError1.Text = "Error 0!";
                labelError1Text.Text = "Data entered \n incorrectly!";
            }
            if (Error.error == 1)
            {
                labelError1.Text = "Error 1!";
                labelError1Text.Text = "Not all \n data entered!";
            }
            if (Error.error == 2)
            {
                labelError1.Text = "Error 2!";
                labelError1Text.Text = "Password \n mismatch!";
            }
            if (Error.error == 3)
            {
                labelError1.Text = "Error 3!";
                labelError1Text.Text = "Gmail entered \n incorrectly!";
            }
            if (Error.error == 4)
            {
                labelError1.Text = "Error 4!";
                labelError1Text.Text = "Password or Login \n or Gmail are used!";
            }
        }
    }
}
