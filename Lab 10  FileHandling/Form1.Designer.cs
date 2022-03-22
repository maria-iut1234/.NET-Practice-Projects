namespace Lab_10__FileHandling__Even_
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
            this.listBox_database = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_search_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label_show_search_results = new System.Windows.Forms.Label();
            this.label_showSearchInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database";
            // 
            // listBox_database
            // 
            this.listBox_database.FormattingEnabled = true;
            this.listBox_database.ItemHeight = 16;
            this.listBox_database.Location = new System.Drawing.Point(17, 51);
            this.listBox_database.Name = "listBox_database";
            this.listBox_database.Size = new System.Drawing.Size(667, 580);
            this.listBox_database.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 653);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.showDatabase);
            // 
            // textBox_search_email
            // 
            this.textBox_search_email.Location = new System.Drawing.Point(731, 97);
            this.textBox_search_email.Name = "textBox_search_email";
            this.textBox_search_email.Size = new System.Drawing.Size(339, 22);
            this.textBox_search_email.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(726, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search using email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(728, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "User email:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(840, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.searchUser);
            // 
            // label_show_search_results
            // 
            this.label_show_search_results.AutoSize = true;
            this.label_show_search_results.Location = new System.Drawing.Point(664, 212);
            this.label_show_search_results.Name = "label_show_search_results";
            this.label_show_search_results.Size = new System.Drawing.Size(0, 16);
            this.label_show_search_results.TabIndex = 7;
            // 
            // label_showSearchInfo
            // 
            this.label_showSearchInfo.AutoSize = true;
            this.label_showSearchInfo.Location = new System.Drawing.Point(728, 233);
            this.label_showSearchInfo.Name = "label_showSearchInfo";
            this.label_showSearchInfo.Size = new System.Drawing.Size(0, 16);
            this.label_showSearchInfo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 734);
            this.Controls.Add(this.label_showSearchInfo);
            this.Controls.Add(this.label_show_search_results);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_search_email);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox_database);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_database;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_search_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_show_search_results;
        private System.Windows.Forms.Label label_showSearchInfo;
    }
}

