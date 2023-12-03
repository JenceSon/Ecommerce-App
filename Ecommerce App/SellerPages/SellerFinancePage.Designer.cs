namespace Ecommerce_App.SellerPages
{
    partial class SellerFinancePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerFinancePage));
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            LogoButton = new Button();
            splitContainer2 = new SplitContainer();
            LogoutButton = new Button();
            FinanceButton = new Button();
            AddProductButton = new Button();
            ProductsButton = new Button();
            panel2 = new Panel();
            TotalRevenue = new Label();
            label3 = new Label();
            PageLabel = new Label();
            ToAfterButton = new Button();
            ToBeforeButton = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            panel1 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            SearchButton = new Button();
            EndDateLabel = new Label();
            StartDateLabel = new Label();
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
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1096, 450);
            splitContainer1.SplitterDistance = 52;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(128, 13);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 3;
            label1.Text = "Finance";
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
            LogoButton.TabIndex = 2;
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
            splitContainer2.Panel1.Paint += splitContainer2_Panel1_Paint;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(panel2);
            splitContainer2.Panel2.Controls.Add(panel1);
            splitContainer2.Size = new Size(1096, 394);
            splitContainer2.SplitterDistance = 180;
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
            FinanceButton.ForeColor = Color.OrangeRed;
            FinanceButton.Location = new Point(3, 113);
            FinanceButton.Name = "FinanceButton";
            FinanceButton.Size = new Size(157, 32);
            FinanceButton.TabIndex = 5;
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
            AddProductButton.TabIndex = 4;
            AddProductButton.Text = "Add New Products";
            AddProductButton.UseVisualStyleBackColor = true;
            // 
            // ProductsButton
            // 
            ProductsButton.FlatAppearance.BorderSize = 0;
            ProductsButton.FlatStyle = FlatStyle.Flat;
            ProductsButton.ForeColor = SystemColors.ControlText;
            ProductsButton.Location = new Point(3, 37);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Size = new Size(157, 32);
            ProductsButton.TabIndex = 2;
            ProductsButton.Text = "My Products";
            ProductsButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(TotalRevenue);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(PageLabel);
            panel2.Controls.Add(ToAfterButton);
            panel2.Controls.Add(ToBeforeButton);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(23, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(588, 282);
            panel2.TabIndex = 3;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, total });
            dataGridView1.Location = new Point(11, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(560, 189);
            dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 22);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Total:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(EndDateLabel);
            panel1.Controls.Add(StartDateLabel);
            panel1.Location = new Point(23, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 104);
            panel1.TabIndex = 2;
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
            // id
            // 
            id.HeaderText = "Product";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 200;
            // 
            // total
            // 
            total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            total.HeaderText = "Total";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // SellerFinancePage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            Name = "SellerFinancePage";
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
        private Button FinanceButton;
        private Button AddProductButton;
        private Panel panel1;
        private Button ResetButton;
        private Button SearchButton;
        private TextBox textBox1;
        private Label CategoryLabel;
        private TextBox NameTextBox;
        private Label StartDateLabel;
        private Label EndDateLabel;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Label label3;
        private Label PageLabel;
        private Button ToAfterButton;
        private Button ToBeforeButton;
        private DataGridView dataGridView1;
        private Label label2;
        private Label TotalRevenue;
        private Button LogoutButton;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn total;
    }
}