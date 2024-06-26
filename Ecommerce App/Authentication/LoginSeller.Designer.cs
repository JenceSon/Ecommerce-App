﻿namespace Ecommerce_App
{
    partial class LoginSeller
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSeller));
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            LoginButton = new Button();
            PasswordTextBox = new TextBox();
            EmailTextBox = new TextBox();
            PasswordLabel = new Label();
            email = new Label();
            label1 = new Label();
            CloseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.OrangeRed;
            splitContainer1.Panel2.Controls.Add(CloseButton);
            splitContainer1.Panel2.Controls.Add(LoginButton);
            splitContainer1.Panel2.Controls.Add(PasswordTextBox);
            splitContainer1.Panel2.Controls.Add(EmailTextBox);
            splitContainer1.Panel2.Controls.Add(PasswordLabel);
            splitContainer1.Panel2.Controls.Add(email);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 331;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(59, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Snow;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.FlatStyle = FlatStyle.Popup;
            LoginButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.ForeColor = Color.OrangeRed;
            LoginButton.Location = new Point(140, 280);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(144, 44);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.ForeColor = Color.LightGray;
            PasswordTextBox.Location = new Point(16, 209);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(392, 38);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.Text = "Enter your password";
            PasswordTextBox.Enter += PwdTextBox_Enter;
            PasswordTextBox.Leave += PwdTextBox_Leave;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTextBox.ForeColor = Color.LightGray;
            EmailTextBox.Location = new Point(16, 119);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(392, 38);
            EmailTextBox.TabIndex = 3;
            EmailTextBox.Text = "Enter your email or username";
            EmailTextBox.Enter += EmailTextBox_Enter;
            EmailTextBox.Leave += EmailTextBox_Leave;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            PasswordLabel.ForeColor = Color.White;
            PasswordLabel.Location = new Point(16, 175);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(122, 31);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password:";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            email.ForeColor = Color.White;
            email.Location = new Point(16, 85);
            email.Name = "email";
            email.Size = new Size(224, 31);
            email.TabIndex = 1;
            email.Text = "Email or Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(310, 41);
            label1.TabIndex = 0;
            label1.Text = "Shopee Seller Centre";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Snow;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatStyle = FlatStyle.Popup;
            CloseButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            CloseButton.ForeColor = Color.OrangeRed;
            CloseButton.Location = new Point(140, 353);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(144, 44);
            CloseButton.TabIndex = 6;
            CloseButton.Text = "Exist";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // LoginSeller
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginSeller";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox EmailTextBox;
        private Label PasswordLabel;
        private Label email;
        private TextBox PasswordTextBox;
        private Button LoginButton;
        private Button CloseButton;
    }
}