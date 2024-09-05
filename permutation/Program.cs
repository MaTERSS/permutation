/*
Даны две переменные. Поменять местами значения двух переменных. Вывести на экран значения переменных до перестановки и после.

Два примера.
1. Есть две переменные имя и фамилия, они сразу инициализированные, но данные не верные, перепутанные. Вот эти данные и надо поменять местами через код.
2. Есть две чашки, в одном кофе, во втором чай. Вам надо поменять местами содержимое чашек
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            string a = "name";
            string b = "surname";
            Console.WriteLine($"{a};{b}");

            (a, b) = (b, a);

            Console.WriteLine($"{a};{b}");

            string c = "coffee";
            string d = "tea";
            Console.WriteLine($"{c};{d}");

            (c, d) = (d, c);

            Console.WriteLine($"{c};{d}");
        }
    }
}