namespace EmployeeManagement
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
            this.label_studentID = new System.Windows.Forms.Label();
            this.label_std_name = new System.Windows.Forms.Label();
            this.label_std_dep = new System.Windows.Forms.Label();
            this.text_studentID = new System.Windows.Forms.TextBox();
            this.text_std_name = new System.Windows.Forms.TextBox();
            this.text_std_dep = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_std_sem = new System.Windows.Forms.Label();
            this.text_std_sem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_tchID = new System.Windows.Forms.Label();
            this.label_tch_dep = new System.Windows.Forms.Label();
            this.label_tch_sem = new System.Windows.Forms.Label();
            this.text_tchID = new System.Windows.Forms.TextBox();
            this.text_tch_name = new System.Windows.Forms.TextBox();
            this.text_tch_dep = new System.Windows.Forms.TextBox();
            this.text_tch_sem = new System.Windows.Forms.TextBox();
            this.listBox_tch = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_tch_salary = new System.Windows.Forms.Label();
            this.text_tch_salary = new System.Windows.Forms.TextBox();
            this.listBox_std = new System.Windows.Forms.ListBox();
            this.label_tch_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_studentID
            // 
            this.label_studentID.AutoSize = true;
            this.label_studentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_studentID.Location = new System.Drawing.Point(11, 81);
            this.label_studentID.Name = "label_studentID";
            this.label_studentID.Size = new System.Drawing.Size(76, 18);
            this.label_studentID.TabIndex = 0;
            this.label_studentID.Text = "Student ID";
            // 
            // label_std_name
            // 
            this.label_std_name.AutoSize = true;
            this.label_std_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_std_name.Location = new System.Drawing.Point(12, 143);
            this.label_std_name.Name = "label_std_name";
            this.label_std_name.Size = new System.Drawing.Size(48, 18);
            this.label_std_name.TabIndex = 1;
            this.label_std_name.Text = "Name";
            // 
            // label_std_dep
            // 
            this.label_std_dep.AutoSize = true;
            this.label_std_dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_std_dep.Location = new System.Drawing.Point(7, 202);
            this.label_std_dep.Name = "label_std_dep";
            this.label_std_dep.Size = new System.Drawing.Size(85, 18);
            this.label_std_dep.TabIndex = 2;
            this.label_std_dep.Text = "Department";
            // 
            // text_studentID
            // 
            this.text_studentID.Location = new System.Drawing.Point(99, 71);
            this.text_studentID.Multiline = true;
            this.text_studentID.Name = "text_studentID";
            this.text_studentID.Size = new System.Drawing.Size(197, 28);
            this.text_studentID.TabIndex = 3;
            // 
            // text_std_name
            // 
            this.text_std_name.Location = new System.Drawing.Point(99, 133);
            this.text_std_name.Multiline = true;
            this.text_std_name.Name = "text_std_name";
            this.text_std_name.Size = new System.Drawing.Size(197, 28);
            this.text_std_name.TabIndex = 4;
            // 
            // text_std_dep
            // 
            this.text_std_dep.Location = new System.Drawing.Point(99, 192);
            this.text_std_dep.Multiline = true;
            this.text_std_dep.Name = "text_std_dep";
            this.text_std_dep.Size = new System.Drawing.Size(197, 28);
            this.text_std_dep.TabIndex = 5;
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(14, 371);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(107, 40);
            this.button.TabIndex = 6;
            this.button.Text = "Save";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.SaveStudent);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(189, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClearStudent);
            // 
            // label_std_sem
            // 
            this.label_std_sem.AutoSize = true;
            this.label_std_sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_std_sem.Location = new System.Drawing.Point(7, 261);
            this.label_std_sem.Name = "label_std_sem";
            this.label_std_sem.Size = new System.Drawing.Size(72, 18);
            this.label_std_sem.TabIndex = 8;
            this.label_std_sem.Text = "Semester";
            // 
            // text_std_sem
            // 
            this.text_std_sem.Location = new System.Drawing.Point(99, 251);
            this.text_std_sem.Multiline = true;
            this.text_std_sem.Name = "text_std_sem";
            this.text_std_sem.Size = new System.Drawing.Size(197, 28);
            this.text_std_sem.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Student";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(401, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Show Student Info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ShowStudentInfo);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(721, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Teacher";
            // 
            // label_tchID
            // 
            this.label_tchID.AutoSize = true;
            this.label_tchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tchID.Location = new System.Drawing.Point(723, 81);
            this.label_tchID.Name = "label_tchID";
            this.label_tchID.Size = new System.Drawing.Size(80, 18);
            this.label_tchID.TabIndex = 14;
            this.label_tchID.Text = "Teacher ID";
            // 
            // label_tch_dep
            // 
            this.label_tch_dep.AutoSize = true;
            this.label_tch_dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tch_dep.Location = new System.Drawing.Point(723, 202);
            this.label_tch_dep.Name = "label_tch_dep";
            this.label_tch_dep.Size = new System.Drawing.Size(85, 18);
            this.label_tch_dep.TabIndex = 16;
            this.label_tch_dep.Text = "Department";
            // 
            // label_tch_sem
            // 
            this.label_tch_sem.AutoSize = true;
            this.label_tch_sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tch_sem.Location = new System.Drawing.Point(723, 260);
            this.label_tch_sem.Name = "label_tch_sem";
            this.label_tch_sem.Size = new System.Drawing.Size(72, 18);
            this.label_tch_sem.TabIndex = 17;
            this.label_tch_sem.Text = "Semester";
            // 
            // text_tchID
            // 
            this.text_tchID.Location = new System.Drawing.Point(820, 71);
            this.text_tchID.Multiline = true;
            this.text_tchID.Name = "text_tchID";
            this.text_tchID.Size = new System.Drawing.Size(197, 28);
            this.text_tchID.TabIndex = 18;
            // 
            // text_tch_name
            // 
            this.text_tch_name.Location = new System.Drawing.Point(820, 133);
            this.text_tch_name.Multiline = true;
            this.text_tch_name.Name = "text_tch_name";
            this.text_tch_name.Size = new System.Drawing.Size(197, 28);
            this.text_tch_name.TabIndex = 19;
            // 
            // text_tch_dep
            // 
            this.text_tch_dep.Location = new System.Drawing.Point(820, 192);
            this.text_tch_dep.Multiline = true;
            this.text_tch_dep.Name = "text_tch_dep";
            this.text_tch_dep.Size = new System.Drawing.Size(197, 28);
            this.text_tch_dep.TabIndex = 20;
            // 
            // text_tch_sem
            // 
            this.text_tch_sem.Location = new System.Drawing.Point(820, 251);
            this.text_tch_sem.Multiline = true;
            this.text_tch_sem.Name = "text_tch_sem";
            this.text_tch_sem.Size = new System.Drawing.Size(197, 28);
            this.text_tch_sem.TabIndex = 21;
            // 
            // listBox_tch
            // 
            this.listBox_tch.FormattingEnabled = true;
            this.listBox_tch.ItemHeight = 16;
            this.listBox_tch.Location = new System.Drawing.Point(1047, 71);
            this.listBox_tch.Name = "listBox_tch";
            this.listBox_tch.Size = new System.Drawing.Size(354, 260);
            this.listBox_tch.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(726, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 40);
            this.button3.TabIndex = 23;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SaveTeacher);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(910, 371);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 40);
            this.button4.TabIndex = 24;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ClearTeacher);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1144, 371);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 40);
            this.button5.TabIndex = 25;
            this.button5.Text = "Show Teacher Info";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ShowTeacherInfo);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(698, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8, 419);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label_tch_salary
            // 
            this.label_tch_salary.AutoSize = true;
            this.label_tch_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tch_salary.Location = new System.Drawing.Point(723, 317);
            this.label_tch_salary.Name = "label_tch_salary";
            this.label_tch_salary.Size = new System.Drawing.Size(49, 18);
            this.label_tch_salary.TabIndex = 27;
            this.label_tch_salary.Text = "Salary";
            // 
            // text_tch_salary
            // 
            this.text_tch_salary.Location = new System.Drawing.Point(820, 307);
            this.text_tch_salary.Multiline = true;
            this.text_tch_salary.Name = "text_tch_salary";
            this.text_tch_salary.Size = new System.Drawing.Size(197, 28);
            this.text_tch_salary.TabIndex = 28;
            // 
            // listBox_std
            // 
            this.listBox_std.FormattingEnabled = true;
            this.listBox_std.ItemHeight = 16;
            this.listBox_std.Location = new System.Drawing.Point(320, 71);
            this.listBox_std.Name = "listBox_std";
            this.listBox_std.Size = new System.Drawing.Size(354, 260);
            this.listBox_std.TabIndex = 29;
            // 
            // label_tch_name
            // 
            this.label_tch_name.AutoSize = true;
            this.label_tch_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tch_name.Location = new System.Drawing.Point(724, 143);
            this.label_tch_name.Name = "label_tch_name";
            this.label_tch_name.Size = new System.Drawing.Size(48, 18);
            this.label_tch_name.TabIndex = 30;
            this.label_tch_name.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 463);
            this.Controls.Add(this.label_tch_name);
            this.Controls.Add(this.listBox_std);
            this.Controls.Add(this.text_tch_salary);
            this.Controls.Add(this.label_tch_salary);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox_tch);
            this.Controls.Add(this.text_tch_sem);
            this.Controls.Add(this.text_tch_dep);
            this.Controls.Add(this.text_tch_name);
            this.Controls.Add(this.text_tchID);
            this.Controls.Add(this.label_tch_sem);
            this.Controls.Add(this.label_tch_dep);
            this.Controls.Add(this.label_tchID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_std_sem);
            this.Controls.Add(this.label_std_sem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.text_std_dep);
            this.Controls.Add(this.text_std_name);
            this.Controls.Add(this.text_studentID);
            this.Controls.Add(this.label_std_dep);
            this.Controls.Add(this.label_std_name);
            this.Controls.Add(this.label_studentID);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_studentID;
        private System.Windows.Forms.Label label_std_name;
        private System.Windows.Forms.Label label_std_dep;
        private System.Windows.Forms.TextBox text_studentID;
        private System.Windows.Forms.TextBox text_std_name;
        private System.Windows.Forms.TextBox text_std_dep;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_std_sem;
        private System.Windows.Forms.TextBox text_std_sem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_tchID;
        private System.Windows.Forms.Label label_tch_dep;
        private System.Windows.Forms.Label label_tch_sem;
        private System.Windows.Forms.TextBox text_tchID;
        private System.Windows.Forms.TextBox text_tch_name;
        private System.Windows.Forms.TextBox text_tch_dep;
        private System.Windows.Forms.TextBox text_tch_sem;
        private System.Windows.Forms.ListBox listBox_tch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_tch_salary;
        private System.Windows.Forms.TextBox text_tch_salary;
        private System.Windows.Forms.ListBox listBox_std;
        private System.Windows.Forms.Label label_tch_name;
    }
}

