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
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void buttonCloseError1_Click(object sender, EventArgs e)
        {
            if (Help.help == 0)
            {
                Count.count = Convert.ToInt32(maskedTextBoxHelp.Text);
            }
            if (Help.help == 1)
            {
                Month.month = Convert.ToInt32(maskedTextBoxHelp.Text);
            }
            if (Help.help == 2)
            {
                FileName.fileName = maskedTextBoxHelp.Text;
                this.maskedTextBoxHelp.Mask = "0000000000000000000000000000";
            }
            this.Close();
        }

        private void FormHelp_Load(object sender, EventArgs e)
        {
            maskedTextBoxHelp.Text = "";
            if (Help.help == 0)
            {
                labelHelpText.Text = "Select the number \n of purchases.";
            }

            if (Help.help == 1)
            {
                labelHelpText.Text = "Select month \n for report.";
            }
            if (Help.help == 2)
            {
                this.maskedTextBoxHelp.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAA";
                labelHelpText.Text = "Set name \n for file.";
            }
        }
    }
}
