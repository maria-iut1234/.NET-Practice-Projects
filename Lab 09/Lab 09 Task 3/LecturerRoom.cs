using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_Task_03
{
    internal class LecturerRoom
    {
        private string roomName;
        private int roomNo;
        private int capacity;

        private string getRoomName()
        {
            return this.roomName;
        }

        public int getRoomNo()
        {
            return this.roomNo;
        }

        public int getCapacity()
        {
            return this.capacity;
        }

        public void setRoomName(string room_name)
        {
            this.roomName = room_name;
        }

        public void setRoomNo(int roomNo)
        {
            this.roomNo = roomNo;
        }

        public void setCapacity(int capacity)
        {
            this.capacity = capacity;
        }
    }
}
