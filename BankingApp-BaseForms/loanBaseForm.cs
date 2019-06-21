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
        public loanBaseForm()
        {
            InitializeComponent();
        }


        public bool ValidateForm()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(loanDescTextBox.Text))
            {
                MessageBox.Show("The loan must have a description/name. Please enter one and try again.");
                loanDescTextBox.BackColor = Color.Salmon;
                isValid = false;
            }

            if (loanTypeComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("A loan type must be selected.");
                loanTypeComboBox.BackColor = Color.Salmon;
                isValid = false;
            }

            if (!double.TryParse(loanAmount.Text, out double value))
            {
                MessageBox.Show("Amount must only contain numbers.");
                loanAmount.BackColor = Color.Salmon;
                isValid = false;
            }

            if (!int.TryParse(loanTermTextBox.Text, out int digits))
            {
                MessageBox.Show("Loan terms must be in whole digits and only contain numbers.");
                loanTermTextBox.BackColor = Color.Salmon;
                isValid = false;
            }

            if (!double.TryParse(loanAPR.Text, out value))
            {
                MessageBox.Show("Loan APR must only contain numbers");
                loanAPR.BackColor = Color.Salmon;
                isValid = false;
            }

            if (!int.TryParse(loanDayDue.Text, out digits))
            {
                MessageBox.Show("Loan Day Due must contain whole numbers.");
                loanDayDue.BackColor = Color.Salmon;
                isValid = false;
            } else if (Convert.ToInt32(loanDayDue.Text) < 1 || Convert.ToInt32(loanDayDue.Text) > 28)
            {
                MessageBox.Show("Loan Day Due must be between 1 and 28.");
                loanDayDue.BackColor = Color.Salmon;
                isValid = false;
            }
            return isValid;
        }

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

        private void LoanTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loanTypeComboBox.SelectedIndex > -1)
            {
                loanTypeComboBox.BackColor = Color.White;
            }
        }

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

        private void LoanAmount_Leave(object sender, EventArgs e)
        {
            //double amount = 0.0d;
            if (Double.TryParse(loanAmount.Text, System.Globalization.NumberStyles.Currency, null, out double amount))
            {
                loanAmount.Text = amount.ToString("C");
            }
        }
    }
}
