using System;

public class Program
{
    public static void Main()
    {
        string[] days = new string[7];
        for (int i = 0; i < 7; i++)
        {
            days[i] = "";
        }

        while (true)
        {
            string Mon = "Monday";
            string Thue = "Thuesday";
            string Wed = "Wednsday";
            string Thu = "Thutsday";
            string Fri = "Friday";
            string Sat = "Saturday";
            string Sun = "Sunday";

            Console.WriteLine("Введите день недели: \n");
            string day = Console.ReadLine();

            int dayNumber = 0;
            if (day.Equals(Mon))
            {
                dayNumber = 0;
            }
            else if (day.Equals(Thue))
            {
                dayNumber = 1;
            }
            else if (day.Equals(Wed))
            {
                dayNumber = 2;
            }
            else if (day.Equals(Thu))
            {
                dayNumber = 3;
            }
            else if (day.Equals(Fri))
            {
                dayNumber = 4;
            }
            else if (day.Equals(Sat))
            {
                dayNumber = 5;
            }
            else if (day.Equals(Sun))
            {
                dayNumber = 6;
            }
            else
            {
                dayNumber = 7;
            }

            if (dayNumber == 7)
            {
                continue;
            }

            if (days[dayNumber] == "")
            {
                Console.WriteLine("Введите план на день: ");
                string work = Console.ReadLine();
                days[dayNumber] = work;
            }
            else
            {
                Console.WriteLine(days[dayNumber] + "\n");
            }
        }

    }
}
