using System;

namespace Items
{
    public class Item
    {
        public string ID { set; get; }
        public string Title { set; get; }

        public override string ToString()
        {
            return $"Item:\nID->{ID,10}\nTITLE->{Title,20}";
        }
    }
}
