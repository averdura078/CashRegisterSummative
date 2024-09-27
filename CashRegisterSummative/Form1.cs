using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegisterSummative
{
    public partial class Form1 : Form
    {
        //global variables

        //prices of three items
        double canvasPrice = 5;
        double pencilPrice = 0.50;
        double paintPrice = 7.99;

        //number of items
        int numOfCanvases = 0;
        int numOfPencils = 0;
        int numOfPaints = 0;

        //before tax
        double subtotalAmount = 0;

        //handling tax
        double taxRate = 0.13;
        double taxAmount = 0;

        //after tax
        double totalCost = 0;

        //change
        double tenderedAmount = 0;
        double changeAmount = 0;

        //3 global variables to hold the 3 different item prices.
        //Global variable to hold total cost of order
        //Global variable to hold tax rate of 13%, (0.13) 
        //Global variable to hold value of tax amount
        //Global variable to hold total cost including tax
        //Initialize all the above variables to 0. 
        //Global variable to hold the amount tendered, (the amount the customer hands over to pay for the bill) 
        //Global variable to hold the amount of change required.

        public Form1()
        {
            InitializeComponent();

            //disable buttons
            changeButton.Enabled = false;
            printReceiptButton.Enabled = false;
        }

        private void totalsButton_Click(object sender, EventArgs e)
        {
            //reset from error
            subtotalOutput.BackColor = Color.LightSkyBlue;
            taxOutput.BackColor = Color.LightSkyBlue;
            totalpriceOutput.BackColor = Color.LightSkyBlue;
            subtotalOutput.Font = new Font("Microsoft Uighur", 18, FontStyle.Regular);

            try
            {
                //play sound effect
                SoundPlayer sp = new SoundPlayer(Properties.Resources.success);
                sp.Play();

                //convert user text inputs to integers
                numOfCanvases = Convert.ToInt16(canvasesInput.Text);
                numOfPencils = Convert.ToInt16(pencilsInput.Text);
                numOfPaints = Convert.ToInt16(paintsInput.Text);

                //calculate
                subtotalAmount = canvasPrice * numOfCanvases + pencilPrice * numOfPencils + paintPrice * numOfPaints;
                taxAmount = taxRate * subtotalAmount;
                totalCost = taxAmount + subtotalAmount;

                //display totals to output labels
                subtotalOutput.Text = $"{subtotalAmount.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalpriceOutput.Text = $"{totalCost.ToString("C")}";

                //enable next button
                changeButton.Enabled = true;

            }
            catch
            {
                //display error message to user
                subtotalOutput.Text = $"INPUT ERROR.";
                subtotalOutput.BackColor = Color.Red;
                subtotalOutput.Font = new Font("Microsoft Uighur", 18, FontStyle.Bold);
                taxOutput.Text = $"Please use numerical";
                taxOutput.BackColor = Color.Red;
                totalpriceOutput.Text = $"values in all boxes.";
                totalpriceOutput.BackColor = Color.Red;

                //play error sound effect
                SoundPlayer sp = new SoundPlayer(Properties.Resources.error);
                sp.Play();
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            //reset from error
            changeOutput.BackColor = Color.LightSkyBlue;

            try
            {
                //play sound effect
                SoundPlayer sp = new SoundPlayer(Properties.Resources.success);
                sp.Play();

                //convert user text input to an integer
                tenderedAmount = Convert.ToInt16(tenderedInput.Text);

                if (tenderedAmount < totalCost)
                {
                    SoundPlayer iferror = new SoundPlayer(Properties.Resources.error);
                    iferror.Play();
                }
                else
                {
                    //calculate change
                    changeAmount = tenderedAmount - totalCost;

                    //display change to output label
                    changeOutput.Text = $"{changeAmount.ToString("C")}";

                    //enable next button
                    printReceiptButton.Enabled = true;
                }
            }
            catch
            {
                //display error message to user
                changeOutput.Text = $"INPUT ERROR.";
                changeOutput.BackColor = Color.Red;

                //play error sound effect
                SoundPlayer sp = new SoundPlayer(Properties.Resources.error);
                sp.Play();
            }

        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            //play sound effect
            SoundPlayer sp = new SoundPlayer(Properties.Resources.success);
            sp.Play();

            //line 1: store name
            SoundPlayer print = new SoundPlayer(Properties.Resources.printline);
            print.Play();
            receiptOutput.Text = $"\n  The Little Art Boutique";
            Refresh();
            Thread.Sleep(750);

            //line 2: today's date
            receiptOutput.Text += $"\n\n{DateTime.Now.DayOfWeek}, {DateTime.Now.ToString("MMMMMMMM")} {DateTime.Now.ToString("dd")}, {DateTime.Now.ToString("yyyy")}";
            //receiptOutput.Text += DateTime.Now.ToString("\nMMMMMMMM dd\"th\" yyyy");
            print.Play();
            Refresh();
            Thread.Sleep(750);

            //line 3: 
            receiptOutput.Text += $"\n\nCanvases       x{canvasesInput.Text} @{canvasPrice.ToString("C")}";
            print.Play();
            Refresh();
            Thread.Sleep(750);

            //line 4:
            receiptOutput.Text += $"\nPencils        x{pencilsInput.Text} @{pencilPrice.ToString("C")}";
            print.Play();
            Refresh();
            Thread.Sleep(750);

            //line 5:
            receiptOutput.Text += $"\nPaints         x{paintsInput.Text} @{paintPrice.ToString("C")}";
            print.Play();
            Refresh();
            Thread.Sleep(750);

            //line 6:
            receiptOutput.Text += $"\n\nSubtotal           {subtotalAmount.ToString("C")}";
            print.Play();
            Refresh();
            Thread.Sleep(750);

            //line 7:
            receiptOutput.Text += $"\nTax                {taxAmount.ToString("C")}";
            print.Play();
            Refresh();
            Thread.Sleep(750);

            //line 8:
            receiptOutput.Text += $"\nTotal              {totalCost.ToString("C")}";
            print.Play();
            Refresh();
            Thread.Sleep(750);

            //line 9:
            receiptOutput.Text += $"\n\nTendered           {tenderedAmount.ToString("C")}";
            print.Play();
            Refresh();
            Thread.Sleep(750);

            //line 10:
            receiptOutput.Text += $"\nChange             {changeAmount.ToString("C")}";
            print.Play();
            Refresh();

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //play error sound effect
            SoundPlayer sp = new SoundPlayer(Properties.Resources.success);
            sp.Play();

            //empty all outputs of text (reset for new inputs)
            canvasesInput.Text = $"";
            pencilsInput.Text = $"";
            paintsInput.Text = $"";

            subtotalOutput.Text = $"";
            taxOutput.Text = $"";
            totalpriceOutput.Text = $"";

            tenderedInput.Text = $"";
            changeOutput.Text = $"";

            receiptOutput.Text = $"";
        }
    }
}
