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
    public partial class MainForm : Form
    {
        public static LoginForm loginForm = null;

        public User currentUser = null;

        public MainForm()
        {
            InitializeComponent();
        }

        //
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
