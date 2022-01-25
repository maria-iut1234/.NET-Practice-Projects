namespace Lab_07_LMS_System
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_teacher_name = new System.Windows.Forms.TextBox();
            this.comboBox_teacher_type = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_course_title = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_course_type = new System.Windows.Forms.ComboBox();
            this.comboBox_course_teacher = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox_teacher = new System.Windows.Forms.ListBox();
            this.comboBox_teacher = new System.Windows.Forms.ComboBox();
            this.ShowTeacherInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_course_semester = new System.Windows.Forms.ComboBox();
            this.textBox_course_code = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_student_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_student_semester = new System.Windows.Forms.ComboBox();
            this.comboBox_student_course = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox_student = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox_student = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teacher Type";
            // 
            // textBox_teacher_name
            // 
            this.textBox_teacher_name.Location = new System.Drawing.Point(119, 45);
            this.textBox_teacher_name.Name = "textBox_teacher_name";
            this.textBox_teacher_name.Size = new System.Drawing.Size(177, 22);
            this.textBox_teacher_name.TabIndex = 6;
            // 
            // comboBox_teacher_type
            // 
            this.comboBox_teacher_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_teacher_type.FormattingEnabled = true;
            this.comboBox_teacher_type.Items.AddRange(new object[] {
            "Lecturer",
            "Professor"});
            this.comboBox_teacher_type.Location = new System.Drawing.Point(119, 85);
            this.comboBox_teacher_type.Name = "comboBox_teacher_type";
            this.comboBox_teacher_type.Size = new System.Drawing.Size(177, 24);
            this.comboBox_teacher_type.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddTeacher);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Course Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Course Type";
            // 
            // textBox_course_title
            // 
            this.textBox_course_title.Location = new System.Drawing.Point(116, 118);
            this.textBox_course_title.Name = "textBox_course_title";
            this.textBox_course_title.Size = new System.Drawing.Size(177, 22);
            this.textBox_course_title.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Course Title";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Semester";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Teacher";
            // 
            // comboBox_course_type
            // 
            this.comboBox_course_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_course_type.FormattingEnabled = true;
            this.comboBox_course_type.Items.AddRange(new object[] {
            "Lab",
            "Theory"});
            this.comboBox_course_type.Location = new System.Drawing.Point(116, 78);
            this.comboBox_course_type.Name = "comboBox_course_type";
            this.comboBox_course_type.Size = new System.Drawing.Size(177, 24);
            this.comboBox_course_type.TabIndex = 18;
            this.comboBox_course_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_course_type_SelectedIndexChanged);
            // 
            // comboBox_course_teacher
            // 
            this.comboBox_course_teacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_course_teacher.FormattingEnabled = true;
            this.comboBox_course_teacher.Location = new System.Drawing.Point(116, 197);
            this.comboBox_course_teacher.Name = "comboBox_course_teacher";
            this.comboBox_course_teacher.Size = new System.Drawing.Size(177, 24);
            this.comboBox_course_teacher.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 38);
            this.button2.TabIndex = 22;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddCourse);
            // 
            // listBox_teacher
            // 
            this.listBox_teacher.FormattingEnabled = true;
            this.listBox_teacher.HorizontalExtent = 200;
            this.listBox_teacher.HorizontalScrollbar = true;
            this.listBox_teacher.ItemHeight = 16;
            this.listBox_teacher.Location = new System.Drawing.Point(15, 254);
            this.listBox_teacher.Name = "listBox_teacher";
            this.listBox_teacher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox_teacher.Size = new System.Drawing.Size(365, 244);
            this.listBox_teacher.TabIndex = 23;
            // 
            // comboBox_teacher
            // 
            this.comboBox_teacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_teacher.FormattingEnabled = true;
            this.comboBox_teacher.Location = new System.Drawing.Point(10, 536);
            this.comboBox_teacher.Name = "comboBox_teacher";
            this.comboBox_teacher.Size = new System.Drawing.Size(177, 24);
            this.comboBox_teacher.TabIndex = 24;
            // 
            // ShowTeacherInfo
            // 
            this.ShowTeacherInfo.Location = new System.Drawing.Point(241, 536);
            this.ShowTeacherInfo.Name = "ShowTeacherInfo";
            this.ShowTeacherInfo.Size = new System.Drawing.Size(139, 47);
            this.ShowTeacherInfo.TabIndex = 25;
            this.ShowTeacherInfo.Text = "Show\r\nTeacher Info\r\n";
            this.ShowTeacherInfo.UseVisualStyleBackColor = true;
            this.ShowTeacherInfo.Click += new System.EventHandler(this.ShowTeacherInfo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_course_semester);
            this.panel1.Controls.Add(this.textBox_course_code);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBox_course_teacher);
            this.panel1.Controls.Add(this.comboBox_course_type);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox_course_title);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(406, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 303);
            this.panel1.TabIndex = 26;
            // 
            // comboBox_course_semester
            // 
            this.comboBox_course_semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_course_semester.FormattingEnabled = true;
            this.comboBox_course_semester.Items.AddRange(new object[] {
            "Summer",
            "Winter"});
            this.comboBox_course_semester.Location = new System.Drawing.Point(116, 155);
            this.comboBox_course_semester.Name = "comboBox_course_semester";
            this.comboBox_course_semester.Size = new System.Drawing.Size(177, 24);
            this.comboBox_course_semester.TabIndex = 34;
            // 
            // textBox_course_code
            // 
            this.textBox_course_code.Location = new System.Drawing.Point(116, 41);
            this.textBox_course_code.Name = "textBox_course_code";
            this.textBox_course_code.Size = new System.Drawing.Size(177, 22);
            this.textBox_course_code.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ShowTeacherInfo);
            this.panel2.Controls.Add(this.comboBox_teacher);
            this.panel2.Controls.Add(this.listBox_teacher);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.comboBox_teacher_type);
            this.panel2.Controls.Add(this.textBox_teacher_name);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 624);
            this.panel2.TabIndex = 27;
            // 
            // textBox_student_name
            // 
            this.textBox_student_name.Location = new System.Drawing.Point(124, 47);
            this.textBox_student_name.Name = "textBox_student_name";
            this.textBox_student_name.Size = new System.Drawing.Size(177, 22);
            this.textBox_student_name.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Semester";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Course";
            // 
            // comboBox_student_semester
            // 
            this.comboBox_student_semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_student_semester.FormattingEnabled = true;
            this.comboBox_student_semester.Items.AddRange(new object[] {
            "Summer",
            "Winter"});
            this.comboBox_student_semester.Location = new System.Drawing.Point(124, 82);
            this.comboBox_student_semester.Name = "comboBox_student_semester";
            this.comboBox_student_semester.Size = new System.Drawing.Size(177, 24);
            this.comboBox_student_semester.TabIndex = 23;
            this.comboBox_student_semester.SelectedIndexChanged += new System.EventHandler(this.comboBox_student_semester_SelectedIndexChanged);
            // 
            // comboBox_student_course
            // 
            this.comboBox_student_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_student_course.FormattingEnabled = true;
            this.comboBox_student_course.Location = new System.Drawing.Point(124, 122);
            this.comboBox_student_course.Name = "comboBox_student_course";
            this.comboBox_student_course.Size = new System.Drawing.Size(177, 24);
            this.comboBox_student_course.TabIndex = 31;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(209, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 38);
            this.button4.TabIndex = 23;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AddStudent);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(248, 533);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 47);
            this.button5.TabIndex = 28;
            this.button5.Text = "Show\r\nStudent Info\r\n";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ShowStudentInfo);
            // 
            // listBox_student
            // 
            this.listBox_student.FormattingEnabled = true;
            this.listBox_student.ItemHeight = 16;
            this.listBox_student.Location = new System.Drawing.Point(20, 252);
            this.listBox_student.Name = "listBox_student";
            this.listBox_student.Size = new System.Drawing.Size(367, 244);
            this.listBox_student.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox_student);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.comboBox_student_course);
            this.panel3.Controls.Add(this.listBox_student);
            this.panel3.Controls.Add(this.comboBox_student_semester);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.textBox_student_name);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(738, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 620);
            this.panel3.TabIndex = 32;
            // 
            // comboBox_student
            // 
            this.comboBox_student.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_student.FormattingEnabled = true;
            this.comboBox_student.Location = new System.Drawing.Point(20, 545);
            this.comboBox_student.Name = "comboBox_student";
            this.comboBox_student.Size = new System.Drawing.Size(177, 24);
            this.comboBox_student.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 667);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_teacher_name;
        private System.Windows.Forms.ComboBox comboBox_teacher_type;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_course_title;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_course_type;
        private System.Windows.Forms.ComboBox comboBox_course_teacher;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox_teacher;
        private System.Windows.Forms.ComboBox comboBox_teacher;
        private System.Windows.Forms.Button ShowTeacherInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_student_name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox_student_semester;
        private System.Windows.Forms.ComboBox comboBox_student_course;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox_student;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_course_code;
        private System.Windows.Forms.ComboBox comboBox_course_semester;
        private System.Windows.Forms.ComboBox comboBox_student;
    }
}

