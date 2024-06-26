﻿namespace Ecommerce_App.SellerPages
{
    partial class AddProduct
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
            panel1 = new Panel();
            generateID = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            DescriptionTextBox = new TextBox();
            label2 = new Label();
            CategoryComboBox = new ComboBox();
            CategoryLabel = new Label();
            ProductNameTextBox = new TextBox();
            NameLabel = new Label();
            panel2 = new Panel();
            AmountTextBox = new TextBox();
            AmountLabel = new Label();
            PriceTextBox = new TextBox();
            PriceLabel = new Label();
            label4 = new Label();
            ResetButton = new Button();
            SaveButton = new Button();
            panel3 = new Panel();
            label6 = new Label();
            panel4 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)generateID).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(generateID);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(DescriptionTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CategoryComboBox);
            panel1.Controls.Add(CategoryLabel);
            panel1.Controls.Add(ProductNameTextBox);
            panel1.Controls.Add(NameLabel);
            panel1.Location = new Point(17, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 259);
            panel1.TabIndex = 3;
            // 
            // generateID
            // 
            generateID.Image = Properties.Resources.automatic;
            generateID.Location = new Point(945, 53);
            generateID.Name = "generateID";
            generateID.Size = new Size(31, 28);
            generateID.SizeMode = PictureBoxSizeMode.StretchImage;
            generateID.TabIndex = 9;
            generateID.TabStop = false;
            generateID.Click += generateID_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(716, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 27);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(631, 55);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 7;
            label1.Text = "Product ID";
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
            DescriptionTextBox.Size = new Size(851, 149);
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
            CategoryComboBox.Size = new Size(217, 28);
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
            ProductNameTextBox.Size = new Size(202, 27);
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
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(AmountTextBox);
            panel2.Controls.Add(AmountLabel);
            panel2.Controls.Add(PriceTextBox);
            panel2.Controls.Add(PriceLabel);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(17, 312);
            panel2.Name = "panel2";
            panel2.Size = new Size(487, 307);
            panel2.TabIndex = 4;
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
            // ResetButton
            // 
            ResetButton.BackColor = Color.White;
            ResetButton.FlatStyle = FlatStyle.Popup;
            ResetButton.ForeColor = Color.Black;
            ResetButton.Location = new Point(839, 12);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(81, 29);
            ResetButton.TabIndex = 8;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.OrangeRed;
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(926, 12);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(81, 29);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(510, 312);
            panel3.Name = "panel3";
            panel3.Size = new Size(498, 302);
            panel3.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(123, 15);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 13;
            label6.Text = "image name";
            // 
            // panel4
            // 
            panel4.Location = new Point(12, 48);
            panel4.Name = "panel4";
            panel4.Size = new Size(471, 244);
            panel4.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(12, 11);
            button1.Name = "button1";
            button1.Size = new Size(93, 29);
            button1.TabIndex = 10;
            button1.Text = "Add Image";
            button1.UseVisualStyleBackColor = false;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 633);
            Controls.Add(panel3);
            Controls.Add(ResetButton);
            Controls.Add(SaveButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddProduct";
            Text = "Add Product";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)generateID).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox DescriptionTextBox;
        private Label label2;
        private ComboBox CategoryComboBox;
        private Label CategoryLabel;
        private TextBox ProductNameTextBox;
        private Label NameLabel;
        private TextBox textBox1;
        private Label label1;
        private Panel panel2;
        private TextBox AmountTextBox;
        private Label AmountLabel;
        private TextBox PriceTextBox;
        private Label PriceLabel;
        private Label label4;
        private Button ResetButton;
        private Button SaveButton;
        private Panel panel3;
        //private Label label5;
        private Panel panel4;
        private Button button1;
        private Label label6;
        private PictureBox generateID;
    }
}