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
    public partial class LOG : Form
    {
        public LOG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HUMPTY1409;Initial Catalog=SIMS;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count ( * ) From Login where Username='" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Home hp = new Home();
                hp.Show();
            }
            else
            {
                MessageBox.Show("Please check your username & password again!");
            }

        }
    }
}
