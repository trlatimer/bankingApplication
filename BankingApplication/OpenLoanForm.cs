using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class OpenLoanForm : BankingApp_BaseForms.loanBaseForm
    {
        // Store calling form, current user, current member
        public Form originatingForm = null;
        public User currentUser = null;
        public Member currentMember = null;
        public Member jointMember = null;

        // Constructor
        public OpenLoanForm()
        {
            InitializeComponent();
        }

        // Cancel Click
        private void ShareCancelButton_Click(object sender, EventArgs e)
        {
            // Return to calling form
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        // APR Leave
        private void LoanAPR_Leave(object sender, EventArgs e)
        {
            // Recalculate loan summary details
            CalculateDetails();
        }

        // Day Due Leave
        private void LoanDayDue_Leave(object sender, EventArgs e)
        {
            // If contains values
            if (!string.IsNullOrWhiteSpace(loanDayDue.Text))
            {
                // Format to appropriate next day due
                loanPayoffDatePicker.Value = Convert.ToDateTime(
                DateTime.Today.AddMonths(1).Month +
                "/" + Convert.ToInt32(loanDayDue.Text) +
                "/" + DateTime.Today.AddMonths(1).Year).AddMonths(Convert.ToInt32(loanTermTextBox.Text));
            }
        }

        // Form Load
        private void OpenLoanForm_Load(object sender, EventArgs e)
        {
            // Populate data on form
            memberNameTextBox.Text = currentMember.FirstName + " " + currentMember.LastName;
            memberSSNTextBox.Text = currentMember.SocialSecurityNumber;
            memberDOBPicker.Value = currentMember.Birthdate;
            jointDOBPicker.Value = jointDOBPicker.MinDate;
        }

        // Joint CheckBox Checked Changed
        private void LoanJointCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If joint, prompt for joint ID
            if (loanJointCheckBox.Checked == true)
            {
                string response = MainForm.ShowDialog("Enter joint ID:", "Add Joint");

                try
                {
                    // Attempt to retrieve joint informatoin
                    jointMember = DataHelper.GetMember(Convert.ToInt32(response));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to locate user with that UserID. Please try again. \n" + ex.Message, "Locate Error");
                    return;
                }
                // Populate joint details on form
                joinInfoGroupBox.Enabled = true;
                jointNameTextBox.Text = jointMember.FirstName + " " + jointMember.LastName;
                jointSSNTextBox.Text = jointMember.SocialSecurityNumber;
                jointDOBPicker.Value = jointMember.Birthdate;
            }
            else
            {
                // Set joint details to empty
                joinInfoGroupBox.Enabled = false;
                jointNameTextBox.Text = "";
                jointSSNTextBox.Text = "";
                jointDOBPicker.Value = jointDOBPicker.MinDate;
            }
        }

        // Submit Click
        private void ShareSubmitButton_Click(object sender, EventArgs e)
        {
            // If joint, create loan with joint parameters
            if (loanJointCheckBox.Checked == false)
            {
                DataHelper.CreateLoan(currentMember.MemberID, loanTypeComboBox.SelectedItem.ToString(), loanDescTextBox.Text, Convert.ToDouble(loanAmount.Text.Replace("$", string.Empty).Replace(",", string.Empty)),
                    Convert.ToDouble(loanAPR.Text), Convert.ToInt32(loanTermTextBox.Text), Convert.ToInt32(loanDayDue.Text), currentUser.GetUserID());
            }
            // If no joint, create loan without joint parameters
            else
            {
                DataHelper.CreateLoan(currentMember.MemberID, loanTypeComboBox.SelectedItem.ToString(), loanDescTextBox.Text, Convert.ToDouble(loanAmount.Text.Replace("$", string.Empty).Replace(",", string.Empty)),
                    Convert.ToDouble(loanAPR.Text), Convert.ToInt32(loanTermTextBox.Text), Convert.ToInt32(loanDayDue.Text), currentUser.GetUserID(), jointMember.MemberID);
            }
            // Log loan creation
            Console.WriteLine($"Account created for, {currentMember.FirstName} {currentMember.LastName}, by user {currentUser.GetUserID()}");
            // Return to calling form
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        // Term Changed
        private void LoanTermTextBox_TextChanged(object sender, EventArgs e)
        {
            // Recalculate loan summary
            CalculateDetails();
        }

        // Amount Changed
        private void LoanAmount_TextChanged(object sender, EventArgs e)
        {
            // Recalculate loan summary
            CalculateDetails();
        }

        // Calculate loan summary details
        public void CalculateDetails()
        {
            // If any of the necessary fields are empty, cancel calculation
            if (string.IsNullOrWhiteSpace(loanAmount.Text) || string.IsNullOrWhiteSpace(loanTermTextBox.Text) || string.IsNullOrWhiteSpace(loanAPR.Text))
            {
                return;
            }
            // Calculate loan payments
            loanPaymentTextBox.Text = Loan.CalculatePayment(Convert.ToDouble(loanAmount.Text.Replace("$", string.Empty).Replace(",", string.Empty)),
                Convert.ToInt32(loanTermTextBox.Text), Convert.ToDouble(loanAPR.Text)).ToString("$###,###,##0.00");
            // Calculate loan total cost
            loanTotalToPayTextBox.Text = Loan.CalculateTotalCost(Convert.ToDouble(loanAmount.Text.Replace("$", string.Empty).Replace(",", string.Empty)), Convert.ToInt32(loanTermTextBox.Text), Convert.ToDouble(loanAPR.Text)).ToString("$###,###,##0.00");
            // Calculate current loan payoff
            loanPayoffAmountTextBox.Text = Loan.CalculatePayoffAmount(Convert.ToDouble(loanAmount.Text.Replace("$", string.Empty).Replace(",", string.Empty)), Convert.ToDouble(loanAPR.Text)).ToString("$###,###,##0.00");
        }

        private void OpenLoanForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            originatingForm.Enabled = true;
            originatingForm.Show();
        }
    }
}
