using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar  = true;
        }

        public Summary summaryForm { get; private set; }

        /// <summary>
        /// perform username and pasword validation on login click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "Sha" && txtPassword.Text == "123")
            {
                summaryForm = new Summary();
                summaryForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Invalid Login",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
