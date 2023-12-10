﻿namespace Ecommerce_App.SellerPages
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            ListProducts = new Panel();
            panel1 = new Panel();
            SeeVariantBtn = new Button();
            DelBtn = new Button();
            ModifyBtn = new Button();
            FilterBtn = new Button();
            AddProductBtn = new Button();
            ProductsTable = new DataGridView();
            ImageCol = new DataGridViewTextBoxColumn();
            IDCol = new DataGridViewTextBoxColumn();
            NameCol = new DataGridViewTextBoxColumn();
            MinPriceCol = new DataGridViewTextBoxColumn();
            MaxPriceCol = new DataGridViewTextBoxColumn();
            DesCol = new DataGridViewTextBoxColumn();
            NoSaleCol = new DataGridViewTextBoxColumn();
            TotalRemainingCol = new DataGridViewTextBoxColumn();
            OnSaleCol = new DataGridViewTextBoxColumn();
            CatCol = new DataGridViewTextBoxColumn();
            ListProducts.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsTable).BeginInit();
            SuspendLayout();
            // 
            // ListProducts
            // 
            ListProducts.BackColor = Color.White;
            ListProducts.Controls.Add(panel1);
            ListProducts.Controls.Add(ProductsTable);
            ListProducts.Location = new Point(12, 12);
            ListProducts.Name = "ListProducts";
            ListProducts.Size = new Size(1634, 951);
            ListProducts.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(SeeVariantBtn);
            panel1.Controls.Add(DelBtn);
            panel1.Controls.Add(ModifyBtn);
            panel1.Controls.Add(FilterBtn);
            panel1.Controls.Add(AddProductBtn);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1611, 56);
            panel1.TabIndex = 14;
            // 
            // SeeVariantBtn
            // 
            SeeVariantBtn.BackColor = Color.OrangeRed;
            SeeVariantBtn.FlatStyle = FlatStyle.Popup;
            SeeVariantBtn.ForeColor = Color.White;
            SeeVariantBtn.Location = new Point(983, 11);
            SeeVariantBtn.Name = "SeeVariantBtn";
            SeeVariantBtn.Size = new Size(113, 29);
            SeeVariantBtn.TabIndex = 13;
            SeeVariantBtn.Text = "Variants";
            SeeVariantBtn.UseVisualStyleBackColor = false;
            SeeVariantBtn.Click += SeeVariantBtn_Click;
            // 
            // DelBtn
            // 
            DelBtn.BackColor = Color.OrangeRed;
            DelBtn.FlatStyle = FlatStyle.Popup;
            DelBtn.ForeColor = Color.White;
            DelBtn.Location = new Point(1319, 11);
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
            ModifyBtn.Location = new Point(1481, 11);
            ModifyBtn.Name = "ModifyBtn";
            ModifyBtn.Size = new Size(113, 29);
            ModifyBtn.TabIndex = 10;
            ModifyBtn.Text = "Modify";
            ModifyBtn.UseVisualStyleBackColor = false;
            ModifyBtn.Click += ModifyBtn_Click;
            // 
            // FilterBtn
            // 
            FilterBtn.BackColor = Color.OrangeRed;
            FilterBtn.FlatStyle = FlatStyle.Popup;
            FilterBtn.ForeColor = Color.White;
            FilterBtn.Location = new Point(3, 11);
            FilterBtn.Name = "FilterBtn";
            FilterBtn.Size = new Size(81, 29);
            FilterBtn.TabIndex = 9;
            FilterBtn.Text = "Filter";
            FilterBtn.UseVisualStyleBackColor = false;
            // 
            // AddProductBtn
            // 
            AddProductBtn.BackColor = Color.OrangeRed;
            AddProductBtn.FlatStyle = FlatStyle.Popup;
            AddProductBtn.ForeColor = Color.White;
            AddProductBtn.Location = new Point(1158, 11);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(113, 29);
            AddProductBtn.TabIndex = 6;
            AddProductBtn.Text = "Add Product";
            AddProductBtn.UseVisualStyleBackColor = false;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // ProductsTable
            // 
            ProductsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsTable.Columns.AddRange(new DataGridViewColumn[] { ImageCol, IDCol, NameCol, MinPriceCol, MaxPriceCol, DesCol, NoSaleCol, TotalRemainingCol, OnSaleCol, CatCol });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProductsTable.DefaultCellStyle = dataGridViewCellStyle1;
            ProductsTable.Location = new Point(11, 74);
            ProductsTable.Name = "ProductsTable";
            ProductsTable.RowHeadersWidth = 51;
            ProductsTable.RowTemplate.Height = 29;
            ProductsTable.Size = new Size(1611, 861);
            ProductsTable.TabIndex = 7;
            // 
            // ImageCol
            // 
            ImageCol.HeaderText = "Image";
            ImageCol.MinimumWidth = 6;
            ImageCol.Name = "ImageCol";
            ImageCol.Width = 300;
            // 
            // IDCol
            // 
            IDCol.HeaderText = "ID";
            IDCol.MinimumWidth = 6;
            IDCol.Name = "IDCol";
            IDCol.Width = 90;
            // 
            // NameCol
            // 
            NameCol.HeaderText = "Name";
            NameCol.MinimumWidth = 6;
            NameCol.Name = "NameCol";
            NameCol.Width = 150;
            // 
            // MinPriceCol
            // 
            MinPriceCol.HeaderText = "Minimum price";
            MinPriceCol.MinimumWidth = 6;
            MinPriceCol.Name = "MinPriceCol";
            MinPriceCol.Width = 140;
            // 
            // MaxPriceCol
            // 
            MaxPriceCol.HeaderText = "Maximum price";
            MaxPriceCol.MinimumWidth = 6;
            MaxPriceCol.Name = "MaxPriceCol";
            MaxPriceCol.Width = 140;
            // 
            // DesCol
            // 
            DesCol.HeaderText = "Description";
            DesCol.MinimumWidth = 6;
            DesCol.Name = "DesCol";
            DesCol.Width = 290;
            // 
            // NoSaleCol
            // 
            NoSaleCol.HeaderText = "Number of Sales";
            NoSaleCol.MinimumWidth = 6;
            NoSaleCol.Name = "NoSaleCol";
            NoSaleCol.Width = 101;
            // 
            // TotalRemainingCol
            // 
            TotalRemainingCol.HeaderText = "In Stock";
            TotalRemainingCol.MinimumWidth = 6;
            TotalRemainingCol.Name = "TotalRemainingCol";
            TotalRemainingCol.Width = 101;
            // 
            // OnSaleCol
            // 
            OnSaleCol.HeaderText = "On sale";
            OnSaleCol.MinimumWidth = 6;
            OnSaleCol.Name = "OnSaleCol";
            OnSaleCol.Width = 101;
            // 
            // CatCol
            // 
            CatCol.HeaderText = "Category";
            CatCol.MinimumWidth = 6;
            CatCol.Name = "CatCol";
            CatCol.Width = 145;
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
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ListProducts;
        private Button AddProductBtn;
        private Button DelBtn;
        private Button ModifyBtn;
        private Button FilterBtn;
        private DataGridView ProductsTable;
        private Panel panel1;
        private Button SeeVariantBtn;
        private DataGridViewTextBoxColumn ImageCol;
        private DataGridViewTextBoxColumn IDCol;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn MinPriceCol;
        private DataGridViewTextBoxColumn MaxPriceCol;
        private DataGridViewTextBoxColumn DesCol;
        private DataGridViewTextBoxColumn NoSaleCol;
        private DataGridViewTextBoxColumn TotalRemainingCol;
        private DataGridViewTextBoxColumn OnSaleCol;
        private DataGridViewTextBoxColumn CatCol;
    }
}