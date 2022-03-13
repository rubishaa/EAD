namespace BudgetTracker
{
    partial class frmAddUpdate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.txtAmnt = new System.Windows.Forms.TextBox();
            this.dtpAdd = new System.Windows.Forms.DateTimePicker();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // btnAdd2
            // 
            this.btnAdd2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd2.Location = new System.Drawing.Point(68, 381);
            this.btnAdd2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(74, 38);
            this.btnAdd2.TabIndex = 5;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Income",
            "Expense",
            "Savings"});
            this.cmbType.Location = new System.Drawing.Point(183, 44);
            this.cmbType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(136, 27);
            this.cmbType.TabIndex = 6;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // cmbCat
            // 
            this.cmbCat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Items.AddRange(new object[] {
            "Salary",
            "Interest",
            "Other Income",
            "Food",
            "Clothes",
            "Transport",
            "Entertainment",
            "Other Expenses",
            "Bank",
            "Cash",
            "OtherSavings"});
            this.cmbCat.Location = new System.Drawing.Point(183, 115);
            this.cmbCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(136, 27);
            this.cmbCat.TabIndex = 7;
            // 
            // txtAmnt
            // 
            this.txtAmnt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmnt.Location = new System.Drawing.Point(183, 176);
            this.txtAmnt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmnt.Name = "txtAmnt";
            this.txtAmnt.Size = new System.Drawing.Size(136, 26);
            this.txtAmnt.TabIndex = 8;
            // 
            // dtpAdd
            // 
            this.dtpAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAdd.Location = new System.Drawing.Point(183, 245);
            this.dtpAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpAdd.MaxDate = new System.DateTime(3022, 12, 31, 0, 0, 0, 0);
            this.dtpAdd.Name = "dtpAdd";
            this.dtpAdd.Size = new System.Drawing.Size(268, 26);
            this.dtpAdd.TabIndex = 9;
            this.dtpAdd.Value = new System.DateTime(2022, 3, 12, 10, 3, 39, 0);
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(183, 316);
            this.txtDes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(136, 26);
            this.txtDes.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(244, 381);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 38);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(480, 451);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.dtpAdd);
            this.Controls.Add(this.txtAmnt);
            this.Controls.Add(this.cmbCat);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddUpdate";
            this.Text = "Add/Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.TextBox txtAmnt;
        private System.Windows.Forms.DateTimePicker dtpAdd;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Button btnUpdate;
    }
}