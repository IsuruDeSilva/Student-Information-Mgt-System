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

namespace SIMS
{
    public partial class Courses_Window : Form
    {
        public Courses_Window()
        {
            InitializeComponent();
        }

        private void Courses_Window_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HUMPTY1409;Initial Catalog=SIMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into courses values (@Course_ID,@Course_Name,@Module_Code,@Module_Name,@Credit_Value)", con);
            cmd.Parameters.AddWithValue("@Course_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Course_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Module_Code", textBox3.Text);
            cmd.Parameters.AddWithValue("@Module_Name", textBox4.Text);
            cmd.Parameters.AddWithValue("@Credit_Value", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Inserted!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HUMPTY1409;Initial Catalog=SIMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Courses set Course_Name =@Course_Name, Module_Code =@Module_Code, Module_Name =@Module_Name, Credit_Value =@Credit_Value Where Course_ID = @Course_ID", con);
            cmd.Parameters.AddWithValue("@Course_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Course_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Module_Code", textBox3.Text);
            cmd.Parameters.AddWithValue("@Module_Name", textBox4.Text);
            cmd.Parameters.AddWithValue("@Credit_Value", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HUMPTY1409;Initial Catalog=SIMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Courses Where Course_ID = @Course_ID", con);
            cmd.Parameters.AddWithValue("@Course_ID", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HUMPTY1409;Initial Catalog=SIMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Courses where Course_ID = @Course_ID", con);
            cmd.Parameters.AddWithValue("@Course_ID", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
