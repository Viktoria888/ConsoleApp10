using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Time
    {
        int hour = 2;
        int minute = 35;
        int second = 47;

        public void Info()
        {
            Console.WriteLine($"Час: {hour}, минута: {minute}, секунда: {second}");
            Console.Write("Изменения:\n");
        }

        public int Hour{get{return hour;}
            set
            {
                if (value < 0)
                {
                    hour = 0;
                }
                else if (value > 60)
                {
                    hour = 0;
                }
                else
                {
                    hour = value;
                }
            }
        }

        public int Minute{get { return minute;}
            set
            {
                if (value < 0)  
                {
                    minute = 0;
                }
                else if (value > 60)
                {
                    minute = 0;
                }
                else
                {
                    minute = value;
                }
            }
        }
        public int Second {get{return second;}
            set
            {
                if (value < 0)
                {
                    second = 0;
                }
                else if (value > 60)
                {
                    second = 0;
                }
                else
                {
                    second = value;
                }
            }
        }

        public virtual void NewInfo()
        {
            Console.WriteLine($"Час: {hour}, минута: {minute}, секунда: {second}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Time first = new Time();
            first.Info();
            first.Hour = 5;
            first.Minute = 75;
            first.Second = 21;
            first.NewInfo();

            Console.ReadKey();
        }
    }
}
