namespace Ecommerce_App.SellerPages
{
    partial class SellerAddProductPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerAddProductPage));
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            LogoButton = new Button();
            splitContainer2 = new SplitContainer();
            LogoutButton = new Button();
            FinanceButton = new Button();
            AddProductButton = new Button();
            ProductsButton = new Button();
            ResetButton = new Button();
            SaveButton = new Button();
            panel2 = new Panel();
            VariationFlowPanel = new FlowLayoutPanel();
            AddButton = new Button();
            AmountTextBox = new TextBox();
            AmountLabel = new Label();
            PriceTextBox = new TextBox();
            PriceLabel = new Label();
            VarEnableButton = new Button();
            label4 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            DescriptionTextBox = new TextBox();
            label2 = new Label();
            CategoryComboBox = new ComboBox();
            CategoryLabel = new Label();
            ProductNameTextBox = new TextBox();
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
            label1.Size = new Size(153, 28);
            label1.TabIndex = 4;
            label1.Text = "Product Details";
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
            LogoButton.TabIndex = 3;
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
            splitContainer2.Panel2.AutoScroll = true;
            splitContainer2.Panel2.Controls.Add(ResetButton);
            splitContainer2.Panel2.Controls.Add(SaveButton);
            splitContainer2.Panel2.Controls.Add(panel2);
            splitContainer2.Panel2.Controls.Add(panel1);
            splitContainer2.Size = new Size(800, 394);
            splitContainer2.SplitterDistance = 158;
            splitContainer2.TabIndex = 0;
            // 
            // LogoutButton
            // 
            LogoutButton.Image = (Image)resources.GetObject("LogoutButton.Image");
            LogoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutButton.Location = new Point(0, 346);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(160, 32);
            LogoutButton.TabIndex = 7;
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
            FinanceButton.TabIndex = 6;
            FinanceButton.Text = "Finance";
            FinanceButton.UseVisualStyleBackColor = true;
            // 
            // AddProductButton
            // 
            AddProductButton.FlatAppearance.BorderSize = 0;
            AddProductButton.FlatStyle = FlatStyle.Flat;
            AddProductButton.ForeColor = Color.OrangeRed;
            AddProductButton.Location = new Point(3, 75);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(157, 32);
            AddProductButton.TabIndex = 5;
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
            ProductsButton.TabIndex = 4;
            ProductsButton.Text = "My Products";
            ProductsButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.White;
            ResetButton.FlatStyle = FlatStyle.Popup;
            ResetButton.ForeColor = Color.Black;
            ResetButton.Location = new Point(444, 12);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(81, 29);
            ResetButton.TabIndex = 6;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.OrangeRed;
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(531, 12);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(81, 29);
            SaveButton.TabIndex = 5;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(VariationFlowPanel);
            panel2.Controls.Add(AddButton);
            panel2.Controls.Add(AmountTextBox);
            panel2.Controls.Add(AmountLabel);
            panel2.Controls.Add(PriceTextBox);
            panel2.Controls.Add(PriceLabel);
            panel2.Controls.Add(VarEnableButton);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(24, 211);
            panel2.Name = "panel2";
            panel2.Size = new Size(588, 179);
            panel2.TabIndex = 3;
            // 
            // VariationFlowPanel
            // 
            VariationFlowPanel.AutoSize = true;
            VariationFlowPanel.Enabled = false;
            VariationFlowPanel.FlowDirection = FlowDirection.TopDown;
            VariationFlowPanel.Location = new Point(0, 90);
            VariationFlowPanel.Name = "VariationFlowPanel";
            VariationFlowPanel.Size = new Size(580, 81);
            VariationFlowPanel.TabIndex = 14;
            VariationFlowPanel.Visible = false;
            // 
            // AddButton
            // 
            AddButton.Enabled = false;
            AddButton.FlatStyle = FlatStyle.Popup;
            AddButton.Location = new Point(420, 51);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 13;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Visible = false;
            AddButton.Click += AddButton_Click;
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(125, 135);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(174, 27);
            AmountTextBox.TabIndex = 11;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(15, 138);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(62, 20);
            AmountLabel.TabIndex = 10;
            AmountLabel.Text = "Amount";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(125, 93);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(174, 27);
            PriceTextBox.TabIndex = 9;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(15, 96);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(41, 20);
            PriceLabel.TabIndex = 8;
            PriceLabel.Text = "Price";
            PriceLabel.Click += PriceLabel_Click;
            // 
            // VarEnableButton
            // 
            VarEnableButton.BackColor = Color.Transparent;
            VarEnableButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            VarEnableButton.FlatStyle = FlatStyle.Flat;
            VarEnableButton.ForeColor = Color.OrangeRed;
            VarEnableButton.Location = new Point(125, 51);
            VarEnableButton.Name = "VarEnableButton";
            VarEnableButton.Size = new Size(144, 29);
            VarEnableButton.TabIndex = 7;
            VarEnableButton.Text = "Enable Variations";
            VarEnableButton.UseVisualStyleBackColor = false;
            VarEnableButton.Click += VarEnableButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 12);
            label4.Name = "label4";
            label4.Size = new Size(171, 28);
            label4.TabIndex = 6;
            label4.Text = "Sales Infomation";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 55);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 0;
            label7.Text = "Variations";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(DescriptionTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CategoryComboBox);
            panel1.Controls.Add(CategoryLabel);
            panel1.Controls.Add(ProductNameTextBox);
            panel1.Controls.Add(NameLabel);
            panel1.Location = new Point(24, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 156);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 12);
            label3.Name = "label3";
            label3.Size = new Size(172, 28);
            label3.TabIndex = 6;
            label3.Text = "Basic Infomation";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(125, 94);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(434, 45);
            DescriptionTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 97);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 4;
            label2.Text = "Description";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(408, 52);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(151, 28);
            CategoryComboBox.TabIndex = 3;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(333, 55);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(69, 20);
            CategoryLabel.TabIndex = 2;
            CategoryLabel.Text = "Category";
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(125, 52);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.Size = new Size(174, 27);
            ProductNameTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(15, 55);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(104, 20);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Product Name";
            // 
            // SellerAddProductPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            Name = "SellerAddProductPage";
            ShowIcon = false;
            Text = "Shopee";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Label label1;
        private Button LogoButton;
        private Button FinanceButton;
        private Button AddProductButton;
        private Button ProductsButton;
        private Panel panel1;
        private Label CategoryLabel;
        private TextBox ProductNameTextBox;
        private Label NameLabel;
        private Panel panel2;
        private Label label4;
        private Label label7;
        private Label label3;
        private TextBox DescriptionTextBox;
        private Label label2;
        private ComboBox CategoryComboBox;
        private Button VarEnableButton;
        private TextBox AmountTextBox;
        private Label AmountLabel;
        private TextBox PriceTextBox;
        private Label PriceLabel;
        private Button SaveButton;
        private Button ResetButton;
        private Button AddButton;
        private Button LogoutButton;
        private FlowLayoutPanel VariationFlowPanel;
    }
}