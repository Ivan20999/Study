using System;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int receptionTime = 10;
            int minutesPerHour = 60;
            Console.WriteLine("Пожалуйста, введите число людей в очереди!");
            int queue = (Convert.ToInt16(Console.ReadLine())) * receptionTime;
            int waitingTimeHour = queue / minutesPerHour;
            int waitingTimeMinute = queue % minutesPerHour;
            Console.WriteLine("Вы должны отстоять в очереди: " + waitingTimeHour + " час(а,ов) " + waitingTimeMinute + " минут, приятного времяпровождения!");
        }
    }
}
