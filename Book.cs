using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project
{
   

    public class Book
    {
        string name;
        string author;
        int price;


        Book(string name, string author, int price)
        {

            this.name = name;
            this.author = author;
            this.price = price;

        }

        public static void MMain(string[] args)
        {
            // Console.WriteLine ("Hello Mono World");
            Book b = new Book("yayati", " v.s.Khandekar", 500);
            // float final = (float)b.price * 0.1;
            double final = (double)b.price * 0.1;
            Console.WriteLine(final + "  final price of a book ");

        }
    }

}


