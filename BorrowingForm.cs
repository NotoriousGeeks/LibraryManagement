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
using System.Windows.Forms.VisualStyles;

namespace LibrarySystem
{
    public partial class BorrowingForm : Form
    {
        
        public BorrowingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        private string[][] GetBorrowerList()
        {
            var BorrowersName = new string[][] {
                new string[]{"Von Andrew Castillo", "Jeremiah Dela Vega", "Sean Samonte","Fredluis Obidos", "Llenard Diama" },
                new string[]{"Lester Diampoc", "Jomariss Plan", "Rommel Dorin"}
            };
            return BorrowersName;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Form_BorrowerName.AutoCompleteCustomSource.Clear();
            cb_Borrower_NumberOfBooks.Items.Clear();
            var BorrowersName = GetBorrowerList();
            foreach (string x in BorrowersName[cb_Borrower_BorrowerType.SelectedIndex])
            {
                tb_Form_BorrowerName.AutoCompleteCustomSource.Add(x);
            }
            int bookLimit;
            _ = (cb_Borrower_BorrowerType.SelectedIndex == 0) ? bookLimit = 2 : bookLimit = 5;
            for (int i = 1; i <= bookLimit; i++)
            {
                cb_Borrower_NumberOfBooks.Items.Add(i+"");
            }
        }

        private void checkIfExist(object sender, EventArgs e)
        {
            bool doesExist = false;
            var BorrowersName = GetBorrowerList();
           
            foreach (var item in BorrowersName[0])
            {
                if(tb_Form_BorrowerName.Text.ToLower() == item.ToLower())
                {
                    doesExist = true;
                }
            }
            if (!doesExist)
            {
                foreach (var item in BorrowersName[1])
                {
                    if (tb_Form_BorrowerName.Text.ToLower() == item.ToLower())
                    {
                        doesExist = true;
                    }
                }
            }

            if (!doesExist && tb_Form_BorrowerName.Text.ToLower() != "")
            {
                panel_Form_BorrowerName.BackColor = Color.FromArgb(222, 15, 0);
            }
            else if(doesExist && tb_Form_BorrowerName.Text.ToLower() != "")
            {
                panel_Form_BorrowerName.BackColor = Color.FromArgb(0, 189, 75);   
            }
        }

        private void tb_Form_BorrowerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
