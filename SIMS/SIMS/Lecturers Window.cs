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
    public partial class Lecturers_Window : Form
    {
        public Lecturers_Window()
        {
            InitializeComponent();
        }

              private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HUMPTY1409;Initial Catalog=SIMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Lecturers values (@Lect_ID,@Lect_Name) ", con);
            cmd.Parameters.AddWithValue("@Lect_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Lect_Name", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Inserted!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HUMPTY1409;Initial Catalog=SIMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Lecturers set Lect_Name =@Lect_Name Where Lect_ID = @Lect_ID", con);
            cmd.Parameters.AddWithValue("@Lect_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Lect_Name", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HUMPTY1409;Initial Catalog=SIMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Lecturers Where Lect_ID = @Lect_ID", con);
            cmd.Parameters.AddWithValue("@Lect_ID", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HUMPTY1409;Initial Catalog=SIMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Lecturers where Lect_ID = @Lect_ID", con);
            cmd.Parameters.AddWithValue("@Lect_ID", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
