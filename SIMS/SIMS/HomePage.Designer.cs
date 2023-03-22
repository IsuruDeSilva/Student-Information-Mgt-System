namespace SIMS
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_student = new System.Windows.Forms.Button();
            this.button_lecturer = new System.Windows.Forms.Button();
            this.button_course = new System.Windows.Forms.Button();
            this.button_department = new System.Windows.Forms.Button();
            this.button_faculty = new System.Windows.Forms.Button();
            this.topic = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_student
            // 
            this.button_student.BackColor = System.Drawing.Color.Gray;
            this.button_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_student.Location = new System.Drawing.Point(601, 350);
            this.button_student.Name = "button_student";
            this.button_student.Size = new System.Drawing.Size(243, 51);
            this.button_student.TabIndex = 14;
            this.button_student.Text = "Students";
            this.button_student.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_student.UseVisualStyleBackColor = false;
            this.button_student.Click += new System.EventHandler(this.button_student_Click);
            // 
            // button_lecturer
            // 
            this.button_lecturer.BackColor = System.Drawing.Color.Gray;
            this.button_lecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lecturer.Location = new System.Drawing.Point(329, 350);
            this.button_lecturer.Name = "button_lecturer";
            this.button_lecturer.Size = new System.Drawing.Size(243, 51);
            this.button_lecturer.TabIndex = 13;
            this.button_lecturer.Text = "Lecturers";
            this.button_lecturer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_lecturer.UseVisualStyleBackColor = false;
            this.button_lecturer.Click += new System.EventHandler(this.button_lecturer_Click);
            // 
            // button_course
            // 
            this.button_course.BackColor = System.Drawing.Color.Gray;
            this.button_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_course.Location = new System.Drawing.Point(768, 247);
            this.button_course.Name = "button_course";
            this.button_course.Size = new System.Drawing.Size(243, 51);
            this.button_course.TabIndex = 12;
            this.button_course.Text = "Courses";
            this.button_course.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_course.UseVisualStyleBackColor = false;
            this.button_course.Click += new System.EventHandler(this.button_course_Click);
            // 
            // button_department
            // 
            this.button_department.BackColor = System.Drawing.Color.Gray;
            this.button_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_department.Location = new System.Drawing.Point(493, 247);
            this.button_department.Name = "button_department";
            this.button_department.Size = new System.Drawing.Size(243, 51);
            this.button_department.TabIndex = 11;
            this.button_department.Text = "Departments";
            this.button_department.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_department.UseVisualStyleBackColor = false;
            this.button_department.Click += new System.EventHandler(this.button_department_Click);
            // 
            // button_faculty
            // 
            this.button_faculty.BackColor = System.Drawing.Color.Gray;
            this.button_faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_faculty.Location = new System.Drawing.Point(222, 247);
            this.button_faculty.Name = "button_faculty";
            this.button_faculty.Size = new System.Drawing.Size(243, 51);
            this.button_faculty.TabIndex = 10;
            this.button_faculty.Text = "Faculties";
            this.button_faculty.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_faculty.UseVisualStyleBackColor = false;
            this.button_faculty.Click += new System.EventHandler(this.button_faculty_Click);
            // 
            // topic
            // 
            this.topic.AutoSize = true;
            this.topic.BackColor = System.Drawing.Color.Transparent;
            this.topic.Font = new System.Drawing.Font("Adobe Gothic Std B", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.topic.Location = new System.Drawing.Point(116, 48);
            this.topic.Name = "topic";
            this.topic.Size = new System.Drawing.Size(948, 60);
            this.topic.TabIndex = 8;
            this.topic.Text = "Student Information Management System";
            this.topic.Click += new System.EventHandler(this.topic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(195, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(832, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "You can search for details, insert, update and delete details.";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1177, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_student);
            this.Controls.Add(this.button_lecturer);
            this.Controls.Add(this.button_course);
            this.Controls.Add(this.button_department);
            this.Controls.Add(this.button_faculty);
            this.Controls.Add(this.topic);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Home";
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_student;
        private System.Windows.Forms.Button button_lecturer;
        private System.Windows.Forms.Button button_course;
        private System.Windows.Forms.Button button_department;
        private System.Windows.Forms.Button button_faculty;
        private System.Windows.Forms.Label topic;
        private System.Windows.Forms.Label label2;
    }
}