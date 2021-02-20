using System;
using System.Collections.Generic;
using System.Linq;
using Extensions.Equality;
using Model;

namespace Operations.Join
{
    public class JoinOperations
    {
        private readonly List<Person> _personList;
        private readonly List<Item> _itemList;
        public JoinOperations()
        {
            _personList = new List<Person>()
            {
                new Person() { Id = 1, Name = "Person1", ItemId = 11 },
                new Person() { Id = 2, Name = "Person2", ItemId = 12 },
                new Person() { Id = 3, Name = "Person3", ItemId = 13 },
                new Person() { Id = 4, Name = "Person4", ItemId = 14 }
            };

            _itemList = new List<Item>()
            {
                new Item() { Id = 12, Name = "Item1" },
                new Item() { Id = 13, Name = "Item2" },
                new Item() { Id = 14, Name = "Item3" },
                new Item() { Id = 15, Name = "Item4" },
            };
        }

        public void Join()
        {
            List<Person> personList = _personList.Join(_itemList,
                                            person => person.ItemId, 
                                            item => item.Id, 
                                            (person, item) => person).ToList();
        }

        public void JoinWithEqualityComparer()
        {
            var equalityComparer = EqualityComparerFactory.Create<int>(
                    id => id.GetHashCode(), 
                    (personId, itemId) => personId == itemId && itemId == 13
                );

            List<Item> itemList = _personList.Join(_itemList,
                                                person => person.ItemId,
                                                item => item.Id,
                                                (person, item) => item,
                                                equalityComparer).ToList();
        }

        
    }
}