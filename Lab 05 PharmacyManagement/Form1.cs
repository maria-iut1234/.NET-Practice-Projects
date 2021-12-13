using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryPharmacyManagement;

namespace Lab_05_PharmacyManagement
{
    public partial class Form1 : Form
    {
        List<Medicine> medicines = new List<Medicine>();
        Account account=new Account();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddMedicine(object sender, EventArgs e)
        {
            string medicine_name = textBox_add_medicine_name.Text;
            string company = textBox_add_company.Text;
            int quantity = Convert.ToInt32(textBox_add_quantity.Text);
            double price = Convert.ToDouble(textBox_add_price.Text);

            if(quantity<1)
            {
                MessageBox.Show("Not enough medicine to add!");
            }
            else if(account.Balance<(quantity*price))
            {
                MessageBox.Show("Insufficient funds.");
            }
            else
            {
                foreach(Medicine medicine in medicines)
                {
                    if(medicine.MedicineName==medicine_name && medicine.Company==company)
                    {
                        quantity+=medicine.Quantity;
                        break;
                    }
                }

                bool flag_medicine = false;
                bool flag_company = false;

                foreach (Medicine medicine in medicines)
                {
                    if (medicine.MedicineName == medicine_name)
                    {
                        flag_medicine = true;
                    }
                    if(medicine.Company==company)
                    {
                        flag_company = true;
                    }
                }

                if(flag_company)
                {
                    if(flag_medicine)
                    {
                        ;
                    }
                    else
                    {
                        comboBox_sell_medicine_name.Items.Add(medicine_name);
                        comboBox_show_medicine_name.Items.Add(medicine_name);
                    }
                }
                else
                {
                    if (flag_medicine)
                    {
                        ;
                    }
                    else
                    {
                        comboBox_sell_medicine_name.Items.Add(medicine_name);
                        comboBox_show_medicine_name.Items.Add(medicine_name);
                    }

                    comboBox_sell_company.Items.Add(company);
                }

                Medicine dummy_medicine = new Medicine(medicine_name, company, quantity, price);
                medicines.Add(dummy_medicine);
                account.Balance -= (quantity * price);

                MessageBox.Show("Medicine has been added to inventory.\n" + "Current Quantity of the medicine: " + dummy_medicine.Quantity);
            }
        }

        private void SellMedicine(object sender, EventArgs e)
        {
            string sell_medicine_name = comboBox_sell_medicine_name.Text;
            string sell_company = comboBox_sell_company.Text;
            int sell_quantity = Convert.ToInt32(textBox_sell_quantity.Text);
            double selling_price = Convert.ToDouble(textBox_selling_price.Text);

            foreach (Medicine medicine in medicines)
            {
                if (medicine.MedicineName == sell_medicine_name && medicine.Company==sell_company)
                {
                    if(sell_quantity<0 || sell_quantity>medicine.Quantity)
                    {
                        MessageBox.Show("Invalid input for Quantity.");
                        break;
                    }
                    else
                    {
                        double sold_price = medicine.calcPrice(sell_quantity, selling_price);
                        medicine.Quantity -= sell_quantity;
                        account.Balance += sold_price;
                        MessageBox.Show("Medicine has been sold successfully.\n" + "Total Selling Price: $" + sold_price);
                        break;
                    }
                }
            }
        }

        private void ShowAvailableStock(object sender, EventArgs e)
        {
            string show_medicine_name = comboBox_show_medicine_name.Text;

            foreach(Medicine medicine in medicines)
            {
                if(medicine.MedicineName==show_medicine_name)
                {
                    label_show_company.Text = "Company: " + medicine.Company;
                    label_show_quantity.Text = "Quantity: " + Convert.ToString(medicine.Quantity);
                }
            }
        }

        private void ShowCurrentBalance(object sender, EventArgs e)
        {
            label_balance.Text = "Balance: $" + Convert.ToString(account.Balance);
        }
    }
}
