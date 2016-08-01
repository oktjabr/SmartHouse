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
        TVGuest tv;
        Alarm alarm;
        public House()
        {
            door = new Door();
            alarm = new Alarm();
        }
       private void InitializeoHuseGuestObjects()
        {
            boiler = new BoilerGuest();
            tv = new TVGuest();
            
        }
        private void InitializeoHuseoOwnerObjects()
        {
            boiler = new BoilerOwner();
            tv = new TVOwner();
        }
        private void InitializeoHuseoMechanicalObjects()
        {
            boiler = new BoilerMechanical();
            tv = new TVMaster();
        }
        public void InspectUser()
        {
            bool value = true;
            while (value)
            {
                Console.WriteLine("кто вы?? напишите (например owner или guest или mechanical, а может еще кто?)");
                door.HouseUser = Console.ReadLine();
                door.DoorLogic();
                if (door.DoorOpen == true && door.HouseUser == "guest")
                {
                    InitializeoHuseGuestObjects();
                    ControlHauseObjects();
                }
                else if (door.DoorOpen == true && door.HouseUser == "owner")
                {
                    InitializeoHuseoOwnerObjects();
                    ControlHauseObjects();
                }
                else if (door.DoorOpen == true && door.HouseUser == "mechanical")
                {
                    InitializeoHuseoMechanicalObjects();
                    ControlHauseObjects();
                }
                else if (door.HouseUser == "quit")
                {
                    value = false;
                }
                else
                {
                    alarm.ShowAlarm();
                }
            }
        }
        public void ControlHauseObjects()
        {
            bool value = true;
            while (value)
            {
                Console.WriteLine("Выберите обьект управления: бойлер или тв или наберите -  выход ");
                string s = Console.ReadLine();
                if(s == "бойлер")
                {
                    ControlHauseBoiler();
                }
                else if(s =="тв")
                {
                    ControlHouseTV();
                }
                else if(s =="выход")
                {
                    value = false;
                }
                else
                {
                    Console.WriteLine("Вы выбрали неверный обьект");
                }

            }
        }
        public void ControlHauseBoiler()
        {
            Console.WriteLine("для управления бойлером доступны следующие команды:");
            Console.WriteLine("- управление включением;\n- контроль температуры;\n- ремонт;\n- статус;\n- TV;\n- TVstatus;\n- exit - выход из Бойлера");
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
         public void ControlHouseTV()
        {
            Console.WriteLine("для управления ТВ доступны следующие команды:");
            Console.WriteLine("- настройка;\n- переключение каналов;\n- статус;\n- смотреть;\n- exit - выход из ТВ");
            bool value = true;
            while (value)
            {
                switch (Console.ReadLine())
                {
                    case "настройка":
                        tv.TVChannelSett();
                        break;
                    case "переключение каналов":
                        tv.SwitchChannel();
                        break;
                    case "смотреть":
                        tv.WachingTV();
                        break;
                    case "статус":
                        tv.ChannelStatus();
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


