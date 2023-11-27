using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace LibrarySystem
{
    public partial class Form_LogIn : Form
    {
        public Form_LogIn()
        {
            InitializeComponent();

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        private void PerformLogin()
        {
            string correctUsername = "admin";
            string correctPassword = "password";

            string enteredUsername = userName_Tb.Text;
            string enteredPassword = password_Tb.Text;

            if (enteredUsername == correctUsername && enteredPassword == correctPassword)
            {
                home h = new home();
                h.Show();
                this.Hide();
            }
            else
            {
                logInErrorMessage_Label.Visible = true;
                userName_Tb.Text = "";
                password_Tb.Text = "";
            }
        }

        private void close_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPassword_Pb_Click(object sender, EventArgs e)
        {
            password_Tb.UseSystemPasswordChar = !password_Tb.UseSystemPasswordChar;
            showPassword_Pb.Visible = false;
            hidePassword_Pb.Visible = true;
        }

        private void hidePassword_Pb_Click(object sender, EventArgs e)
        {
            password_Tb.UseSystemPasswordChar = !password_Tb.UseSystemPasswordChar;
            hidePassword_Pb.Visible = false;
            showPassword_Pb.Visible = true;
        }

        private void ClearOnClicked(object sender, EventArgs e)
        {
            logInErrorMessage_Label.Visible = false;
        }
    }
}
