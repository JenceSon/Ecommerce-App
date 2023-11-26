namespace Ecommerce_App.Page
{
    partial class Cart
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(800, 309);
            dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 387);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 65);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(guna2TileButton1);
            panel2.Controls.Add(guna2PictureBox1);
            panel2.Location = new Point(0, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 73);
            panel2.TabIndex = 3;
            // 
            // guna2TileButton1
            // 
            guna2TileButton1.BackColor = Color.Transparent;
            guna2TileButton1.Cursor = Cursors.Hand;
            guna2TileButton1.CustomizableEdges = customizableEdges1;
            guna2TileButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2TileButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2TileButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2TileButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2TileButton1.FillColor = Color.Transparent;
            guna2TileButton1.FocusedColor = Color.Transparent;
            guna2TileButton1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            guna2TileButton1.ForeColor = Color.OrangeRed;
            guna2TileButton1.HoverState.BorderColor = Color.Transparent;
            guna2TileButton1.HoverState.CustomBorderColor = Color.Transparent;
            guna2TileButton1.HoverState.FillColor = Color.Transparent;
            guna2TileButton1.HoverState.ForeColor = Color.OrangeRed;
            guna2TileButton1.ImageAlign = HorizontalAlignment.Left;
            guna2TileButton1.Location = new Point(78, 17);
            guna2TileButton1.Margin = new Padding(1);
            guna2TileButton1.Name = "guna2TileButton1";
            guna2TileButton1.PressedColor = Color.Transparent;
            guna2TileButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TileButton1.Size = new Size(239, 41);
            guna2TileButton1.TabIndex = 3;
            guna2TileButton1.Text = "Shopee | Cart";
            guna2TileButton1.TextAlign = HorizontalAlignment.Left;
            guna2TileButton1.Click += guna2TileButton1_Click;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.Cursor = Cursors.Hand;
            guna2PictureBox1.CustomizableEdges = customizableEdges3;
            guna2PictureBox1.FillColor = Color.Transparent;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(25, 17);
            guna2PictureBox1.Margin = new Padding(2);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox1.Size = new Size(50, 41);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 2;
            guna2PictureBox1.TabStop = false;
            guna2PictureBox1.UseTransparentBackground = true;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Cart";
            Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
    }
}