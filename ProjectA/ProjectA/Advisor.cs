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
    public partial class Advisor : Form
    {
        public Advisor()
        {
            InitializeComponent();
        }
        SqlConnection conStr = new SqlConnection("Data Source=TANIAARSHAD;Initial Catalog=ProjectA;Integrated Security=True");
        private void lbl_Lname_Click(object sender, EventArgs e)
        {

        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void cmd_register_Click(object sender, EventArgs e)
        {
            conStr.Open();
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
            string con = cmb_designation.SelectedItem.ToString();
            string desigvalue = "select id from lookup where category = 'Designation' and value = '" + con + "'";
            SqlCommand desigInt = new SqlCommand(desigvalue, conStr);
            int vlu = 0;
            SqlDataReader rad = desigInt.ExecuteReader();
            while (rad.Read())
            {
                vlu = int.Parse(rad[0].ToString());
            }
            rad.Close();

            string q = "insert into Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) values ('" + txt_fname.Text + "','" + txt_Lname.Text + "','" + txt_contact.Text + "','" + txt_email.Text + "',NULL,'" + value + "')";
            SqlCommand cmd = new SqlCommand(q, conStr);
            cmd.ExecuteNonQuery();
            MessageBox.Show("student registration successfull");
            string a = "select * from Person";
            SqlDataAdapter t = new SqlDataAdapter();
            t.SelectCommand = new SqlCommand(a, conStr);
            DataTable w = new DataTable();
            t.Fill(w);

            foreach (DataRow row in w.Rows)
            {
                if (row[1].ToString() == txt_fname.Text && row[2].ToString() == txt_Lname.Text)
                {
                    int y = Convert.ToInt32(row[0].ToString());
                    SqlCommand cm = conStr.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Advisor (Id,Designation,Salary) values ('" + y + "','" + vlu + "','" + txt_salary.Text + "')";
                    cmd.ExecuteNonQuery();
                }
                string cmbn = "select Person.FirstName,Person.LastName,Person.Contact,Person.Email,Person.DateofBirth,Advisor.DESIGNATION,Advisor.Salary From Person inner join Advisor on Person.Id = Advisor.Id";
                SqlDataAdapter ta = new SqlDataAdapter();
                ta.SelectCommand = new SqlCommand(cmbn, conStr);
                DataTable i = new DataTable();
                ta.Fill(i);
                BindingSource n = new BindingSource();
                n.DataSource = i;
                dt_advisor.DataSource = n;
                txt_fname.Text = "";
                txt_Lname.Text = "";
                txt_email.Text = "";
                txt_contact.Text = "";
                txt_salary.Text = "";
                cmb_designation.Text = "";
                cmb_Gender.Text = "";

            }
            }

        private void cmd_back_Click(object sender, EventArgs e)
        {
            Main b = new Main();
            b.Show();
            this.Hide();
        }
    }
    }
