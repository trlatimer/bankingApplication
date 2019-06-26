using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp_BaseForms
{
    public partial class loanBaseForm : Form
    {
        // Constructor
        public loanBaseForm()
        {
            InitializeComponent();
        }

        // Validate inputs on form
        public bool ValidateForm()
        {
            bool isValid = true;

            // Check if Description is null
            if (string.IsNullOrWhiteSpace(loanDescTextBox.Text))
            {
                MessageBox.Show("The loan must have a description/name. Please enter one and try again.");
                loanDescTextBox.BackColor = Color.Salmon;
                isValid = false;
            }

            // Check that a type has been selected
            if (loanTypeComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("A loan type must be selected.");
                loanTypeComboBox.BackColor = Color.Salmon;
                isValid = false;
            }

            // Verify that the loan amount contains integers and no other characters
            if (!double.TryParse(loanAmount.Text, out double value))
            {
                MessageBox.Show("Amount must only contain numbers.");
                loanAmount.BackColor = Color.Salmon;
                isValid = false;
            }

            // Verify that the loan term contains only integers
            if (!int.TryParse(loanTermTextBox.Text, out int digits))
            {
                MessageBox.Show("Loan terms must be in whole digits and only contain numbers.");
                loanTermTextBox.BackColor = Color.Salmon;
                isValid = false;
            }

            // Verify that APR contains only numerical values and decimal
            if (!double.TryParse(loanAPR.Text, out value))
            {
                MessageBox.Show("Loan APR must only contain numbers");
                loanAPR.BackColor = Color.Salmon;
                isValid = false;
            }

            // Verify that the DayDue only contains numbers
            if (!int.TryParse(loanDayDue.Text, out digits))
            {
                MessageBox.Show("Loan Day Due must contain whole numbers.");
                loanDayDue.BackColor = Color.Salmon;
                isValid = false;
            // If it only contains numbers, ensure it is within the accepted days of the month
            } else if (Convert.ToInt32(loanDayDue.Text) < 1 || Convert.ToInt32(loanDayDue.Text) > 28)
            {
                MessageBox.Show("Loan Day Due must be between 1 and 28.");
                loanDayDue.BackColor = Color.Salmon;
                isValid = false;
            }
            // return whether or not any of the checks failed
            return isValid;
        }

        // If loan description changes, ensure it has a value
        private void LoanDescTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loanDescTextBox.Text))
            {
                loanDescTextBox.BackColor = Color.Salmon;
            } else
            {
                loanDescTextBox.BackColor = Color.White;
            }
        }

        // If loan amount changes, ensure it has a value
        private void LoanAmount_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loanAmount.Text))
            {
                loanAmount.BackColor = Color.Salmon;
            }
            else
            {
                loanAmount.BackColor = Color.White;
            }
        }

        // If type selection changes, ensure it is at least index 0
        private void LoanTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loanTypeComboBox.SelectedIndex > -1)
            {
                loanTypeComboBox.BackColor = Color.White;
            }
        }

        // If term is changed, ensure it contains a value
        private void LoanTermTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loanTermTextBox.Text))
            {
                loanTermTextBox.BackColor = Color.Salmon;
            }
            else
            {
                loanTermTextBox.BackColor = Color.White;
            }
        }

        // if APR changes, ensure it contains a value
        private void LoanAPR_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loanAPR.Text))
            {
                loanAPR.BackColor = Color.Salmon;
            }
            else
            {
                loanAPR.BackColor = Color.White;
            }
        }

        // if DayDue changes, ensure it contains a value
        private void LoanDayDue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loanDayDue.Text))
            {
                loanDayDue.BackColor = Color.Salmon;
            }
            else
            {
                loanDayDue.BackColor = Color.White;
            }
        }

        // When leaving loan amount, convert value to current format
        private void LoanAmount_Leave(object sender, EventArgs e)
        {
            // Ensure that value only contains numbers and a decimal
            if (Double.TryParse(loanAmount.Text, System.Globalization.NumberStyles.Currency, null, out double amount))
            {
                loanAmount.Text = amount.ToString("C");
            }
        }
    }
}
