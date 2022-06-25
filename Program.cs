using System;

namespace _1168
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //первый элемент прогресии
            Console.WriteLine("Введите первый элемент прогресии");
            int first = Convert.ToInt32(Console.ReadLine());
            //второй элемент прогресии
            Console.WriteLine("Введите второй элемент прогресии");
            int second = Convert.ToInt32(Console.ReadLine());
            // номер элемента арифметической прогресии
            Console.WriteLine("Введите номер нужного элемента арифметической прогресии");
            int numArifProg = Convert.ToInt32(Console.ReadLine());
            // разность арифметической прогресии
            int difference = second - first;
            // элемент арифметической прогресии
            int elementOfNumArifProg = first + (difference * numArifProg);
            Console.WriteLine("Элемент арифметической прогресии под номером" + numArifProg + " равен " + elementOfNumArifProg);

        }
    }
}