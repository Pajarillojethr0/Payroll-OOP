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
    public partial class logInForm : Form
    {

        private OleDbConnection con;
        private OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter oledbAdapter;
        DataTable dTable = new DataTable();

        private string conParam = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jeivee\source\repos\CS_PuregoldPayrollSystem\Payroll.accdb";


        public logInForm()
        {
            con = new OleDbConnection(conParam);
            InitializeComponent();
        }

        private void logInForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            var msgBox = MessageBox.Show("Are you sure you want to Exit?", "Warning!!", MessageBoxButtons.YesNo); // Show message box 

            if (msgBox == DialogResult.Yes)
            {
                this.Close(); //close login form
            }
        }

        private void tb_User_Enter(object sender, EventArgs e) // Enter event
        {
           
        }

        private void tb_User_Leave(object sender, EventArgs e) // Leave event
        {
            if (tb_User.Text == "") //if txtbox is empty 
            {
                tb_User.Text = "Enter Username"; // set txtbox text to enter username
                tb_User.ForeColor = Color.DimGray; // set font colot to gray for placeholder effect
            }
        }

        private void tb_Pass_Enter(object sender, EventArgs e)
        {

        }

        private void tb_Pass_Leave(object sender, EventArgs e)
        {
            if (tb_Pass.Text == "") // if txtbox is empty
            {
                tb_Pass.Visible = false; // hide txtbox pass
                tb_PlaceHolder.Visible = true; // show txtbox placeholder 
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            oledbAdapter = new OleDbDataAdapter("SELECT * FROM Login WHERE Username='" + tb_User.Text + "' and Password='" + tb_Pass.Text + "'", con); // query check if entered user and pass is in database
            oledbAdapter.Fill(dTable);

            if (dTable.Rows.Count <= 0) // if username and password is not in database
            {
                    lbl_Display.Visible = true; // show lbl display
                    lbl_Display.Text = "Incorrect Username or Password"; // display this
            }
            else if (dTable.Rows.Count > 0) // if username and pass is in database
            {
                Form2 f2 = new Form2(); // instantiate form 2
                f2.Show(); // show form 2
                this.Hide();
                lbl_Display.Text = "Login Successfully";
            }

            dTable.Clear();
        }

        private void picBox_Show_Click(object sender, EventArgs e)
        {
            picBox_Hide.Visible = true; // show picbox_hide
            picBox_Show.Visible = false; // hide picbox_show
            tb_Pass.UseSystemPasswordChar = false; 
        }

        private void picBox_Hide_Click(object sender, EventArgs e)
        {
            picBox_Show.Visible = true; //show picbox_show
            picBox_Hide.Visible = false; // hide picbox_hide
            tb_Pass.UseSystemPasswordChar = true;
        }

        private void tb_PlaceHolder_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // disable all keys
        }

        private void btn_Login_MouseLeave(object sender, EventArgs e) // change color to Royal Blue if cursor leave the button
        {
            btn_Login.BackColor = Color.RoyalBlue;
        }

        private void btn_Login_MouseEnter(object sender, EventArgs e)
        {
            btn_Login.BackColor = Color.DeepSkyBlue;
        }

        private void btn_Exit_MouseEnter(object sender, EventArgs e)
        {
            btn_Exit.BackColor = Color.Red;
        }

        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.BackColor = Color.White;
        }

        private void tb_PlaceHolder_Enter(object sender, EventArgs e)
        {
            
        }

        private void tb_PlaceHolder_MouseEnter(object sender, EventArgs e)
        {
            tb_Pass.Visible = true;
            tb_Pass.Focus(); // cursor to tb_Pass
            tb_PlaceHolder.Visible = false;
        }

        private void tb_User_MouseEnter(object sender, EventArgs e)
        {
            if (tb_User.Text == "Enter Username")
            {
                tb_User.Text = "";
                tb_User.ForeColor = Color.Black; // change the fore color to black
                tb_User.Focus();
            }
        }
    }
}
