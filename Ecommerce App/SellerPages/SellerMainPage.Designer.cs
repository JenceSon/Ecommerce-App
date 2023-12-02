namespace Ecommerce_App.SellerPages
{
    partial class SellerMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerMainPage));
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            LogoButton = new Button();
            splitContainer2 = new SplitContainer();
            LogoutButton = new Button();
            FinanceButton = new Button();
            AddProductButton = new Button();
            ProductsButton = new Button();
            panel3 = new Panel();
            TopSalesLabel = new Label();
            label4 = new Label();
            panel2 = new Panel();
            PendingOrderNumberLabel = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(LogoButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 47;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(128, 13);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 1;
            label1.Text = "Seller Centre";
            // 
            // LogoButton
            // 
            LogoButton.BackColor = Color.White;
            LogoButton.Cursor = Cursors.Hand;
            LogoButton.FlatAppearance.BorderColor = Color.White;
            LogoButton.FlatAppearance.BorderSize = 0;
            LogoButton.FlatStyle = FlatStyle.Flat;
            LogoButton.Image = (Image)resources.GetObject("LogoButton.Image");
            LogoButton.Location = new Point(12, 6);
            LogoButton.Margin = new Padding(0);
            LogoButton.Name = "LogoButton";
            LogoButton.Size = new Size(113, 35);
            LogoButton.TabIndex = 0;
            LogoButton.TextImageRelation = TextImageRelation.ImageAboveText;
            LogoButton.UseVisualStyleBackColor = false;
            LogoButton.MouseEnter += LogoButton_MouseEnter;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.White;
            splitContainer2.Panel1.Controls.Add(LogoutButton);
            splitContainer2.Panel1.Controls.Add(FinanceButton);
            splitContainer2.Panel1.Controls.Add(AddProductButton);
            splitContainer2.Panel1.Controls.Add(ProductsButton);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.AutoScroll = true;
            splitContainer2.Panel2.BackColor = SystemColors.Control;
            splitContainer2.Panel2.Controls.Add(panel3);
            splitContainer2.Panel2.Controls.Add(panel2);
            splitContainer2.Panel2.Controls.Add(panel1);
            splitContainer2.Size = new Size(800, 399);
            splitContainer2.SplitterDistance = 163;
            splitContainer2.TabIndex = 0;
            // 
            // LogoutButton
            // 
            LogoutButton.Image = (Image)resources.GetObject("LogoutButton.Image");
            LogoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutButton.Location = new Point(0, 346);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(160, 32);
            LogoutButton.TabIndex = 8;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            // 
            // FinanceButton
            // 
            FinanceButton.FlatAppearance.BorderSize = 0;
            FinanceButton.FlatStyle = FlatStyle.Flat;
            FinanceButton.Location = new Point(3, 113);
            FinanceButton.Name = "FinanceButton";
            FinanceButton.Size = new Size(157, 32);
            FinanceButton.TabIndex = 2;
            FinanceButton.Text = "Finance";
            FinanceButton.UseVisualStyleBackColor = true;
            // 
            // AddProductButton
            // 
            AddProductButton.FlatAppearance.BorderSize = 0;
            AddProductButton.FlatStyle = FlatStyle.Flat;
            AddProductButton.Location = new Point(3, 75);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(157, 32);
            AddProductButton.TabIndex = 1;
            AddProductButton.Text = "Add New Products";
            AddProductButton.UseVisualStyleBackColor = true;
            // 
            // ProductsButton
            // 
            ProductsButton.FlatAppearance.BorderSize = 0;
            ProductsButton.FlatStyle = FlatStyle.Flat;
            ProductsButton.Location = new Point(3, 37);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Size = new Size(157, 32);
            ProductsButton.TabIndex = 0;
            ProductsButton.Text = "My Products";
            ProductsButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(TopSalesLabel);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(325, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(296, 303);
            panel3.TabIndex = 6;
            // 
            // TopSalesLabel
            // 
            TopSalesLabel.AutoSize = true;
            TopSalesLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            TopSalesLabel.Location = new Point(127, 130);
            TopSalesLabel.Name = "TopSalesLabel";
            TopSalesLabel.Size = new Size(48, 46);
            TopSalesLabel.TabIndex = 2;
            TopSalesLabel.Text = "--";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 12);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 1;
            label4.Text = "Top Sales (last 7 days)";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(PendingOrderNumberLabel);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(23, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 303);
            panel2.TabIndex = 5;
            // 
            // PendingOrderNumberLabel
            // 
            PendingOrderNumberLabel.AutoSize = true;
            PendingOrderNumberLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            PendingOrderNumberLabel.Location = new Point(124, 130);
            PendingOrderNumberLabel.Name = "PendingOrderNumberLabel";
            PendingOrderNumberLabel.Size = new Size(40, 46);
            PendingOrderNumberLabel.TabIndex = 1;
            PendingOrderNumberLabel.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 12);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 0;
            label3.Text = "Pending Order";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(23, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 48);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 10);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 0;
            label2.Text = "Overview";
            // 
            // SellerMainPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            Name = "SellerMainPage";
            ShowIcon = false;
            Text = "Shopee";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button LogoButton;
        private Label label1;
        private Button ProductsButton;
        private Button FinanceButton;
        private Button AddProductButton;
        private Panel panel1;
        private Label label2;
        private Button LogoutButton;
        private Panel panel3;
        private Label label4;
        private Panel panel2;
        private Label label3;
        private Label PendingOrderNumberLabel;
        private Label TopSalesLabel;
    }
}