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
            string name = "name";
            string surname = "surname";
            Console.WriteLine($"{name};{surname}");

            (name, surname) = (surname, name);

            Console.WriteLine($"{name};{surname}");

            string coffee = "coffee";
            string tea = "tea";
            Console.WriteLine($"{coffee};{tea}");

            (coffee, tea) = (tea, coffee);

            Console.WriteLine($"{coffee};{tea}");
        }
    }
}
