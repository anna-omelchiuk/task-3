using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using static System.Console;

namespace prac_2
{
    class WebSite
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string IP_Adress{ get; set; }

        public void InputData(WebSite webSite)
        {
            WriteLine("\nІНФОРМАЦІЯ ПРО ВЕБ-САЙТ");

            Write("\nВведіть назву веб-сайту: ");
            webSite.Name = ReadLine();

            Write("Введіть URL веб-сайту: ");
            webSite.Url = ReadLine();

            Write("Введіть опис веб-сайту: ");
            webSite.Description = ReadLine();

            Write("Введіть IP-адресу веб-сайту: ");
            webSite.IP_Adress = ReadLine();
        }

        public override string ToString()
        {
            return $"\nНазва: {Name}\nURL веб-сайту: {Url}\nОпис веб-сайту: {Description}\nIP-адресa: {IP_Adress}";
        }

    }
}
