namespace ProjectA
{
    partial class Advisor
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
            this.dt_advisor = new System.Windows.Forms.DataGridView();
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
            this.advisorTableAdapter1 = new ProjectA.ProjectADataSetTableAdapters.AdvisorTableAdapter();
            this.lbl_designation = new System.Windows.Forms.Label();
            this.cmd_back = new System.Windows.Forms.Button();
            this.lbl_salary = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.cmb_designation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_advisor)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_advisor
            // 
            this.dt_advisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_advisor.Location = new System.Drawing.Point(22, 326);
            this.dt_advisor.Name = "dt_advisor";
            this.dt_advisor.Size = new System.Drawing.Size(311, 165);
            this.dt_advisor.TabIndex = 45;
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmb_Gender.Location = new System.Drawing.Point(133, 222);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(200, 21);
            this.cmb_Gender.TabIndex = 44;
            // 
            // cmd_register
            // 
            this.cmd_register.Location = new System.Drawing.Point(77, 497);
            this.cmd_register.Name = "cmd_register";
            this.cmd_register.Size = new System.Drawing.Size(75, 23);
            this.cmd_register.TabIndex = 43;
            this.cmd_register.Text = "Register";
            this.cmd_register.UseVisualStyleBackColor = true;
            this.cmd_register.Click += new System.EventHandler(this.cmd_register_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(133, 135);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(200, 20);
            this.txt_email.TabIndex = 42;
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(133, 93);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(200, 20);
            this.txt_contact.TabIndex = 41;
            // 
            // txt_Lname
            // 
            this.txt_Lname.Location = new System.Drawing.Point(133, 55);
            this.txt_Lname.Name = "txt_Lname";
            this.txt_Lname.Size = new System.Drawing.Size(200, 20);
            this.txt_Lname.TabIndex = 40;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(25, 225);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(42, 13);
            this.lbl_gender.TabIndex = 39;
            this.lbl_gender.Text = "Gender";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Location = new System.Drawing.Point(22, 182);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(62, 13);
            this.lbl_DOB.TabIndex = 38;
            this.lbl_DOB.Text = "DateOfBirth";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(23, 135);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 37;
            this.lbl_email.Text = "Email";
            this.lbl_email.Click += new System.EventHandler(this.lbl_email_Click);
            // 
            // lbl_cntct
            // 
            this.lbl_cntct.AutoSize = true;
            this.lbl_cntct.Location = new System.Drawing.Point(23, 93);
            this.lbl_cntct.Name = "lbl_cntct";
            this.lbl_cntct.Size = new System.Drawing.Size(44, 13);
            this.lbl_cntct.TabIndex = 36;
            this.lbl_cntct.Text = "Contact";
            // 
            // dt_DOB
            // 
            this.dt_DOB.Location = new System.Drawing.Point(133, 181);
            this.dt_DOB.Name = "dt_DOB";
            this.dt_DOB.Size = new System.Drawing.Size(200, 20);
            this.dt_DOB.TabIndex = 35;
            // 
            // lbl_Lname
            // 
            this.lbl_Lname.AutoSize = true;
            this.lbl_Lname.Location = new System.Drawing.Point(22, 55);
            this.lbl_Lname.Name = "lbl_Lname";
            this.lbl_Lname.Size = new System.Drawing.Size(55, 13);
            this.lbl_Lname.TabIndex = 34;
            this.lbl_Lname.Text = "LastName";
            this.lbl_Lname.Click += new System.EventHandler(this.lbl_Lname_Click);
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Location = new System.Drawing.Point(23, 17);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(54, 13);
            this.lbl_fname.TabIndex = 33;
            this.lbl_fname.Text = "FirstName";
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(133, 14);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(200, 20);
            this.txt_fname.TabIndex = 32;
            // 
            // advisorTableAdapter1
            // 
            this.advisorTableAdapter1.ClearBeforeFill = true;
            // 
            // lbl_designation
            // 
            this.lbl_designation.AutoSize = true;
            this.lbl_designation.Location = new System.Drawing.Point(25, 266);
            this.lbl_designation.Name = "lbl_designation";
            this.lbl_designation.Size = new System.Drawing.Size(63, 13);
            this.lbl_designation.TabIndex = 47;
            this.lbl_designation.Text = "Designation";
            // 
            // cmd_back
            // 
            this.cmd_back.Location = new System.Drawing.Point(176, 497);
            this.cmd_back.Name = "cmd_back";
            this.cmd_back.Size = new System.Drawing.Size(75, 23);
            this.cmd_back.TabIndex = 49;
            this.cmd_back.Text = "Back";
            this.cmd_back.UseVisualStyleBackColor = true;
            this.cmd_back.Click += new System.EventHandler(this.cmd_back_Click);
            // 
            // lbl_salary
            // 
            this.lbl_salary.AutoSize = true;
            this.lbl_salary.Location = new System.Drawing.Point(25, 305);
            this.lbl_salary.Name = "lbl_salary";
            this.lbl_salary.Size = new System.Drawing.Size(36, 13);
            this.lbl_salary.TabIndex = 50;
            this.lbl_salary.Text = "Salary";
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(133, 300);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(200, 20);
            this.txt_salary.TabIndex = 51;
            // 
            // cmb_designation
            // 
            this.cmb_designation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_designation.FormattingEnabled = true;
            this.cmb_designation.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assistant Professor",
            "Lecturer",
            "Industry Professional"});
            this.cmb_designation.Location = new System.Drawing.Point(130, 263);
            this.cmb_designation.Name = "cmb_designation";
            this.cmb_designation.Size = new System.Drawing.Size(203, 21);
            this.cmb_designation.TabIndex = 52;
            // 
            // Advisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 523);
            this.Controls.Add(this.cmb_designation);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.lbl_salary);
            this.Controls.Add(this.cmd_back);
            this.Controls.Add(this.lbl_designation);
            this.Controls.Add(this.dt_advisor);
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
            this.Name = "Advisor";
            this.Text = "Advisor";
            ((System.ComponentModel.ISupportInitialize)(this.dt_advisor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dt_advisor;
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
        private ProjectADataSetTableAdapters.AdvisorTableAdapter advisorTableAdapter1;
        private System.Windows.Forms.Label lbl_designation;
        private System.Windows.Forms.Button cmd_back;
        private System.Windows.Forms.Label lbl_salary;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.ComboBox cmb_designation;
    }
}