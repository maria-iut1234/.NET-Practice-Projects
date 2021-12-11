namespace Car_Rental_System
{
    partial class CarRentalSystem
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
            this.label_userID = new System.Windows.Forms.Label();
            this.label_user_name = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_destination = new System.Windows.Forms.Label();
            this.text_userID = new System.Windows.Forms.TextBox();
            this.text_user_name = new System.Windows.Forms.TextBox();
            this.text_address = new System.Windows.Forms.TextBox();
            this.text_destination = new System.Windows.Forms.TextBox();
            this.text_num_of_cars = new System.Windows.Forms.TextBox();
            this.text_car_model = new System.Windows.Forms.TextBox();
            this.text_car_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_model = new System.Windows.Forms.Label();
            this.label_car_name = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_save_user = new System.Windows.Forms.Button();
            this.button_save_car = new System.Windows.Forms.Button();
            this.text_rent_car_name = new System.Windows.Forms.TextBox();
            this.label_rent_car_name = new System.Windows.Forms.Label();
            this.text_rent_userID = new System.Windows.Forms.TextBox();
            this.label_rent_userID = new System.Windows.Forms.Label();
            this.button_rent_car = new System.Windows.Forms.Button();
            this.button_show_user_hist = new System.Windows.Forms.Button();
            this.text_hist_userID = new System.Windows.Forms.TextBox();
            this.label_hist_destination = new System.Windows.Forms.Label();
            this.label_hist_address = new System.Windows.Forms.Label();
            this.label_hist_user_name = new System.Windows.Forms.Label();
            this.label_history_userID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_hist_rented_car = new System.Windows.Forms.Label();
            this.text_hist_car_name = new System.Windows.Forms.TextBox();
            this.label_hist_available_unit = new System.Windows.Forms.Label();
            this.label_hist_model = new System.Windows.Forms.Label();
            this.label_hist_car_name = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_show_car_hist = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Rental System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User";
            // 
            // label_userID
            // 
            this.label_userID.AutoSize = true;
            this.label_userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userID.Location = new System.Drawing.Point(33, 92);
            this.label_userID.Name = "label_userID";
            this.label_userID.Size = new System.Drawing.Size(62, 18);
            this.label_userID.TabIndex = 2;
            this.label_userID.Text = "User ID:";
            // 
            // label_user_name
            // 
            this.label_user_name.AutoSize = true;
            this.label_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user_name.Location = new System.Drawing.Point(33, 132);
            this.label_user_name.Name = "label_user_name";
            this.label_user_name.Size = new System.Drawing.Size(88, 18);
            this.label_user_name.TabIndex = 3;
            this.label_user_name.Text = "User Name:";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.Location = new System.Drawing.Point(35, 175);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(66, 18);
            this.label_address.TabIndex = 4;
            this.label_address.Text = "Address:";
            // 
            // label_destination
            // 
            this.label_destination.AutoSize = true;
            this.label_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_destination.Location = new System.Drawing.Point(35, 215);
            this.label_destination.Name = "label_destination";
            this.label_destination.Size = new System.Drawing.Size(86, 18);
            this.label_destination.TabIndex = 5;
            this.label_destination.Text = "Destination:";
            // 
            // text_userID
            // 
            this.text_userID.Location = new System.Drawing.Point(125, 92);
            this.text_userID.Name = "text_userID";
            this.text_userID.Size = new System.Drawing.Size(192, 22);
            this.text_userID.TabIndex = 6;
            // 
            // text_user_name
            // 
            this.text_user_name.Location = new System.Drawing.Point(127, 132);
            this.text_user_name.Name = "text_user_name";
            this.text_user_name.Size = new System.Drawing.Size(190, 22);
            this.text_user_name.TabIndex = 7;
            // 
            // text_address
            // 
            this.text_address.Location = new System.Drawing.Point(127, 171);
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(190, 22);
            this.text_address.TabIndex = 8;
            // 
            // text_destination
            // 
            this.text_destination.Location = new System.Drawing.Point(127, 214);
            this.text_destination.Name = "text_destination";
            this.text_destination.Size = new System.Drawing.Size(190, 22);
            this.text_destination.TabIndex = 9;
            // 
            // text_num_of_cars
            // 
            this.text_num_of_cars.Location = new System.Drawing.Point(159, 480);
            this.text_num_of_cars.Name = "text_num_of_cars";
            this.text_num_of_cars.Size = new System.Drawing.Size(190, 22);
            this.text_num_of_cars.TabIndex = 17;
            // 
            // text_car_model
            // 
            this.text_car_model.Location = new System.Drawing.Point(159, 438);
            this.text_car_model.Name = "text_car_model";
            this.text_car_model.Size = new System.Drawing.Size(190, 22);
            this.text_car_model.TabIndex = 16;
            // 
            // text_car_name
            // 
            this.text_car_name.Location = new System.Drawing.Point(157, 397);
            this.text_car_name.Name = "text_car_name";
            this.text_car_name.Size = new System.Drawing.Size(192, 22);
            this.text_car_name.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Number of Cars:";
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_model.Location = new System.Drawing.Point(33, 438);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(53, 18);
            this.label_model.TabIndex = 12;
            this.label_model.Text = "Model:";
            // 
            // label_car_name
            // 
            this.label_car_name.AutoSize = true;
            this.label_car_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_car_name.Location = new System.Drawing.Point(33, 398);
            this.label_car_name.Name = "label_car_name";
            this.label_car_name.Size = new System.Drawing.Size(80, 18);
            this.label_car_name.TabIndex = 11;
            this.label_car_name.Text = "Car Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Car";
            // 
            // button_save_user
            // 
            this.button_save_user.Location = new System.Drawing.Point(125, 286);
            this.button_save_user.Name = "button_save_user";
            this.button_save_user.Size = new System.Drawing.Size(119, 42);
            this.button_save_user.TabIndex = 18;
            this.button_save_user.Text = "Save";
            this.button_save_user.UseVisualStyleBackColor = true;
            this.button_save_user.Click += new System.EventHandler(this.SaveUserButton);
            // 
            // button_save_car
            // 
            this.button_save_car.Location = new System.Drawing.Point(127, 557);
            this.button_save_car.Name = "button_save_car";
            this.button_save_car.Size = new System.Drawing.Size(119, 42);
            this.button_save_car.TabIndex = 19;
            this.button_save_car.Text = "Save";
            this.button_save_car.UseVisualStyleBackColor = true;
            this.button_save_car.Click += new System.EventHandler(this.SaveCarButton);
            // 
            // text_rent_car_name
            // 
            this.text_rent_car_name.Location = new System.Drawing.Point(509, 261);
            this.text_rent_car_name.Name = "text_rent_car_name";
            this.text_rent_car_name.Size = new System.Drawing.Size(192, 22);
            this.text_rent_car_name.TabIndex = 24;
            // 
            // label_rent_car_name
            // 
            this.label_rent_car_name.AutoSize = true;
            this.label_rent_car_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rent_car_name.Location = new System.Drawing.Point(414, 262);
            this.label_rent_car_name.Name = "label_rent_car_name";
            this.label_rent_car_name.Size = new System.Drawing.Size(80, 18);
            this.label_rent_car_name.TabIndex = 23;
            this.label_rent_car_name.Text = "Car Name:";
            // 
            // text_rent_userID
            // 
            this.text_rent_userID.Location = new System.Drawing.Point(509, 214);
            this.text_rent_userID.Name = "text_rent_userID";
            this.text_rent_userID.Size = new System.Drawing.Size(192, 22);
            this.text_rent_userID.TabIndex = 22;
            // 
            // label_rent_userID
            // 
            this.label_rent_userID.AutoSize = true;
            this.label_rent_userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rent_userID.Location = new System.Drawing.Point(412, 218);
            this.label_rent_userID.Name = "label_rent_userID";
            this.label_rent_userID.Size = new System.Drawing.Size(62, 18);
            this.label_rent_userID.TabIndex = 21;
            this.label_rent_userID.Text = "User ID:";
            // 
            // button_rent_car
            // 
            this.button_rent_car.Location = new System.Drawing.Point(509, 330);
            this.button_rent_car.Name = "button_rent_car";
            this.button_rent_car.Size = new System.Drawing.Size(119, 42);
            this.button_rent_car.TabIndex = 25;
            this.button_rent_car.Text = "Rent Car";
            this.button_rent_car.UseVisualStyleBackColor = true;
            this.button_rent_car.Click += new System.EventHandler(this.RentCarButton);
            // 
            // button_show_user_hist
            // 
            this.button_show_user_hist.Location = new System.Drawing.Point(796, 297);
            this.button_show_user_hist.Name = "button_show_user_hist";
            this.button_show_user_hist.Size = new System.Drawing.Size(279, 31);
            this.button_show_user_hist.TabIndex = 35;
            this.button_show_user_hist.Text = "Show User History";
            this.button_show_user_hist.UseVisualStyleBackColor = true;
            this.button_show_user_hist.Click += new System.EventHandler(this.ShowUserHistoryButton);
            // 
            // text_hist_userID
            // 
            this.text_hist_userID.Location = new System.Drawing.Point(883, 92);
            this.text_hist_userID.Name = "text_hist_userID";
            this.text_hist_userID.Size = new System.Drawing.Size(192, 22);
            this.text_hist_userID.TabIndex = 31;
            // 
            // label_hist_destination
            // 
            this.label_hist_destination.AutoSize = true;
            this.label_hist_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hist_destination.Location = new System.Drawing.Point(793, 254);
            this.label_hist_destination.Name = "label_hist_destination";
            this.label_hist_destination.Size = new System.Drawing.Size(86, 18);
            this.label_hist_destination.TabIndex = 30;
            this.label_hist_destination.Text = "Destination:";
            // 
            // label_hist_address
            // 
            this.label_hist_address.AutoSize = true;
            this.label_hist_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hist_address.Location = new System.Drawing.Point(793, 175);
            this.label_hist_address.Name = "label_hist_address";
            this.label_hist_address.Size = new System.Drawing.Size(66, 18);
            this.label_hist_address.TabIndex = 29;
            this.label_hist_address.Text = "Address:";
            // 
            // label_hist_user_name
            // 
            this.label_hist_user_name.AutoSize = true;
            this.label_hist_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hist_user_name.Location = new System.Drawing.Point(791, 132);
            this.label_hist_user_name.Name = "label_hist_user_name";
            this.label_hist_user_name.Size = new System.Drawing.Size(88, 18);
            this.label_hist_user_name.TabIndex = 28;
            this.label_hist_user_name.Text = "User Name:";
            // 
            // label_history_userID
            // 
            this.label_history_userID.AutoSize = true;
            this.label_history_userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_history_userID.Location = new System.Drawing.Point(791, 92);
            this.label_history_userID.Name = "label_history_userID";
            this.label_history_userID.Size = new System.Drawing.Size(62, 18);
            this.label_history_userID.TabIndex = 27;
            this.label_history_userID.Text = "User ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(792, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "User History";
            // 
            // label_hist_rented_car
            // 
            this.label_hist_rented_car.AutoSize = true;
            this.label_hist_rented_car.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hist_rented_car.Location = new System.Drawing.Point(793, 215);
            this.label_hist_rented_car.Name = "label_hist_rented_car";
            this.label_hist_rented_car.Size = new System.Drawing.Size(87, 18);
            this.label_hist_rented_car.TabIndex = 36;
            this.label_hist_rented_car.Text = "Rented Car:";
            // 
            // text_hist_car_name
            // 
            this.text_hist_car_name.Location = new System.Drawing.Point(902, 397);
            this.text_hist_car_name.Name = "text_hist_car_name";
            this.text_hist_car_name.Size = new System.Drawing.Size(192, 22);
            this.text_hist_car_name.TabIndex = 41;
            // 
            // label_hist_available_unit
            // 
            this.label_hist_available_unit.AutoSize = true;
            this.label_hist_available_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hist_available_unit.Location = new System.Drawing.Point(793, 481);
            this.label_hist_available_unit.Name = "label_hist_available_unit";
            this.label_hist_available_unit.Size = new System.Drawing.Size(99, 18);
            this.label_hist_available_unit.TabIndex = 40;
            this.label_hist_available_unit.Text = "Available Unit:";
            // 
            // label_hist_model
            // 
            this.label_hist_model.AutoSize = true;
            this.label_hist_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hist_model.Location = new System.Drawing.Point(791, 438);
            this.label_hist_model.Name = "label_hist_model";
            this.label_hist_model.Size = new System.Drawing.Size(53, 18);
            this.label_hist_model.TabIndex = 39;
            this.label_hist_model.Text = "Model:";
            // 
            // label_hist_car_name
            // 
            this.label_hist_car_name.AutoSize = true;
            this.label_hist_car_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hist_car_name.Location = new System.Drawing.Point(791, 398);
            this.label_hist_car_name.Name = "label_hist_car_name";
            this.label_hist_car_name.Size = new System.Drawing.Size(80, 18);
            this.label_hist_car_name.TabIndex = 38;
            this.label_hist_car_name.Text = "Car Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(792, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Car History";
            // 
            // button_show_car_hist
            // 
            this.button_show_car_hist.Location = new System.Drawing.Point(794, 537);
            this.button_show_car_hist.Name = "button_show_car_hist";
            this.button_show_car_hist.Size = new System.Drawing.Size(279, 31);
            this.button_show_car_hist.TabIndex = 42;
            this.button_show_car_hist.Text = "Show Car History";
            this.button_show_car_hist.UseVisualStyleBackColor = true;
            this.button_show_car_hist.Click += new System.EventHandler(this.ShowCarHistoryButton);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Rent Car:";
            // 
            // CarRentalSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 653);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_show_car_hist);
            this.Controls.Add(this.text_hist_car_name);
            this.Controls.Add(this.label_hist_available_unit);
            this.Controls.Add(this.label_hist_model);
            this.Controls.Add(this.label_hist_car_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_hist_rented_car);
            this.Controls.Add(this.button_show_user_hist);
            this.Controls.Add(this.text_hist_userID);
            this.Controls.Add(this.label_hist_destination);
            this.Controls.Add(this.label_hist_address);
            this.Controls.Add(this.label_hist_user_name);
            this.Controls.Add(this.label_history_userID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button_rent_car);
            this.Controls.Add(this.text_rent_car_name);
            this.Controls.Add(this.label_rent_car_name);
            this.Controls.Add(this.text_rent_userID);
            this.Controls.Add(this.label_rent_userID);
            this.Controls.Add(this.button_save_car);
            this.Controls.Add(this.button_save_user);
            this.Controls.Add(this.text_num_of_cars);
            this.Controls.Add(this.text_car_model);
            this.Controls.Add(this.text_car_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_model);
            this.Controls.Add(this.label_car_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_destination);
            this.Controls.Add(this.text_address);
            this.Controls.Add(this.text_user_name);
            this.Controls.Add(this.text_userID);
            this.Controls.Add(this.label_destination);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_user_name);
            this.Controls.Add(this.label_userID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CarRentalSystem";
            this.Text = "CarRentalSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_userID;
        private System.Windows.Forms.Label label_user_name;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_destination;
        private System.Windows.Forms.TextBox text_userID;
        private System.Windows.Forms.TextBox text_user_name;
        private System.Windows.Forms.TextBox text_address;
        private System.Windows.Forms.TextBox text_destination;
        private System.Windows.Forms.TextBox text_num_of_cars;
        private System.Windows.Forms.TextBox text_car_model;
        private System.Windows.Forms.TextBox text_car_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Label label_car_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_save_user;
        private System.Windows.Forms.Button button_save_car;
        private System.Windows.Forms.TextBox text_rent_car_name;
        private System.Windows.Forms.Label label_rent_car_name;
        private System.Windows.Forms.TextBox text_rent_userID;
        private System.Windows.Forms.Label label_rent_userID;
        private System.Windows.Forms.Button button_rent_car;
        private System.Windows.Forms.Button button_show_user_hist;
        private System.Windows.Forms.TextBox text_hist_userID;
        private System.Windows.Forms.Label label_hist_destination;
        private System.Windows.Forms.Label label_hist_address;
        private System.Windows.Forms.Label label_hist_user_name;
        private System.Windows.Forms.Label label_history_userID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_hist_rented_car;
        private System.Windows.Forms.TextBox text_hist_car_name;
        private System.Windows.Forms.Label label_hist_available_unit;
        private System.Windows.Forms.Label label_hist_model;
        private System.Windows.Forms.Label label_hist_car_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_show_car_hist;
        private System.Windows.Forms.Label label3;
    }
}

