using System.Collections.Generic;

namespace Model
{
    public class PersonWithItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Item> ItemList { get; set;}
    }
}