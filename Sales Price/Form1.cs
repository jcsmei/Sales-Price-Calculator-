using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Price
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string originalPrice = txtOriginalPrice.Text;
            string discount = txtDiscount.Text;
            string SalesTax = txtSalesTax.Text;
            lblFinalPrice.Text = "The item's original price is $" +
                originalPrice + ". It is on sale now with a " +
                discount + "% discount. As usual, there is a " +
                SalesTax + "% sales tax.";
        }

        private void btnGetPrice_Click(object sender, EventArgs e)
        {
            lblFinalPrice.Text = "";

            float originalPrice = float.Parse(txtOriginalPrice.Text);
            float discount = float.Parse(txtDiscount.Text);
            float SalesTax = float.Parse(txtSalesTax.Text);
            float FinalPrice = 0;
            
            if (discount>=1)
            {
                discount = discount / 100;
            }
            if(SalesTax >= 1)
            {
                SalesTax = SalesTax / 100;
            }
            FinalPrice = originalPrice * (1 - discount) * (1 + SalesTax);
            lblFinalPrice.Text = FinalPrice.ToString("c2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDiscount.Clear();
            txtOriginalPrice.Clear();
            txtSalesTax.Clear();
            lblFinalPrice.Text = "";
        }
    }
}
