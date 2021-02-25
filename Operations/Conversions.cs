using System.Collections.Generic;
using System.Linq;
using Model;

namespace Operations.Conversions
{
    public class ConversionOperations
    {
        private readonly List<User> _userList;
        public ConversionOperations()
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

        //important - IEnumerable vs IQueryable
        public void AsEnumerable()
        {
            //eager loading
            var asEnumerableUserList = _userList.AsEnumerable();
        }

        public void AsQueryable()
        {
            //lazy loading
            var asQueryableUserList = _userList.AsQueryable();
        }

        public void Cast()
        {
            List<object> objectUserList = _userList.Cast<object>().ToList();
            List<User> userList = objectUserList.Cast<User>().ToList();
        }

        public void OfType()
        {
            //used in filtering operations.
        }

        public void ToArray()
        {
            string[] usernameList = _userList.Select( x => x.Username ).ToArray();
        }

        public void ToDictionary()
        {
            var userDictionary = _userList.ToDictionary( x => x.Username);
            var userDictionary2 = _userList.ToDictionary( x => x.Username, x => x);
            var userDictionary3 = _userList.ToDictionary( x => x.Username, x => x.Name);
        }

        public void ToList()
        {
            var userList = _userList.ToList();
        }

        public void ToLookup()
        {
            //used in grouping operations.
        }

    }


}