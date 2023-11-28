using RestSharp.Extensions;
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
        private int checkBoxLimit;
        private int checkBoxCount = 1;
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
            if (cb_Borrower_BorrowerType.SelectedIndex == 0) 
            { 
                bookLimit = 2; 
                dtp_Borrower_DueDate.Enabled = true;
            }
            else
            {
                bookLimit = 5;
                dtp_Borrower_DueDate.Enabled = false;
            };
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void checkBoxLimiter(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (checkBoxCount > checkBoxLimit && cb.Checked)
            {
                MessageBox.Show("Exceed the limit.");
                cb.Checked = false;
                checkBoxCount++;
            }
            else if (checkBoxCount <= checkBoxLimit && cb.Checked)
            {
                checkBoxCount++;
            }
            else
            {
                checkBoxCount--;
            }
            if (checkBoxCount <= 1)
            {
                cb_Borrower_NumberOfBooks.Enabled = true;
            }
            else
            {
                cb_Borrower_NumberOfBooks.Enabled = false;
            }
            
        }

        private void cb_Borrower_NumberOfBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel_Borrower_BookListCheckBox.Enabled = true;
            panel_Borrower_BookListCheckBox.Visible = true;
            checkBoxLimit = Convert.ToInt32(cb_Borrower_NumberOfBooks.Text);
        }
    }
}
