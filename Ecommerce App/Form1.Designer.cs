namespace Ecommerce_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            test = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)test).BeginInit();
            SuspendLayout();
            // 
            // test
            // 
            test.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            test.Location = new Point(113, 59);
            test.Name = "test";
            test.RowHeadersWidth = 51;
            test.RowTemplate.Height = 29;
            test.Size = new Size(561, 290);
            test.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(test);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)test).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView test;
    }
}