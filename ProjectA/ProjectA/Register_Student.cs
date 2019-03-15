using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class Register_Student : Form
    {
        public Register_Student()
        {
            InitializeComponent();
            string cmbn = "select Person.FirstName,Person.LastName,Person.Contact,Person.Email,Person.DateofBirth,Student.RegistrationNo From Person inner join Student on Person.Id = Student.Id";
            conStr.Open();
            SqlDataAdapter ta = new SqlDataAdapter();
            ta.SelectCommand = new SqlCommand(cmbn, conStr);
            DataTable w = new DataTable();
            ta.Fill(w);
            BindingSource n = new BindingSource();
            n.DataSource = w;
            dataGridView1.DataSource = n;

        }
        
        SqlConnection conStr = new SqlConnection("Data Source=TANIAARSHAD;Initial Catalog=ProjectA;Integrated Security=True");


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cmd_register_Click(object sender, EventArgs e)
        {
            string cnvrt = cmb_Gender.SelectedItem.ToString();
            string gendervalue = "select id from lookup where category = 'Gender' and value = '" + cnvrt + "'";
            SqlCommand genderInt = new SqlCommand(gendervalue, conStr);
            int value = 0;
            SqlDataReader reader = genderInt.ExecuteReader();
            while (reader.Read())
            {
                value = int.Parse(reader[0].ToString());
            }
            reader.Close();

            string q = "insert into Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) values ('" + txt_fname.Text + "','" + txt_Lname.Text + "','" + txt_contact.Text + "','" + txt_email.Text + "',NULL,'" + value + "')";
            SqlCommand cmd = new SqlCommand(q, conStr);
            cmd.ExecuteNonQuery(); 
            MessageBox.Show("student registration successfull");
            string a = "select * from Person";
            SqlDataAdapter t = new SqlDataAdapter();
            t.SelectCommand = new SqlCommand(a,conStr);
            DataTable w = new DataTable();
            t.Fill(w);

            foreach(DataRow row in w.Rows)
            {
                if(row[1].ToString() == txt_fname.Text && row[2].ToString() == txt_Lname.Text)
                {
                    int y = Convert.ToInt32(row[0].ToString());
                    SqlCommand cm = conStr.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Student (Id,RegistrationNo) values ('" +y+ "','" +txt_rno.Text+"')";
                    cmd.ExecuteNonQuery();
                }
                string cmbn = "select Person.FirstName,Person.LastName,Person.Contact,Person.Email,Person.DateofBirth,Student.RegistrationNo From Person inner join Student on Person.Id = Student.Id";
                SqlDataAdapter ta = new SqlDataAdapter();
                ta.SelectCommand = new SqlCommand(cmbn, conStr);
                DataTable i = new DataTable();
                ta.Fill(i);
                BindingSource n = new BindingSource();
                n.DataSource = i;
                dataGridView1.DataSource = n;
                txt_fname.Text = "";
                txt_Lname.Text = "";
                txt_email.Text = "";
                txt_contact.Text = "";
                txt_rno.Text = "";
            }
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cntct_Click(object sender, EventArgs e)
        {

        }

        private void cmd_back_Click(object sender, EventArgs e)
        {
            Main q = new Main();
            q.Show();
            this.Hide();
        }
    }
}