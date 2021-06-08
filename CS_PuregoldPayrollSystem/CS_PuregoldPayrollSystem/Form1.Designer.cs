
namespace CS_PuregoldPayrollSystem
{
    partial class logInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logInForm));
            this.tb_User = new System.Windows.Forms.TextBox();
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_Display = new System.Windows.Forms.Label();
            this.picBox_Hide = new System.Windows.Forms.PictureBox();
            this.picBox_Show = new System.Windows.Forms.PictureBox();
            this.tb_PlaceHolder = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_User
            // 
            this.tb_User.BackColor = System.Drawing.SystemColors.Window;
            this.tb_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_User.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_User.ForeColor = System.Drawing.Color.DimGray;
            this.tb_User.Location = new System.Drawing.Point(136, 238);
            this.tb_User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(258, 22);
            this.tb_User.TabIndex = 20;
            this.tb_User.TabStop = false;
            this.tb_User.Text = "Enter Username";
            this.tb_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_User.Enter += new System.EventHandler(this.tb_User_Enter);
            this.tb_User.Leave += new System.EventHandler(this.tb_User_Leave);
            this.tb_User.MouseEnter += new System.EventHandler(this.tb_User_MouseEnter);
            // 
            // tb_Pass
            // 
            this.tb_Pass.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Pass.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.tb_Pass.ForeColor = System.Drawing.Color.Black;
            this.tb_Pass.Location = new System.Drawing.Point(136, 286);
            this.tb_Pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.Size = new System.Drawing.Size(258, 22);
            this.tb_Pass.TabIndex = 19;
            this.tb_Pass.TabStop = false;
            this.tb_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Pass.UseSystemPasswordChar = true;
            this.tb_Pass.Enter += new System.EventHandler(this.tb_Pass_Enter);
            this.tb_Pass.Leave += new System.EventHandler(this.tb_Pass_Leave);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.btn_Login.Location = new System.Drawing.Point(140, 360);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(258, 38);
            this.btn_Login.TabIndex = 21;
            this.btn_Login.Text = "Log in";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            this.btn_Login.MouseEnter += new System.EventHandler(this.btn_Login_MouseEnter);
            this.btn_Login.MouseLeave += new System.EventHandler(this.btn_Login_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(138, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 36);
            this.label3.TabIndex = 18;
            this.label3.Text = "Payroll System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(136, 261);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 4);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(136, 309);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 4);
            this.panel2.TabIndex = 25;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.btn_Exit.Location = new System.Drawing.Point(140, 405);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(258, 38);
            this.btn_Exit.TabIndex = 22;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            this.btn_Exit.MouseEnter += new System.EventHandler(this.btn_Exit_MouseEnter);
            this.btn_Exit.MouseLeave += new System.EventHandler(this.btn_Exit_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(136, 226);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(136, 274);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_Display
            // 
            this.lbl_Display.AutoSize = true;
            this.lbl_Display.Font = new System.Drawing.Font("Arial Unicode MS", 8.5F);
            this.lbl_Display.ForeColor = System.Drawing.Color.Red;
            this.lbl_Display.Location = new System.Drawing.Point(137, 326);
            this.lbl_Display.Name = "lbl_Display";
            this.lbl_Display.Size = new System.Drawing.Size(42, 16);
            this.lbl_Display.TabIndex = 28;
            this.lbl_Display.Text = "label1";
            this.lbl_Display.Visible = false;
            // 
            // picBox_Hide
            // 
            this.picBox_Hide.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Hide.Image")));
            this.picBox_Hide.Location = new System.Drawing.Point(369, 280);
            this.picBox_Hide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBox_Hide.Name = "picBox_Hide";
            this.picBox_Hide.Size = new System.Drawing.Size(25, 29);
            this.picBox_Hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Hide.TabIndex = 29;
            this.picBox_Hide.TabStop = false;
            this.picBox_Hide.Click += new System.EventHandler(this.picBox_Hide_Click);
            // 
            // picBox_Show
            // 
            this.picBox_Show.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Show.Image")));
            this.picBox_Show.Location = new System.Drawing.Point(369, 280);
            this.picBox_Show.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBox_Show.Name = "picBox_Show";
            this.picBox_Show.Size = new System.Drawing.Size(25, 29);
            this.picBox_Show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Show.TabIndex = 30;
            this.picBox_Show.TabStop = false;
            this.picBox_Show.Click += new System.EventHandler(this.picBox_Show_Click);
            // 
            // tb_PlaceHolder
            // 
            this.tb_PlaceHolder.BackColor = System.Drawing.SystemColors.Window;
            this.tb_PlaceHolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_PlaceHolder.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.tb_PlaceHolder.ForeColor = System.Drawing.Color.DimGray;
            this.tb_PlaceHolder.Location = new System.Drawing.Point(172, 287);
            this.tb_PlaceHolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_PlaceHolder.Name = "tb_PlaceHolder";
            this.tb_PlaceHolder.Size = new System.Drawing.Size(185, 22);
            this.tb_PlaceHolder.TabIndex = 31;
            this.tb_PlaceHolder.TabStop = false;
            this.tb_PlaceHolder.Text = "Enter Password";
            this.tb_PlaceHolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_PlaceHolder.Enter += new System.EventHandler(this.tb_PlaceHolder_Enter);
            this.tb_PlaceHolder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_PlaceHolder_KeyPress);
            this.tb_PlaceHolder.MouseEnter += new System.EventHandler(this.tb_PlaceHolder_MouseEnter);
            // 
            // logInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 484);
            this.Controls.Add(this.tb_PlaceHolder);
            this.Controls.Add(this.picBox_Show);
            this.Controls.Add(this.picBox_Hide);
            this.Controls.Add(this.lbl_Display);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.tb_User);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "logInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.logInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.TextBox tb_Pass;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_Display;
        private System.Windows.Forms.PictureBox picBox_Hide;
        private System.Windows.Forms.PictureBox picBox_Show;
        private System.Windows.Forms.TextBox tb_PlaceHolder;
    }
}

