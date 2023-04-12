using System;
using System.Collections.Generic;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Libro book1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro book2 = new Libro("Pro C#","Troelsen","001-035");
            
            Shelve sh1 = new Shelve("A");
            Shelve sh2 = new Shelve("B");

            Sector s1 = new Sector("7");
            s1.AddShelveToSector(sh1);

            sh1.AddBookToShelve(book1);

            Console.WriteLine(sh1);

            
            //book1.ShelveBook("A","7");
            //book2.ShelveBook("B","3");

        }
    }
}