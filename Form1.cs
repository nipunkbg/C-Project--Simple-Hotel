using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleHotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void FriesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (FriesCb.Checked == true)
            {
                FriesTb.Enabled = true;
            }
            if(FriesCb.Checked == false)
            {
                FriesTb.Enabled = false;
                FriesTb.Text = "0";
            }
        }

        private void BurgerCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BurgerCb.Checked == true)
            {
                BurgerTb.Enabled = true;
            }
            if (FriesCb.Checked == false)
            {
                BurgerTb.Enabled = false;
                BurgerTb.Text = "0";
            }

        }

        private void SaladCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SaladCb.Checked == true)
            {
                SaladTb.Enabled = true;
            }
            if (SaladCb.Checked == false)
            {
                SaladTb.Enabled = false;
                SaladTb.Text = "0";
            }
        }

        private void SandwichCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SandwichCb.Checked == true)
            {
                SandwichTb.Enabled = true;
            }
            if (SandwichCb.Checked == false)
            {
                SandwichTb.Enabled = false;
                SandwichTb.Text = "0";
            }
        }

        private void closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void ReceiptTb_TextChanged(object sender, EventArgs e)
        {

        }
        //unit price
        double friesup = 50, burgerup = 80, saladup = 100, sandwichup = 75, cheeseuo = 80, chickenup = 40;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ReceiptTb.Text + " Subtotal" + Subtotallbl.Text + "Tax:" + taxlbl.Text + "Grand Total" + Grdtotallbl.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Blue, new Point(130));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FriesCb.Checked = false;
            BurgerCb.Checked = false;
            SaladCb.Checked = false;
            SandwichCb.Checked = false;
            ChickenCb.Checked = false;
            CheeseCb.Checked = false;
            TeaCb.Checked = false;
            ColaCb.Checked = false;
            WaterCb.Checked = false;
            ChocolateCb.Checked = false;
            PancakeCb.Checked = false;
            OrangeCb.Checked = false;



        }

        double waterup = 20, teaup = 15, cocaup = 30, chocolateup = 30, pancakeup = 35, orangeup = 25, cheesup=50;
        //total price
        double friestp, burgertp, saladtp, sandwichtp, cheestp, watertp, teatp, cocatp, chocalatetp, pancaketp, orangetp, chickentp;
        double Subtotal = 0, Tax, grdtotal;

        private void button2_Click(object sender, EventArgs e)
        {
            friestp = friesup * Convert.ToDouble(FriesTb.Text);
            burgertp = burgerup * Convert.ToDouble(BurgerTb.Text);
            saladtp = burgerup * Convert.ToDouble(SaladTb.Text);
            sandwichtp = sandwichup * Convert.ToDouble(SandwichTb.Text);
            chickentp = chickenup * Convert.ToDouble(ChickenTb.Text);
            cheestp = cheesup * Convert.ToDouble(ChickenTb.Text);
            teatp = teaup * Convert.ToDouble(TeaTb.Text);
            watertp = waterup * Convert.ToDouble(WaterTb.Text);
            chocalatetp = chocolateup * Convert.ToDouble(ChocolateTb.Text);
            orangetp = orangeup * Convert.ToDouble(OrangeTb.Text);
            pancaketp = pancakeup * Convert.ToDouble(PancakeTb.Text);
            cocatp = cocaup * Convert.ToDouble(ColaTb.Text);
            //add products on receipt
            ReceiptTb.Clear();
            Subtotal = 0;
            ReceiptTb.AppendText(Environment.NewLine);
            ReceiptTb.AppendText("\t\t\tCODESPACE RESTAURENT\t\t" +Datelbl.Text+ Environment.NewLine);
            ReceiptTb.AppendText("\t\t\t******************************" + Environment.NewLine);
            if(BurgerCb.Checked == true)
            {
                ReceiptTb.AppendText("\tBurger:" + burgertp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + burgertp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (SaladCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSalad:" + saladtp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + saladtp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (ChickenCb.Checked == true)
            {
                ReceiptTb.AppendText("\tChicken:" + chickentp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + chickentp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (SandwichCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSandwich:" + sandwichtp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + sandwichtp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (ChickenCb.Checked == true)
            {
                ReceiptTb.AppendText("\tChees:" + cheestp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + cheestp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (FriesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tFries:" + friestp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + friestp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (TeaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tTea:" + teatp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + teatp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (ColaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCola:" + cocatp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + cocatp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (WaterCb.Checked == true)
            {
                ReceiptTb.AppendText("\tWater:" + watertp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + watertp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (ChocolateCb.Checked == true)
            {
                ReceiptTb.AppendText("\tChocolate:" + chocalatetp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + chocalatetp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (PancakeCb.Checked == true)
            {
                ReceiptTb.AppendText("\tPancake:" + pancaketp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + pancaketp;
                Subtotallbl.Text = "" + Subtotal;

            }
            if (OrangeCb.Checked == true)
            {
                ReceiptTb.AppendText("\tOrange:" + orangetp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + orangetp;
                Subtotallbl.Text = "" + Subtotal;
            }

            Tax = Subtotal * 0.16;
            grdtotal = Subtotal + Tax;
            taxlbl.Text = "Rs" + Tax;
            Grdtotallbl.Text = "Rs" + grdtotal;
   


            
            
        }
    }
}
