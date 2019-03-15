namespace ProjectA
{
    partial class Register_Student
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.cmd_register = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.txt_Lname = new System.Windows.Forms.TextBox();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_cntct = new System.Windows.Forms.Label();
            this.dt_DOB = new System.Windows.Forms.DateTimePicker();
            this.lbl_Lname = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.lbl_r_no = new System.Windows.Forms.Label();
            this.txt_rno = new System.Windows.Forms.TextBox();
            this.cmd_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(285, 142);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmb_Gender.Location = new System.Drawing.Point(112, 230);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(200, 21);
            this.cmb_Gender.TabIndex = 29;
            // 
            // cmd_register
            // 
            this.cmd_register.Location = new System.Drawing.Point(112, 468);
            this.cmd_register.Name = "cmd_register";
            this.cmd_register.Size = new System.Drawing.Size(75, 23);
            this.cmd_register.TabIndex = 28;
            this.cmd_register.Text = "Register";
            this.cmd_register.UseVisualStyleBackColor = true;
            this.cmd_register.Click += new System.EventHandler(this.cmd_register_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(112, 147);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(200, 20);
            this.txt_email.TabIndex = 27;
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(112, 106);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(200, 20);
            this.txt_contact.TabIndex = 26;
            // 
            // txt_Lname
            // 
            this.txt_Lname.Location = new System.Drawing.Point(112, 62);
            this.txt_Lname.Name = "txt_Lname";
            this.txt_Lname.Size = new System.Drawing.Size(200, 20);
            this.txt_Lname.TabIndex = 25;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(24, 233);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(42, 13);
            this.lbl_gender.TabIndex = 24;
            this.lbl_gender.Text = "Gender";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Location = new System.Drawing.Point(24, 187);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(62, 13);
            this.lbl_DOB.TabIndex = 23;
            this.lbl_DOB.Text = "DateOfBirth";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(24, 147);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 22;
            this.lbl_email.Text = "Email";
            // 
            // lbl_cntct
            // 
            this.lbl_cntct.AutoSize = true;
            this.lbl_cntct.Location = new System.Drawing.Point(24, 106);
            this.lbl_cntct.Name = "lbl_cntct";
            this.lbl_cntct.Size = new System.Drawing.Size(44, 13);
            this.lbl_cntct.TabIndex = 21;
            this.lbl_cntct.Text = "Contact";
            this.lbl_cntct.Click += new System.EventHandler(this.lbl_cntct_Click);
            // 
            // dt_DOB
            // 
            this.dt_DOB.Location = new System.Drawing.Point(112, 187);
            this.dt_DOB.Name = "dt_DOB";
            this.dt_DOB.Size = new System.Drawing.Size(200, 20);
            this.dt_DOB.TabIndex = 20;
            // 
            // lbl_Lname
            // 
            this.lbl_Lname.AutoSize = true;
            this.lbl_Lname.Location = new System.Drawing.Point(24, 62);
            this.lbl_Lname.Name = "lbl_Lname";
            this.lbl_Lname.Size = new System.Drawing.Size(55, 13);
            this.lbl_Lname.TabIndex = 19;
            this.lbl_Lname.Text = "LastName";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Location = new System.Drawing.Point(24, 17);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(54, 13);
            this.lbl_fname.TabIndex = 18;
            this.lbl_fname.Text = "FirstName";
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(112, 17);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(200, 20);
            this.txt_fname.TabIndex = 17;
            // 
            // lbl_r_no
            // 
            this.lbl_r_no.AutoSize = true;
            this.lbl_r_no.Location = new System.Drawing.Point(24, 273);
            this.lbl_r_no.Name = "lbl_r_no";
            this.lbl_r_no.Size = new System.Drawing.Size(76, 13);
            this.lbl_r_no.TabIndex = 32;
            this.lbl_r_no.Text = "registration_no";
            // 
            // txt_rno
            // 
            this.txt_rno.Location = new System.Drawing.Point(112, 273);
            this.txt_rno.Name = "txt_rno";
            this.txt_rno.Size = new System.Drawing.Size(200, 20);
            this.txt_rno.TabIndex = 33;
            // 
            // cmd_back
            // 
            this.cmd_back.Location = new System.Drawing.Point(193, 468);
            this.cmd_back.Name = "cmd_back";
            this.cmd_back.Size = new System.Drawing.Size(119, 23);
            this.cmd_back.TabIndex = 34;
            this.cmd_back.Text = "Back to Main Page";
            this.cmd_back.UseVisualStyleBackColor = true;
            this.cmd_back.Click += new System.EventHandler(this.cmd_back_Click);
            // 
            // Register_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 503);
            this.Controls.Add(this.cmd_back);
            this.Controls.Add(this.txt_rno);
            this.Controls.Add(this.lbl_r_no);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_Gender);
            this.Controls.Add(this.cmd_register);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.txt_Lname);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_cntct);
            this.Controls.Add(this.dt_DOB);
            this.Controls.Add(this.lbl_Lname);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.txt_fname);
            this.Name = "Register_Student";
            this.Text = "Register_Student";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.Button cmd_register;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.TextBox txt_Lname;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_cntct;
        private System.Windows.Forms.DateTimePicker dt_DOB;
        private System.Windows.Forms.Label lbl_Lname;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label lbl_r_no;
        private System.Windows.Forms.TextBox txt_rno;
        private System.Windows.Forms.Button cmd_back;
    }
}