using System;
using System.Collections.Generic;
namespace SimpleCalc
{
    class MessageLeaver
    {
        private Dictionary<DateTime, List<string>> messages;
        private DateTime day;

        private void SelectDay()
        {
            try
            {
                Console.WriteLine("Введите день в формате YYYY-MM-DD");
                day = DateTime.Parse(Console.ReadLine());
                Console.WriteLine($"Вы выбрали {day}");
                if (day != null)
                {
                    if (messages.Count > 0)
                    {
                        if (messages.ContainsKey(day) && messages[day].Count != 0)
                        {
                            Console.WriteLine($"Ваши сообщения на {day}:");
                            foreach (string msg in messages[day])
                            {
                                Console.WriteLine(msg);
                            }
                        }
                        else Console.WriteLine($"У вас нет сообщений на {day}");
                    }
                    else Console.WriteLine("У вас нет сообщений");
                }
                else Console.WriteLine("Вы не ввели день");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Неправильный формат даты. Правильный формат YYYY-MM-DD");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Непредвиденная ошибка: " + ex.Message);
            }
            Selection();
        }
        private void LeaveMessage()
        {
            Console.WriteLine("Напишите Ваше сообщение: ");
            string msg = Console.ReadLine();
            if (!messages.ContainsKey(day))
                messages.Add(day, new List<string>());
            messages[day].Add(msg);
            Selection();
        }
        public MessageLeaver()
        {
            this.day = new DateTime();
            this.messages = new Dictionary<DateTime, List<string>>();
        }
        public void Selection()
        {
            Console.WriteLine("Выберите Ваше действие:\n1)Выбрать день\n2)Оставить сообщение\n3)Закрыть приложение");
            try
            {
                int select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        SelectDay();
                        break;
                    case 2:
                        LeaveMessage();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Вы выбрали неправильное действие. Попробуйте еще раз");
                        Selection();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите Ваш действие в виде числа от 1 до 3");
                Selection();
            }
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            MessageLeaver msg_leaver = new MessageLeaver();
            msg_leaver.Selection();
        }
        
    }
}