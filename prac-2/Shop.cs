using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace prac_2
{
    class Shop
    {
        public string Name { get; set; }

        public string IP_Adress { get; set; }

        public string Description { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
        

        public void InputData(Shop shop)
        {
            WriteLine("\nІНФОРМАЦІЯ ПРO МАГАЗИН");

            Write("\nВведіть назву магазину: ");
            shop.Name = ReadLine();

            Write("Введіть IP-адресу магазину: ");
            shop.IP_Adress = ReadLine();

            Write("Введіть опис магазину: ");
            shop.Description = ReadLine();

            Write("Введіть контактний телефон: ");
            shop.Phone = ReadLine();

            Write("Введіть контактний email: ");
            shop.Email = ReadLine();
        }

        public override string ToString()
        {
            return $"\nНазва: {Name}\nIP-адресa: {IP_Adress}\nОпис магазину: {Description}\nТелефон: {Phone}\nEmail: {Email}";
        }
    }
}
