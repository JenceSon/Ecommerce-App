namespace Ecommerce_App.SellerPages
{
    partial class Finance
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
            panel2 = new Panel();
            EnddatePicker = new DateTimePicker();
            StartdatePicker = new DateTimePicker();
            SearchButton = new Button();
            EndDateLabel = new Label();
            StartDateLabel = new Label();
            panel3 = new Panel();
            TotalRevenue = new Label();
            label3 = new Label();
            ListProductRevenue = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            label4 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ListProductRevenue).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(EnddatePicker);
            panel2.Controls.Add(StartdatePicker);
            panel2.Controls.Add(SearchButton);
            panel2.Controls.Add(EndDateLabel);
            panel2.Controls.Add(StartDateLabel);
            panel2.Location = new Point(13, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(571, 104);
            panel2.TabIndex = 6;
            // 
            // EnddatePicker
            // 
            EnddatePicker.Location = new Point(125, 57);
            EnddatePicker.Name = "EnddatePicker";
            EnddatePicker.Size = new Size(250, 27);
            EnddatePicker.TabIndex = 6;
            // 
            // StartdatePicker
            // 
            StartdatePicker.Location = new Point(125, 15);
            StartdatePicker.Name = "StartdatePicker";
            StartdatePicker.Size = new Size(250, 27);
            StartdatePicker.TabIndex = 5;
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
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(TotalRevenue);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(ListProductRevenue);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(13, 114);
            panel3.Name = "panel3";
            panel3.Size = new Size(571, 267);
            panel3.TabIndex = 7;
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
            // ListProductRevenue
            // 
            ListProductRevenue.AllowUserToAddRows = false;
            ListProductRevenue.AllowUserToDeleteRows = false;
            ListProductRevenue.AllowUserToOrderColumns = true;
            ListProductRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListProductRevenue.Columns.AddRange(new DataGridViewColumn[] { id, total });
            ListProductRevenue.Location = new Point(5, 46);
            ListProductRevenue.Name = "ListProductRevenue";
            ListProductRevenue.ReadOnly = true;
            ListProductRevenue.RowHeadersWidth = 51;
            ListProductRevenue.RowTemplate.Height = 29;
            ListProductRevenue.Size = new Size(560, 218);
            ListProductRevenue.TabIndex = 2;
            // 
            // id
            // 
            id.HeaderText = "Product";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 250;
            // 
            // total
            // 
            total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            total.HeaderText = "Total";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(11, 22);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 1;
            label4.Text = "Total:";
            // 
            // Finance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Finance";
            Size = new Size(598, 384);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ListProductRevenue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DateTimePicker EnddatePicker;
        private DateTimePicker StartdatePicker;
        private Button SearchButton;
        private Label EndDateLabel;
        private Label StartDateLabel;
        private Panel panel3;
        private Label TotalRevenue;
        private Label label3;
        private DataGridView ListProductRevenue;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn total;
        private Label label4;
    }
}
