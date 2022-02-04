using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_08_EmployeeManagementSystem
{
    public partial class Form1 : Form
    {
        List<Typewriter> typewriters = new List<Typewriter>();
        List<Manager> managers = new List<Manager>();
        List<Salesperson> salesperson = new List<Salesperson>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddEmployee(object sender, EventArgs e)
        {
            if(textBox_add_contact.Text=="" || textBox_add_name.Text=="" || comboBox_add_designation.Text=="")
            {
                MessageBox.Show("Error: Input Field can not be empty!");
            }
            else
            {
                string name = textBox_add_name.Text;
                string designation = comboBox_add_designation.Text;
                string contact = textBox_add_contact.Text;
                DateTime dateOfJoining = dateTimePicker_add.Value;

                if(designation=="Typewriter")
                {
                    Typewriter dummy = new Typewriter(name, contact, dateOfJoining);
                    typewriters.Add(dummy);

                    MessageBox.Show("Employee has been added successfully\n Employee ID: " + dummy.getEmployeeID().ToString());

                    if(comboBox_show_empID.Items.Contains(dummy.getEmployeeID().ToString()))
                    {
                        ;
                    }
                    else
                    {
                        comboBox_show_empID.Items.Add(dummy.getEmployeeID().ToString());
                    }
                }
                else if(designation=="Salesperson")
                {
                    Salesperson dummy = new Salesperson(name, contact, dateOfJoining);
                    salesperson.Add(dummy);

                    MessageBox.Show("Employee has been added successfully\n Employee ID: " + dummy.getEmployeeID().ToString());

                    if (comboBox_show_empID.Items.Contains(dummy.getEmployeeID().ToString()))
                    {
                        ;
                    }
                    else
                    {
                        comboBox_show_empID.Items.Add(dummy.getEmployeeID().ToString());
                    }
                }
                else if(designation=="Manager")
                {
                    Manager dummy = new Manager(name, contact, dateOfJoining);
                    managers.Add(dummy);

                    MessageBox.Show("Employee has been added successfully\n Employee ID: " + dummy.getEmployeeID().ToString());

                    if (comboBox_show_empID.Items.Contains(dummy.getEmployeeID().ToString()))
                    {
                        ;
                    }
                    else
                    {
                        comboBox_show_empID.Items.Add(dummy.getEmployeeID().ToString());
                    }
                }
            }
        }

        private void UpdateEmployee(object sender, EventArgs e)
        {
            EmployeeIDNotFoundException ex = new EmployeeIDNotFoundException();

            if(textBox_update_empID.Text!="")
            {
                double empID = Convert.ToDouble(textBox_update_empID.Text);
                bool flag = false;

                for (int i = 0; i < typewriters.Count; i++)
                {
                     if (typewriters[i].getEmployeeID() == empID)
                     {
                         flag = true;
                         break;
                     }
                     else
                    {
                        ;
                    }
                }
                for (int i = 0; i < salesperson.Count; i++)
                {
                    if (salesperson[i].getEmployeeID() == empID)
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        ;
                    }
                }
                for (int i = 0; i < managers.Count; i++)
                {
                    if (managers[i].getEmployeeID() == empID)
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        ;
                    }
                }

                if (flag == false)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                else
                {
                    flag = false;

                    for (int i = 0; i < typewriters.Count; i++)
                    {
                        if (typewriters[i].getEmployeeID() == empID)
                        {
                            flag = true;
                            if (textBox_update_name.Text != "")
                            {
                                typewriters[i].setName(textBox_update_name.Text);
                            }
                            if(textBox_update_contact.Text!="")
                            {
                                typewriters[i].setContact(textBox_update_contact.Text);
                            }
                            

                            MessageBox.Show("Information updated.");
                            break;
                        }
                        else
                        {
                            ;
                        }
                    }
                    if(flag==false)
                    {
                        for (int i = 0; i < salesperson.Count; i++)
                        {
                            if (salesperson[i].getEmployeeID() == empID)
                            {
                                flag = true;
                                if (textBox_update_name.Text != "")
                                {
                                    salesperson[i].setName(textBox_update_name.Text);
                                }
                                if (textBox_update_contact.Text != "")
                                {
                                    salesperson[i].setContact(textBox_update_contact.Text);
                                }
                                

                                MessageBox.Show("Information updated.");
                                break;
                            }
                            else
                            {
                                ;
                            }
                        }
                    }
                    if(flag==false)
                    {
                        for (int i = 0; i < managers.Count; i++)
                        {
                            if (managers[i].getEmployeeID() == empID)
                            {
                                flag = true;
                                if (textBox_update_name.Text != "")
                                {
                                    managers[i].setName(textBox_update_name.Text);
                                }
                                if (textBox_update_contact.Text != "")
                                {
                                    managers[i].setContact(textBox_update_contact.Text);
                                }
                                
                                MessageBox.Show("Information updated.");
                                break;
                            }
                            else
                            {
                                ;
                            }
                        }
                    }
                    else
                    {
                        ;
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Error: Input field empty!");
            }
        }

        private void ShowEmployee(object sender, EventArgs e)
        {
            listBox_show.Items.Clear();

            int empID = Convert.ToInt32(comboBox_show_empID.Text);


            for (int i = 0; i < typewriters.Count; i++)
            {
                if (typewriters[i].getEmployeeID() == empID)
                {
            
                    listBox_show.Items.Add("Employee ID: " + typewriters[i].getEmployeeID().ToString());
                    listBox_show.Items.Add("Name: " + typewriters[i].getName());
                    listBox_show.Items.Add("Designation: " + typewriters[i].getDesignation());
                    listBox_show.Items.Add("Contact: " + typewriters[i].getContact());
                    listBox_show.Items.Add("Date of Joining: " + typewriters[i].getDate());
                    listBox_show.Items.Add("Salary: Tk." + typewriters[i].getSalary());
                    break;

                }
                else
                {
                    ;
                }
            }
            for (int i = 0; i < managers.Count; i++)
            {
                 if (managers[i].getEmployeeID() == empID)
                 {
                
                      listBox_show.Items.Add("Employee ID: " + managers[i].getEmployeeID().ToString());
                      listBox_show.Items.Add("Name: " + managers[i].getName());
                      listBox_show.Items.Add("Designation: " + managers[i].getDesignation());
                      listBox_show.Items.Add("Contact: " + managers[i].getContact());
                      listBox_show.Items.Add("Date of Joining: " + managers[i].getDate());
                      listBox_show.Items.Add("Salary: Tk." + managers[i].getSalary());
                      break;

                 }
                 else
                 {
                      ;
                 }
            }
    
            
                for (int i = 0; i < salesperson.Count; i++)
                {
                    if (salesperson[i].getEmployeeID() == empID)
                    {
                  
                        listBox_show.Items.Add("Employee ID: " + salesperson[i].getEmployeeID().ToString());
                        listBox_show.Items.Add("Name: " + salesperson[i].getName());
                        listBox_show.Items.Add("Designation: " + salesperson[i].getDesignation());
                        listBox_show.Items.Add("Contact: " + salesperson[i].getContact());
                        listBox_show.Items.Add("Date of Joining: " + salesperson[i].getDate());
                        listBox_show.Items.Add("Salary: Tk." + salesperson[i].getSalary());
                        break;

                    }
                    else
                    {
                        ;
                    }
                }
     
            
        }
    }
}
