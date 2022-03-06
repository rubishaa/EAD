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
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
            loadSampleData();            
        }
        
        private void btnTrans_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
           
        }
        public DataTable tabl = new DataTable();
        public DataSet ds = new DataSet();

        public frmAddUpdate frmAdd;
        private void loadSampleData()
        {
            
            //Creating columns
            tabl.Columns.Add("Date", typeof(DateTime));
            tabl.Columns.Add("Type", typeof(string));
            tabl.Columns.Add("Category", typeof(string));
            tabl.Columns.Add("Amount", typeof(float));
            tabl.Columns.Add("Description", typeof(string));
            tabl.Columns.Add("TID", typeof(int));

            tabl.Columns["TID"].AutoIncrement = true;
            tabl.Columns["TID"].AutoIncrementSeed = 1;
            tabl.Columns["TID"].AutoIncrementStep = 1;

            //Adding data in a Datatable.
            tabl.Rows.Add(DateTime.Today, "Income", "Salary", 120000,"");
            tabl.Rows.Add(DateTime.Today, "Expense","Food", 1000, "");
            tabl.Rows.Add(DateTime.Today, "Expense", "Food", 1500, "");
            tabl.Rows.Add(DateTime.Today, "Expense", "Clothes", 5000, "");
            tabl.Rows.Add(DateTime.Today, "Income", "Salary", 120000, "");
            tabl.Rows.Add(DateTime.Today, "Expense", "Food", 1000, "");
            tabl.Rows.Add(DateTime.Today, "Expense", "Food", 1500, "");
            tabl.Rows.Add(DateTime.Today, "Expense", "Clothes", 5000, "");
            tabl.Rows.Add(DateTime.Today, "Income", "Salary", 120000, "");
            tabl.Rows.Add(DateTime.Today, "Expense", "Food", 1000, "");
            tabl.Rows.Add(DateTime.Today, "Expense", "Food", 1500, "");
            tabl.Rows.Add(DateTime.Today, "Expense", "Clothes", 5000, "");
            
            ds.Tables.Add(tabl);
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdd = new frmAddUpdate(this);
            frmAdd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAdd = new frmAddUpdate(this);
            frmAdd.Show();
            frmAdd.loadValues(selectedRow);
        }

        public DataGridViewRow selectedRow;
        
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Summary_Load(object sender, EventArgs e)
        {
           
        }

        private void tabTD_Click(object sender, EventArgs e)
        {
            
        }

        private void rbtLast_CheckedChanged(object sender, EventArgs e)
        {
           
            ds.Tables[0].DefaultView.Sort = "Date DESC";
            DataTable dtTop = tabl.Rows.Cast<DataRow>().Take(10).CopyToDataTable();
            var newDS = new DataSet();
            newDS.Tables.Add(dtTop);
            dgvTD.DataSource = newDS.Tables[0].DefaultView;
            dgvTD.Columns["TID"].Visible = false;
        }

        private void rbtFilter_CheckedChanged(object sender, EventArgs e)
        {
            var strExpr = "Type = 'Income' AND Category = 'Salary'";
            
            
            var dv = ds.Tables[0].DefaultView;
            dv.RowFilter = strExpr;
            var newDS = new DataSet();
            var newDT = dv.ToTable();
            newDS.Tables.Add(newDT);
            dgvTD.DataSource = newDS.Tables[0].DefaultView;
            dgvTD.Columns["TID"].Visible = false;
            
        }

        public void addTransaction(DateTime date, String type, String category, String amount, String des)
        {
            float amt = (float)Convert.ToDouble(amount);
            tabl.Rows.Add(date, type, category, amt, des);
            viewAll();
        }

        private void rbtView_CheckedChanged(object sender, EventArgs e)
        {
            viewAll();
        }

        private void viewAll()
        {
            tabl.DefaultView.RowFilter = string.Empty;
            dgvTD.DataSource = ds.Tables[0].DefaultView;
            dgvTD.Columns["TID"].Visible = false;
        }

        public int rowIndex;
        private void dgvTD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            selectedRow = dgvTD.Rows[rowIndex];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteRow();
            MessageBox.Show("Deleted Successfully");
            viewAll();
        }

        public void deleteRow()
        {
            ds.Tables[0].Rows[rowIndex].Delete();
        }
    }
}
