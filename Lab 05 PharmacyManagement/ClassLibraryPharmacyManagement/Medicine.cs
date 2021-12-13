using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPharmacyManagement
{
    public class Medicine
    {
        private string medicine_name;
        private string company;
        private int quantity;
        private double buying_price;
        private double selling_price;

        public string MedicineName
        {
            get { return medicine_name; }
            set { medicine_name = value; }
        }

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double BuyingPrice
        {
            get { return buying_price; }
            set { buying_price = value; }
        }

        public double SellingPrice
        {
            get { return selling_price; }
            set { selling_price = value; }
        }

        public Medicine(string medicine_name, string company, int quantity, double price)
        {
            this.medicine_name = medicine_name;
            this.company = company;
            this.quantity = quantity;
            this.buying_price = price;
        }

        public double calcPrice(int quantity, double price)
        {
            return quantity * price;
        }
    }
}
