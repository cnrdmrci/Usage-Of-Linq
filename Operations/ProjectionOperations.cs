using System.Collections.Generic;
using System.Linq;
using Model;

namespace Operations.Projection
{
    public class ProjectionOperations
    {
        private readonly List<PersonWithItem> _personWithItemList;
        public ProjectionOperations()
        {
            _personWithItemList = new List<PersonWithItem>()
            {
                new PersonWithItem()
                {
                    Id = 1,
                    Name = "Person1",
                    ItemList = new List<Item>()
                    {
                        new Item()
                        {
                            Id = 101,
                            Name = "Item1",
                        },
                        new Item()
                        {
                            Id = 102,
                            Name = "Item2",
                        },
                        new Item()
                        {
                            Id = 103,
                            Name = "Item3",
                        }
                    }
                },
                new PersonWithItem()
                {
                    Id = 2,
                    Name = "Person2",
                    ItemList = new List<Item>()
                    {
                        new Item()
                        {
                            Id = 104,
                            Name = "Item4",
                        },
                        new Item()
                        {
                            Id = 105,
                            Name = "Item5",
                        },
                        new Item()
                        {
                            Id = 106,
                            Name = "Item6",
                        }
                    }
                },
                new PersonWithItem()
                {
                    Id = 3,
                    Name = "Person3",
                    ItemList = new List<Item>()
                    {
                        new Item()
                        {
                            Id = 107,
                            Name = "Item7",
                        },
                        new Item()
                        {
                            Id = 108,
                            Name = "Item8",
                        }
                    }
                }
            };
        }
        public void Select()
        {
            var personNames = _personWithItemList.Select( x => x.Name);
        }

        public void SelectMany()
        {
            var personNamesCharList = _personWithItemList.SelectMany( x => x.Name );
            var allOfItemList = _personWithItemList.SelectMany( x => x.ItemList );
            var allOfItemNameList = _personWithItemList.SelectMany( x => x.ItemList, (person,item) => item.Name );
            var personAndItemList = _personWithItemList.SelectMany( x => x.ItemList, (person,item) => new { PersonName = person.Name, Item = item.Name} );
            var personAndItemList2 = _personWithItemList.SelectMany( x => x.ItemList, (person,item) => person.Name + " - " + item.Name  );
        }
    }

}