using System;
using System.Collections.Generic;

namespace SRP
{
    public class Shelve
    {

        public string LibraryShelve { get; set; }
        public List<Libro> bookInShelve = new List<Libro>();

        public Shelve(String shelve)
        {
            this.LibraryShelve = shelve;
        }

        public void AddBookToShelve(Libro libro)
        {
            bookInShelve.Add(libro);
        }

        public override string ToString()
        {
            return $"Estantería {this.LibraryShelve} contiene el libro: {String.Join("", bookInShelve)}";
        }
    }
}
