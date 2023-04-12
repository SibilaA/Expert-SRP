using System;
using System.Collections.Generic;

namespace SRP
{
    public class Libro
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
 
        public Libro(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        public override string ToString()
        {
            return $"{this.Title} y su autor: {this.Author}";
        }


    }
}
