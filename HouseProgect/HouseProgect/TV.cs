using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProgect
{
    class TVGuest
    {
        protected ChannelCollection myChannel;
        public virtual void TVChannelSett()
        {
            Console.WriteLine("Настройка недоступна");
        }
        public virtual void SwitchChannel()
        {
            Console.WriteLine("Переключение недоступно");
        }
        public  void ChannelStatus()
        {
            if (myChannel == null)
            {
                Console.WriteLine("Каналы не настроены");
            }
            else
            {
                foreach (Channel element in myChannel)
                {
                    Console.WriteLine("Статус канала - {0}, настроин на диапазон - {1}, качество канала - {2} %", element.ChannelName, element.ChannelWorkDiapazone, element.QualitySignal);
                }
            }
        }

        public void WachingTV()
        {
            if (myChannel == null)
            {
                Console.WriteLine("каналы не настроены");
            }
            else
            {
                Console.WriteLine("Вы смотрите канал:");
                Console.WriteLine(myChannel.Current);
            }
        }
    }

    class TVOwner : TVGuest
    {
        public override void SwitchChannel()
        {
            myChannel.MoveNext();
        }

    }
    class TVMaster : TVOwner
    {
       

        public TVMaster()
        {
            myChannel = new ChannelCollection();
        }
        public override void TVChannelSett()
        {
            myChannel.ChannelSetting();
        }
        


    }


}
