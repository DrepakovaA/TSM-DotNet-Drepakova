using System;

public class Program
{
    public static void Main()
    {
        string[] days = new string[7];
        Menu();

    }
    enum Days : byte
    {
        Monday = 0,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    static void Menu()
    {
        bool continue_print = true;
        while (continue_print)
        {
        Console.WriteLine("Enter day");
            Console.ReadLine();
        Console.WriteLine("Enter plans");
        string day = Console.ReadLine();
            switch (day)
            {
                case "Mon":
                case "Monday":
                case "0":
                    break;
                case "Tues":
                case "Tuesday":
                case "1":
                    break;
                case "Wed":
                case "Wednesday":
                case "2":
                    break;
                case "Thurs":
                case "Thursday":
                case "3":
                    break;
                case "Fri":
                case "Friday":
                case "4":
                    break;
                case "Sat":
                case "Saturday":
                case "5":
                    break;
                case "Sun":
                case "Sunday":
                case "6":
                    break;
                case "exit":
                    continue_print = false;
                    break;
            }
                    



        }
        Console.WriteLine("Вы ввели {exit} и теперь можете выйти из цикла");
    }

}

   