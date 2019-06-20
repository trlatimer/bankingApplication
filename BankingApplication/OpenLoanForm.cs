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
        public MainForm mainForm = null;
        public User currentUser = null;
        public Member currentMember = null;
        public Member jointMember = null;

        public OpenLoanForm()
        {
            InitializeComponent();
        }

        private void ShareCancelButton_Click(object sender, EventArgs e)
        {
            mainForm.Enabled = true;
            mainForm.Show();
            this.Close();
        }

        private void LoanAPR_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loanAmount.Text) || string.IsNullOrWhiteSpace(loanTermTextBox.Text) || string.IsNullOrWhiteSpace(loanAPR.Text))
            {
                return;
            }
            loanPaymentTextBox.Text = Loan.calculatePayment(Convert.ToDouble(loanAmount.Text.Replace("$", string.Empty).Replace(",", string.Empty)),
                Convert.ToInt32(loanTermTextBox.Text), Convert.ToDouble(loanAPR.Text)).ToString("$###,###,##0.00");
            loanTotalToPayTextBox.Text = Loan.calculateTotalCost(Convert.ToDouble(loanAmount.Text.Replace("$", string.Empty).Replace(",", string.Empty)), Convert.ToInt32(loanTermTextBox.Text), Convert.ToDouble(loanAPR.Text)).ToString("$###,###,##0.00");
            loanPayoffAmountTextBox.Text = Loan.calculatePayoffAmount(Convert.ToDouble(loanAmount.Text.Replace("$", string.Empty).Replace(",", string.Empty)), Convert.ToDouble(loanAPR.Text)).ToString("$###,###,##0.00");
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

        private void OpenLoanForm_Load(object sender, EventArgs e)
        {
            memberNameTextBox.Text = currentMember.FirstName + " " + currentMember.LastName;
            memberSSNTextBox.Text = currentMember.SocialSecurityNumber.ToString("###-##-####");
            memberDOBPicker.Value = currentMember.Birthdate;
            jointDOBPicker.Value = jointDOBPicker.MinDate;
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
                jointSSNTextBox.Text = jointMember.SocialSecurityNumber.ToString("###-##-####");
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

        private void ShareSubmitButton_Click(object sender, EventArgs e)
        {
            if (loanJointCheckBox.Checked == false)
            {
                DataHelper.CreateLoan(currentMember.MemberID, loanTypeComboBox.SelectedItem.ToString(), loanDescTextBox.Text, Convert.ToDouble(loanAmount.Text.Replace("$", string.Empty).Replace(",", string.Empty)),
                    Convert.ToDouble(loanAPR.Text), Convert.ToInt32(loanTermTextBox.Text), Convert.ToInt32(loanDayDue.Text), currentUser.GetUserID());
            }
            else
            {
                DataHelper.CreateLoan(currentMember.MemberID, loanTypeComboBox.SelectedItem.ToString(), loanDescTextBox.Text, Convert.ToDouble(loanAmount.Text.Replace("$", string.Empty).Replace(",", string.Empty)),
                    Convert.ToDouble(loanAPR.Text), Convert.ToInt32(loanTermTextBox.Text), Convert.ToInt32(loanDayDue.Text), currentUser.GetUserID(), jointMember.MemberID);
            }
            Console.WriteLine($"Account created for, {currentMember.FirstName} {currentMember.LastName}, by user {currentUser.GetUserID()}");
            mainForm.Enabled = true;
            mainForm.Show();
            mainForm.PopulateData();
            this.Close();
        }
    }
}
