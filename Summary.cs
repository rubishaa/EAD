using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace BudgetTracker
{
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
            loadSampleData();            
        }
        
        private void btnReport_Click(object sender, EventArgs e)
        {
            string AppLocation = "";
            AppLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            AppLocation = AppLocation.Replace("file:\\", "");
            string date = DateTime.Now.ToShortDateString();
            date = date.Replace("/", "_");
            string filepath = AppLocation + "\\Reports\\" + "BUDGET_REPORT_" + date + ".xlsx";

            var wbook = new XLWorkbook();

            var dv = ds.Tables[0].DefaultView;

            if (rbtCustom.Enabled == true)
            {
                var strExpr = "Date >= '" + dtpRptFrom.Text + "' AND DATE <= '" + dtpRptTo.Text + "'";
                dv.RowFilter = strExpr; 
            }
            else if (rbtWeek.Enabled == true)
            {

            }
            var newDS = new DataSet();
            var newDT = dv.ToTable();
            newDS.Tables.Add(newDT);
            wbook.Worksheets.Add(newDS.Tables[0], newDS.Tables[0].TableName);
            wbook.SaveAs(filepath);
            MessageBox.Show("Saved");

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
           // tabl.Columns.Add("TID", typeof(int));

           /* tabl.Columns["TID"].AutoIncrement = true;
            tabl.Columns["TID"].AutoIncrementSeed = 1;
            tabl.Columns["TID"].AutoIncrementStep = 1;*/

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
            frmAdd.calledFunctions(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAdd = new frmAddUpdate(this);
            frmAdd.Show();
            frmAdd.loadValues(selectedRow);
            frmAdd.calledFunctions(2);
        }

        public DataGridViewRow selectedRow;
        
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Summary_Load(object sender, EventArgs e)
        {
            calculateSummary();

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
            //dgvTD.Columns["TID"].Visible = false;
        }

        private void rbtFilter_CheckedChanged(object sender, EventArgs e)
        {
            filterValues();          
        }

        private void filterValues()
        {
            var strExpr = "Date >= '" + dtpTDFrom.Text + "' AND DATE <= '" + dtpTDTo.Text + "'";
            var dv = ds.Tables[0].DefaultView;
            dv.RowFilter = strExpr;
            var newDS = new DataSet();
            var newDT = dv.ToTable();
            newDS.Tables.Add(newDT);
            dgvTD.DataSource = newDS.Tables[0].DefaultView;
        }
       
        public void addTransaction(DateTime date, String type, String category, String amount, String des)
        {
            float amt = (float)Convert.ToDouble(amount);
            tabl.Rows.Add(date.Date, type, category, amt, des);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabSummary_Click(object sender, EventArgs e)
        {

        }

        private void dtpTDTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void calculateSummary()
        { 
            DateTime now = DateTime.Now;
            var thisMonthRows = tabl.AsEnumerable()
                .Where(r => r.Field<DateTime>("Date").Year == now.Year
                          && r.Field<DateTime>("Date").Month == now.Month);

            DataTable tabl2 = thisMonthRows.CopyToDataTable();

            float income = tabl2.AsEnumerable()
                .Where(y => y.Field<string>("Type") == "Income")
                .Sum(x => x.Field<float>("Amount"));
            
            float exp = tabl2.AsEnumerable()
                .Where(y => y.Field<string>("Type") == "Expense")
                .Sum(x => x.Field<float>("Amount"));

            float save = tabl2.AsEnumerable()
                .Where(y => y.Field<string>("Type") == "Savings")
                .Sum(x => x.Field<float>("Amount"));

            float food = tabl2.AsEnumerable()
                .Where(y => y.Field<string>("Category") == "Food")
                .Sum(x => x.Field<float>("Amount"));

            float clothes = tabl2.AsEnumerable()
                .Where(y => y.Field<string>("Category") == "Clothes")
                .Sum(x => x.Field<float>("Amount"));

            float trans = tabl2.AsEnumerable()
                .Where(y => y.Field<string>("Category") == "Transport")
                .Sum(x => x.Field<float>("Amount"));

            float ent = tabl2.AsEnumerable()
                    .Where(y => y.Field<string>("Category") == "Entertainment")
                    .Sum(x => x.Field<float>("Amount"));

            float otherEx = tabl2.AsEnumerable()
                .Where(y => y.Field<string>("Category") == "Other Expenses")
                .Sum(x => x.Field<float>("Amount"));

            float salary = tabl2.AsEnumerable()
                .Where(y => y.Field<string>("Category") == "Salary")
                .Sum(x => x.Field<float>("Amount"));

            float interest = tabl2.AsEnumerable()
                .Where(y => y.Field<string>("Category") == "Interest")
                .Sum(x => x.Field<float>("Amount"));

            float other = tabl2.AsEnumerable()
                .Where(y => y.Field<string>("Category") == "Other Income")
                .Sum(x => x.Field<float>("Amount"));

            int date = DateTime.Now.Day;
            
            int daysInmonth = System.DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            txtExpFor.Text = ((exp / date)*daysInmonth).ToString();

            txtClotheFor.Text = ((clothes / date)*daysInmonth).ToString();
            txtEntFor.Text  = ((ent / date) * daysInmonth).ToString();
            txtExpOtFor.Text = ((otherEx / date) * daysInmonth).ToString();
            txtFoodFor.Text = ((food / date) * daysInmonth).ToString();
            txtTransFor.Text = ((trans / date) * daysInmonth).ToString();

            txtIncome.Text = income.ToString();
            txtExp.Text = exp.ToString();
            txtSave.Text =save.ToString();
            txtFood.Text = food.ToString();
            txtClothes.Text = clothes.ToString();
            txtTransport.Text = trans.ToString();
            txtEnt.Text = ent.ToString();
            txtOtherEx.Text = otherEx.ToString();
            txtSalary.Text = salary.ToString();
            txtInterest.Text = interest.ToString();
            txtOther.Text = other.ToString();

            float bal = income - exp- save;
            txtBal.Text = bal.ToString();


            /*double[] data = { food, clothes, trans, ent, other};

            // The labels for the pie chart
            string[] labels = {"Food", "Clothes", "Transport", "Entertainment", "Other"};

            // Create a PieChart object of size 360 x 300 pixels
            PieChart c = new PieChart(360, 300);

            // Set the center of the pie at (180, 140) and the radius to 100 pixels
            c.setPieSize(180, 140, 100);

            // Set the pie data and the pie labels
            chtOver.DataBind(labels,data);

            // Output the chart
            viewer.Chart = c;

            //include tool tip for the chart
            viewer.ImageMap = c.getHTMLImageMap("clickable", "",
                "title='{label}: US${value}K ({percent}%)'");*/
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            filterValues();
        }

        private void chtOver_Click(object sender, EventArgs e)
        {

        }

       
    }
}
