namespace LibrarySystem
{
    partial class BooksDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_BookImageDisplay = new System.Windows.Forms.PictureBox();
            this.lbl_BookTitle = new System.Windows.Forms.Label();
            this.lbl_ISBN = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.lbl_Copyright = new System.Windows.Forms.Label();
            this.lbl_Publisher = new System.Windows.Forms.Label();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BookImageDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_BookImageDisplay
            // 
            this.pb_BookImageDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_BookImageDisplay.Location = new System.Drawing.Point(58, 182);
            this.pb_BookImageDisplay.MaximumSize = new System.Drawing.Size(500, 550);
            this.pb_BookImageDisplay.Name = "pb_BookImageDisplay";
            this.pb_BookImageDisplay.Size = new System.Drawing.Size(400, 442);
            this.pb_BookImageDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_BookImageDisplay.TabIndex = 0;
            this.pb_BookImageDisplay.TabStop = false;
            // 
            // lbl_BookTitle
            // 
            this.lbl_BookTitle.AutoSize = true;
            this.lbl_BookTitle.Location = new System.Drawing.Point(14, 20);
            this.lbl_BookTitle.Name = "lbl_BookTitle";
            this.lbl_BookTitle.Size = new System.Drawing.Size(53, 25);
            this.lbl_BookTitle.TabIndex = 1;
            this.lbl_BookTitle.Text = "Title";
            this.lbl_BookTitle.Click += new System.EventHandler(this.lbl_BookTitle_Click);
            // 
            // lbl_ISBN
            // 
            this.lbl_ISBN.AutoSize = true;
            this.lbl_ISBN.Location = new System.Drawing.Point(14, 80);
            this.lbl_ISBN.Name = "lbl_ISBN";
            this.lbl_ISBN.Size = new System.Drawing.Size(60, 25);
            this.lbl_ISBN.TabIndex = 2;
            this.lbl_ISBN.Text = "ISBN";
            this.lbl_ISBN.Click += new System.EventHandler(this.lbl_ISBN_Click);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(14, 136);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(99, 25);
            this.lbl_Category.TabIndex = 3;
            this.lbl_Category.Text = "Category";
            this.lbl_Category.Click += new System.EventHandler(this.lbl_Category_Click);
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Location = new System.Drawing.Point(14, 193);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(75, 25);
            this.lbl_Author.TabIndex = 4;
            this.lbl_Author.Text = "Author";
            this.lbl_Author.Click += new System.EventHandler(this.lbl_Author_Click);
            // 
            // lbl_Copyright
            // 
            this.lbl_Copyright.AutoSize = true;
            this.lbl_Copyright.Location = new System.Drawing.Point(14, 243);
            this.lbl_Copyright.Name = "lbl_Copyright";
            this.lbl_Copyright.Size = new System.Drawing.Size(104, 25);
            this.lbl_Copyright.TabIndex = 5;
            this.lbl_Copyright.Text = "Copyright";
            // 
            // lbl_Publisher
            // 
            this.lbl_Publisher.AutoSize = true;
            this.lbl_Publisher.Location = new System.Drawing.Point(14, 303);
            this.lbl_Publisher.Name = "lbl_Publisher";
            this.lbl_Publisher.Size = new System.Drawing.Size(102, 25);
            this.lbl_Publisher.TabIndex = 6;
            this.lbl_Publisher.Text = "Publisher";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(19, 392);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(82, 36);
            this.materialButton1.TabIndex = 7;
            this.materialButton1.Text = "Borrow";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Publisher);
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Controls.Add(this.lbl_BookTitle);
            this.panel1.Controls.Add(this.lbl_ISBN);
            this.panel1.Controls.Add(this.lbl_Copyright);
            this.panel1.Controls.Add(this.lbl_Category);
            this.panel1.Controls.Add(this.lbl_Author);
            this.panel1.Location = new System.Drawing.Point(540, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 477);
            this.panel1.TabIndex = 8;
            // 
            // BooksDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 736);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_BookImageDisplay);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BooksDisplay";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BooksDisplay";
            this.Load += new System.EventHandler(this.BooksDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_BookImageDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_BookImageDisplay;
        private System.Windows.Forms.Label lbl_BookTitle;
        private System.Windows.Forms.Label lbl_ISBN;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.Label lbl_Copyright;
        private System.Windows.Forms.Label lbl_Publisher;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.Panel panel1;
    }
}