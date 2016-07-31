using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProgect
{
    class BoilerGuest
    {
        protected bool boilerDedLine = true;
        protected int temperature;
        protected bool boilerStatusOn = false;

        public virtual void TurnOnOff()
        {
            if (boilerDedLine == true)
            {
                Console.WriteLine("вы можете включить и выключить бойлер ");

                switch (Console.ReadLine())
                {
                    case "включить":
                        boilerStatusOn = true;
                        Console.WriteLine("бойлер включен");
                        break;
                    case "выключить":
                        boilerStatusOn = false;
                        Console.WriteLine("бойлер выключен");
                        break;
                    default:
                        break;
                }
            }
            else
                Console.WriteLine("Бойлер сломан");
        }
        public virtual void ControlTemperature()
        {
            Console.WriteLine("Управление температурой бойлера недоступно ");
        }
        public virtual void Repair()
        {
            Console.WriteLine("ремонт недоступен");
        }
        public void ShowStatus()
        {
            Console.WriteLine("статус исправности бойлера -{0}, статус включения -{1}, \nтемпературный режим - +{2} грд С", boilerDedLine, boilerStatusOn,temperature);
        }

    }
    class BoilerOwner : BoilerGuest
    {
        public override void ControlTemperature()
        {
            try
            {
                Console.WriteLine("выберите температурный режим бойлеру от 0 до 90 грд.С");
                int s = Convert.ToInt32(Console.ReadLine());
                if (s < 90 && s > 0)
                {
                    temperature = s;
                }
                else
                {
                    base.boilerStatusOn = false;
                    base.boilerDedLine = false;
                    base.temperature = 0;
                    throw new Exception("Бойлер сгорел");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("{0} ",e.Message);
                Console.Write("Вызовите мастера");
            }
        }
        public override void Repair()
        {
            Console.WriteLine("ремонт лучше не делать");
        }
    }
    class BoilerMechanical : BoilerOwner
    {
        public override void Repair()
        {
            if (boilerDedLine == false)
            {
                Console.WriteLine("Вы ОЧЕНЬ крутой ремонтник бойлеров отремонтировали бойлер)))");
                base.boilerDedLine = true;
            }
            else
                Console.WriteLine("ремонт бойлеру не нужен, но вы по прежнему крутой ремонтник))");
        }
    }
}

