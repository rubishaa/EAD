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
    public partial class frmAddUpdate : Form
    {
        public Summary sumForm { get; private set; }

        public frmAddUpdate(Summary summaryForm)
        {
            InitializeComponent();
            sumForm = summaryForm;
        }

        //on add buttonclick
        private void button1_Click(object sender, EventArgs e)
        {
            if (validateEntry())
            {
                sumForm.addTransaction(dtpAdd.Value.Date, cmbType.Text, cmbCat.Text, txtAmnt.Text, txtDes.Text);

                if (!sumForm.getError())
                {
                    MessageBox.Show("Successfully Added");
                }
            }
            else
            {
                MessageBox.Show("Please fill the Type, Category and Amount");              
            }
        }

        /// <summary>
        /// load the selected row's current values for update
        /// </summary>
        /// <param name="updateRow"> slectedrow for update</param>

        public void loadValues(DataGridViewRow updateRow)
        {
            DataGridViewRow selectedRow = new DataGridViewRow();
            selectedRow = updateRow;
            dtpAdd.Text = selectedRow.Cells[0].Value.ToString() ;
            cmbType.Text = selectedRow.Cells[1].Value.ToString();
            cmbCat.Text = selectedRow.Cells[2].Value.ToString();
            txtAmnt.Text = selectedRow.Cells[3].Value.ToString();
            txtDes.Text = selectedRow.Cells[4].Value.ToString();

        }

        //onUpdate button click

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validateEntry())
            {
                sumForm.deleteRow();
                sumForm.addTransaction(dtpAdd.Value, cmbType.Text, cmbCat.Text, txtAmnt.Text, txtDes.Text);
                MessageBox.Show("Successfully Updated");
            }
            else
            {
                MessageBox.Show("Please fill the Type, Category and Amount");
            }
        }

        /// <summary>
        /// Based on the selected operation ADD or Update disable the other button
        /// </summary>
        /// <param name="func"> variable to identify the add or update functions</param>
        public void calledFunctions(int func)
        {
            if (func == 1)
            {
                btnAdd2.Enabled = true;
                btnUpdate.Enabled = false;
            }
            else if (func == 2)
            {
                btnAdd2.Enabled = false;
                btnUpdate.Enabled = true;
            }
            else 
            {

            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedType = cmbType.SelectedIndex;
            cmbCat.Items.Clear();
            if (selectedType == 0)
            {
                cmbCat.Items.Add("Salary");
                cmbCat.Items.Add("Interest");
                cmbCat.Items.Add("Other Income");
            }
            else if (selectedType == 1)
            {
                cmbCat.Items.Add("Food");
                cmbCat.Items.Add("Clothes");
                cmbCat.Items.Add("Transport");
                cmbCat.Items.Add("Entertainment");
                cmbCat.Items.Add("Other Expenses");
            }
            else if (selectedType == 2)
            {
                cmbCat.Items.Add("Bank");
                cmbCat.Items.Add("Cash");
                cmbCat.Items.Add("Other Savings");
            }
            
        }

        private bool validateEntry()
        {
            if (cmbType.SelectedIndex == -1)
            {
                return false;
            }

            if (cmbCat.SelectedIndex == -1)
            {
                return false;
            }

            if (txtAmnt.Text == null || txtAmnt.Text == "")
            {
                return false;
            }
            return true;
        }
    }
}
