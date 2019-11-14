using System;

namespace hoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes;
            int hours;
            int entry;

            Console.WriteLine("Please enter the number of mminutes worked.>>>>");
            entry = Convert.ToInt32(Console.ReadLine());

            hours = entry / 60;
            minutes = entry % 60;

            Console.WriteLine("{0} entered = {1} and {2} left over", entry, hours, minutes);
        }
    }
}
