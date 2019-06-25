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
        public Form originatingForm = null;
        public User currentUser = null;
        public Member currentMember = null;
        public Member jointMember = null;
        public Loan currentLoan = null;

        public EditLoanForm()
        {
            InitializeComponent();
        }

        private void ShareCancelButton_Click(object sender, EventArgs e)
        {
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        private void EditLoanForm_Load(object sender, EventArgs e)
        {
            memberNameTextBox.Text = currentMember.FirstName + " " + currentMember.LastName;
            memberSSNTextBox.Text = currentMember.SocialSecurityNumber;
            memberDOBPicker.Value = currentMember.Birthdate;
            loanDescTextBox.Text = currentLoan.Description;
            loanTypeComboBox.SelectedItem = currentLoan.LoanType;
            loanAmount.Text = currentLoan.StartingBalance.ToString("$###,###,##0.00");
            loanTermTextBox.Text = currentLoan.TermLength.ToString();
            loanAPR.Text = currentLoan.APR.ToString("#0.000");
            loanDayDue.Text = currentLoan.DayDue.ToString();
            CalculateDetails();
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

        public void CalculateDetails()
        {
            if (string.IsNullOrWhiteSpace(loanAmount.Text) || string.IsNullOrWhiteSpace(loanTermTextBox.Text) || string.IsNullOrWhiteSpace(loanAPR.Text))
            {
                return;
            }
            loanPaymentTextBox.Text = Loan.CalculatePayment(Convert.ToDouble(loanAmount.Text.Replace("$", string.Empty).Replace(",", string.Empty)),
                Convert.ToInt32(loanTermTextBox.Text), Convert.ToDouble(loanAPR.Text)).ToString("$###,###,##0.00");
            loanTotalToPayTextBox.Text = Loan.CalculateTotalCost(Convert.ToDouble(loanAmount.Text.Replace("$", string.Empty).Replace(",", string.Empty)), Convert.ToInt32(loanTermTextBox.Text), Convert.ToDouble(loanAPR.Text)).ToString("$###,###,##0.00");
            loanPayoffAmountTextBox.Text = Loan.CalculatePayoffAmount(Convert.ToDouble(loanAmount.Text.Replace("$", string.Empty).Replace(",", string.Empty)), Convert.ToDouble(loanAPR.Text)).ToString("$###,###,##0.00");
        }

        private void LoanAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateDetails();
        }

        private void LoanTermTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateDetails();
        }

        private void LoanAPR_TextChanged(object sender, EventArgs e)
        {
            CalculateDetails();
        }

        private void ShareSubmitButton_Click(object sender, EventArgs e)
        {
            if (loanJointCheckBox.Checked == false)
            {
                DataHelper.UpdateLoan(currentLoan.LoanID, loanTypeComboBox.SelectedItem.ToString(), loanDescTextBox.Text, Convert.ToDouble(loanAPR.Text), 
                    Convert.ToInt32(loanTermTextBox.Text), Convert.ToInt32(loanDayDue.Text), currentUser.GetUserID());
            }
            else
            {
                DataHelper.UpdateLoan(currentLoan.LoanID, loanTypeComboBox.SelectedItem.ToString(), loanDescTextBox.Text, Convert.ToDouble(loanAPR.Text), 
                    Convert.ToInt32(loanTermTextBox.Text), Convert.ToInt32(loanDayDue.Text), currentUser.GetUserID(), currentLoan.JointMemberID);
            }
            Console.WriteLine($"Account updated for, {currentMember.FirstName} {currentMember.LastName}, by user {currentUser.GetUserID()}");
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        private void LoanJointCheckBox_CheckedChanged(object sender, EventArgs e)
        {
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

                joinInfoGroupBox.Enabled = true;
                jointNameTextBox.Text = jointMember.FirstName + " " + jointMember.LastName;
                jointSSNTextBox.Text = jointMember.SocialSecurityNumber;
                jointDOBPicker.Value = jointMember.Birthdate;
            }
            else
            {
                joinInfoGroupBox.Enabled = false;
                jointNameTextBox.Text = "";
                jointSSNTextBox.Text = "";
                jointDOBPicker.Value = jointDOBPicker.MinDate;
            }
        }

        private void LoanDayDue_Leave(object sender, EventArgs e)
        {
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
