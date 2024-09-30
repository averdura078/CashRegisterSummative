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

        //easter egg
        int clickCounter = 2;

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
            subtotalOutput.BackColor = Color.Transparent;
            taxOutput.BackColor = Color.Transparent;
            totalpriceOutput.BackColor = Color.Transparent;
            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalpriceOutput.Text = "";
            Refresh();
            Thread.Sleep(200);
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
                Refresh();
                Thread.Sleep(250);
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                Refresh();
                Thread.Sleep(250);
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

                //keep other buttons disabled
                changeButton.Enabled = false;
                printReceiptButton.Enabled = false;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            //reset from error
            changeOutput.BackColor = Color.Transparent;
            changeOutput.Text = "";

            try
            {
                //play sound effect
                SoundPlayer sp = new SoundPlayer(Properties.Resources.success);
                sp.Play();

                //convert user text input to an integer
                tenderedAmount = Convert.ToInt16(tenderedInput.Text);

                if (tenderedAmount < totalCost)
                {
                    SoundPlayer sp2 = new SoundPlayer(Properties.Resources.error);
                    sp2.Play();
                    changeOutput.BackColor = Color.Red;
                    changeOutput.Text = $"INPUT ERROR";
                    printReceiptButton.Enabled = false;
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
                changeOutput.Text = $"INPUT ERROR";
                changeOutput.BackColor = Color.Red;

                //play error sound effect
                SoundPlayer sp = new SoundPlayer(Properties.Resources.error);
                sp.Play();

                //keep next button disabled
                printReceiptButton.Enabled = false;
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

            //play chaching sound
            SoundPlayer sp2 = new SoundPlayer(Properties.Resources.chaching);
            sp2.Play();
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //play sound effect
            SoundPlayer sp = new SoundPlayer(Properties.Resources.success);
            sp.Play();

            //empty all text (reset for new inputs)
            canvasesInput.Text = $"";
            pencilsInput.Text = $"";
            paintsInput.Text = $"";

            subtotalOutput.Text = $"";
            taxOutput.Text = $"";
            totalpriceOutput.Text = $"";

            tenderedInput.Text = $"";
            changeOutput.Text = $"";

            receiptOutput.Text = $"";

            //reset from error
            subtotalOutput.BackColor = Color.Transparent;
            taxOutput.BackColor = Color.Transparent;
            totalpriceOutput.BackColor = Color.Transparent;
            subtotalOutput.Font = new Font("Microsoft Uighur", 18, FontStyle.Regular);
            changeOutput.BackColor = Color.Transparent;
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            clickCounter += +1;

            //empty all text (function as a second "NEW ORDER" button)
            canvasesInput.Text = $"";
            pencilsInput.Text = $"";
            paintsInput.Text = $"";

            subtotalOutput.Text = $"";
            taxOutput.Text = $"";
            totalpriceOutput.Text = $"";

            tenderedInput.Text = $"";
            changeOutput.Text = $"";

            receiptOutput.Text = $"";

            if (clickCounter % 3 == 1)
            {
                BackColor = Color.LightSeaGreen;
                titleLabel.BackColor = Color.Orange;
                totalsButton.BackColor = Color.Orange;
                changeButton.BackColor = Color.Orange;
                printReceiptButton.BackColor = Color.Orange;
                newOrderButton.BackColor = Color.Orange;

                subtotalOutput.BackColor = Color.LightSeaGreen;
                taxOutput.BackColor = Color.LightSeaGreen;
                totalpriceOutput.BackColor = Color.LightSeaGreen;
            }
            else if (clickCounter % 3 == 2)
            {
                BackColor = Color.LightSkyBlue;
                titleLabel.BackColor = Color.Thistle;
                totalsButton.BackColor = Color.Thistle;
                changeButton.BackColor = Color.Thistle;
                printReceiptButton.BackColor = Color.Thistle;
                newOrderButton.BackColor = Color.Thistle;

                subtotalOutput.BackColor = Color.LightSkyBlue;
                taxOutput.BackColor = Color.LightSkyBlue;
                totalpriceOutput.BackColor = Color.LightSkyBlue;
            }
            else
            {
                BackColor = Color.DeepPink;
                titleLabel.BackColor = Color.LightPink;
                totalsButton.BackColor = Color.LightPink;
                changeButton.BackColor = Color.LightPink;
                printReceiptButton.BackColor = Color.LightPink;
                newOrderButton.BackColor = Color.LightPink;

                subtotalOutput.BackColor = Color.DeepPink;
                taxOutput.BackColor = Color.DeepPink;
                totalpriceOutput.BackColor = Color.DeepPink;
            }
        }
    }
}
