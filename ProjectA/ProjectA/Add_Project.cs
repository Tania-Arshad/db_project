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
    public partial class Add_Project : Form
    {
        public Add_Project()
        {
            InitializeComponent();
        }
        SqlConnection conStr = new SqlConnection("Data Source=TANIAARSHAD;Initial Catalog=ProjectA;Integrated Security=True");
        private void txt_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Id_Click(object sender, EventArgs e)
        {

        }

        private void cmd_insert_Click(object sender, EventArgs e)
        {
            conStr.Open();
            SqlCommand cmd = conStr.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Project(Description,Title) values ('" + txt_description.Text + "','" + txt_title.Text+ "')";
            cmd.ExecuteNonQuery();
            conStr.Close();
            disp_data();
            MessageBox.Show("data has been inserted");
            txt_description.Text = "";
            txt_title.Text = "";

        }

        public void disp_data()
        {
            conStr.Open();
            SqlCommand cmd = conStr.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Project";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dt_project.DataSource = dt;
            conStr.Close();
        }
        private void cmd_back_Click(object sender, EventArgs e)
        {
            Main b = new Main();
            b.Show();
            this.Hide();
        }

        private void dt_project_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                conStr.Open();
                string del = "delete from Project where title = '" + dt_project.Rows[e.RowIndex].Cells[4].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(del, conStr);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted");
            }
        }
    }
}
