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
    public partial class OpenAccountForm : Form
    {
        public MainForm mainForm = null;
        public User currentUser = null;

        public OpenAccountForm()
        {
            InitializeComponent();
        }
    }
}
