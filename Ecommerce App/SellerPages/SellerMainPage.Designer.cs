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
            OverviewButton = new Button();
            LogoutButton = new Button();
            FinanceButton = new Button();
            ProductsButton = new Button();
            shopInformation = new ShopInformation();
            listProducts = new ListProducts();
            finance = new Finance();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
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
            splitContainer2.Panel1.Controls.Add(OverviewButton);
            splitContainer2.Panel1.Controls.Add(LogoutButton);
            splitContainer2.Panel1.Controls.Add(FinanceButton);
            splitContainer2.Panel1.Controls.Add(ProductsButton);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.AutoScroll = true;
            splitContainer2.Panel2.BackColor = SystemColors.Control;
            splitContainer2.Panel2.Controls.Add(shopInformation);
            splitContainer2.Panel2.Controls.Add(listProducts);
            splitContainer2.Panel2.Controls.Add(finance);
            splitContainer2.Size = new Size(800, 399);
            splitContainer2.SplitterDistance = 163;
            splitContainer2.TabIndex = 0;
            // 
            // OverviewButton
            // 
            OverviewButton.FlatAppearance.BorderSize = 0;
            OverviewButton.FlatStyle = FlatStyle.Flat;
            OverviewButton.Location = new Point(3, 113);
            OverviewButton.Name = "OverviewButton";
            OverviewButton.Size = new Size(157, 32);
            OverviewButton.TabIndex = 9;
            OverviewButton.Text = "Shop Information";
            OverviewButton.UseVisualStyleBackColor = true;
            OverviewButton.Click += OverviewButton_Click;
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
            LogoutButton.Click += LogoutButton_Click;
            // 
            // FinanceButton
            // 
            FinanceButton.FlatAppearance.BorderSize = 0;
            FinanceButton.FlatStyle = FlatStyle.Flat;
            FinanceButton.Location = new Point(3, 75);
            FinanceButton.Name = "FinanceButton";
            FinanceButton.Size = new Size(157, 32);
            FinanceButton.TabIndex = 2;
            FinanceButton.Text = "Finance";
            FinanceButton.UseVisualStyleBackColor = true;
            FinanceButton.Click += FinanceButton_Click;
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
            ProductsButton.Click += ProductsButton_Click;
            // 
            // shopInformation
            // 
            shopInformation.Location = new Point(13, 3);
            shopInformation.Name = "shopInformation";
            shopInformation.Size = new Size(598, 384);
            shopInformation.TabIndex = 2;
            // 
            // listProducts
            // 
            listProducts.BackColor = Color.White;
            listProducts.Location = new Point(13, 3);
            listProducts.Name = "listProducts";
            listProducts.Size = new Size(598, 384);
            listProducts.TabIndex = 1;
            // 
            // finance
            // 
            finance.Location = new Point(13, 3);
            finance.Name = "finance";
            finance.Size = new Size(608, 384);
            finance.TabIndex = 0;
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
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button LogoButton;
        private Label label1;
        private Button ProductsButton;
        private Button FinanceButton;
        private Button LogoutButton;
        private Button OverviewButton;
        private Button button1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private Finance finance;
        private ListProducts listProducts;
        private ShopInformation shopInformation;
    }
}