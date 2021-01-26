using System;

namespace Items
{
    public class Item
    {
        // Default constructor
        public Item()
        {
            ID = "Default";
            Title = "Default";
        }

        // Two param constructor
        public Item(string ID, string Title)
        {
            this.ID = ID;
            this.Title = Title;
        }

        // Variables
        public string ID { set; get; }
        public string Title { set; get; }

        // Methods
        public virtual void UseMe()
        {
            Console.WriteLine($"Using Item {ID} Title: {Title}");
        }

        public override string ToString()
        {
            return $"Item:\nID->{ID,10}\nTITLE->{Title,20}";
        }
    }
}
