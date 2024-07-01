using System;
using System.Security.Cryptography.X509Certificates;
namespace EnumProject
{
    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    class Program
    {
        public static Days MeetingDay { get; set; } = Days.Monday;
        static void Main()
        {
            Days d=Days.Wednesday;
            Console.WriteLine(d);
            Console.WriteLine((int)d);

            foreach(int i in Enum.GetValues(typeof(Days)))     //GetValued() method returns an array of the values of the constants in a specified enumeration
            {
                Console.WriteLine(i);
            }

            foreach (string s in Enum.GetNames(typeof(Days)))   //GetNames() method returns an array of the names of the constants in a specified enumeration
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(MeetingDay);
            MeetingDay=Days.Friday;
            Console.WriteLine(MeetingDay);


        }
    }

}
