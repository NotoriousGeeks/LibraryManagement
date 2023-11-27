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
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
