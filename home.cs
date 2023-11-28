using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibrarySystem
{
    public partial class home : MaterialForm
    {
        public home()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Red500, Accent.Orange200, TextShade.WHITE);
        }

        private void home_MaterialTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(home_MaterialTabControl.SelectedTab == logout_Tab) 
            {
                logout();
            }
        }
        private void logout()
        {
            Form_LogIn h = new Form_LogIn();
            h.Show();
            this.Hide();
        }
        private void displayBook(string name, string filePath)
        {
            BooksDisplay disp = new BooksDisplay(name, filePath);
            disp.Show();
        }

        private void bookList_Tab_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            displayBook(Deep_Learning_and_Computer_Vision.Text, Deep_Learning_and_Computer_Vision.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            displayBook(Computer_Forensics.Text, Computer_Forensics.Name);
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            displayBook(Python_Unit_Test_Automation.Text, Python_Unit_Test_Automation.Text);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            displayBook(Computer_Storage_Fundamentals.Text, Computer_Storage_Fundamentals.Text);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            displayBook(Computer_Fundamentals.Text, Computer_Fundamentals.Text);
        }
        private void home_Load(object sender, EventArgs e)
        {
          
        }

    }
}
