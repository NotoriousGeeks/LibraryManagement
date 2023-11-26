namespace LibrarySystem
{
    partial class home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bookReservation_Tab = new System.Windows.Forms.TabPage();
            this.bookReturning_Tab = new System.Windows.Forms.TabPage();
            this.bookBorrowing_Tab = new System.Windows.Forms.TabPage();
            this.borrowerList_Tab = new System.Windows.Forms.TabPage();
            this.bookList_Tab = new System.Windows.Forms.TabPage();
            this.dashboard_Tab = new System.Windows.Forms.TabPage();
            this.home_MaterialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.logout_Tab = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.borrowerList_Tab.SuspendLayout();
            this.bookList_Tab.SuspendLayout();
            this.home_MaterialTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bookListed2.png");
            this.imageList1.Images.SetKeyName(1, "books.png");
            this.imageList1.Images.SetKeyName(2, "booksListed1.png");
            this.imageList1.Images.SetKeyName(3, "booksReturned.png");
            this.imageList1.Images.SetKeyName(4, "booksReturned2.png");
            this.imageList1.Images.SetKeyName(5, "borrower1.png");
            this.imageList1.Images.SetKeyName(6, "dashboard1.png");
            this.imageList1.Images.SetKeyName(7, "lockIcon.png");
            this.imageList1.Images.SetKeyName(8, "logo2.png");
            this.imageList1.Images.SetKeyName(9, "penalty.png");
            this.imageList1.Images.SetKeyName(10, "profileIcon4.png");
            this.imageList1.Images.SetKeyName(11, "registeredUsers.png");
            this.imageList1.Images.SetKeyName(12, "book2.png");
            this.imageList1.Images.SetKeyName(13, "book3.png");
            this.imageList1.Images.SetKeyName(14, "book4.png");
            this.imageList1.Images.SetKeyName(15, "book5.png");
            this.imageList1.Images.SetKeyName(16, "book6.png");
            this.imageList1.Images.SetKeyName(17, "logout.png");
            this.imageList1.Images.SetKeyName(18, "home.png");
            // 
            // bookReservation_Tab
            // 
            this.bookReservation_Tab.ImageKey = "book5.png";
            this.bookReservation_Tab.Location = new System.Drawing.Point(4, 26);
            this.bookReservation_Tab.Name = "bookReservation_Tab";
            this.bookReservation_Tab.Size = new System.Drawing.Size(910, 523);
            this.bookReservation_Tab.TabIndex = 5;
            this.bookReservation_Tab.Text = "Book Reservation";
            this.bookReservation_Tab.UseVisualStyleBackColor = true;
            // 
            // bookReturning_Tab
            // 
            this.bookReturning_Tab.ImageKey = "book6.png";
            this.bookReturning_Tab.Location = new System.Drawing.Point(4, 26);
            this.bookReturning_Tab.Name = "bookReturning_Tab";
            this.bookReturning_Tab.Size = new System.Drawing.Size(910, 523);
            this.bookReturning_Tab.TabIndex = 4;
            this.bookReturning_Tab.Text = "Book Returning";
            this.bookReturning_Tab.UseVisualStyleBackColor = true;
            // 
            // bookBorrowing_Tab
            // 
            this.bookBorrowing_Tab.ImageKey = "book2.png";
            this.bookBorrowing_Tab.Location = new System.Drawing.Point(4, 26);
            this.bookBorrowing_Tab.Name = "bookBorrowing_Tab";
            this.bookBorrowing_Tab.Size = new System.Drawing.Size(910, 523);
            this.bookBorrowing_Tab.TabIndex = 3;
            this.bookBorrowing_Tab.Text = "Book Borrowing";
            this.bookBorrowing_Tab.UseVisualStyleBackColor = true;
            // 
            // borrowerList_Tab
            // 
            this.borrowerList_Tab.BackColor = System.Drawing.Color.White;
            this.borrowerList_Tab.Controls.Add(this.materialLabel1);
            this.borrowerList_Tab.ImageKey = "borrower1.png";
            this.borrowerList_Tab.Location = new System.Drawing.Point(4, 26);
            this.borrowerList_Tab.Name = "borrowerList_Tab";
            this.borrowerList_Tab.Size = new System.Drawing.Size(910, 523);
            this.borrowerList_Tab.TabIndex = 2;
            this.borrowerList_Tab.Text = "Borrower List";
            // 
            // bookList_Tab
            // 
            this.bookList_Tab.BackColor = System.Drawing.Color.White;
            this.bookList_Tab.Controls.Add(this.materialLabel2);
            this.bookList_Tab.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookList_Tab.ImageKey = "books.png";
            this.bookList_Tab.Location = new System.Drawing.Point(4, 26);
            this.bookList_Tab.Name = "bookList_Tab";
            this.bookList_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.bookList_Tab.Size = new System.Drawing.Size(910, 523);
            this.bookList_Tab.TabIndex = 1;
            this.bookList_Tab.Text = "Book List";
            // 
            // dashboard_Tab
            // 
            this.dashboard_Tab.BackColor = System.Drawing.Color.White;
            this.dashboard_Tab.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_Tab.ImageKey = "home.png";
            this.dashboard_Tab.Location = new System.Drawing.Point(4, 26);
            this.dashboard_Tab.Name = "dashboard_Tab";
            this.dashboard_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.dashboard_Tab.Size = new System.Drawing.Size(910, 523);
            this.dashboard_Tab.TabIndex = 0;
            this.dashboard_Tab.Text = "Dashboard";
            // 
            // home_MaterialTabControl
            // 
            this.home_MaterialTabControl.Controls.Add(this.dashboard_Tab);
            this.home_MaterialTabControl.Controls.Add(this.bookList_Tab);
            this.home_MaterialTabControl.Controls.Add(this.borrowerList_Tab);
            this.home_MaterialTabControl.Controls.Add(this.bookBorrowing_Tab);
            this.home_MaterialTabControl.Controls.Add(this.bookReturning_Tab);
            this.home_MaterialTabControl.Controls.Add(this.bookReservation_Tab);
            this.home_MaterialTabControl.Controls.Add(this.logout_Tab);
            this.home_MaterialTabControl.Depth = 0;
            this.home_MaterialTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_MaterialTabControl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_MaterialTabControl.ImageList = this.imageList1;
            this.home_MaterialTabControl.Location = new System.Drawing.Point(3, 64);
            this.home_MaterialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.home_MaterialTabControl.Multiline = true;
            this.home_MaterialTabControl.Name = "home_MaterialTabControl";
            this.home_MaterialTabControl.SelectedIndex = 0;
            this.home_MaterialTabControl.Size = new System.Drawing.Size(918, 553);
            this.home_MaterialTabControl.TabIndex = 0;
            this.home_MaterialTabControl.SelectedIndexChanged += new System.EventHandler(this.home_MaterialTabControl_SelectedIndexChanged);
            // 
            // logout_Tab
            // 
            this.logout_Tab.ImageKey = "logout.png";
            this.logout_Tab.Location = new System.Drawing.Point(4, 26);
            this.logout_Tab.Name = "logout_Tab";
            this.logout_Tab.Size = new System.Drawing.Size(910, 523);
            this.logout_Tab.TabIndex = 6;
            this.logout_Tab.Text = "Log Out";
            this.logout_Tab.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel1.Location = new System.Drawing.Point(29, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Book List";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel2.Location = new System.Drawing.Point(28, 26);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(67, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Book List";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 620);
            this.Controls.Add(this.home_MaterialTabControl);
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.home_MaterialTabControl;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEINKRAFTERS Library Management System";
            this.borrowerList_Tab.ResumeLayout(false);
            this.borrowerList_Tab.PerformLayout();
            this.bookList_Tab.ResumeLayout(false);
            this.bookList_Tab.PerformLayout();
            this.home_MaterialTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage bookReservation_Tab;
        private System.Windows.Forms.TabPage bookReturning_Tab;
        private System.Windows.Forms.TabPage bookBorrowing_Tab;
        private System.Windows.Forms.TabPage borrowerList_Tab;
        private System.Windows.Forms.TabPage bookList_Tab;
        private System.Windows.Forms.TabPage dashboard_Tab;
        private MaterialSkin.Controls.MaterialTabControl home_MaterialTabControl;
        private System.Windows.Forms.TabPage logout_Tab;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}

