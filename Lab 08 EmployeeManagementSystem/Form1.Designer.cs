namespace Lab_08_EmployeeManagementSystem
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
            this.textBox_add_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_add_contact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_add_designation = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_add = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_update_empID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_update_contact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_update_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listBox_show = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox_show_empID = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // textBox_add_name
            // 
            this.textBox_add_name.Location = new System.Drawing.Point(117, 58);
            this.textBox_add_name.Name = "textBox_add_name";
            this.textBox_add_name.Size = new System.Drawing.Size(210, 22);
            this.textBox_add_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Designation";
            // 
            // textBox_add_contact
            // 
            this.textBox_add_contact.Location = new System.Drawing.Point(117, 145);
            this.textBox_add_contact.Name = "textBox_add_contact";
            this.textBox_add_contact.Size = new System.Drawing.Size(210, 22);
            this.textBox_add_contact.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Date of Joining";
            // 
            // comboBox_add_designation
            // 
            this.comboBox_add_designation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_add_designation.FormattingEnabled = true;
            this.comboBox_add_designation.Items.AddRange(new object[] {
            "Manager",
            "Typewriter",
            "Salesperson"});
            this.comboBox_add_designation.Location = new System.Drawing.Point(117, 100);
            this.comboBox_add_designation.Name = "comboBox_add_designation";
            this.comboBox_add_designation.Size = new System.Drawing.Size(209, 24);
            this.comboBox_add_designation.TabIndex = 11;
            // 
            // dateTimePicker_add
            // 
            this.dateTimePicker_add.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_add.Location = new System.Drawing.Point(117, 190);
            this.dateTimePicker_add.Name = "dateTimePicker_add";
            this.dateTimePicker_add.Size = new System.Drawing.Size(210, 22);
            this.dateTimePicker_add.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddEmployee);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker_add);
            this.panel1.Controls.Add(this.comboBox_add_designation);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_add_contact);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_add_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 300);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_update_empID);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox_update_contact);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox_update_name);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(12, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 278);
            this.panel2.TabIndex = 15;
            // 
            // textBox_update_empID
            // 
            this.textBox_update_empID.Location = new System.Drawing.Point(117, 61);
            this.textBox_update_empID.Name = "textBox_update_empID";
            this.textBox_update_empID.Size = new System.Drawing.Size(210, 22);
            this.textBox_update_empID.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Employee ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.UpdateEmployee);
            // 
            // textBox_update_contact
            // 
            this.textBox_update_contact.Location = new System.Drawing.Point(117, 148);
            this.textBox_update_contact.Name = "textBox_update_contact";
            this.textBox_update_contact.Size = new System.Drawing.Size(210, 22);
            this.textBox_update_contact.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Contact";
            // 
            // textBox_update_name
            // 
            this.textBox_update_name.Location = new System.Drawing.Point(117, 102);
            this.textBox_update_name.Name = "textBox_update_name";
            this.textBox_update_name.Size = new System.Drawing.Size(210, 22);
            this.textBox_update_name.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Update Employee";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(399, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "Show Employee";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(401, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Employee ID";
            // 
            // listBox_show
            // 
            this.listBox_show.FormattingEnabled = true;
            this.listBox_show.ItemHeight = 16;
            this.listBox_show.Location = new System.Drawing.Point(407, 121);
            this.listBox_show.Name = "listBox_show";
            this.listBox_show.Size = new System.Drawing.Size(317, 420);
            this.listBox_show.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(515, 571);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 37);
            this.button3.TabIndex = 16;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ShowEmployee);
            // 
            // comboBox_show_empID
            // 
            this.comboBox_show_empID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_show_empID.FormattingEnabled = true;
            this.comboBox_show_empID.Location = new System.Drawing.Point(515, 70);
            this.comboBox_show_empID.Name = "comboBox_show_empID";
            this.comboBox_show_empID.Size = new System.Drawing.Size(209, 24);
            this.comboBox_show_empID.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 638);
            this.Controls.Add(this.comboBox_show_empID);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox_show);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_add_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_add_contact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_add_designation;
        private System.Windows.Forms.DateTimePicker dateTimePicker_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_update_empID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_update_contact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_update_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBox_show;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox_show_empID;
    }
}

