﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string korisnik = Console.ReadLine();
            string[] polje = korisnik.Split(' ');
            Console.WriteLine(polje[0]+polje[polje.Length-1]);

            Console.ReadKey();

        }
    }
}
