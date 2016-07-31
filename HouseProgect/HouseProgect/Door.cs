using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProgect
{
    
    public delegate void EventDelegate();
    class Door
    {
        private bool doorOpen = false;
        private bool garageDoorOpen = false;
        public Door()
        {
           
        }
        private string houseUser;
        public bool DoorOpen
        {
            get { return doorOpen; }
        }
        public bool GarageDoorOpen
        {
            get { return garageDoorOpen; }
        }
        public string HouseUser
        {
            set { houseUser = value; }
            get { return houseUser; }
        }
        public void DoorLogic()
        {
            switch(houseUser)
            {
                case "owner":
                    doorOpen = true;
                    garageDoorOpen = false;
                    break;
                case "guest":
                    doorOpen = true;
                    garageDoorOpen = false;
                    break;
                case "mechanical":
                    doorOpen = true;
                    garageDoorOpen = true;
                    break;
                default:
                    doorOpen = false;
                    garageDoorOpen = false;
                   
                    break;


            }
        }
    }
}
