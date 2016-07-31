using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProgect
{
    class House
    {
        BoilerGuest boiler;
        Door door;
        TV tv;
        Alarm alarm;
        public House()
        {
            door = new Door();
            alarm = new Alarm();
        }
       private void InitializeoHuseGuestObjects()
        {
            boiler = new BoilerGuest();
           // tv = new TV();
            
        }
        private void InitializeoHuseoOwnerObjects()
        {
            boiler = new BoilerOwner();
        }
        private void InitializeoHuseoMechanicalObjects()
        {
            boiler = new BoilerMechanical();
        }
        public void InspectUser()
        {
            Console.WriteLine("кто вы?? напишите (например owner или guest или mechanical, а может еще кто?)");
            door.HouseUser = Console.ReadLine();
            door.DoorLogic();
            if(door.DoorOpen == true&&door.HouseUser == "guest")
            {
                InitializeoHuseGuestObjects();
                ControlHauseObjects();
            }
            else if(door.DoorOpen == true&&door.HouseUser == "owner")
            {
                InitializeoHuseoOwnerObjects();
                ControlHauseObjects();
            }
            else if(door.DoorOpen == true && door.HouseUser == "mechanical")
            {
                InitializeoHuseoMechanicalObjects();
                ControlHauseObjects();
            }
            else
            {
                alarm.ShowAlarm();
            }
        }
        public void ControlHauseObjects()
        {
            Console.WriteLine("для управления бойлером доступны следующие команды:");
            Console.WriteLine("- управление включением;\n- контроль температуры;\n- ремонт;\n- статус;\n- exit - выход из дома");
            bool value = true;
            while (value)
            {
                switch (Console.ReadLine())
                {
                    case "управление включением":
                        boiler.TurnOnOff();
                        break;
                    case "контроль температуры":
                        boiler.ControlTemperature();
                        break;
                    case "ремонт":
                        boiler.Repair();
                        break;
                    case "статус":
                        boiler.ShowStatus();
                        break;
                    case "exit":
                        value = false;
                        break;
                    default:
                        Console.WriteLine("вы выбрали неверную команду");
                        break;
                }
            }
            
            
            
        }
   
    }

}
