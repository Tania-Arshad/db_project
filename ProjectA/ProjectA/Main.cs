using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void cmd_registration_Click(object sender, EventArgs e)
        {
            Register_Student n = new Register_Student();
            n.Show();
            this.Hide();
        }

        private void cmd_AddProject_Click(object sender, EventArgs e)
        {
            Add_Project x = new Add_Project();
            x.Show();
            this.Hide();
        }

        private void cmd_evaluation_Click(object sender, EventArgs e)
        {
            Evaluation z = new Evaluation();
            z.Show();
            this.Hide();
        }

        private void cmd_advisor_Click(object sender, EventArgs e)
        {
            Advisor o = new Advisor();
            o.Show();
            this.Hide();
        }
    }
}
