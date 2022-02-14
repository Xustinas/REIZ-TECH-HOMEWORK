using System;

namespace REIZ_TECH_HOMEWORK
{
    class Program
    {
        static void Main(string[] args)
        {
            AngleFinder();

            void AngleFinder()
            {
                int hours = 0;
                int minutes = 0;
                int hoursHand = 360 / 12;
                int minutesHand = 360 / 60;
                int angleDifferenceClockwise;
                int angleDifferenceAntiClockwise;

                try
                {
                    Console.WriteLine("Please enter hours hh and minutes mm");
                    hours = Convert.ToInt32(Console.ReadLine());
                    minutes = Convert.ToInt32(Console.ReadLine());

                    while (hours <= 0 || minutes <= 0)
                    {
                        Console.WriteLine("Bad entry, try again");
                        Console.WriteLine("Please enter hours hh and minutes mm");
                        hours = Convert.ToInt32(Console.ReadLine());
                        minutes = Convert.ToInt32(Console.ReadLine());
                    }
                    hoursHand = hours * hoursHand;
                    minutesHand = minutes * minutesHand;

                    if (hoursHand > minutesHand)
                    {
                        angleDifferenceClockwise = hoursHand - minutesHand;
                        Console.WriteLine($"Angle is: {angleDifferenceClockwise} ");
                    }
                    else
                    {
                        angleDifferenceAntiClockwise = minutesHand - hoursHand;
                        Console.WriteLine($"Angle is: {angleDifferenceAntiClockwise} ");
                    }
                }
                catch
                {
                    Console.WriteLine("Error: bad entry, try again");
                    AngleFinder();
                }
            }
        }
    }
}
