namespace ProjectA
{
    partial class Main
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
            this.cmd_registration = new System.Windows.Forms.Button();
            this.cmd_AddProject = new System.Windows.Forms.Button();
            this.cmd_evaluation = new System.Windows.Forms.Button();
            this.cmd_advisor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_registration
            // 
            this.cmd_registration.Location = new System.Drawing.Point(113, 57);
            this.cmd_registration.Name = "cmd_registration";
            this.cmd_registration.Size = new System.Drawing.Size(75, 23);
            this.cmd_registration.TabIndex = 0;
            this.cmd_registration.Text = "Student Registration";
            this.cmd_registration.UseVisualStyleBackColor = true;
            this.cmd_registration.Click += new System.EventHandler(this.cmd_registration_Click);
            // 
            // cmd_AddProject
            // 
            this.cmd_AddProject.Location = new System.Drawing.Point(113, 105);
            this.cmd_AddProject.Name = "cmd_AddProject";
            this.cmd_AddProject.Size = new System.Drawing.Size(75, 23);
            this.cmd_AddProject.TabIndex = 1;
            this.cmd_AddProject.Text = "Add Project";
            this.cmd_AddProject.UseVisualStyleBackColor = true;
            this.cmd_AddProject.Click += new System.EventHandler(this.cmd_AddProject_Click);
            // 
            // cmd_evaluation
            // 
            this.cmd_evaluation.Location = new System.Drawing.Point(113, 155);
            this.cmd_evaluation.Name = "cmd_evaluation";
            this.cmd_evaluation.Size = new System.Drawing.Size(75, 23);
            this.cmd_evaluation.TabIndex = 2;
            this.cmd_evaluation.Text = "Evaluation";
            this.cmd_evaluation.UseVisualStyleBackColor = true;
            this.cmd_evaluation.Click += new System.EventHandler(this.cmd_evaluation_Click);
            // 
            // cmd_advisor
            // 
            this.cmd_advisor.Location = new System.Drawing.Point(113, 200);
            this.cmd_advisor.Name = "cmd_advisor";
            this.cmd_advisor.Size = new System.Drawing.Size(75, 23);
            this.cmd_advisor.TabIndex = 3;
            this.cmd_advisor.Text = "Advisor";
            this.cmd_advisor.UseVisualStyleBackColor = true;
            this.cmd_advisor.Click += new System.EventHandler(this.cmd_advisor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Project Handling";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 237);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_advisor);
            this.Controls.Add(this.cmd_evaluation);
            this.Controls.Add(this.cmd_AddProject);
            this.Controls.Add(this.cmd_registration);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_registration;
        private System.Windows.Forms.Button cmd_AddProject;
        private System.Windows.Forms.Button cmd_evaluation;
        private System.Windows.Forms.Button cmd_advisor;
        private System.Windows.Forms.Label label1;
    }
}