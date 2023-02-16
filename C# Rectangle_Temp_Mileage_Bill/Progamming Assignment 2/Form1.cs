using System;
using System.Windows.Forms;

namespace Progamming_Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           


            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonArea_Click(object sender, EventArgs e)
        {
            double length, width, area;
            length = double.Parse(lengthBox.Text);
            width = double.Parse(widthBox.Text);
            area = length * width;
            labelRect.Text = area.ToString("n2");

            

        }

        private void ButtonPerimeter_Click(object sender, EventArgs e)
        {
            double length, width, perimeter;
            length = double.Parse(lengthBox.Text);
            width = double.Parse(widthBox.Text);
            perimeter = 2 * (length + width);
            labelRect.Text = perimeter.ToString("n2");
        }

        private void CtoFbutton_Click(object sender, EventArgs e)
        {
            double f, c;
            c = double.Parse(tempBox.Text);
            f = c * 9 / 5 + 32;
            labelTemp.Text = f.ToString();

        }

        private void FtoCbutton_Click(object sender, EventArgs e)
        {
            double f, c;
            f = double.Parse(tempBox.Text);
            c = 5 * (f - 32) / 9;
            labelTemp.Text = c.ToString();
        }

        private void mileComp_Click(object sender, EventArgs e)
        {
            double MPG, endmile, startmile, gallonsneed;
            startmile = double.Parse(startmileBox.Text);
            endmile = double.Parse(endmileBox.Text);
            gallonsneed = double.Parse(tankBox.Text);
            MPG = (endmile - startmile) / gallonsneed;
            labelMile.Text = MPG.ToString();


        }

        private void billButton_Click(object sender, EventArgs e)
        {
            const double baseburgerPrice = 2.75;
            const double basefryPrice = 1.75;
            const double basedrinkPrice = 1.25;
            
            int burger, fry, drink;
            double total, burgertot, frytot, drinktot;
            burger = int.Parse(burgBox.Text);
            fry = int.Parse(fryBox.Text);
            drink = int.Parse(drinkBox.Text);
            burgertot = baseburgerPrice * burger;
            frytot = basefryPrice * burger;
            drinktot = basedrinkPrice * drink; 
            total = (baseburgerPrice * burger) + (basefryPrice * fry) + (basedrinkPrice * drink);

            BillList.Items.Add("Burgers" + Convert.ToChar(9) + burgertot);
            BillList.Items.Add("Fries" + Convert.ToChar(9) + frytot);
            BillList.Items.Add("Drink" + Convert.ToChar(9) + drinktot);
            BillList.Items.Add("Total Bill" + Convert.ToChar(9) + total);
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            lengthBox.Text = "";
            widthBox.Text = "";
            tempBox.Text = "";
            startmileBox.Text = "";
            endmileBox.Text = "";
            tankBox.Text = "";
            burgBox.Text = "";
            fryBox.Text = "";
            drinkBox.Text = "";
            labelRect.Text = "";
            labelTemp.Text = "";
            labelMile.Text = "";
            BillList.Text = "";
            lengthBox.Focus();



        }
    }
}
