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
    public partial class EditLoanForm : BankingApp_BaseForms.loanBaseForm
    {
        // Store callin form
        public Form originatingForm = null;
        // Store current user and member
        public User currentUser = null;
        public Member currentMember = null;
        // Store joint member information
        public Member jointMember = null;
        // Store selected loan information
        public Loan currentLoan = null;

        // Constructor
        public EditLoanForm()
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

        // Form Load
        private void EditLoanForm_Load(object sender, EventArgs e)
        {
            // Set values to existing loan and member information
            memberNameTextBox.Text = currentMember.FirstName + " " + currentMember.LastName;
            memberSSNTextBox.Text = currentMember.SocialSecurityNumber;
            memberDOBPicker.Value = currentMember.Birthdate;
            loanDescTextBox.Text = currentLoan.Description;
            loanTypeComboBox.SelectedItem = currentLoan.LoanType;
            loanAmount.Text = currentLoan.StartingBalance.ToString("$###,###,##0.00");
            loanTermTextBox.Text = currentLoan.TermLength.ToString();
            loanAPR.Text = currentLoan.APR.ToString("#0.000");
            loanDayDue.Text = currentLoan.DayDue.ToString();
            // Calculate payments and other details in summary
            CalculateDetails();
            // If joint member exists, set values to joint information
            if (currentLoan.JointMemberID != 0)
            {
                joinInfoGroupBox.Enabled = true;
                loanJointCheckBox.CheckedChanged -= LoanJointCheckBox_CheckedChanged;
                loanJointCheckBox.Checked = true;
                loanJointCheckBox.CheckedChanged += LoanJointCheckBox_CheckedChanged;
                jointMember = DataHelper.GetMember(Convert.ToInt32(currentLoan.JointMemberID));
                jointDOBPicker.Value = jointMember.Birthdate;
                jointNameTextBox.Text = currentLoan.JointMemberName;
                jointSSNTextBox.Text = currentLoan.JointMemberSSN;
            }
            else
            {
                jointDOBPicker.Value = jointDOBPicker.MinDate;
            }
        }

        // Calculate loan summary information
        public void CalculateDetails()
        {
            // If inputs are not empty, calculate
            if (string.IsNullOrWhiteSpace(loanAmount.Text) || string.IsNullOrWhiteSpace(loanTermTextBox.Text) || string.IsNullOrWhiteSpace(loanAPR.Text))
            {
                return;
            }
            // Calculate loan payment
            loanPaymentTextBox.Text = Loan.CalculatePayment(Convert.ToDouble(loanAmount.Text.Replace("$", string.Empty).Replace(",", string.Empty)),
                Convert.ToInt32(loanTermTextBox.Text), Convert.ToDouble(loanAPR.Text)).ToString("$###,###,##0.00");
            // Calculate loan total cost
            loanTotalToPayTextBox.Text = Loan.CalculateTotalCost(Convert.ToDouble(loanAmount.Text.Replace("$", string.Empty).Replace(",", string.Empty)), Convert.ToInt32(loanTermTextBox.Text), Convert.ToDouble(loanAPR.Text)).ToString("$###,###,##0.00");
            // Calculate loan payoff
            loanPayoffAmountTextBox.Text = Loan.CalculatePayoffAmount(Convert.ToDouble(loanAmount.Text.Replace("$", string.Empty).Replace(",", string.Empty)), Convert.ToDouble(loanAPR.Text)).ToString("$###,###,##0.00");
        }

        // Loan Amount Text Changed
        private void LoanAmount_TextChanged(object sender, EventArgs e)
        {
            // Recalculate loan summary if all information is provided
            CalculateDetails();
        }

        // Loan Term Text Changed
        private void LoanTermTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateDetails();
        }

        // Loan APR Text Changed
        private void LoanAPR_TextChanged(object sender, EventArgs e)
        {
            CalculateDetails();
        }

        // Submit Button Click
        private void ShareSubmitButton_Click(object sender, EventArgs e)
        {
            // If no joint, update loan without joint info
            if (loanJointCheckBox.Checked == false)
            {
                DataHelper.UpdateLoan(currentLoan.LoanID, loanTypeComboBox.SelectedItem.ToString(), loanDescTextBox.Text, Convert.ToDouble(loanAPR.Text), 
                    Convert.ToInt32(loanTermTextBox.Text), Convert.ToInt32(loanDayDue.Text), currentUser.GetUserID());
            }
            // If joint, update loan with joint info
            else
            {
                DataHelper.UpdateLoan(currentLoan.LoanID, loanTypeComboBox.SelectedItem.ToString(), loanDescTextBox.Text, Convert.ToDouble(loanAPR.Text), 
                    Convert.ToInt32(loanTermTextBox.Text), Convert.ToInt32(loanDayDue.Text), currentUser.GetUserID(), currentLoan.JointMemberID);
            }
            // Log account update
            Console.WriteLine($"Account updated for, {currentMember.FirstName} {currentMember.LastName}, by user {currentUser.GetUserID()}");
            // Return to calling form
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }
        
        // Joint CheckBox Checked Changed
        private void LoanJointCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If now true, prompt for joint ID, obtain joint info, and populate info on form
            if (loanJointCheckBox.Checked == true)
            {
                string response = MainForm.ShowDialog("Enter joint ID:", "Add Joint");

                try
                {
                    jointMember = DataHelper.GetMember(Convert.ToInt32(response));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to locate user with that UserID. Please try again. \n" + ex.Message, "Locate Error");
                    return;
                }

                // Set inputs to values obtained from database
                joinInfoGroupBox.Enabled = true;
                jointNameTextBox.Text = jointMember.FirstName + " " + jointMember.LastName;
                jointSSNTextBox.Text = jointMember.SocialSecurityNumber;
                jointDOBPicker.Value = jointMember.Birthdate;
            }
            else
            {
                // If no joint, set joint info to blank
                joinInfoGroupBox.Enabled = false;
                jointNameTextBox.Text = "";
                jointSSNTextBox.Text = "";
                jointDOBPicker.Value = jointDOBPicker.MinDate;
            }
        }

        // Load Day Due Leave
        private void LoanDayDue_Leave(object sender, EventArgs e)
        {
            // If value is entered, format to correct Date format for next occurrence
            if (!string.IsNullOrWhiteSpace(loanDayDue.Text))
            {
                loanPayoffDatePicker.Value = Convert.ToDateTime(
                DateTime.Today.AddMonths(1).Month +
                "/" + Convert.ToInt32(loanDayDue.Text) +
                "/" + DateTime.Today.AddMonths(1).Year).AddMonths(Convert.ToInt32(loanTermTextBox.Text));
            }
        }
    }
}
