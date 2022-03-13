namespace BudgetTracker
{
    partial class Summary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBal = new System.Windows.Forms.TextBox();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.txtExpOtFor = new System.Windows.Forms.TextBox();
            this.txtOtherEx = new System.Windows.Forms.TextBox();
            this.txtEntFor = new System.Windows.Forms.TextBox();
            this.txtEnt = new System.Windows.Forms.TextBox();
            this.txtTransFor = new System.Windows.Forms.TextBox();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.txtClotheFor = new System.Windows.Forms.TextBox();
            this.txtClothes = new System.Windows.Forms.TextBox();
            this.txtFoodFor = new System.Windows.Forms.TextBox();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.txtExpFor = new System.Windows.Forms.TextBox();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.chtExp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtOver = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabTD = new System.Windows.Forms.TabPage();
            this.btnFilter = new System.Windows.Forms.Button();
            this.rbtView = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpTDFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTDTo = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvTD = new System.Windows.Forms.DataGridView();
            this.rbtFilter = new System.Windows.Forms.RadioButton();
            this.rbtLast = new System.Windows.Forms.RadioButton();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.rbtMonth = new System.Windows.Forms.RadioButton();
            this.rbtWeek = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpRptTo = new System.Windows.Forms.DateTimePicker();
            this.rbtCustom = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpRptFrom = new System.Windows.Forms.DateTimePicker();
            this.dgvRpt = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtOver)).BeginInit();
            this.tabTD.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTD)).BeginInit();
            this.tabReport.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRpt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(62, 132);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(164, 28);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Income";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBal);
            this.groupBox1.Controls.Add(this.txtSave);
            this.groupBox1.Controls.Add(this.txtExpOtFor);
            this.groupBox1.Controls.Add(this.txtOtherEx);
            this.groupBox1.Controls.Add(this.txtEntFor);
            this.groupBox1.Controls.Add(this.txtEnt);
            this.groupBox1.Controls.Add(this.txtTransFor);
            this.groupBox1.Controls.Add(this.txtTransport);
            this.groupBox1.Controls.Add(this.txtClotheFor);
            this.groupBox1.Controls.Add(this.txtClothes);
            this.groupBox1.Controls.Add(this.txtFoodFor);
            this.groupBox1.Controls.Add(this.txtFood);
            this.groupBox1.Controls.Add(this.txtExpFor);
            this.groupBox1.Controls.Add(this.txtExp);
            this.groupBox1.Controls.Add(this.txtOther);
            this.groupBox1.Controls.Add(this.txtInterest);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.txtIncome);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(409, 540);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtBal
            // 
            this.txtBal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBal.Location = new System.Drawing.Point(122, 489);
            this.txtBal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBal.Name = "txtBal";
            this.txtBal.Size = new System.Drawing.Size(110, 26);
            this.txtBal.TabIndex = 37;
            this.txtBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSave
            // 
            this.txtSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSave.Location = new System.Drawing.Point(122, 443);
            this.txtSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(110, 26);
            this.txtSave.TabIndex = 35;
            this.txtSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtExpOtFor
            // 
            this.txtExpOtFor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpOtFor.Location = new System.Drawing.Point(270, 395);
            this.txtExpOtFor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExpOtFor.Name = "txtExpOtFor";
            this.txtExpOtFor.Size = new System.Drawing.Size(110, 26);
            this.txtExpOtFor.TabIndex = 34;
            this.txtExpOtFor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOtherEx
            // 
            this.txtOtherEx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherEx.Location = new System.Drawing.Point(122, 395);
            this.txtOtherEx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOtherEx.Name = "txtOtherEx";
            this.txtOtherEx.Size = new System.Drawing.Size(110, 26);
            this.txtOtherEx.TabIndex = 33;
            this.txtOtherEx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEntFor
            // 
            this.txtEntFor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntFor.Location = new System.Drawing.Point(270, 354);
            this.txtEntFor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEntFor.Name = "txtEntFor";
            this.txtEntFor.Size = new System.Drawing.Size(110, 26);
            this.txtEntFor.TabIndex = 32;
            this.txtEntFor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEnt
            // 
            this.txtEnt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnt.Location = new System.Drawing.Point(122, 357);
            this.txtEnt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEnt.Name = "txtEnt";
            this.txtEnt.Size = new System.Drawing.Size(110, 26);
            this.txtEnt.TabIndex = 31;
            this.txtEnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTransFor
            // 
            this.txtTransFor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransFor.Location = new System.Drawing.Point(270, 319);
            this.txtTransFor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTransFor.Name = "txtTransFor";
            this.txtTransFor.Size = new System.Drawing.Size(110, 26);
            this.txtTransFor.TabIndex = 30;
            this.txtTransFor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTransport
            // 
            this.txtTransport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransport.Location = new System.Drawing.Point(122, 317);
            this.txtTransport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(110, 26);
            this.txtTransport.TabIndex = 29;
            this.txtTransport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtClotheFor
            // 
            this.txtClotheFor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClotheFor.Location = new System.Drawing.Point(270, 280);
            this.txtClotheFor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClotheFor.Name = "txtClotheFor";
            this.txtClotheFor.Size = new System.Drawing.Size(110, 26);
            this.txtClotheFor.TabIndex = 28;
            this.txtClotheFor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtClothes
            // 
            this.txtClothes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClothes.Location = new System.Drawing.Point(122, 280);
            this.txtClothes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClothes.Name = "txtClothes";
            this.txtClothes.Size = new System.Drawing.Size(110, 26);
            this.txtClothes.TabIndex = 27;
            this.txtClothes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFoodFor
            // 
            this.txtFoodFor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodFor.Location = new System.Drawing.Point(270, 245);
            this.txtFoodFor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFoodFor.Name = "txtFoodFor";
            this.txtFoodFor.Size = new System.Drawing.Size(110, 26);
            this.txtFoodFor.TabIndex = 26;
            this.txtFoodFor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFood
            // 
            this.txtFood.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFood.Location = new System.Drawing.Point(122, 242);
            this.txtFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(110, 26);
            this.txtFood.TabIndex = 25;
            this.txtFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtExpFor
            // 
            this.txtExpFor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpFor.Location = new System.Drawing.Point(270, 209);
            this.txtExpFor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExpFor.Name = "txtExpFor";
            this.txtExpFor.Size = new System.Drawing.Size(110, 26);
            this.txtExpFor.TabIndex = 24;
            this.txtExpFor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtExp
            // 
            this.txtExp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExp.Location = new System.Drawing.Point(122, 209);
            this.txtExp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(110, 26);
            this.txtExp.TabIndex = 23;
            this.txtExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOther
            // 
            this.txtOther.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOther.Location = new System.Drawing.Point(122, 157);
            this.txtOther.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(110, 26);
            this.txtOther.TabIndex = 21;
            this.txtOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInterest
            // 
            this.txtInterest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterest.Location = new System.Drawing.Point(122, 122);
            this.txtInterest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(110, 26);
            this.txtInterest.TabIndex = 19;
            this.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(122, 84);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(110, 26);
            this.txtSalary.TabIndex = 17;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIncome
            // 
            this.txtIncome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncome.Location = new System.Drawing.Point(122, 48);
            this.txtIncome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(110, 26);
            this.txtIncome.TabIndex = 15;
            this.txtIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 495);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 19);
            this.label16.TabIndex = 14;
            this.label16.Text = "Balance";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 443);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 19);
            this.label15.TabIndex = 13;
            this.label15.Text = "Savings";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(27, 392);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 19);
            this.label14.TabIndex = 12;
            this.label14.Text = "Other";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 357);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 19);
            this.label12.TabIndex = 7;
            this.label12.Text = "Entertainment";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 319);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 19);
            this.label11.TabIndex = 7;
            this.label11.Text = "Transport";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 284);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "Clothes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 248);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Food";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Other";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Interest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Expense";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Forcast";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabSummary);
            this.tabControl1.Controls.Add(this.tabTD);
            this.tabControl1.Controls.Add(this.tabReport);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-1, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 618);
            this.tabControl1.TabIndex = 5;
            // 
            // tabSummary
            // 
            this.tabSummary.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabSummary.Controls.Add(this.btnRefresh);
            this.tabSummary.Controls.Add(this.chtExp);
            this.tabSummary.Controls.Add(this.chtOver);
            this.tabSummary.Controls.Add(this.groupBox1);
            this.tabSummary.Location = new System.Drawing.Point(4, 31);
            this.tabSummary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSummary.Size = new System.Drawing.Size(714, 583);
            this.tabSummary.TabIndex = 0;
            this.tabSummary.Text = "Summary";
            this.tabSummary.Click += new System.EventHandler(this.tabSummary_Click);
            // 
            // chtExp
            // 
            chartArea3.Name = "ChartArea1";
            this.chtExp.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chtExp.Legends.Add(legend3);
            this.chtExp.Location = new System.Drawing.Point(475, 326);
            this.chtExp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chtExp.Name = "chtExp";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chtExp.Series.Add(series3);
            this.chtExp.Size = new System.Drawing.Size(225, 230);
            this.chtExp.TabIndex = 6;
            this.chtExp.Text = "Expenses";
            // 
            // chtOver
            // 
            chartArea4.Name = "ChartArea1";
            this.chtOver.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chtOver.Legends.Add(legend4);
            this.chtOver.Location = new System.Drawing.Point(475, 57);
            this.chtOver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chtOver.Name = "chtOver";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chtOver.Series.Add(series4);
            this.chtOver.Size = new System.Drawing.Size(225, 223);
            this.chtOver.TabIndex = 5;
            this.chtOver.Text = "Overview";
            this.chtOver.Click += new System.EventHandler(this.chtOver_Click);
            // 
            // tabTD
            // 
            this.tabTD.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabTD.Controls.Add(this.btnFilter);
            this.tabTD.Controls.Add(this.rbtView);
            this.tabTD.Controls.Add(this.groupBox3);
            this.tabTD.Controls.Add(this.groupBox2);
            this.tabTD.Controls.Add(this.dgvTD);
            this.tabTD.Controls.Add(this.rbtFilter);
            this.tabTD.Controls.Add(this.rbtLast);
            this.tabTD.Location = new System.Drawing.Point(4, 31);
            this.tabTD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabTD.Name = "tabTD";
            this.tabTD.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabTD.Size = new System.Drawing.Size(714, 583);
            this.tabTD.TabIndex = 1;
            this.tabTD.Text = "Transactions";
            this.tabTD.Click += new System.EventHandler(this.tabTD_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(584, 109);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(80, 32);
            this.btnFilter.TabIndex = 25;
            this.btnFilter.Text = "Apply Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // rbtView
            // 
            this.rbtView.AutoSize = true;
            this.rbtView.Location = new System.Drawing.Point(16, 17);
            this.rbtView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtView.Name = "rbtView";
            this.rbtView.Size = new System.Drawing.Size(81, 23);
            this.rbtView.TabIndex = 24;
            this.rbtView.TabStop = true;
            this.rbtView.Text = "View All";
            this.rbtView.UseVisualStyleBackColor = true;
            this.rbtView.CheckedChanged += new System.EventHandler(this.rbtView_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Location = new System.Drawing.Point(350, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(322, 51);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.Location = new System.Drawing.Point(4, 13);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 33);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(235, 13);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 33);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnUpdate.Location = new System.Drawing.Point(104, 13);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 33);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.dtpTDFrom);
            this.groupBox2.Controls.Add(this.dtpTDTo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(81, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(474, 39);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(10, 13);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 19);
            this.label17.TabIndex = 11;
            this.label17.Text = "From";
            // 
            // dtpTDFrom
            // 
            this.dtpTDFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTDFrom.Location = new System.Drawing.Point(51, 11);
            this.dtpTDFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTDFrom.MaxDate = new System.DateTime(3023, 12, 31, 0, 0, 0, 0);
            this.dtpTDFrom.Name = "dtpTDFrom";
            this.dtpTDFrom.Size = new System.Drawing.Size(189, 26);
            this.dtpTDFrom.TabIndex = 10;
            this.dtpTDFrom.Value = new System.DateTime(2022, 3, 12, 0, 0, 0, 0);
            // 
            // dtpTDTo
            // 
            this.dtpTDTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTDTo.Location = new System.Drawing.Point(275, 11);
            this.dtpTDTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTDTo.MaxDate = new System.DateTime(3023, 12, 31, 0, 0, 0, 0);
            this.dtpTDTo.Name = "dtpTDTo";
            this.dtpTDTo.Size = new System.Drawing.Size(189, 26);
            this.dtpTDTo.TabIndex = 13;
            this.dtpTDTo.Value = new System.DateTime(2022, 3, 12, 0, 0, 0, 0);
            this.dtpTDTo.ValueChanged += new System.EventHandler(this.dtpTDTo_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(250, 15);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 19);
            this.label13.TabIndex = 12;
            this.label13.Text = "To";
            // 
            // dgvTD
            // 
            this.dgvTD.AllowUserToAddRows = false;
            this.dgvTD.AllowUserToDeleteRows = false;
            this.dgvTD.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTD.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvTD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTD.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTD.Location = new System.Drawing.Point(16, 161);
            this.dgvTD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTD.Name = "dgvTD";
            this.dgvTD.ReadOnly = true;
            this.dgvTD.RowHeadersWidth = 51;
            this.dgvTD.RowTemplate.Height = 24;
            this.dgvTD.Size = new System.Drawing.Size(691, 413);
            this.dgvTD.TabIndex = 19;
            this.dgvTD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTD_CellContentClick);
            // 
            // rbtFilter
            // 
            this.rbtFilter.AutoSize = true;
            this.rbtFilter.Location = new System.Drawing.Point(16, 113);
            this.rbtFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtFilter.Name = "rbtFilter";
            this.rbtFilter.Size = new System.Drawing.Size(63, 23);
            this.rbtFilter.TabIndex = 16;
            this.rbtFilter.Text = "Filter";
            this.rbtFilter.UseVisualStyleBackColor = true;
            this.rbtFilter.CheckedChanged += new System.EventHandler(this.rbtFilter_CheckedChanged);
            // 
            // rbtLast
            // 
            this.rbtLast.AutoSize = true;
            this.rbtLast.Location = new System.Drawing.Point(16, 63);
            this.rbtLast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtLast.Name = "rbtLast";
            this.rbtLast.Size = new System.Drawing.Size(159, 23);
            this.rbtLast.TabIndex = 15;
            this.rbtLast.Text = "Last 10 Transaction";
            this.rbtLast.UseVisualStyleBackColor = true;
            this.rbtLast.CheckedChanged += new System.EventHandler(this.rbtLast_CheckedChanged);
            // 
            // tabReport
            // 
            this.tabReport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabReport.Controls.Add(this.dgvRpt);
            this.tabReport.Controls.Add(this.rbtCustom);
            this.tabReport.Controls.Add(this.label19);
            this.tabReport.Controls.Add(this.rbtMonth);
            this.tabReport.Controls.Add(this.rbtWeek);
            this.tabReport.Controls.Add(this.groupBox4);
            this.tabReport.Controls.Add(this.btnReport);
            this.tabReport.Location = new System.Drawing.Point(4, 31);
            this.tabReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabReport.Name = "tabReport";
            this.tabReport.Size = new System.Drawing.Size(714, 583);
            this.tabReport.TabIndex = 2;
            this.tabReport.Text = "Report";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 38);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(240, 19);
            this.label19.TabIndex = 25;
            this.label19.Text = "Select the period to cover in report";
            // 
            // rbtMonth
            // 
            this.rbtMonth.AutoSize = true;
            this.rbtMonth.Location = new System.Drawing.Point(124, 85);
            this.rbtMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtMonth.Name = "rbtMonth";
            this.rbtMonth.Size = new System.Drawing.Size(84, 23);
            this.rbtMonth.TabIndex = 23;
            this.rbtMonth.TabStop = true;
            this.rbtMonth.Text = "Monthly";
            this.rbtMonth.UseVisualStyleBackColor = true;
            // 
            // rbtWeek
            // 
            this.rbtWeek.AutoSize = true;
            this.rbtWeek.Location = new System.Drawing.Point(18, 84);
            this.rbtWeek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtWeek.Name = "rbtWeek";
            this.rbtWeek.Size = new System.Drawing.Size(78, 23);
            this.rbtWeek.TabIndex = 22;
            this.rbtWeek.TabStop = true;
            this.rbtWeek.Text = "Weekly";
            this.rbtWeek.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpRptTo);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.dtpRptFrom);
            this.groupBox4.Location = new System.Drawing.Point(337, 68);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(308, 92);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // dtpRptTo
            // 
            this.dtpRptTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRptTo.Location = new System.Drawing.Point(94, 62);
            this.dtpRptTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpRptTo.MaxDate = new System.DateTime(3022, 12, 31, 0, 0, 0, 0);
            this.dtpRptTo.Name = "dtpRptTo";
            this.dtpRptTo.Size = new System.Drawing.Size(191, 26);
            this.dtpRptTo.TabIndex = 13;
            this.dtpRptTo.Value = new System.DateTime(2022, 3, 12, 0, 0, 0, 0);
            // 
            // rbtCustom
            // 
            this.rbtCustom.AutoSize = true;
            this.rbtCustom.Location = new System.Drawing.Point(240, 85);
            this.rbtCustom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtCustom.Name = "rbtCustom";
            this.rbtCustom.Size = new System.Drawing.Size(78, 23);
            this.rbtCustom.TabIndex = 24;
            this.rbtCustom.TabStop = true;
            this.rbtCustom.Text = "Custom";
            this.rbtCustom.UseVisualStyleBackColor = true;
            this.rbtCustom.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "From";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(17, 62);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 19);
            this.label18.TabIndex = 12;
            this.label18.Text = "To";
            // 
            // dtpRptFrom
            // 
            this.dtpRptFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRptFrom.Location = new System.Drawing.Point(94, 19);
            this.dtpRptFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpRptFrom.MaxDate = new System.DateTime(3022, 12, 31, 0, 0, 0, 0);
            this.dtpRptFrom.Name = "dtpRptFrom";
            this.dtpRptFrom.Size = new System.Drawing.Size(191, 26);
            this.dtpRptFrom.TabIndex = 10;
            this.dtpRptFrom.Value = new System.DateTime(2022, 3, 12, 0, 0, 0, 0);
            // 
            // dgvRpt
            // 
            this.dgvRpt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRpt.Location = new System.Drawing.Point(18, 198);
            this.dgvRpt.Name = "dgvRpt";
            this.dgvRpt.ReadOnly = true;
            this.dgvRpt.Size = new System.Drawing.Size(665, 357);
            this.dgvRpt.TabIndex = 26;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(475, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 33);
            this.btnRefresh.TabIndex = 38;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 616);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Summary";
            this.Text = "Summary";
            this.Load += new System.EventHandler(this.Summary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtOver)).EndInit();
            this.tabTD.ResumeLayout(false);
            this.tabTD.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTD)).EndInit();
            this.tabReport.ResumeLayout(false);
            this.tabReport.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRpt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.TabPage tabTD;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.TextBox txtBal;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.TextBox txtExpOtFor;
        private System.Windows.Forms.TextBox txtOtherEx;
        private System.Windows.Forms.TextBox txtEntFor;
        private System.Windows.Forms.TextBox txtEnt;
        private System.Windows.Forms.TextBox txtTransFor;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.TextBox txtClotheFor;
        private System.Windows.Forms.TextBox txtClothes;
        private System.Windows.Forms.TextBox txtFoodFor;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.TextBox txtExpFor;
        private System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpTDFrom;
        private System.Windows.Forms.DateTimePicker dtpTDTo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvTD;
        private System.Windows.Forms.RadioButton rbtFilter;
        private System.Windows.Forms.RadioButton rbtLast;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton rbtCustom;
        private System.Windows.Forms.RadioButton rbtMonth;
        private System.Windows.Forms.RadioButton rbtWeek;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpRptFrom;
        private System.Windows.Forms.DateTimePicker dtpRptTo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtExp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtOver;
        private System.Windows.Forms.RadioButton rbtView;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dgvRpt;
        private System.Windows.Forms.Button btnRefresh;
    }
}