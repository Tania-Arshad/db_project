using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectA
{
    public partial class Evaluation : Form
    {
        public Evaluation()
        {
            InitializeComponent();
        }
        SqlConnection conStr = new SqlConnection("Data Source=TANIAARSHAD;Initial Catalog=ProjectA;Integrated Security=True");
        public void display_data()
        {
            conStr.Open();
            SqlCommand cmd = conStr.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from evaluation";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dt_evaluation.DataSource = dt;
            conStr.Close();
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TotalMarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmd_insert_Click(object sender, EventArgs e)
        {
            conStr.Open();
            SqlCommand cmd = conStr.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Evaluation(Name,TotalMarks,TotalWeightage) values ('" + txt_Name.Text + "','" + txt_TotalMarks.Text + "','" + txt_tweightage.Text+"')";
            cmd.ExecuteNonQuery();
            conStr.Close();
            display_data();
            MessageBox.Show("data has been inserted");
            txt_Name.Text = "";
            txt_TotalMarks.Text = "";
            txt_tweightage.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main b = new Main();
            b.Show();
            this.Hide();
        }

        private void dt_evaluation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                conStr.Open();
                string del = "delete from Evaluation where Name = '" + dt_evaluation.Rows[e.RowIndex].Cells[3].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(del, conStr);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted");
                conStr.Close();
            }
        }

    }
}
