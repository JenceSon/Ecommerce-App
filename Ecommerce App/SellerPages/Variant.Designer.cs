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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            DelBtn = new Button();
            ModifyBtn = new Button();
            AddVariantBtn = new Button();
            ListProducts = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ListProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(DelBtn);
            panel1.Controls.Add(ModifyBtn);
            panel1.Controls.Add(AddVariantBtn);
            panel1.Location = new Point(16, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 56);
            panel1.TabIndex = 14;
            // 
            // DelBtn
            // 
            DelBtn.BackColor = Color.OrangeRed;
            DelBtn.FlatStyle = FlatStyle.Popup;
            DelBtn.ForeColor = Color.White;
            DelBtn.Location = new Point(712, 11);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(113, 29);
            DelBtn.TabIndex = 12;
            DelBtn.Text = "Delete";
            DelBtn.UseVisualStyleBackColor = false;
            // 
            // ModifyBtn
            // 
            ModifyBtn.BackColor = Color.OrangeRed;
            ModifyBtn.FlatStyle = FlatStyle.Popup;
            ModifyBtn.ForeColor = Color.White;
            ModifyBtn.Location = new Point(844, 11);
            ModifyBtn.Name = "ModifyBtn";
            ModifyBtn.Size = new Size(113, 29);
            ModifyBtn.TabIndex = 10;
            ModifyBtn.Text = "Modify";
            ModifyBtn.UseVisualStyleBackColor = false;
            // 
            // AddVariantBtn
            // 
            AddVariantBtn.BackColor = Color.OrangeRed;
            AddVariantBtn.FlatStyle = FlatStyle.Popup;
            AddVariantBtn.ForeColor = Color.White;
            AddVariantBtn.Location = new Point(576, 11);
            AddVariantBtn.Name = "AddVariantBtn";
            AddVariantBtn.Size = new Size(113, 29);
            AddVariantBtn.TabIndex = 6;
            AddVariantBtn.Text = "Add Variant";
            AddVariantBtn.UseVisualStyleBackColor = false;
            AddVariantBtn.Click += AddVariantBtn_Click;
            // 
            // ListProducts
            // 
            ListProducts.BackColor = Color.White;
            ListProducts.Controls.Add(panel1);
            ListProducts.Controls.Add(dataGridView1);
            ListProducts.Location = new Point(0, 0);
            ListProducts.Name = "ListProducts";
            ListProducts.Size = new Size(1006, 649);
            ListProducts.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(978, 558);
            dataGridView1.TabIndex = 7;
            // 
            // Variant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 644);
            Controls.Add(ListProducts);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Variant";
            Text = "Variant";
            panel1.ResumeLayout(false);
            ListProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button DelBtn;
        private Button ModifyBtn;
        private Button AddVariantBtn;
        private Panel ListProducts;
        private DataGridView dataGridView1;
    }
}