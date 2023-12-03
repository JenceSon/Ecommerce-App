namespace Ecommerce_App.SellerPages
{
    partial class Product_Information
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
            ListProducts = new Panel();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            SeeMore = new Button();
            panel1 = new Panel();
            ResetButton = new Button();
            SearchButton = new Button();
            textBox1 = new TextBox();
            CategoryLabel = new Label();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            ListProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ListProducts
            // 
            ListProducts.BackColor = Color.White;
            ListProducts.Controls.Add(panel1);
            ListProducts.Controls.Add(dataGridView1);
            ListProducts.Location = new Point(12, 12);
            ListProducts.Name = "ListProducts";
            ListProducts.Size = new Size(1634, 951);
            ListProducts.TabIndex = 4;
            // 
            // button5
            // 
            button5.BackColor = Color.OrangeRed;
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = Color.White;
            button5.Location = new Point(1156, 11);
            button5.Name = "button5";
            button5.Size = new Size(113, 29);
            button5.TabIndex = 12;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.OrangeRed;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = Color.White;
            button3.Location = new Point(1318, 11);
            button3.Name = "button3";
            button3.Size = new Size(113, 29);
            button3.TabIndex = 10;
            button3.Text = "Modify";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.White;
            button2.Location = new Point(1488, 11);
            button2.Name = "button2";
            button2.Size = new Size(113, 29);
            button2.TabIndex = 9;
            button2.Text = "See variant";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1611, 813);
            dataGridView1.TabIndex = 7;
            // 
            // SeeMore
            // 
            SeeMore.BackColor = Color.OrangeRed;
            SeeMore.FlatStyle = FlatStyle.Popup;
            SeeMore.ForeColor = Color.White;
            SeeMore.Location = new Point(999, 11);
            SeeMore.Name = "SeeMore";
            SeeMore.Size = new Size(113, 29);
            SeeMore.TabIndex = 6;
            SeeMore.Text = "Add Product";
            SeeMore.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ResetButton);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(CategoryLabel);
            panel1.Controls.Add(NameTextBox);
            panel1.Controls.Add(SeeMore);
            panel1.Controls.Add(NameLabel);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1611, 104);
            panel1.TabIndex = 14;
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
            // Product_Information
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1658, 975);
            Controls.Add(ListProducts);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Product_Information";
            Text = "Product_Information";
            ListProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ListProducts;
        private Button SeeMore;
        private Button button5;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button ResetButton;
        private Button SearchButton;
        private TextBox textBox1;
        private Label CategoryLabel;
        private TextBox NameTextBox;
        private Label NameLabel;
    }
}