using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_mine__project
{
    public class Book2
    {
        public enum BookLibrary { historyBook, BattelBook };
        public class Library2
        {
            public string name;
            public string author;
            public int price;

            public string Name { set; get; }
            public string Author { set; get; }
            public int Price { set; get; }

            public BookLibrary bookLibrary;
        }
        public class BookMain
        {
            static void Main(string[] args)
            {
                List<Library2> l = new List<Library2>()
                {
                    new Library2
                    {
                        name= " yayati ",
                        author= " VS khandekar",
                        price=1500,
                        bookLibrary =BookLibrary.historyBook

                    },
                    new Library2
                    {
                        name= "panipat",
                        author= " vishavas patil ",
                        price= 10000,
                         bookLibrary =BookLibrary.BattelBook
                    }
                };

            }
        }
    }
}


   
    

