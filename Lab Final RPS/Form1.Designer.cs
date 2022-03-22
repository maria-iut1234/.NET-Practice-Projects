namespace Lab_Final_RPS
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
            this.listBox_show_list = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_search_ID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_show_search_result = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "IUT Result Processing System";
            // 
            // listBox_show_list
            // 
            this.listBox_show_list.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_show_list.FormattingEnabled = true;
            this.listBox_show_list.ItemHeight = 15;
            this.listBox_show_list.Location = new System.Drawing.Point(29, 113);
            this.listBox_show_list.Name = "listBox_show_list";
            this.listBox_show_list.Size = new System.Drawing.Size(681, 439);
            this.listBox_show_list.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course Name: Object Oriented Concepts I";
            // 
            // textBox_search_ID
            // 
            this.textBox_search_ID.Location = new System.Drawing.Point(730, 113);
            this.textBox_search_ID.Name = "textBox_search_ID";
            this.textBox_search_ID.Size = new System.Drawing.Size(284, 22);
            this.textBox_search_ID.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(730, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search by ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSearchByID);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(763, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Developed By:";
            // 
            // label_show_search_result
            // 
            this.label_show_search_result.AutoSize = true;
            this.label_show_search_result.Location = new System.Drawing.Point(764, 240);
            this.label_show_search_result.Name = "label_show_search_result";
            this.label_show_search_result.Size = new System.Drawing.Size(0, 16);
            this.label_show_search_result.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(932, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "200042172";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 631);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_show_search_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_search_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_show_list);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_show_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_search_ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_show_search_result;
        private System.Windows.Forms.Label label4;
    }
}

