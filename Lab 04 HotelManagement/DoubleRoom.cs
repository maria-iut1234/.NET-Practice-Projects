using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    internal class DoubleRoom:Room
    {
        public string extra_TV;
        public string complimentary_breakfast;

        public DoubleRoom(string room_name, int num_of_TV, int num_of_refrigerator, int num_of_bed, int quantity,
                          string air_conditioner, string extra_TV, string complimentary_breakfast)
        {
            this.room_name = room_name;
            this.num_of_TV = num_of_TV;
            this.num_of_refrigerator = num_of_refrigerator;
            this.num_of_bed = num_of_bed;
            this.quantity = quantity;
            this.air_conditioner = air_conditioner;
            this.extra_TV = extra_TV;
            this.complimentary_breakfast = complimentary_breakfast;
        }

        public int CalculateCost()
        {
            int cost = 3500;

            if (air_conditioner == "Yes")
            {
                cost += 500;
            }
            if (extra_TV == "Yes")
            {
                cost += 1000;
            }
            if(complimentary_breakfast=="Yes")
            {
                cost += 500;
            }

            return cost;
        }
    }
}
