using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project.Collection
{
    class Library
    {
        public enum BookLibraries { ComedyBook, HerrorBook, DramaBook }
        public class Book
        {
            public string BookName { set; get; }
            public int BookPrice { set; get; }
            public string Author { set; get; }

            public BookLibraries bookLibraries;
         //   public List<BookDetails> booklist = new List<BookDetails>();
        }

       
        public class MainBookDetails
        {
            static void mMain(string[] args)
            {
                List<Book> blist = new List<Book>()
            {
                new Book
                {
                    BookName = "panipat ",
                    BookPrice=2500,
                    Author= " V.S. patil ",
                bookLibraries = BookLibraries.ComedyBook,
                    
                   // booklist = { new BookDetails {Author = " V.S. patil" }, }

                },
                new Book
                {
                    BookName = "Gost Story",
                    BookPrice =20000,
                     Author= "",
                    bookLibraries =BookLibraries.HerrorBook,
                   // booklist ={new BookDetails { Author="Petter"} }
                },
                new Book
                {
                    BookName="Romeo And juliet",
                    BookPrice = 25000,
                     Author= " Williams  ",
                    bookLibraries =BookLibraries.DramaBook,
                   // booklist = {new BookDetails { Author = "William Shakespear"} }
                }
            };
                foreach (Book items in blist)
                {
                    Console.WriteLine($"{items.BookName} -> {items.BookPrice} -> {items.bookLibraries}");
                   
                }
                Console.ReadLine();

            }
        }
    }
}
