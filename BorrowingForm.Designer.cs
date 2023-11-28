namespace LibrarySystem
{
    partial class BorrowingForm
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
            this.tb_Form_BorrowerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Borrower_NumberOfBooks = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Borrower_BorrowerType = new System.Windows.Forms.ComboBox();
            this.panel_Form_BorrowerName = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_Borrower_DueDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_Borrower_BookListCheckBox = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_Form_BorrowerName.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_Borrower_BookListCheckBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Form_BorrowerName
            // 
            this.tb_Form_BorrowerName.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.tb_Form_BorrowerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tb_Form_BorrowerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_Form_BorrowerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Form_BorrowerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Form_BorrowerName.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Form_BorrowerName.Location = new System.Drawing.Point(4, 4);
            this.tb_Form_BorrowerName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_Form_BorrowerName.Name = "tb_Form_BorrowerName";
            this.tb_Form_BorrowerName.Size = new System.Drawing.Size(352, 27);
            this.tb_Form_BorrowerName.TabIndex = 1;
            this.tb_Form_BorrowerName.TextChanged += new System.EventHandler(this.tb_Form_BorrowerName_TextChanged);
            this.tb_Form_BorrowerName.Leave += new System.EventHandler(this.checkIfExist);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "BORROWER NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "NUMBER OF BOOKS";
            // 
            // cb_Borrower_NumberOfBooks
            // 
            this.cb_Borrower_NumberOfBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Borrower_NumberOfBooks.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Borrower_NumberOfBooks.FormatString = " Books";
            this.cb_Borrower_NumberOfBooks.FormattingEnabled = true;
            this.cb_Borrower_NumberOfBooks.Location = new System.Drawing.Point(8, 310);
            this.cb_Borrower_NumberOfBooks.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_Borrower_NumberOfBooks.Name = "cb_Borrower_NumberOfBooks";
            this.cb_Borrower_NumberOfBooks.Size = new System.Drawing.Size(78, 35);
            this.cb_Borrower_NumberOfBooks.TabIndex = 4;
            this.cb_Borrower_NumberOfBooks.SelectedIndexChanged += new System.EventHandler(this.cb_Borrower_NumberOfBooks_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(652, -19);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 87);
            this.button1.TabIndex = 5;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "BORROWER TYPE";
            // 
            // cb_Borrower_BorrowerType
            // 
            this.cb_Borrower_BorrowerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Borrower_BorrowerType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Borrower_BorrowerType.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Borrower_BorrowerType.FormatString = " Books";
            this.cb_Borrower_BorrowerType.FormattingEnabled = true;
            this.cb_Borrower_BorrowerType.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.cb_Borrower_BorrowerType.Location = new System.Drawing.Point(6, 37);
            this.cb_Borrower_BorrowerType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_Borrower_BorrowerType.Name = "cb_Borrower_BorrowerType";
            this.cb_Borrower_BorrowerType.Size = new System.Drawing.Size(360, 35);
            this.cb_Borrower_BorrowerType.TabIndex = 7;
            this.cb_Borrower_BorrowerType.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // panel_Form_BorrowerName
            // 
            this.panel_Form_BorrowerName.BackColor = System.Drawing.Color.White;
            this.panel_Form_BorrowerName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Form_BorrowerName.Controls.Add(this.tb_Form_BorrowerName);
            this.panel_Form_BorrowerName.Location = new System.Drawing.Point(6, 123);
            this.panel_Form_BorrowerName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel_Form_BorrowerName.Name = "panel_Form_BorrowerName";
            this.panel_Form_BorrowerName.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_Form_BorrowerName.Size = new System.Drawing.Size(360, 37);
            this.panel_Form_BorrowerName.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel_Borrower_BookListCheckBox);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtp_Borrower_DueDate);
            this.panel1.Controls.Add(this.cb_Borrower_NumberOfBooks);
            this.panel1.Controls.Add(this.panel_Form_BorrowerName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_Borrower_BorrowerType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(57, 158);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 650);
            this.panel1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 219);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(154, 31);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(202, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "DUE DATE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "DATE BORROWED";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtp_Borrower_DueDate
            // 
            this.dtp_Borrower_DueDate.CalendarFont = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Borrower_DueDate.Checked = false;
            this.dtp_Borrower_DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Borrower_DueDate.Location = new System.Drawing.Point(208, 219);
            this.dtp_Borrower_DueDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtp_Borrower_DueDate.Name = "dtp_Borrower_DueDate";
            this.dtp_Borrower_DueDate.Size = new System.Drawing.Size(152, 31);
            this.dtp_Borrower_DueDate.TabIndex = 9;
            this.dtp_Borrower_DueDate.Value = new System.DateTime(2023, 12, 2, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(238, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "BOOK BORROWING";
            // 
            // panel_Borrower_BookListCheckBox
            // 
            this.panel_Borrower_BookListCheckBox.Controls.Add(this.checkBox6);
            this.panel_Borrower_BookListCheckBox.Controls.Add(this.checkBox7);
            this.panel_Borrower_BookListCheckBox.Controls.Add(this.checkBox8);
            this.panel_Borrower_BookListCheckBox.Controls.Add(this.checkBox9);
            this.panel_Borrower_BookListCheckBox.Controls.Add(this.checkBox10);
            this.panel_Borrower_BookListCheckBox.Controls.Add(this.checkBox5);
            this.panel_Borrower_BookListCheckBox.Controls.Add(this.checkBox4);
            this.panel_Borrower_BookListCheckBox.Controls.Add(this.checkBox3);
            this.panel_Borrower_BookListCheckBox.Controls.Add(this.checkBox2);
            this.panel_Borrower_BookListCheckBox.Controls.Add(this.checkBox1);
            this.panel_Borrower_BookListCheckBox.Enabled = false;
            this.panel_Borrower_BookListCheckBox.Location = new System.Drawing.Point(6, 357);
            this.panel_Borrower_BookListCheckBox.Name = "panel_Borrower_BookListCheckBox";
            this.panel_Borrower_BookListCheckBox.Size = new System.Drawing.Size(587, 209);
            this.panel_Borrower_BookListCheckBox.TabIndex = 13;
            this.panel_Borrower_BookListCheckBox.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox1.Location = new System.Drawing.Point(4, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 29);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Berenice";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBoxLimiter);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox2.Location = new System.Drawing.Point(4, 45);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(117, 29);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Dracula";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBoxLimiter);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox3.Location = new System.Drawing.Point(4, 80);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(144, 29);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "In A Grove";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBoxLimiter);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox4.Location = new System.Drawing.Point(4, 115);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(202, 29);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "The Demon Spell";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBoxLimiter);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox5.Location = new System.Drawing.Point(4, 151);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(203, 29);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "The Yellow Paper";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBoxLimiter);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox6.Location = new System.Drawing.Point(232, 151);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(343, 29);
            this.checkBox6.TabIndex = 9;
            this.checkBox6.Text = "The Worst Journey In The World";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBoxLimiter);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox7.Location = new System.Drawing.Point(232, 115);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(293, 29);
            this.checkBox7.TabIndex = 8;
            this.checkBox7.Text = "Memoir Of Queen Adelaide";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBoxLimiter);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox8.Location = new System.Drawing.Point(232, 80);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(188, 29);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "My Own Affairs";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBoxLimiter);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox9.Location = new System.Drawing.Point(232, 45);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(214, 29);
            this.checkBox9.TabIndex = 6;
            this.checkBox9.Text = "The Golden Bough";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBoxLimiter);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox10.Location = new System.Drawing.Point(232, 10);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(317, 29);
            this.checkBox10.TabIndex = 5;
            this.checkBox10.Text = "Royal Girls And Royal Courts";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBoxLimiter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(67)))), ((int)(((byte)(72)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(228, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 60);
            this.button2.TabIndex = 14;
            this.button2.Text = "Borrow";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BorrowingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BackgroundImage = global::LibrarySystem.Properties.Resources.Borrowing_Book_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 823);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "BorrowingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowingForm";
            this.panel_Form_BorrowerName.ResumeLayout(false);
            this.panel_Form_BorrowerName.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Borrower_BookListCheckBox.ResumeLayout(false);
            this.panel_Borrower_BookListCheckBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Form_BorrowerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Borrower_NumberOfBooks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Borrower_BorrowerType;
        private System.Windows.Forms.Panel panel_Form_BorrowerName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_Borrower_DueDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_Borrower_BookListCheckBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.Button button2;
    }
}