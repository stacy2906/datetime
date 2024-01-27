using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            // Ввести две даты
            Console.WriteLine("Введите первую дату (гггг-мм-дд):");
            DateTime date1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введите вторую дату (гггг-мм-дд):");
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            // Определить количество дней между ними
            TimeSpan difference = date2 - date1;
            Console.WriteLine("Количество дней между датами: " + difference.Days);

            //Задание 2
            // Определить, сколько дней осталось до конца месяца
            DateTime currentDate = DateTime.Today;
            int daysLeft = DateTime.DaysInMonth(currentDate.Year, currentDate.Month) - currentDate.Day;
            Console.WriteLine("Дней осталось до конца месяца: " + daysLeft);

            //Задание 3
            // Ввести свою дату рождения
            Console.WriteLine("Введите свою дату рождения (гггг-мм-дд):");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            // a) день недели, в котором вы родились
            Console.WriteLine("Вы родились в " + birthDate.DayOfWeek);

            // b) порядковый номер дня рождения в году
            Console.WriteLine("Порядковый номер дня рождения в году: " + birthDate.DayOfYear);

            // c) является ли ваш год рождения високосным
            Console.WriteLine("Ваш год рождения " + (DateTime.IsLeapYear(birthDate.Year) ? "високосный" : "не високосный"));

            // d) дата ближайшего дня рождения
            DateTime nextBirthday = new DateTime(DateTime.Today.Year, birthDate.Month, birthDate.Day);
            if (nextBirthday < DateTime.Today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }
            Console.WriteLine("Ближайшее день рождения: " + nextBirthday.ToString("dddd, dd MMMM yyyy"));

            // e) количество полных лет
            int age = DateTime.Today.Year - birthDate.Year;
            if (DateTime.Today < birthDate.AddYears(age))
                age--;
            Console.WriteLine("Количество полных лет: " + age);

            // f) сколько дней осталось от сегодняшней даты до вашего ближайшего дня рождения
            TimeSpan daysUntilBirthday = nextBirthday - DateTime.Today;
            int daysLeftUntilBirthday = (int)daysUntilBirthday.Days;
            Console.WriteLine("Дней осталось до вашего ближайшего дня рождения: " + daysLeftUntilBirthday);
            Console.ReadKey();
        }
    }
}

