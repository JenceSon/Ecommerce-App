namespace Ecommerce_App.SellerPages
{
    partial class ListProducts
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
            label1 = new Label();
            SeeMoreBtn = new Button();
            ProductTable = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NameProduct = new DataGridViewTextBoxColumn();
            TotalRemaining = new DataGridViewTextBoxColumn();
            MinPrice = new DataGridViewTextBoxColumn();
            MaxPrice = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ProductTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(96, 30);
            label1.TabIndex = 0;
            label1.Text = "Product";
            // 
            // SeeMoreBtn
            // 
            SeeMoreBtn.BackColor = Color.OrangeRed;
            SeeMoreBtn.FlatStyle = FlatStyle.Popup;
            SeeMoreBtn.ForeColor = Color.White;
            SeeMoreBtn.Location = new Point(494, 15);
            SeeMoreBtn.Name = "SeeMoreBtn";
            SeeMoreBtn.Size = new Size(98, 29);
            SeeMoreBtn.TabIndex = 5;
            SeeMoreBtn.Text = "See more...";
            SeeMoreBtn.UseVisualStyleBackColor = false;
            SeeMoreBtn.Click += SeeMoreBtn_Click;
            // 
            // ProductTable
            // 
            ProductTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductTable.Columns.AddRange(new DataGridViewColumn[] { ID, NameProduct, TotalRemaining, MinPrice, MaxPrice });
            ProductTable.Location = new Point(8, 53);
            ProductTable.Name = "ProductTable";
            ProductTable.RowHeadersWidth = 51;
            ProductTable.RowTemplate.Height = 29;
            ProductTable.Size = new Size(584, 328);
            ProductTable.TabIndex = 6;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 90;
            // 
            // NameProduct
            // 
            NameProduct.HeaderText = "Name";
            NameProduct.MinimumWidth = 6;
            NameProduct.Name = "NameProduct";
            NameProduct.Width = 140;
            // 
            // TotalRemaining
            // 
            TotalRemaining.HeaderText = "Total remaining";
            TotalRemaining.MinimumWidth = 6;
            TotalRemaining.Name = "TotalRemaining";
            TotalRemaining.Width = 80;
            // 
            // MinPrice
            // 
            MinPrice.HeaderText = "Minimum price";
            MinPrice.MinimumWidth = 6;
            MinPrice.Name = "MinPrice";
            MinPrice.Width = 110;
            // 
            // MaxPrice
            // 
            MaxPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaxPrice.HeaderText = "Maximum Price";
            MaxPrice.MinimumWidth = 6;
            MaxPrice.Name = "MaxPrice";
            // 
            // ListProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ProductTable);
            Controls.Add(SeeMoreBtn);
            Controls.Add(label1);
            Name = "ListProducts";
            Size = new Size(598, 384);
            ((System.ComponentModel.ISupportInitialize)ProductTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button SeeMoreBtn;
        private DataGridView ProductTable;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NameProduct;
        private DataGridViewTextBoxColumn TotalRemaining;
        private DataGridViewTextBoxColumn MinPrice;
        private DataGridViewTextBoxColumn MaxPrice;
    }
}
