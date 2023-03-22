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
    public partial class Departments_Window : Form
    {
        public Departments_Window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HUMPTY1409;Initial Catalog=SIMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Dept values (@Dept_ID,@Dept_Name) ", con);
            cmd.Parameters.AddWithValue("@Dept_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Dept_Name", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Inserted!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HUMPTY1409;Initial Catalog=SIMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Dept set Dept_Name =@Dept_Name Where Dept_ID = @Dept_ID", con);
            cmd.Parameters.AddWithValue("@Dept_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Dept_Name", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HUMPTY1409;Initial Catalog=SIMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Dept Where Dept_ID = @Dept_ID", con);
            cmd.Parameters.AddWithValue("Dept_ID", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HUMPTY1409;Initial Catalog=SIMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Dept where Dept_ID = @Dept_ID",con);
            cmd.Parameters.AddWithValue("@Dept_ID", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
