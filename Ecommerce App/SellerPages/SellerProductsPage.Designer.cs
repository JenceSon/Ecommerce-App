namespace Ecommerce_App.SellerPages
{
    partial class SellerProductsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerProductsPage));
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            LogoButton = new Button();
            splitContainer2 = new SplitContainer();
            LogoutButton = new Button();
            FinanceButton = new Button();
            AddProductButton = new Button();
            ProductsButton = new Button();
            panel2 = new Panel();
            PageLabel = new Label();
            ToAfterButton = new Button();
            ToBeforeButton = new Button();
            AddProductButton2 = new Button();
            dataGridView1 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            variation = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            edit = new DataGridViewImageColumn();
            delete = new DataGridViewImageColumn();
            label2 = new Label();
            panel1 = new Panel();
            ResetButton = new Button();
            SearchButton = new Button();
            textBox1 = new TextBox();
            CategoryLabel = new Label();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            splitContainer1.SplitterDistance = 52;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(128, 13);
            label1.Name = "label1";
            label1.Size = new Size(128, 28);
            label1.TabIndex = 2;
            label1.Text = "My Products";
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
            LogoButton.TabIndex = 1;
            LogoButton.TextImageRelation = TextImageRelation.ImageAboveText;
            LogoButton.UseVisualStyleBackColor = false;
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
            splitContainer2.Panel2.Controls.Add(panel2);
            splitContainer2.Panel2.Controls.Add(panel1);
            splitContainer2.Size = new Size(800, 394);
            splitContainer2.SplitterDistance = 161;
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
            FinanceButton.TabIndex = 3;
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
            AddProductButton.TabIndex = 2;
            AddProductButton.Text = "Add New Products";
            AddProductButton.UseVisualStyleBackColor = true;
            // 
            // ProductsButton
            // 
            ProductsButton.FlatAppearance.BorderSize = 0;
            ProductsButton.FlatStyle = FlatStyle.Flat;
            ProductsButton.ForeColor = Color.OrangeRed;
            ProductsButton.Location = new Point(3, 37);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Size = new Size(157, 32);
            ProductsButton.TabIndex = 1;
            ProductsButton.Text = "My Products";
            ProductsButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(PageLabel);
            panel2.Controls.Add(ToAfterButton);
            panel2.Controls.Add(ToBeforeButton);
            panel2.Controls.Add(AddProductButton2);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(23, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(588, 282);
            panel2.TabIndex = 2;
            // 
            // PageLabel
            // 
            PageLabel.AutoSize = true;
            PageLabel.Location = new Point(513, 253);
            PageLabel.Name = "PageLabel";
            PageLabel.Size = new Size(17, 20);
            PageLabel.TabIndex = 8;
            PageLabel.Text = "1";
            // 
            // ToAfterButton
            // 
            ToAfterButton.Location = new Point(541, 248);
            ToAfterButton.Name = "ToAfterButton";
            ToAfterButton.Size = new Size(30, 30);
            ToAfterButton.TabIndex = 7;
            ToAfterButton.Text = ">";
            ToAfterButton.UseVisualStyleBackColor = true;
            // 
            // ToBeforeButton
            // 
            ToBeforeButton.BackColor = SystemColors.ControlLight;
            ToBeforeButton.Location = new Point(473, 248);
            ToBeforeButton.Name = "ToBeforeButton";
            ToBeforeButton.Size = new Size(30, 30);
            ToBeforeButton.TabIndex = 6;
            ToBeforeButton.Text = "<";
            ToBeforeButton.UseVisualStyleBackColor = false;
            // 
            // AddProductButton2
            // 
            AddProductButton2.BackColor = Color.OrangeRed;
            AddProductButton2.FlatStyle = FlatStyle.Popup;
            AddProductButton2.ForeColor = Color.White;
            AddProductButton2.Location = new Point(458, 14);
            AddProductButton2.Name = "AddProductButton2";
            AddProductButton2.Size = new Size(113, 29);
            AddProductButton2.TabIndex = 5;
            AddProductButton2.Text = "Add Product";
            AddProductButton2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, variation, price, amount, edit, delete });
            dataGridView1.Location = new Point(11, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(560, 189);
            dataGridView1.TabIndex = 2;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 15);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 1;
            label2.Text = "Products";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ResetButton);
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(CategoryLabel);
            panel1.Controls.Add(NameTextBox);
            panel1.Controls.Add(NameLabel);
            panel1.Location = new Point(23, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 104);
            panel1.TabIndex = 1;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = SystemColors.ControlLight;
            ResetButton.FlatStyle = FlatStyle.Popup;
            ResetButton.ForeColor = Color.Black;
            ResetButton.Location = new Point(124, 60);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(81, 29);
            ResetButton.TabIndex = 5;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = false;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.OrangeRed;
            SearchButton.FlatStyle = FlatStyle.Popup;
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(27, 60);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(81, 29);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(397, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 27);
            textBox1.TabIndex = 3;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(322, 20);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(69, 20);
            CategoryLabel.TabIndex = 2;
            CategoryLabel.Text = "Category";
            CategoryLabel.Click += CategoryLabel_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(114, 17);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(174, 27);
            NameTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(4, 20);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(104, 20);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Product Name";
            // 
            // SellerProductsPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            Name = "SellerProductsPage";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Show;
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button AddProductButton;
        private Button FinanceButton;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private Label CategoryLabel;
        private TextBox NameTextBox;
        private Label NameLabel;
        private Button ResetButton;
        private Button SearchButton;
        private Label label2;
        private Button AddProductButton2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn variation;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn delete;
        private Label PageLabel;
        private Button ToAfterButton;
        private Button ToBeforeButton;
        private Button LogoutButton;
    }
}