using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Major_Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Default APR % on opening
        private void Form1_Load(object sender, EventArgs e)
        {
            aprComboBox.Items.Add("2.5");
            aprComboBox.Items.Add("10");
            aprComboBox.Items.Add("12.5");
            aprComboBox.Items.Add("15");
            aprComboBox.Items.Add("20");
        }

        //In next 3 methods
        //Automatically select all the inputs when clicked in respective textBoxes and comboBox
        private void loanTextBox_Click(object sender, EventArgs e)
        {

            loanTextBox.SelectAll();
        }

        private void aprComboBox_Click(object sender, EventArgs e)
        {
            aprComboBox.SelectAll();
        }


        private void rebateTextBox_Click(object sender, EventArgs e)
        {
            rebateTextBox.SelectAll();
        }

        //In next 3 methods
        //Automatically select all inputs when tabbed to in respective textBoxes and comboBox

        private void loanTextBox_Enter(object sender, EventArgs e)
        {

            loanTextBox.SelectAll();
        }

        private void aprComboBox_Enter(object sender, EventArgs e)
        {

            aprComboBox.SelectAll();
        }

        private void rebateTextBox_Enter(object sender, EventArgs e)
        {

            rebateTextBox.SelectAll();
        }

        //In next 3 methods
        //When any of the inputs are changed in the textBoxes/comboBox, disable the display labels for loan and interest, clear the list box and disable accept loan button
        private void loanTextBox_TextChanged(object sender, EventArgs e)
        {
            loanListBox.Items.Clear();

            acceptBtn.Enabled = false;

            totalLoanlbl.Text = null;
            totalInterestlbl.Text = null;
        }


        private void aprComboBox_TextChanged(object sender, EventArgs e)
        {
            loanListBox.Items.Clear();

            acceptBtn.Enabled = false;

            totalLoanlbl.Text = null;
            totalInterestlbl.Text = null;
        }




        private void rebateTextBox_TextChanged(object sender, EventArgs e)
        {
            loanListBox.Items.Clear();

            acceptBtn.Enabled = false;

            totalLoanlbl.Text = null;
            totalInterestlbl.Text = null;
        }

        //Next three methods only allow backspace digits and period to be entered into the respective textBoxes/ComboBox
        private void loanTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void AprComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void RebateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }
        //The next 4 methods clear the listBox when a radio button is cleared, disables the accept button and disable the labels displaying the loan and interest

        private void radioButton1_Click(object sender, EventArgs e)
        {
            loanListBox.Items.Clear();

            acceptBtn.Enabled = false;

            totalLoanlbl.Text = null;
            totalInterestlbl.Text = null;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            loanListBox.Items.Clear();

            acceptBtn.Enabled = false;

            totalLoanlbl.Text = null;
            totalInterestlbl.Text = null;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            loanListBox.Items.Clear();

            acceptBtn.Enabled = false;

            totalLoanlbl.Text = null;
            totalInterestlbl.Text = null;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            loanListBox.Items.Clear();

            acceptBtn.Enabled = false;

            totalLoanlbl.Text = null;
            totalInterestlbl.Text = null;
        }

        //Enable the rebate textBox when rebateCheckedBox is checked and disable it, clear the rebateTextBox and ListBox when checkBox is unchecked

        private void RebateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rebateCheckBox.Checked)
            
                rebateTextBox.Enabled = true;
            
            else
            
                rebateTextBox.Enabled = false;
                rebateTextBox.Clear();
                loanListBox.Items.Clear();
            

        }

        //Initialize variables to be used in calculating the loan
        double loan, rate, rebateAmount, principalPayment, interest, pmt, totalInterest, totalPrinciple, totalPayment = 0;

        

        int months = 0;

        //Calculate the loan payment and display in loanListBox
        private void calcBtn_Click(object sender, EventArgs e)
        {


           
                //Get input data from textBoxes via tryparse and convert the rate in the comboBox to a double
                double.TryParse(loanTextBox.Text, out loan);
                double.TryParse(rebateTextBox.Text, out rebateAmount);
                rate = Convert.ToDouble(aprComboBox.Text);

                //Get the inputs for radioButtons
                if (radioButton1.Checked)
                {
                    months = 6;
                }
                else if (radioButton2.Checked)
                {
                    months = 12;
                }
                else if (radioButton3.Checked)
                {
                    months = 18;
                }
                else
                {
                    months = 24;
                }

                //validate the inputs given by the user and if not prompt them to enter again and focus the loanTextBox
                if (loan == 0 || rate == 0)
                {
                    MessageBox.Show("Enter a loan and select an APR(%).", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    loanTextBox.Focus();
                }
                else
                {
                    //Clear the loan list box to prevent from running twice by mistake if double-clicked or if user wants to do another loan calculation along with total loan and interest displays
                    loanListBox.Items.Clear();
                    totalInterestlbl.Text = null;
                    totalLoanlbl.Text = null;

                    //Enable accept button after calc
                    acceptBtn.Enabled = true;

                    //Get the listbox to format correctly with the given headers above 
                    string formattedString = "{0,5}{1,12}{2,12}{3,12}{4,12}";
                    loanListBox.Items.Add(string.Format(formattedString, "Months", "Interest", "Princple", "Payment", "Balance"));

                    //loop for loan payment for each month
                    if (rebateCheckBox.Checked)
                    {
                        loan = loan - rebateAmount;
                        rate = rate / 100;

                        int monthCounter = 0;
                        for (monthCounter = 1; monthCounter <= months; monthCounter++)
                        {
                            //Calculate interest payment
                            interest = loan * rate / 12;
                            if (monthCounter == 1)
                            {
                                principalPayment = rate / 12 * (loan + 0 * Math.Pow(1 + rate / 12, months)) / ((Math.Pow(1 + rate /
                                12, months) - 1) * (1 + rate / 12 * 0));
                                pmt = principalPayment + interest;
                            }
                            else
                            {
                                principalPayment = pmt - interest;
                            }

                            //subtract principle payment from loan
                            loan = loan - principalPayment;
                            totalInterest += interest;
                            totalPrinciple += principalPayment;
                            totalPayment += pmt;

                        //Move to other variables
                        ttLoan = totalPrinciple;
                        ttInterest = totalInterest;

                            //Add month, interest, principal, payment, balance for every month into listBox
                            loanListBox.Items.Add(string.Format(formattedString, monthCounter,
                            interest.ToString("C2"), principalPayment.ToString("C2"), pmt.ToString("C2"), loan.ToString("C2")));
                        }

                        //Add line for the total values
                        loanListBox.Items.Add("");
                        loanListBox.Items.Add(string.Format(formattedString, "Total", totalInterest.ToString("C2"), totalPrinciple.ToString("C2"), totalPayment.ToString("C2"), " "));

                    }

                }
            }

        double acceptTotalLoan = 0 , acceptTotalInterest = 0, ttLoan, ttInterest;

        //Accrue all the loans and interest, clear everything and refocus the radio buttons and textbox
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            acceptTotalLoan += ttLoan;
            acceptTotalInterest += ttInterest;
            loanTextBox.Clear();
            aprComboBox.Text = null;
            rebateCheckBox.Checked = false;
            loanListBox.Items.Clear();
            radioButton1.Focus();
            loanTextBox.Focus();
        }

        //Display the total loan and interest when display all loans is pressed
        private void displayBtn_Click(object sender, EventArgs e)
        {
            totalLoanlbl.Text = acceptTotalLoan.ToString("C2");
            totalInterestlbl.Text = acceptTotalInterest.ToString("C2");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    }
    


