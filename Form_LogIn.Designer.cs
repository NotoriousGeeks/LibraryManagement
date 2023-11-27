﻿namespace LibrarySystem
{
    partial class Form_LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.login_Btn = new MaterialSkin.Controls.MaterialButton();
            this.userName_Tb = new System.Windows.Forms.TextBox();
            this.password_Tb = new System.Windows.Forms.TextBox();
            this.close_Btn = new System.Windows.Forms.Button();
            this.logInErrorMessage_Label = new System.Windows.Forms.Label();
            this.hidePassword_Pb = new System.Windows.Forms.PictureBox();
            this.showPassword_Pb = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hidePassword_Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassword_Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(214, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Administrator Log In";
            // 
            // login_Btn
            // 
            this.login_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.login_Btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.login_Btn.Depth = 0;
            this.login_Btn.FlatAppearance.BorderSize = 0;
            this.login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_Btn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Btn.ForeColor = System.Drawing.Color.White;
            this.login_Btn.HighEmphasis = true;
            this.login_Btn.Icon = null;
            this.login_Btn.Location = new System.Drawing.Point(312, 633);
            this.login_Btn.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.login_Btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_Btn.Name = "login_Btn";
            this.login_Btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.login_Btn.Size = new System.Drawing.Size(68, 36);
            this.login_Btn.TabIndex = 6;
            this.login_Btn.Text = "Log In";
            this.login_Btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.login_Btn.UseAccentColor = false;
            this.login_Btn.UseVisualStyleBackColor = false;
            this.login_Btn.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // userName_Tb
            // 
            this.userName_Tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.userName_Tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userName_Tb.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_Tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userName_Tb.Location = new System.Drawing.Point(214, 428);
            this.userName_Tb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.userName_Tb.Name = "userName_Tb";
            this.userName_Tb.Size = new System.Drawing.Size(368, 33);
            this.userName_Tb.TabIndex = 7;
            this.userName_Tb.Click += new System.EventHandler(this.ClearOnClicked);
            this.userName_Tb.TabStopChanged += new System.EventHandler(this.ClearOnClicked);
            // 
            // password_Tb
            // 
            this.password_Tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.password_Tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_Tb.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_Tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.password_Tb.Location = new System.Drawing.Point(214, 550);
            this.password_Tb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.password_Tb.Name = "password_Tb";
            this.password_Tb.Size = new System.Drawing.Size(368, 33);
            this.password_Tb.TabIndex = 8;
            this.password_Tb.UseSystemPasswordChar = true;
            this.password_Tb.Click += new System.EventHandler(this.ClearOnClicked);
            this.password_Tb.TabStopChanged += new System.EventHandler(this.ClearOnClicked);
            // 
            // close_Btn
            // 
            this.close_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.close_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_Btn.FlatAppearance.BorderSize = 0;
            this.close_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_Btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_Btn.ForeColor = System.Drawing.Color.White;
            this.close_Btn.Location = new System.Drawing.Point(1272, -4);
            this.close_Btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.close_Btn.Name = "close_Btn";
            this.close_Btn.Size = new System.Drawing.Size(60, 65);
            this.close_Btn.TabIndex = 12;
            this.close_Btn.TabStop = false;
            this.close_Btn.Text = "x";
            this.close_Btn.UseVisualStyleBackColor = false;
            this.close_Btn.Click += new System.EventHandler(this.close_Btn_Click);
            // 
            // logInErrorMessage_Label
            // 
            this.logInErrorMessage_Label.AutoSize = true;
            this.logInErrorMessage_Label.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInErrorMessage_Label.ForeColor = System.Drawing.Color.Red;
            this.logInErrorMessage_Label.Location = new System.Drawing.Point(120, 342);
            this.logInErrorMessage_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.logInErrorMessage_Label.Name = "logInErrorMessage_Label";
            this.logInErrorMessage_Label.Size = new System.Drawing.Size(508, 25);
            this.logInErrorMessage_Label.TabIndex = 13;
            this.logInErrorMessage_Label.Text = "Invalid username/ password! Please try again.";
            this.logInErrorMessage_Label.Visible = false;
            // 
            // hidePassword_Pb
            // 
            this.hidePassword_Pb.Image = ((System.Drawing.Image)(resources.GetObject("hidePassword_Pb.Image")));
            this.hidePassword_Pb.Location = new System.Drawing.Point(620, 535);
            this.hidePassword_Pb.Margin = new System.Windows.Forms.Padding(6);
            this.hidePassword_Pb.Name = "hidePassword_Pb";
            this.hidePassword_Pb.Size = new System.Drawing.Size(50, 48);
            this.hidePassword_Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hidePassword_Pb.TabIndex = 15;
            this.hidePassword_Pb.TabStop = false;
            this.hidePassword_Pb.Visible = false;
            this.hidePassword_Pb.Click += new System.EventHandler(this.hidePassword_Pb_Click);
            // 
            // showPassword_Pb
            // 
            this.showPassword_Pb.Image = ((System.Drawing.Image)(resources.GetObject("showPassword_Pb.Image")));
            this.showPassword_Pb.Location = new System.Drawing.Point(620, 535);
            this.showPassword_Pb.Margin = new System.Windows.Forms.Padding(6);
            this.showPassword_Pb.Name = "showPassword_Pb";
            this.showPassword_Pb.Size = new System.Drawing.Size(50, 48);
            this.showPassword_Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPassword_Pb.TabIndex = 14;
            this.showPassword_Pb.TabStop = false;
            this.showPassword_Pb.Click += new System.EventHandler(this.showPassword_Pb_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(152, 535);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(152, 413);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(142, 515);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(466, 88);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(142, 392);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(466, 88);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(274, 102);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-256, -192);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1590, 1215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(214, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 1);
            this.label2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(214, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 1);
            this.label3.TabIndex = 17;
            // 
            // Form_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 804);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hidePassword_Pb);
            this.Controls.Add(this.showPassword_Pb);
            this.Controls.Add(this.logInErrorMessage_Label);
            this.Controls.Add(this.close_Btn);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.password_Tb);
            this.Controls.Add(this.userName_Tb);
            this.Controls.Add(this.login_Btn);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form_LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.hidePassword_Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassword_Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialButton login_Btn;
        private System.Windows.Forms.TextBox userName_Tb;
        private System.Windows.Forms.TextBox password_Tb;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button close_Btn;
        private System.Windows.Forms.Label logInErrorMessage_Label;
        private System.Windows.Forms.PictureBox showPassword_Pb;
        private System.Windows.Forms.PictureBox hidePassword_Pb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}