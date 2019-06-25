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
        public Form originatingForm = null;

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchBackButton_Click(object sender, EventArgs e)
        {
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        private void SearchSubmitButton_Click(object sender, EventArgs e)
        {
            DataTable members = new DataTable();
            if (searchByComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please specify how you wish to search and try again.");
                return;
            }
            if (string.IsNullOrWhiteSpace(searchTextTextBox.Text))
            {
                MessageBox.Show("A value must be entered in the search text. Please try again.");
                return;
            }

            switch (searchByComboBox.SelectedItem.ToString())
            {
                case "Member ID":
                    if (int.TryParse(searchTextTextBox.Text, out int value))
                    {
                        members = DataHelper.SearchByID(Convert.ToInt32(searchTextTextBox.Text));
                    } else
                    {
                        MessageBox.Show("Search text must be numbers in order to search by ID");
                        return;
                    }
                    break;
                case "Name":
                    members = DataHelper.SearchByName(searchTextTextBox.Text);
                    break;
                case "Social Security Number":
                    members = DataHelper.SearchBySSN(searchTextTextBox.Text);
                    break;
            }

            if (members.Rows.Count < 1)
            {
                MessageBox.Show("No members found matching that criteria. Please try again.");
                return;
            }

            searchResultsDGV.DataSource = members;
        }
    }
}
