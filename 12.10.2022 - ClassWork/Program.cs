using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._10._2022___ClassWork
{
    public enum dayOfWeek
    {
        monday = 1,
        tuesday = 2,
        wednesday = 3,
        thursday = 4,
        friday = 5,
        saturday = 6,
        sunday = 7
    }


    class EmployerTime
    {
        private int[] WorkTime;
        public EmployerTime()
        {
            WorkTime = new int[7+1];
        }
        public int this[int index]
        {
            set { WorkTime[index] = value; }
            get { return WorkTime[index]; }
        }
       /* public string PrintDayOfWeek(dayOfWeek dayOfWeek)
        {
            string MydayOfWeek = "";
            switch(dayOfWeek)
            {
                case dayOfWeek.monday:
                    MydayOfWeek = "monday";
                    break;
                case dayOfWeek.tuesday:
                    MydayOfWeek = "tuesday";
                     break;
                case dayOfWeek.wednesday:
                    MydayOfWeek = "wednesday";
                      break;
                case dayOfWeek.thursday:
                    MydayOfWeek = "thursday";
                    break;
                case dayOfWeek.friday:
                    MydayOfWeek = "friday";
                    break;
                case dayOfWeek.saturday:
                    MydayOfWeek = "saturday";
                    break;
                case dayOfWeek.sunday:
                    MydayOfWeek = "sunday";
                    break;
                default:
                    break;
            }
            return MydayOfWeek;
        }
       */
        public void Print()
        {
            foreach (var item in Enum.GetValues(typeof(dayOfWeek)))
            {
                Console.WriteLine($"В день {item}  отработано {WorkTime[(int)item]} часов");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            Console.WriteLine("Введите количество часов:");
            int entrance = int.Parse(Console.ReadLine());

            try
            {

            }
            catch (Exception)
            {
                
            }

            if (entrance > 8 || entrance <0)
            {
                Console.WriteLine("Ошибка ввода");
                entrance = 8;
            }

            var BobTime = new EmployerTime();
            BobTime.Print();
            BobTime[2] = entrance;
            BobTime.Print();
            Console.ReadKey();
        }
    }
}
