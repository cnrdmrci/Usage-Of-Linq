using System;
using System.Collections.Generic;
using System.Linq;
using Model;

namespace Operations.Grouping
{
    public class GroupingOperations
    {
        private readonly List<User> _userList;
        private readonly int[] _array = { 1,2,3,4,5,6,7,8,9,10,11,12 };
        public GroupingOperations()
        {
            _userList = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Name = "Caner",
                    Surname = "Surname1",
                    Username = "c1"
                },
                new User()
                {
                    Id = 2,
                    Name = "Caner",
                    Surname = "Surname2",
                    Username = "c2"
                },
                new User()
                {
                    Id = 3,
                    Name = "Caner1",
                    Surname = "Surname3",
                    Username = "c3"
                },
                new User()
                {
                    Id = 4,
                    Name = "Caner2",
                    Surname = "Surname4",
                    Username = "c4"
                }
            };
        }

        //lazy loading in ef
        public void GroupBy()
        {
            //only one column group
            _userList.GroupBy(x => x.Name).ToList().ForEach( x => {
                Console.WriteLine("Key: " + x.Key + " Count: " + x.Count());
            });

            //multiple column group
            _userList.GroupBy(x => new { x.Name, x.Surname }).ToList().ForEach( x => {
                Console.WriteLine("Key1: " + x.Key.Name + " Key2: " + x.Key.Surname + " Count: " + x.Count() );
            });

        }

        //eager loading in ef
        public void ToLookUp()
        {
            var lookup = _array.ToLookup( x => x % 2 );
            
            Console.WriteLine(string.Join(",",lookup[0]));
            //output: 2,4,6,8

            Console.WriteLine(string.Join(",",lookup[1]));
            //output: 1,3,5,7


            //------------------------------
            _userList.ToLookup( x => x.Name ).ToList().ForEach( x => {
                Console.WriteLine("Key: " + x.Key + " Count: " + x.Count());
            });
        }
    }
}