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
    public partial class SearchForm : Form
    {
        // Store calling form
        public Form originatingForm = null;

        // Constructor
        public SearchForm()
        {
            InitializeComponent();
        }

        // Back Click
        private void SearchBackButton_Click(object sender, EventArgs e)
        {
            // Return to calling form
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        // Submit Click
        private void SearchSubmitButton_Click(object sender, EventArgs e)
        {
            // Store returned members
            DataTable members = new DataTable();
            // Ensure that a search option has been selected
            if (searchByComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please specify how you wish to search and try again.");
                return;
            }
            // Ensure the search text contains values
            if (string.IsNullOrWhiteSpace(searchTextTextBox.Text))
            {
                MessageBox.Show("A value must be entered in the search text. Please try again.");
                return;
            }

            // Determine which method is selected for searching
            switch (searchByComboBox.SelectedItem.ToString())
            {
                case "Member ID":
                    // Ensure a number was entered
                    if (int.TryParse(searchTextTextBox.Text, out int value))
                    {
                        // Retrieve members matching the ID entered
                        members = DataHelper.SearchByID(Convert.ToInt32(searchTextTextBox.Text));
                    } else
                    {
                        MessageBox.Show("Search text must be numbers in order to search by ID");
                        return;
                    }
                    break;
                case "Name":
                    // Retrieve members with similar names to the one entered
                    members = DataHelper.SearchByName(searchTextTextBox.Text);
                    break;
                case "Social Security Number":
                    // Retrieve members with similar SSN's to the one entered
                    members = DataHelper.SearchBySSN(searchTextTextBox.Text);
                    break;
            }

            // If no members are found, display message
            if (members.Rows.Count < 1)
            {
                MessageBox.Show("No members found matching that criteria. Please try again.");
                return;
            }
            // Populate DGV with returned members
            searchResultsDGV.DataSource = members;
        }
    }
}
