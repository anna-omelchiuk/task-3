using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace prac_2
{
    class Reservoir
    {
        private double capacity;
        private double curVol;
        private string material;
        private bool isFull;

        public Reservoir(double capacity)
        {
            this.capacity = capacity;
            this.curVol = 0;
            this.material = "Невідомо";
            this.isFull = false;
        }

        public Reservoir(double capacity, string material)
        {
            this.capacity = capacity;
            this.material = material;
            this.curVol = 0;
            this.isFull = false;
        }

        public Reservoir(double capacity, string material, bool isFull)
        {
            this.capacity = capacity;
            this.material = material;
            this.isFull = isFull;
            this.curVol = isFull ? capacity : 0;
        }

        public void Fill(double amount)
        {
            if (amount <= 0)
            {
                WriteLine("Некоректне значення!");
                return;
            }

            if (curVol + amount > capacity)
            {
                WriteLine("Переповнення! Заповнюємо до максимуму.");
                curVol = capacity;
                isFull = true;
            }
            else
            {
                curVol += amount;
                if (curVol == capacity)
                    isFull = true;
            }
        }

        public void Empty(double amount)
        {
            if (amount <= 0)
            {
                WriteLine("Некоректне значення!");
                return;
            }

            if (amount > curVol)
            {
                WriteLine("Резервуар повністю спорожнілий.");
                curVol = 0;
                isFull = false;
            }
            else
            {
                curVol -= amount;
                isFull = false;
            }
        }

        public void ShowInfo()
        {
            WriteLine($"Об'єм: {capacity}");
            WriteLine($"Матеріал: {material}");
            WriteLine($"Поточний об'єм: {curVol}");
            WriteLine($"Стан: {(isFull ? "Заповнений" : "Не заповнений")}");
            WriteLine();
        }
    }
}