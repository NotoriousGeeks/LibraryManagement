using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibrarySystem
{
    public partial class BooksDisplay : MaterialForm
    {
        public BooksDisplay(string name, string filePath)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Red500, Accent.Orange200, TextShade.WHITE);

            ModifyForm(name, filePath);
            BackEndLibrary(name);


        }
        private void BackEndLibrary(string BookName)
        {
            var Books = new Dictionary<string, Dictionary<string, object>>();
            Books["Computer Fundamentals"] = new Dictionary<string, object>
            {
                {"Title", "Computer Fundamentals"},
                {"ISBN", "9788176567527"},
                {"Author", "N/A"},
                {"Category", "Academic Books"},
                {"Copyright", "2004"},
                {"Publisher", "BPB Publications"}
            };
            Books["Deep Learning and Computer Vision"] = new Dictionary<string, object> 
            {
                {"Title", "Deep Learning and Computer Vision"},
                {"ISBN", "9789388511858"},
                {"Author", "N/A"},
                {"Category", "Academic Books"},
                {"Copyright", "2020"},
                {"Publisher", "BPB Publications"}
            };
            Books["Computer Forensics"] = new Dictionary<string, object>
            {
                {"Title", "Computer Forensics"},
                {"ISBN", "9781838641092"},
                {"Author", "N/A"},
                {"Category", "Academic Books"},
                {"Copyright", "2020"},
                {"Publisher", "Packt Publishing"}
            };
            Books["Computer Storage Fundamentals"] = new Dictionary<string, object>
            {
                {"Title", "Computer Storage Fundamentals"},
                {"ISBN", "9789388176552"},
                {"Author", "N/A"},
                {"Category", "Academic Books"},
                {"Copyright", "2020"},
                {"Publisher", "BPB Publications"}
            };
            Books["Python Unit Test Automation"] = new Dictionary<string, object>
            {
                {"Title", "Python Unit Test Automation"},
                {"ISBN", "9781484226773"},
                {"Author", "N/A"},
                {"Category", "Academic Books"},
                {"Copyright", "2017"},
                {"Publisher", "Apress"}
            };
            lbl_BookTitle.Text = "Title: " + (string)Books[BookName]["Title"];
            lbl_Author.Text = "Author: " + (string)Books[BookName]["Author"];
            lbl_Category.Text = "Category: " + (string)Books[BookName]["Category"];
            lbl_ISBN.Text = "ISBN: " + (string)Books[BookName]["ISBN"];
            lbl_Publisher.Text = "Publisher: " + (string)Books[BookName]["Publisher"];
            lbl_Copyright.Text = "Copyright: " + (string)Books[BookName]["Copyright"];
        }
        private void ModifyForm(string name, string filePath)
        {
            this.Text = name;
            Bitmap filepath = (Bitmap)Properties.Resources.ResourceManager.GetObject(name);
            pb_BookImageDisplay.Image = filepath;

        }

        private void BooksDisplay_Load(object sender, EventArgs e)
        {

        }

        private void lbl_BookTitle_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ISBN_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Category_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Author_Click(object sender, EventArgs e)
        {

        }
    }
}
