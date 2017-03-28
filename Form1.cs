using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CalculateCost();
        }

        private const double BASE_PRICE = 12.00;
        private double toppingPrice = 1.25;
        private double price = BASE_PRICE;
        private double numOfToppings = 0;
        private double extraCosts = 0;
        private double couponSavings = 1;

//Topping Pricing

        private void onionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (onionCheckBox.Checked)
                numOfToppings += 1;
            else
                numOfToppings -= 1;
            CalculateCost();
        }

        private void pepperCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pepperCheckBox.Checked)
                numOfToppings += 1;
            else
                numOfToppings -= 1;
            CalculateCost();
        }

        private void pepperoniCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pepperoniCheckBox.Checked)
                numOfToppings += 1;
            else
                numOfToppings -= 1;
            CalculateCost();
        }

        private void sausageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sausageCheckBox.Checked)
                numOfToppings += 1;
            else
                numOfToppings -= 1;
            CalculateCost();
        }

//Delivery Charges

        private void deliveryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            const double DELIVERY_CHARGE = 2.00;
            if (deliveryRadioButton.Checked)
                extraCosts += DELIVERY_CHARGE;
            else
                extraCosts -= DELIVERY_CHARGE;
            CalculateCost();
        }

        private void smallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (smallRadioButton.Checked)
            {
                toppingPrice -= .50;
                extraCosts -= 2.00;
            }
            else
            { 
                toppingPrice += .50;
                extraCosts += 2.00;
            }
            CalculateCost();
        }

        private void largeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (largeRadioButton.Checked)
            {
                toppingPrice += .50;
                extraCosts += 2.00;
            }
            else
            {
                toppingPrice -= .50;
                extraCosts -= 2.00;
            }
            CalculateCost();
        }

//Coupon Validation

        private void btnVerify_Click(object sender, EventArgs e)
        {
            var coupon = "pizza";
            

            if (coupon == couponTextBox.Text.ToLower())
            {
                couponSavings = .50;
                verifyLabel.Text = "Approved!";
                verifyLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                couponSavings = 1;
                verifyLabel.Text = "Invalid Coupon";
                verifyLabel.ForeColor = System.Drawing.Color.Red;
            }

            verifyLabel.Visible = true;
            CalculateCost();
        }

        private void CalculateCost()
        {
            double pizzaCost = BASE_PRICE + extraCosts + (numOfToppings * toppingPrice);
            price = couponSavings * pizzaCost;

            outputLabel.Text = "Total: " + price.ToString("C");
        }


    }
}
