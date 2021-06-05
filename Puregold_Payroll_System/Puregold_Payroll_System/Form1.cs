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

namespace Puregold_Payroll_System
{
    public partial class loginForm : Form
    {
        private OleDbConnection con;
        private OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da;
        DataTable dt = new DataTable();

        private string conParam = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\jeivee\Desktop\2nd Year\2nd Sem\Object Oriented Programming\Puregold_Payroll_System\Payroll.accdb";

        public loginForm()
        {
            con = new OleDbConnection(conParam);
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cb_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var msgBox = MessageBox.Show("Are you sure you want to Exit?", "Warning!!", MessageBoxButtons.YesNo);

            if (msgBox == DialogResult.Yes)
            {
                this.Close();
            }


        }

        private void tb_User_Enter(object sender, EventArgs e)
        {
            if (tb_User.Text == "Enter Username")
            {
                tb_User.Text = "";
                tb_User.ForeColor = Color.Black;
               
            }
            if(tb_Pass.Text == "")
            {
                tb_PlaceHolder.Visible = true;
            }

        }

        private void tb_User_Leave(object sender, EventArgs e)
        {
            if (tb_User.Text == "")
            {
                tb_User.Text = "Enter Username";
                tb_User.ForeColor = Color.DimGray;
            }

        }

        private void tb_Pass_Enter(object sender, EventArgs e)
        {
            if (tb_Pass.Text == "Enter Password")
            {
                
                tb_Pass.Text = "";
                tb_Pass.ForeColor = Color.Black;
                tb_Pass.UseSystemPasswordChar = true;
            }
        }

        private void tb_Pass_Leave(object sender, EventArgs e)
        {
            if (tb_Pass.Text == "" && tb_Pass.Focus() == false)
            {
                tb_Pass.ForeColor = Color.DimGray;
                tb_Pass.UseSystemPasswordChar = false;
                tb_Pass.Visible = false;
                tb_PlaceHolder.Visible = true;
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void tb_Pass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_User_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

         

                da = new OleDbDataAdapter("SELECT * FROM Login WHERE Username='" + tb_User.Text + "' and Password='" + tb_Pass.Text + "'", con);
                da.Fill(dt);
                if (dt.Rows.Count <= 0)
                {
                      if (tb_User.Text == "" && tb_Pass.Text == "")
                      {
                            lbl_Display.Visible = true;
                            lbl_Display.Text = "Enter your Username and Password!";

                      }
                      else
                      {
                            lbl_Display.Visible = true;
                            lbl_Display.Text = "Incorrect Username or Password";
                      }
                }
                else if (dt.Rows.Count > 0)
                {

                    Form2 f2 = new Form2();
                    f2.Show();
                    lbl_Display.Text = "Login Successfully";


                    lbl_Display.Text = "";

                }

                dt.Clear();
            

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            picBox_Hide.Visible = true;
            picBox_Show.Visible =false;
            tb_Pass.UseSystemPasswordChar = false;

        }

        private void picBox_Hide_Click(object sender, EventArgs e)
        {
            picBox_Show.Visible = true;
            picBox_Hide.Visible = false;
            tb_Pass.UseSystemPasswordChar = true;
        }

        private void lbl_Display_Click(object sender, EventArgs e)
        {

        }

        private void tb_PlaceHolder_Enter(object sender, EventArgs e)
        {
           tb_Pass.Visible = true;
            
            tb_Pass.Focus();
            tb_PlaceHolder.Visible = false;
        }

        private void tb_Pass_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tb_PlaceHolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_PlaceHolder_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_Login_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btn_Login_MouseLeave(object sender, EventArgs e)
        {
            btn_Login.BackColor = Color.RoyalBlue;
        }

        private void btn_Login_MouseEnter(object sender, EventArgs e)
        {
            btn_Login.BackColor = Color.DeepSkyBlue;
            if (tb_Pass.Text == "")
            {
                tb_PlaceHolder.Visible = true;
                btn_Login.Focus();
            }
        }

        private void btn_Exit_MouseEnter(object sender, EventArgs e)
        {
            btn_Exit.BackColor = Color.Red;
            if (tb_Pass.Text == "")
            {
                tb_PlaceHolder.Visible = true;
                btn_Exit.Focus();
            }
        }

        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.BackColor = Color.White;
        }

        private void tb_PlaceHolder_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
