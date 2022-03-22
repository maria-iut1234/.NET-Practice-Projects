using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_10__FileHandling__Even_
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void showDatabase(object sender, EventArgs e)
        {
            var path = @"E:\IUT Classes\2nd Semester\SWE 4202 Object Oriented Concepts I Lab\Lab 10  FileHandling (Even)\userInfo.csv";
            using (var reader = new StreamReader(path))
            {
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    User dummy_user = new User(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9]);

                    users.Add(dummy_user);
                }
            }

            listBox_database.Items.Add("First Name             Last Name               Email");

            foreach(User user in users)
            {
                if(user.getFirstName()!="first_name")
                {
                    listBox_database.Items.Add(user.getFirstName() + "\t\t" + user.getLastName() + "\t\t" + user.getEmail());
                }
            }
        }

        private void searchUser(object sender, EventArgs e)
        {
            string search_email = textBox_search_email.Text;
            bool flag = false;
            string path = @"E:\IUT Classes\2nd Semester\SWE 4202 Object Oriented Concepts I Lab\Lab 10  FileHandling (Even)\search.txt";

            foreach (User user in users)
            {
                if(user.getEmail()==search_email)
                {
                    label_showSearchInfo.Text = user.getInfo();
                    flag = true;

                    if (File.Exists(path))
                    {
                        // Create a file to write to.
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            sw.WriteLine(DateTime.Now + "\t" + search_email + "\t");

                            if (flag == true)
                            {
                                sw.WriteLine("Found" + "\n");
                                sw.WriteLine(user.getInfo());
                            }
                        }
                    }

                    break;
                }
            }

            if(flag==false)
            {
                label_showSearchInfo.Text = "Not Found";
                if (File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(DateTime.Now + "\t" + search_email + "\t");
                        sw.WriteLine("Not Found" + "\n");
                    }
                }
            }
        }
    }
}
