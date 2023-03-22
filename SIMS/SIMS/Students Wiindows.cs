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
    public partial class Students_Wiindows : Form
    {
        public Students_Wiindows()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HUMPTY1409;Initial Catalog=SIMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Student values (@Stud_ID,@Stud_Name) ", con);
            cmd.Parameters.AddWithValue("@Stud_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Stud_Name", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Inserted!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HUMPTY1409;Initial Catalog=SIMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Student set Stud_Name =@Stud_Name Where Stud_ID = @Stud_ID", con);
            cmd.Parameters.AddWithValue("@Stud_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Stud_Name", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HUMPTY1409;Initial Catalog=SIMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Student Where Stud_ID = @Stud_ID", con);
            cmd.Parameters.AddWithValue("@Stud_ID", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HUMPTY1409;Initial Catalog=SIMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Student where Stud_ID = @Stud_ID", con);
            cmd.Parameters.AddWithValue("@Stud_ID", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
