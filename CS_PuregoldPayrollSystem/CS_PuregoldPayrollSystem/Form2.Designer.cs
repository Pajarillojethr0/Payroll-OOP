
namespace CS_PuregoldPayrollSystem
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.emp_Tab = new System.Windows.Forms.TabPage();
            this.cb_Gender = new System.Windows.Forms.ComboBox();
            this.cb_Position = new System.Windows.Forms.ComboBox();
            this.date_dob = new System.Windows.Forms.DateTimePicker();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_Rate = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Contact = new System.Windows.Forms.TextBox();
            this.tb_Firstname = new System.Windows.Forms.TextBox();
            this.tb_Lastname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.payrollDataSet = new CS_PuregoldPayrollSystem.PayrollDataSet();
            this.payrollDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payrollDataSet3 = new CS_PuregoldPayrollSystem.PayrollDataSet3();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new CS_PuregoldPayrollSystem.PayrollDataSet3TableAdapters.EmployeeTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.emp_Tab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.emp_Tab);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1069, 595);
            this.tabControl1.TabIndex = 0;
            // 
            // emp_Tab
            // 
            this.emp_Tab.Controls.Add(this.button2);
            this.emp_Tab.Controls.Add(this.button1);
            this.emp_Tab.Controls.Add(this.cb_Gender);
            this.emp_Tab.Controls.Add(this.cb_Position);
            this.emp_Tab.Controls.Add(this.date_dob);
            this.emp_Tab.Controls.Add(this.btn_Add);
            this.emp_Tab.Controls.Add(this.tb_Rate);
            this.emp_Tab.Controls.Add(this.tb_Address);
            this.emp_Tab.Controls.Add(this.tb_Contact);
            this.emp_Tab.Controls.Add(this.tb_Firstname);
            this.emp_Tab.Controls.Add(this.tb_Lastname);
            this.emp_Tab.Controls.Add(this.label10);
            this.emp_Tab.Controls.Add(this.label9);
            this.emp_Tab.Controls.Add(this.label8);
            this.emp_Tab.Controls.Add(this.label7);
            this.emp_Tab.Controls.Add(this.label6);
            this.emp_Tab.Controls.Add(this.label5);
            this.emp_Tab.Controls.Add(this.label3);
            this.emp_Tab.Controls.Add(this.label2);
            this.emp_Tab.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_Tab.Location = new System.Drawing.Point(4, 34);
            this.emp_Tab.Name = "emp_Tab";
            this.emp_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.emp_Tab.Size = new System.Drawing.Size(1061, 557);
            this.emp_Tab.TabIndex = 0;
            this.emp_Tab.Text = "Employee";
            this.emp_Tab.UseVisualStyleBackColor = true;
            this.emp_Tab.Click += new System.EventHandler(this.emp_Tab_Click);
            // 
            // cb_Gender
            // 
            this.cb_Gender.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Gender.FormattingEnabled = true;
            this.cb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_Gender.Location = new System.Drawing.Point(244, 365);
            this.cb_Gender.Name = "cb_Gender";
            this.cb_Gender.Size = new System.Drawing.Size(153, 29);
            this.cb_Gender.TabIndex = 43;
            // 
            // cb_Position
            // 
            this.cb_Position.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Position.FormattingEnabled = true;
            this.cb_Position.Location = new System.Drawing.Point(713, 233);
            this.cb_Position.Name = "cb_Position";
            this.cb_Position.Size = new System.Drawing.Size(154, 29);
            this.cb_Position.TabIndex = 42;
            // 
            // date_dob
            // 
            this.date_dob.CalendarFont = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_dob.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_dob.Location = new System.Drawing.Point(44, 365);
            this.date_dob.Name = "date_dob";
            this.date_dob.Size = new System.Drawing.Size(193, 29);
            this.date_dob.TabIndex = 41;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(169, 425);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(154, 34);
            this.btn_Add.TabIndex = 40;
            this.btn_Add.Text = "Add Employee";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_Rate
            // 
            this.tb_Rate.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Rate.Location = new System.Drawing.Point(713, 368);
            this.tb_Rate.Name = "tb_Rate";
            this.tb_Rate.Size = new System.Drawing.Size(154, 29);
            this.tb_Rate.TabIndex = 38;
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(44, 233);
            this.tb_Address.Multiline = true;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(353, 92);
            this.tb_Address.TabIndex = 34;
            // 
            // tb_Contact
            // 
            this.tb_Contact.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Contact.Location = new System.Drawing.Point(713, 109);
            this.tb_Contact.Name = "tb_Contact";
            this.tb_Contact.Size = new System.Drawing.Size(154, 29);
            this.tb_Contact.TabIndex = 33;
            // 
            // tb_Firstname
            // 
            this.tb_Firstname.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Firstname.Location = new System.Drawing.Point(243, 109);
            this.tb_Firstname.Name = "tb_Firstname";
            this.tb_Firstname.Size = new System.Drawing.Size(154, 29);
            this.tb_Firstname.TabIndex = 31;
            // 
            // tb_Lastname
            // 
            this.tb_Lastname.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Lastname.Location = new System.Drawing.Point(44, 109);
            this.tb_Lastname.Name = "tb_Lastname";
            this.tb_Lastname.Size = new System.Drawing.Size(154, 29);
            this.tb_Lastname.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(709, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Contact";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(709, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 21);
            this.label9.TabIndex = 28;
            this.label9.Text = "Basic Rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(709, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(239, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Birthdate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Last name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1061, 557);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data Grid";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.basicRateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(105, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 344);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(355, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 34);
            this.button1.TabIndex = 44;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(544, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 34);
            this.button2.TabIndex = 45;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // payrollDataSet
            // 
            this.payrollDataSet.DataSetName = "PayrollDataSet";
            this.payrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payrollDataSetBindingSource
            // 
            this.payrollDataSetBindingSource.DataSource = this.payrollDataSet;
            this.payrollDataSetBindingSource.Position = 0;
            // 
            // payrollDataSet3
            // 
            this.payrollDataSet3.DataSetName = "PayrollDataSet3";
            this.payrollDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.payrollDataSet3;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // basicRateDataGridViewTextBoxColumn
            // 
            this.basicRateDataGridViewTextBoxColumn.DataPropertyName = "BasicRate";
            this.basicRateDataGridViewTextBoxColumn.HeaderText = "BasicRate";
            this.basicRateDataGridViewTextBoxColumn.Name = "basicRateDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 522);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.emp_Tab.ResumeLayout(false);
            this.emp_Tab.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage emp_Tab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_Rate;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Contact;
        private System.Windows.Forms.TextBox tb_Firstname;
        private System.Windows.Forms.TextBox tb_Lastname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Position;
        private System.Windows.Forms.DateTimePicker date_dob;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_Gender;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource payrollDataSetBindingSource;
        private PayrollDataSet payrollDataSet;
        private PayrollDataSet3 payrollDataSet3;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private PayrollDataSet3TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicRateDataGridViewTextBoxColumn;
    }
}