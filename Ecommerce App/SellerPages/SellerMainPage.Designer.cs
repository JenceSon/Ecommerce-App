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
            Finance = new Panel();
            panel3 = new Panel();
            TotalRevenue = new Label();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            panel2 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            SearchButton = new Button();
            EndDateLabel = new Label();
            StartDateLabel = new Label();
            ShopInformation = new Panel();
            label2 = new Label();
            ShopName = new Label();
            ListProducts = new Panel();
            SeeMore = new Button();
            dataGridView1 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            variation = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            edit = new DataGridViewImageColumn();
            delete = new DataGridViewImageColumn();
            label5 = new Label();
            id = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            Finance.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            ShopInformation.SuspendLayout();
            ListProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            splitContainer2.Panel2.Controls.Add(Finance);
            splitContainer2.Panel2.Controls.Add(ShopInformation);
            splitContainer2.Panel2.Controls.Add(ListProducts);
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
            // Finance
            // 
            Finance.BackColor = Color.White;
            Finance.Controls.Add(panel3);
            Finance.Controls.Add(panel2);
            Finance.Location = new Point(13, 3);
            Finance.Name = "Finance";
            Finance.Size = new Size(598, 384);
            Finance.TabIndex = 8;
            Finance.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(TotalRevenue);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dataGridView2);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(11, 114);
            panel3.Name = "panel3";
            panel3.Size = new Size(571, 267);
            panel3.TabIndex = 4;
            // 
            // TotalRevenue
            // 
            TotalRevenue.AutoSize = true;
            TotalRevenue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TotalRevenue.Location = new Point(105, 15);
            TotalRevenue.Name = "TotalRevenue";
            TotalRevenue.Size = new Size(39, 28);
            TotalRevenue.TabIndex = 10;
            TotalRevenue.Text = "0.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 22);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 9;
            label3.Text = "VND";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { id, total });
            dataGridView2.Location = new Point(11, 56);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(560, 189);
            dataGridView2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(11, 22);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 1;
            label4.Text = "Total:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(SearchButton);
            panel2.Controls.Add(EndDateLabel);
            panel2.Controls.Add(StartDateLabel);
            panel2.Location = new Point(11, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(571, 104);
            panel2.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(125, 57);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(125, 15);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.OrangeRed;
            SearchButton.FlatStyle = FlatStyle.Popup;
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(484, 58);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(81, 29);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            // 
            // EndDateLabel
            // 
            EndDateLabel.AutoSize = true;
            EndDateLabel.Location = new Point(39, 62);
            EndDateLabel.Name = "EndDateLabel";
            EndDateLabel.Size = new Size(73, 20);
            EndDateLabel.TabIndex = 2;
            EndDateLabel.Text = "End Date:";
            // 
            // StartDateLabel
            // 
            StartDateLabel.AutoSize = true;
            StartDateLabel.Location = new Point(33, 20);
            StartDateLabel.Name = "StartDateLabel";
            StartDateLabel.Size = new Size(79, 20);
            StartDateLabel.TabIndex = 0;
            StartDateLabel.Text = "Start Date:";
            // 
            // ShopInformation
            // 
            ShopInformation.BackColor = Color.White;
            ShopInformation.Controls.Add(label2);
            ShopInformation.Controls.Add(ShopName);
            ShopInformation.Location = new Point(13, 3);
            ShopInformation.Name = "ShopInformation";
            ShopInformation.Size = new Size(598, 384);
            ShopInformation.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 78);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // ShopName
            // 
            ShopName.AutoSize = true;
            ShopName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ShopName.Location = new Point(250, 11);
            ShopName.Name = "ShopName";
            ShopName.Size = new Size(93, 28);
            ShopName.TabIndex = 1;
            ShopName.Text = "Hahahah";
            // 
            // ListProducts
            // 
            ListProducts.BackColor = Color.White;
            ListProducts.Controls.Add(SeeMore);
            ListProducts.Controls.Add(dataGridView1);
            ListProducts.Controls.Add(label5);
            ListProducts.Location = new Point(13, 3);
            ListProducts.Name = "ListProducts";
            ListProducts.Size = new Size(598, 384);
            ListProducts.TabIndex = 3;
            ListProducts.Visible = false;
            // 
            // SeeMore
            // 
            SeeMore.BackColor = Color.OrangeRed;
            SeeMore.FlatStyle = FlatStyle.Popup;
            SeeMore.ForeColor = Color.White;
            SeeMore.Location = new Point(465, 14);
            SeeMore.Name = "SeeMore";
            SeeMore.Size = new Size(113, 29);
            SeeMore.TabIndex = 6;
            SeeMore.Text = "See more...";
            SeeMore.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, variation, price, amount, edit, delete });
            dataGridView1.Location = new Point(3, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(592, 325);
            dataGridView1.TabIndex = 2;
            dataGridView1.Visible = false;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Product Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // variation
            // 
            variation.HeaderText = "Variations";
            variation.MinimumWidth = 6;
            variation.Name = "variation";
            variation.ReadOnly = true;
            variation.Width = 125;
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.ReadOnly = true;
            price.Width = 70;
            // 
            // amount
            // 
            amount.HeaderText = "Amount";
            amount.MinimumWidth = 6;
            amount.Name = "amount";
            amount.ReadOnly = true;
            amount.Width = 70;
            // 
            // edit
            // 
            edit.HeaderText = "";
            edit.Image = (Image)resources.GetObject("edit.Image");
            edit.MinimumWidth = 6;
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Width = 30;
            // 
            // delete
            // 
            delete.HeaderText = "";
            delete.Image = (Image)resources.GetObject("delete.Image");
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Width = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(11, 15);
            label5.Name = "label5";
            label5.Size = new Size(92, 28);
            label5.TabIndex = 1;
            label5.Text = "Products";
            // 
            // id
            // 
            id.HeaderText = "Product";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 250;
            // 
            // total
            // 
            total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            total.HeaderText = "Total";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.ReadOnly = true;
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
            Finance.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ShopInformation.ResumeLayout(false);
            ShopInformation.PerformLayout();
            ListProducts.ResumeLayout(false);
            ListProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Panel ShopInformation;
        private Button button1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private Label ShopName;
        private Panel ListProducts;
        private Button SeeMore;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn variation;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn delete;
        private Label label5;
        private Label label2;
        private Panel Finance;
        private Panel panel2;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button SearchButton;
        private Label EndDateLabel;
        private Label StartDateLabel;
        private Panel panel3;
        private Label TotalRevenue;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn total;
    }
}