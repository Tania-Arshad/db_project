namespace ProjectA
{
    partial class Evaluation
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
            this.cmd_insert = new System.Windows.Forms.Button();
            this.dt_evaluation = new System.Windows.Forms.DataGridView();
            this.txt_tweightage = new System.Windows.Forms.TextBox();
            this.lbl_tweightage = new System.Windows.Forms.Label();
            this.txt_TotalMarks = new System.Windows.Forms.TextBox();
            this.lbl_tmarks = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.cmd_back = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dt_evaluation)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_insert
            // 
            this.cmd_insert.Location = new System.Drawing.Point(12, 356);
            this.cmd_insert.Name = "cmd_insert";
            this.cmd_insert.Size = new System.Drawing.Size(75, 23);
            this.cmd_insert.TabIndex = 18;
            this.cmd_insert.Text = "Insert";
            this.cmd_insert.UseVisualStyleBackColor = true;
            this.cmd_insert.Click += new System.EventHandler(this.cmd_insert_Click);
            // 
            // dt_evaluation
            // 
            this.dt_evaluation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_evaluation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dt_evaluation.Location = new System.Drawing.Point(12, 183);
            this.dt_evaluation.Name = "dt_evaluation";
            this.dt_evaluation.Size = new System.Drawing.Size(318, 150);
            this.dt_evaluation.TabIndex = 17;
            this.dt_evaluation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_evaluation_CellContentClick);
            // 
            // txt_tweightage
            // 
            this.txt_tweightage.Location = new System.Drawing.Point(110, 140);
            this.txt_tweightage.Name = "txt_tweightage";
            this.txt_tweightage.Size = new System.Drawing.Size(219, 20);
            this.txt_tweightage.TabIndex = 16;
            // 
            // lbl_tweightage
            // 
            this.lbl_tweightage.AutoSize = true;
            this.lbl_tweightage.Location = new System.Drawing.Point(12, 140);
            this.lbl_tweightage.Name = "lbl_tweightage";
            this.lbl_tweightage.Size = new System.Drawing.Size(86, 13);
            this.lbl_tweightage.TabIndex = 15;
            this.lbl_tweightage.Text = "Total_weightage";
            // 
            // txt_TotalMarks
            // 
            this.txt_TotalMarks.Location = new System.Drawing.Point(110, 77);
            this.txt_TotalMarks.Name = "txt_TotalMarks";
            this.txt_TotalMarks.Size = new System.Drawing.Size(219, 20);
            this.txt_TotalMarks.TabIndex = 14;
            this.txt_TotalMarks.TextChanged += new System.EventHandler(this.txt_TotalMarks_TextChanged);
            // 
            // lbl_tmarks
            // 
            this.lbl_tmarks.AutoSize = true;
            this.lbl_tmarks.Location = new System.Drawing.Point(12, 77);
            this.lbl_tmarks.Name = "lbl_tmarks";
            this.lbl_tmarks.Size = new System.Drawing.Size(63, 13);
            this.lbl_tmarks.TabIndex = 13;
            this.lbl_tmarks.Text = "Total Marks";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(113, 24);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(216, 20);
            this.txt_Name.TabIndex = 12;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(23, 24);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 11;
            this.lbl_Name.Text = "Name";
            // 
            // cmd_back
            // 
            this.cmd_back.Location = new System.Drawing.Point(255, 356);
            this.cmd_back.Name = "cmd_back";
            this.cmd_back.Size = new System.Drawing.Size(75, 23);
            this.cmd_back.TabIndex = 21;
            this.cmd_back.Text = "Back";
            this.cmd_back.UseVisualStyleBackColor = true;
            this.cmd_back.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "update";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Delete";
            this.Column2.Name = "Column2";
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 387);
            this.Controls.Add(this.cmd_back);
            this.Controls.Add(this.cmd_insert);
            this.Controls.Add(this.dt_evaluation);
            this.Controls.Add(this.txt_tweightage);
            this.Controls.Add(this.lbl_tweightage);
            this.Controls.Add(this.txt_TotalMarks);
            this.Controls.Add(this.lbl_tmarks);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Name);
            this.Name = "Evaluation";
            this.Text = "Evaluation";
            ((System.ComponentModel.ISupportInitialize)(this.dt_evaluation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmd_insert;
        private System.Windows.Forms.DataGridView dt_evaluation;
        private System.Windows.Forms.TextBox txt_tweightage;
        private System.Windows.Forms.Label lbl_tweightage;
        private System.Windows.Forms.TextBox txt_TotalMarks;
        private System.Windows.Forms.Label lbl_tmarks;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button cmd_back;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}