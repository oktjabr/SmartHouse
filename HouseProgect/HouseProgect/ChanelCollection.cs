using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProgect
{
    class PrimariSignal
    {
        public readonly int firstDiapazone = 3;
        public readonly int secondDiapazone = 10;
        public readonly int thirdDiapazone = 15;
    }
    class Channel
    {
        PrimariSignal parameterOfSignal;
        Random random = new Random();

        string channelName;
        int channelWorkDiapazone;
        int qualitySignal;
        
        public Channel(string channelName, int channelWorkDiapazone)
        {
            
            parameterOfSignal = new PrimariSignal();
            this.channelName = channelName;
            this.channelWorkDiapazone = channelWorkDiapazone;
            ChuseQualitySignal();
        }
        public void ChuseQualitySignal()
        {
            if (channelWorkDiapazone == parameterOfSignal.firstDiapazone || channelWorkDiapazone == parameterOfSignal.secondDiapazone || channelWorkDiapazone == parameterOfSignal.thirdDiapazone)
            {
                qualitySignal = random.Next(90, 100);
            }
            else if ((channelWorkDiapazone - 1) == parameterOfSignal.firstDiapazone || (channelWorkDiapazone + 1) == parameterOfSignal.firstDiapazone || (channelWorkDiapazone - 1) == parameterOfSignal.secondDiapazone || (channelWorkDiapazone + 1) == parameterOfSignal.secondDiapazone || (channelWorkDiapazone - 1) == parameterOfSignal.thirdDiapazone || (channelWorkDiapazone + 1) == parameterOfSignal.thirdDiapazone)
            {
                qualitySignal = random.Next(70, 90);
            }
            else
            {
                qualitySignal = random.Next(0, 40);
            }
        }
        public string ChannelName
        {
            get { return channelName; }
            set { channelName = value; }
        }
        public int ChannelWorkDiapazone
        {
            get { return channelWorkDiapazone; }
            set { channelWorkDiapazone = value; }
        }
        public int QualitySignal
        {
            get { return qualitySignal; }
        }

    }

    class ChannelCollection : IEnumerable, IEnumerator
    {
        public Channel[] channelAray = null;
        public ChannelCollection()
        {
            channelAray = new Channel[3];
        }
        public void ChannelSetting()//For Master only
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите название -{0} канала", i + 1);
                string s = Console.ReadLine();
                Console.WriteLine ("Введите его диапазон от 0 до 16 ", i + 1);
                int n = Convert.ToInt32(Console.ReadLine());
                
                
                channelAray[i] = new Channel(s,n);
                Console.WriteLine("Качество канала - {0} %", channelAray[i].QualitySignal);
            }
        }
        int possition = -1;
        public bool MoveNext()
        {
            if (possition < channelAray.Length - 1)
            {
                possition++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        { possition = -1; }
        public object Current
        {
            get
            {
                return channelAray[possition];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }

    }
}
