using System;
using System.Collections.Generic;
using Items;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            Item i;
            Book b;
            DVD d;
            Movie m;

            // Instantiate Objects
            i = new Item("10", "title10");
            b = new Book() { ID = "1", Title = "Book 1", Pages = 100 };
            m = new Movie("Brian") { ID = "3", Title = "Movie 3", Length = 30 };
            d = new DVD();

            // Do stuff
            i.UseMe();
            b.UseMe();
            m.UseMe();
            d.UseMe();

            Item x = b;
            Item y = m;
            x.UseMe();

            List<Item> itemList = new List<Item>()
            {
                i,
                b,
                m,
                d
            };

            foreach (var item in itemList)
            {
                item.UseMe();
            }

        }
    }
}
