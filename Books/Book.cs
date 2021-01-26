using System;

namespace Items
{
    public class Book : Item
    {
        // Default Constructor
        // :base will provide  params to the Item constructor that Book is a child of
        public Book() :base("not supplied", "not supplied")
        {
            Pages = 0;
        }

        // Variables
        public int Pages { get; set; }

        // Methods
        public override void UseMe()
        {
            Console.WriteLine($"Reading Book {ID} Title: {Title} Pages: {Pages}");
        }
    }
}
