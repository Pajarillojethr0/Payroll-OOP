using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CS_PuregoldPayrollSystem
{
    public partial class Form2 : Form
    {
        private OleDbConnection con;
        private OleDbCommand cmd = new OleDbCommand();
        DataTable dTable = new DataTable();

        private string conParam = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jeivee\source\repos\CS_PuregoldPayrollSystem\Payroll.accdb";

        public Form2()
        {
            con = new OleDbConnection(conParam);
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //try
            //{
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into Employee(Firstname, Lastname, Birthdate, Gender, Address, Contact ,Position, BasicRate) Values" +
                "('" + tb_Firstname.Text +"', '"+ tb_Lastname.Text +"', '"+ date_dob.Text + "', '" + cb_Gender.Text + "', '" + tb_Address.Text + "', '" + tb_Contact.Text + "','"+ cb_Position.Text +"','" + tb_Rate.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Added successfully");

                con.Close();

            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Something went wrong");
            //}
        }

        private void emp_Tab_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payrollDataSet3.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.payrollDataSet3.Employee);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_Firstname.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_Lastname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            date_dob.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cb_Gender.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_Address.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tb_Contact.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cb_Position.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tb_Rate.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
