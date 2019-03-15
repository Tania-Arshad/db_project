namespace ProjectA
{
    partial class Add_Project
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
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.dt_project = new System.Windows.Forms.DataGridView();
            this.cmd_insert = new System.Windows.Forms.Button();
            this.cmd_back = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dt_project)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(27, 29);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(60, 13);
            this.lbl_description.TabIndex = 2;
            this.lbl_description.Text = "Description";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(123, 29);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(191, 20);
            this.txt_description.TabIndex = 3;
            this.txt_description.TextChanged += new System.EventHandler(this.txt_description_TextChanged);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(40, 86);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(27, 13);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "Title";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(123, 86);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(191, 20);
            this.txt_title.TabIndex = 5;
            // 
            // dt_project
            // 
            this.dt_project.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_project.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dt_project.Location = new System.Drawing.Point(12, 121);
            this.dt_project.Name = "dt_project";
            this.dt_project.Size = new System.Drawing.Size(302, 150);
            this.dt_project.TabIndex = 6;
            this.dt_project.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_project_CellContentClick);
            // 
            // cmd_insert
            // 
            this.cmd_insert.Location = new System.Drawing.Point(119, 294);
            this.cmd_insert.Name = "cmd_insert";
            this.cmd_insert.Size = new System.Drawing.Size(75, 23);
            this.cmd_insert.TabIndex = 7;
            this.cmd_insert.Text = "Insert";
            this.cmd_insert.UseVisualStyleBackColor = true;
            this.cmd_insert.Click += new System.EventHandler(this.cmd_insert_Click);
            // 
            // cmd_back
            // 
            this.cmd_back.Location = new System.Drawing.Point(200, 294);
            this.cmd_back.Name = "cmd_back";
            this.cmd_back.Size = new System.Drawing.Size(112, 23);
            this.cmd_back.TabIndex = 10;
            this.cmd_back.Text = "Back To Main Page";
            this.cmd_back.UseVisualStyleBackColor = true;
            this.cmd_back.Click += new System.EventHandler(this.cmd_back_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Update";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Delete";
            this.Column2.Name = "Column2";
            // 
            // Add_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 332);
            this.Controls.Add(this.cmd_back);
            this.Controls.Add(this.cmd_insert);
            this.Controls.Add(this.dt_project);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.lbl_description);
            this.Name = "Add_Project";
            this.Text = "Add_Project";
            ((System.ComponentModel.ISupportInitialize)(this.dt_project)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.DataGridView dt_project;
        private System.Windows.Forms.Button cmd_insert;
        private System.Windows.Forms.Button cmd_back;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}