using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    internal class SingleRoom:Room
    {
        public string gaming_setup;

        public SingleRoom(string room_name, int num_of_TV, int num_of_refrigerator, int num_of_bed, int quantity,
                          string air_conditioner, string gaming_setup)
        {
            this.room_name = room_name;
            this.num_of_TV = num_of_TV;
            this.num_of_refrigerator = num_of_refrigerator;
            this.num_of_bed = num_of_bed;
            this.quantity = quantity;
            this.air_conditioner = air_conditioner;
            this.gaming_setup = gaming_setup;
        }

        public int CalculateCost()
        {
            int cost = 2000;

            if (air_conditioner == "Yes")
            {
                cost += 500;
            }
            if(gaming_setup=="Yes")
            {
                cost += 1000;
            }

            return cost;
        }
    }
}
