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
        public DataTable tabl = new DataTable();
        public DataSet ds = new DataSet();
        public frmAddUpdate frmAdd;
        public DataGridViewRow selectedRow = null;
        public DateTime now = DateTime.Now;
        public int iDate = DateTime.Now.Day;
        public int rowIndex;
        public int reportCount = 0;
        public int forecastDate = System.DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

        public Summary()
        {
            InitializeComponent();
            loadSampleData();            
        }
        
        private void btnReport_Click(object sender, EventArgs e)
        {
            reportCount ++;
            generateReport(reportCount);

        }
       
 
        //onAdd click
        private void button1_Click(object sender, EventArgs e)
        {
            frmAdd = new frmAddUpdate(this);
            frmAdd.Show();
            frmAdd.calledFunctions(1);
        }

        //onUpdate click
        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedRow == null)
            {
                MessageBox.Show("Please select the row to update");
                return;
            }
            frmAdd = new frmAddUpdate(this);
            frmAdd.Show();
            frmAdd.loadValues(selectedRow);
            frmAdd.calledFunctions(2);
        }

        private void Summary_Load(object sender, EventArgs e)
        {
          
            chtExp.Titles.Add("Expense view");
            chtExp.Series["Series1"].IsValueShownAsLabel = true;
            calculateSummary();

        }

       
        private void rbtLast_CheckedChanged(object sender, EventArgs e)
        {
           
            ds.Tables[0].DefaultView.Sort = "Date DESC";
            DataTable dtTop = tabl.Rows.Cast<DataRow>().Take(10).CopyToDataTable();
            var newDS = new DataSet();
            newDS.Tables.Add(dtTop);
            dgvTD.DataSource = newDS.Tables[0].DefaultView;
            
        }

        private void rbtFilter_CheckedChanged(object sender, EventArgs e)
        {
            DataSet newDS = filterValues(dtpTDFrom.Text, dtpTDTo.Text);
            dgvTD.DataSource = newDS.Tables[0].DefaultView;

        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            DataSet newDS = filterValues(dtpTDFrom.Text, dtpTDTo.Text);
            dgvTD.DataSource = newDS.Tables[0].DefaultView;
        }


        private void rbtView_CheckedChanged(object sender, EventArgs e)
        {
            viewAll();
        }


        private void dgvTD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            selectedRow = dgvTD.Rows[rowIndex];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRow == null)
            {
                MessageBox.Show("Please select the row to update");
                return;
            }
            deleteRow();
            MessageBox.Show("Successfully Deleted");
            viewAll();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            calculateSummary();
        }

        /// <summary>
        /// Filter the rows based on the period given 
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
        private DataSet filterValues(string fromDate, string toDate)
        {
            var strExpr = "Date >= '" + fromDate + "' AND DATE <= '" + toDate + "'";
            var dv = ds.Tables[0].DefaultView;
            dv.RowFilter = strExpr;
            var newDS = new DataSet();
            var newDT = dv.ToTable();
            newDS.Tables.Add(newDT);
            return newDS;

        }
        
        /// <summary>
        /// Add new row to the table
        /// </summary>
        /// <param name="date"></param>
        /// <param name="type"></param>
        /// <param name="category"></param>
        /// <param name="amount"></param>
        /// <param name="des"></param>
        public void addTransaction(DateTime date, String type, String category, String amount, String des)
        {
            float amt = (float)Convert.ToDouble(amount);
            tabl.Rows.Add(date, type, category, amt, des);
            viewAll();
        }

        /// <summary>
        /// View all the rows in data table
        /// </summary>
        private void viewAll()
        {
            tabl.DefaultView.RowFilter = string.Empty;
            dgvTD.DataSource = ds.Tables[0].DefaultView;
        }

        /// <summary>
        /// Delete the selected row
        /// </summary>
        public void deleteRow()
        {
            ds.Tables[0].Rows[rowIndex].Delete();
        }

        /// <summary>
        /// Insert sample data to the table for testing
        /// </summary>
        private void loadSampleData()
        {

            //Creating columns
            tabl.Columns.Add("Date", typeof(DateTime));
            tabl.Columns.Add("Type", typeof(string));
            tabl.Columns.Add("Category", typeof(string));
            tabl.Columns.Add("Amount", typeof(float));
            tabl.Columns.Add("Description", typeof(string));

            //Adding data in a Datatable.
            tabl.Rows.Add(DateTime.Today, "Income", "Salary", 120000, "");
            tabl.Rows.Add(DateTime.Today, "Expense", "Food", 1000, "");
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

        /// <summary>
        /// Calculate the total based on type and category. Shows the calucalted values as text and chart
        /// </summary>
        private void calculateSummary()
        { 
            //filter and calcualte the total
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

            //forcast calculation        
            
            txtExpFor.Text = ((exp / iDate)*forecastDate).ToString();
            txtClotheFor.Text = ((clothes / iDate) * forecastDate).ToString();
            txtEntFor.Text  = ((ent / iDate) * forecastDate).ToString();
            txtExpOtFor.Text = ((otherEx / iDate) * forecastDate).ToString();
            txtFoodFor.Text = ((food / iDate) * forecastDate).ToString();
            txtTransFor.Text = ((trans / iDate) * forecastDate).ToString();

            // assign the alues to the text box
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

            //generate pie chart
           
            
            chtExp.Series["Series1"].Points.Clear();
            chtExp.Series["Series1"].Points.AddXY("Food", food);
            chtExp.Series["Series1"].Points.AddXY("Transport", trans);
            chtExp.Series["Series1"].Points.AddXY("Clothes", clothes);
            chtExp.Series["Series1"].Points.AddXY("Entertainment", ent);
            chtExp.Series["Series1"].Points.AddXY("Other", otherEx);
     
        }

       
        /// <summary>
        /// Generate the report based on the selection and saced as xlsx file in the given location
        /// </summary>
        /// <param name="reportCount"></param>

        private void generateReport(int reportCount)
        {
            string AppLocation = "";
            AppLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            AppLocation = AppLocation.Replace("file:\\", "");
            string date = now.ToShortDateString();
            date = date.Replace("/", "_");
            
            string type;

            var wbook = new XLWorkbook();

            var dv = ds.Tables[0].DefaultView;
            var newDS = new DataSet();
            DataTable newDT;

            if (rbtCustom.Checked == true)
            {
                newDS = filterValues(dtpRptFrom.Text, dtpRptTo.Text);
                type = "Custom Date";
            }
            else if (rbtWeek.Checked == true)
            { 
                var thisMonthRows = tabl.AsEnumerable()
                   .Where(r => r.Field<DateTime>("Date").Year == now.Year && r.Field<DateTime>("Date").Month == now.Month
                    && (r.Field<DateTime>("Date").Day <= iDate && r.Field<DateTime>("Date").Day >= iDate - 6));

                newDT = thisMonthRows.CopyToDataTable();
                newDS.Tables.Add(newDT);
                dgvRpt.DataSource = newDS.Tables[0].DefaultView;
                type = "Weekly";

            }
            else
            {
                var thisMonthRows = tabl.AsEnumerable()
                    .Where(r => r.Field<DateTime>("Date").Year == now.Year
                     && r.Field<DateTime>("Date").Month == now.Month);

                newDT = thisMonthRows.CopyToDataTable();
                newDS.Tables.Add(newDT);
                type = "Monthly";
               
            }

            string filepath = AppLocation + "\\Reports\\" + "BUDGET_REPORT_" + date + "_" + type + "_" + reportCount + ".xlsx";
            dgvRpt.DataSource = newDS.Tables[0].DefaultView;
            wbook.Worksheets.Add(newDS.Tables[0], newDS.Tables[0].TableName);
            wbook.SaveAs(filepath);
            MessageBox.Show(type + " report successfully saved as " + filepath );   
        }



        private void chtOver_Click(object sender, EventArgs e)
        {

        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabTD_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabSummary_Click(object sender, EventArgs e)
        {
            calculateSummary();
        }

        private void dtpTDTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            forecastDate = dtpForecast.Value.Day;
            calculateSummary();
        }
    }
}
