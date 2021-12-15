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
    public static class Error
    {
        public static int error = 99;
    }

    public static class Success
    {
        public static int success = 99;
    }

    public static class User
    {
        public static string ID = "";
        public static string surname = "";
        public static string name = "";
        public static string gmail = "";
        public static string aceess_Level = "99";
    }
    public static class CheakUser
    {
        public static bool cheakUser = false;
    }
    public class FileName
    {
        public static string fileName = "";
    }
    

    public sealed class Help
    {
        public static int help = 99;
    }

    public static class Month
    {
        public static int month = 0;
    }

    public static class Count
    {
        public static int count = 0;
    }
    public partial class FormEntance : Form
    {
        public FormEntance()
        {
            InitializeComponent();
            Controls.Add(buttonExit);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            FormAuthorization formAuthorization = new FormAuthorization();
            formAuthorization.Show();
            this.Hide();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.Show();
            this.Hide();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
