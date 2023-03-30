using System;

namespace TalkingClock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            if (args.Length > 0)
            {
                if (!DateTime.TryParse(args[0], out currentTime))
                {
                    Console.WriteLine("Invalid time format. Please use HH:mm format.");
                    return;
                }
            }
            ITalkingClock clock = new TalkingClock();
            var HumanFriendlyText = clock.GetTimeToHumanFriendlyText(Convert.ToString(currentTime));
            Console.WriteLine(HumanFriendlyText);
            Console.ReadLine();
        }
    }
}
