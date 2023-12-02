using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce_App.SellerPages
{
    public partial class SellerAddProductPage : Form
    {
        public int hasVariation;
        public SellerAddProductPage()
        {
            InitializeComponent();
            this.hasVariation = 0;
        }

        private void VarEnableButton_Click(object sender, EventArgs e)
        {
            AmountLabel.Visible = false;
            PriceLabel.Visible = false;
            AmountTextBox.Visible = false;
            AmountTextBox.Enabled = false;
            PriceTextBox.Enabled = false;
            PriceTextBox.Visible = false;

            VarEnableButton.Enabled = false;
            VarEnableButton.Visible = false;

            VariationFlowPanel.Enabled = true;
            VariationFlowPanel.Visible = true;
            Variant var = new Variant();
            VariationFlowPanel.Controls.Add(var);
            var.Size = new Size(560, 130);

            AddButton.Visible = true;
            AddButton.Enabled = true;

            this.hasVariation++;
        }

        private void PriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Variant var = new Variant();
            VariationFlowPanel.Controls.Add(var);
            var.Size = new Size(560, 130);
        }

        public void DecreseVariation()
        {
            this.hasVariation--;
            if (this.hasVariation <= 0)
            {
                AmountLabel.Visible = true;
                PriceLabel.Visible = true;
                AmountTextBox.Visible = true;
                AmountTextBox.Enabled = true;
                PriceTextBox.Enabled = true;
                PriceTextBox.Visible = true;

                VarEnableButton.Enabled = true;
                VarEnableButton.Visible = true;

                VariationFlowPanel.Enabled = false;
                VariationFlowPanel.Visible = false;

                AddButton.Visible = false;
                AddButton.Enabled = false;
                
                this.hasVariation = 0;
            }
        }

        public void Variant_VariantDeleted(object sender, EventArgs e)
        {
            this.hasVariation--;
            if (this.hasVariation <= 0)
            {
                AmountLabel.Visible = true;
                PriceLabel.Visible = true;
                AmountTextBox.Visible = true;
                AmountTextBox.Enabled = true;
                PriceTextBox.Enabled = true;
                PriceTextBox.Visible = true;

                VarEnableButton.Enabled = true;
                VarEnableButton.Visible = true;

                VariationFlowPanel.Enabled = false;
                VariationFlowPanel.Visible = false;

                AddButton.Visible = false;
                AddButton.Enabled = false;

                this.hasVariation = 0;
            }
        }
    }
}
