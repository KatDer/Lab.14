using System;

namespace lab14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[10];//задаем количество элементов целочисленного массива
            Random r = new Random(); 

            Console.WriteLine("Первоначальный массив: "); //вывод на экран
            for (int n = 0; n < mass.Length; ++n) 
            {
                mass[n] = r.Next(0, 100); //задание массива
                Console.Write(mass[n] + " "); //вывод на экран
            }

            int k; //объявление целочисленной переменной

            for (int i = 0; i < mass.Length - 1; i++) //цикл, пока верно условие
            {
                for (int j = i + 1; j < mass.Length; j++) //цикл, пока верно условие
                {
                    if ((mass[i] % 2 != 0) && (mass[j] % 2 != 0) && (mass[i] > mass[j])) //выполняется, если верно условие
                    {
                        k = mass[i]; //присваеваем k значения i
                        mass[i] = mass[j]; //присваеваем значения j
                        mass[j] = k; //присваеваем значения j
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Отсортированный массив: ");  // вывод на экран
            for (int i = 0; i < mass.Length; i++) //цикл, пока верно условие
            {
                Console.Write(mass[i] + " "); //вывод массива на экран
            }
            Console.ReadLine();
            
        }
    }
}