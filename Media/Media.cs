using System;

namespace Items
{
    public class DVD : Item
    {
        public int Length { get; set; }
        public override void UseMe()
        {
            Console.WriteLine($"Playing DVD Item {ID} Title: {Title} for {Length}");
        }
    }

    public class Movie : DVD
    {
        public Movie(string producer)
        {
            this.Producer = producer;
        }

        public string Producer { get; set; }
        // if no override the UseMe() will be DVD's
        public override void UseMe()
        {
            Console.WriteLine($"Watching the Movie Item {ID} Title: {Title} for {Length} by Producer {Producer}");
        }
    }
}
