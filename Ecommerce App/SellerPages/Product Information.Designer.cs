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
            label1 = new Label();
            ListProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ListProducts
            // 
            ListProducts.BackColor = Color.White;
            ListProducts.Controls.Add(label1);
            ListProducts.Controls.Add(button5);
            ListProducts.Controls.Add(button3);
            ListProducts.Controls.Add(button2);
            ListProducts.Controls.Add(dataGridView1);
            ListProducts.Controls.Add(SeeMore);
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
            button5.Location = new Point(172, 20);
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
            button3.Location = new Point(334, 20);
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
            button2.Location = new Point(504, 20);
            button2.Name = "button2";
            button2.Size = new Size(113, 29);
            button2.TabIndex = 9;
            button2.Text = "See variant";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1611, 880);
            dataGridView1.TabIndex = 7;
            // 
            // SeeMore
            // 
            SeeMore.BackColor = Color.OrangeRed;
            SeeMore.FlatStyle = FlatStyle.Popup;
            SeeMore.ForeColor = Color.White;
            SeeMore.Location = new Point(11, 20);
            SeeMore.Name = "SeeMore";
            SeeMore.Size = new Size(113, 29);
            SeeMore.TabIndex = 6;
            SeeMore.Text = "Add Product";
            SeeMore.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1561, 16);
            label1.Name = "label1";
            label1.Size = new Size(61, 30);
            label1.TabIndex = 13;
            label1.Text = "Filter";
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
            ListProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ListProducts;
        private Button SeeMore;
        private Button button5;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label1;
    }
}