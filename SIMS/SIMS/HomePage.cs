using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button_faculty_Click(object sender, EventArgs e)
        {
            Faculty ff = new Faculty();
            ff.Show();
        }

        private void button_department_Click(object sender, EventArgs e)
        {
            Departments_Window dd = new Departments_Window();
            dd.Show();
        }

        private void button_course_Click(object sender, EventArgs e)
        {
            Courses_Window cc = new Courses_Window();
            cc.Show();
        }

        private void button_lecturer_Click(object sender, EventArgs e)
        {
            Lecturers_Window ll = new Lecturers_Window();
            ll.Show();
        }

        private void button_student_Click(object sender, EventArgs e)
        {
            Students_Wiindows ss = new Students_Wiindows();
            ss.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void topic_Click(object sender, EventArgs e)
        {

        }
    }
}
