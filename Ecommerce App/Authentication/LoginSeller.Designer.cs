namespace Ecommerce_App
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSeller));
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            LoginButton = new Button();
            PasswordTextBox = new TextBox();
            EmailTextBox = new TextBox();
            PasswordLabel = new Label();
            email = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
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
            LoginButton.Location = new Point(155, 286);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(144, 44);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(16, 209);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(392, 38);
            PasswordTextBox.TabIndex = 4;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTextBox.Location = new Point(16, 119);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(392, 38);
            EmailTextBox.TabIndex = 3;
            EmailTextBox.TextChanged += textBox1_TextChanged;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLabel.ForeColor = Color.White;
            PasswordLabel.Location = new Point(16, 175);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(120, 31);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password:";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            email.ForeColor = Color.White;
            email.Location = new Point(16, 85);
            email.Name = "email";
            email.Size = new Size(79, 31);
            email.TabIndex = 1;
            email.Text = "Email:";
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
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox EmailTextBox;
        private Label PasswordLabel;
        private Label email;
        private TextBox PasswordTextBox;
        private Button LoginButton;
    }
}