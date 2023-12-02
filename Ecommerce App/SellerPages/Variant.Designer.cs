namespace Ecommerce_App.SellerPages
{
    partial class Variant
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Variant));
            RemoveButton = new Button();
            DescriptionTextBox = new TextBox();
            label2 = new Label();
            CategoryLabel = new Label();
            ProductNameTextBox = new TextBox();
            VariantLabel = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // RemoveButton
            // 
            RemoveButton.Image = (Image)resources.GetObject("RemoveButton.Image");
            RemoveButton.Location = new Point(525, 22);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(38, 84);
            RemoveButton.TabIndex = 0;
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(122, 74);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(393, 43);
            DescriptionTextBox.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 9;
            label2.Text = "Description";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(340, 5);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(0, 20);
            CategoryLabel.TabIndex = 8;
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(122, 3);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.Size = new Size(393, 27);
            ProductNameTextBox.TabIndex = 7;
            // 
            // VariantLabel
            // 
            VariantLabel.AutoSize = true;
            VariantLabel.Location = new Point(12, 6);
            VariantLabel.Name = "VariantLabel";
            VariantLabel.Size = new Size(55, 20);
            VariantLabel.TabIndex = 6;
            VariantLabel.Text = "Option";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 27);
            textBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 11;
            label1.Text = "Price";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(399, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(116, 27);
            textBox2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 41);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 13;
            label3.Text = "Amount";
            // 
            // Variant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(DescriptionTextBox);
            Controls.Add(label2);
            Controls.Add(CategoryLabel);
            Controls.Add(ProductNameTextBox);
            Controls.Add(VariantLabel);
            Controls.Add(RemoveButton);
            Name = "Variant";
            Size = new Size(568, 120);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RemoveButton;
        private TextBox DescriptionTextBox;
        private Label label2;
        private Label CategoryLabel;
        private TextBox ProductNameTextBox;
        private Label VariantLabel;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
    }
}
