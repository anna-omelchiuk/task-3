using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace prac_2
{
    class Magazine
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public void InputData()
        {
            WriteLine("\nІНФОРМАЦІЯ ПРО ЖУРНАЛ");

            Write("\nВведіть назву журналу: ");
            Name = ReadLine();

            Write("Введіть рік заснування: ");
            int year;

            while (!int.TryParse(ReadLine(), out year))
            {
                Write("Введіть коректний рік: ");
            }

            Year = year;

            Write("Введіть опис журналу: ");
            Description = ReadLine();

            Write("Введіть контактний телефон: ");
            Phone = ReadLine();

            Write("Введіть контактний email: ");
            Email = ReadLine();
        }

        public override string ToString()
        {
            return $"\nНазва: {Name}\nРік заснування: {Year}\nОпис: {Description}\nТелефон: {Phone}\nEmail: {Email}";
        }
    }
}
