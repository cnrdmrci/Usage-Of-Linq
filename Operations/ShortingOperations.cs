using System.Collections.Generic;
using System.Linq;
using Model;

namespace Operations.Shorting
{
    public class ShortingOperations
    {
        private readonly List<User> _userList;
        public ShortingOperations()
        {
            _userList = new List<User>()
            {
                new User() { Id = 1, Name = "John", Surname = "Wren", Username = "wrenjohn" },
                new User() { Id = 2, Name = "Maria", Surname = "Aria", Username = "maria123" },
                new User() { Id = 3, Name = "William", Surname = "Aria", Username = "aria9"},
                new User() { Id = 4, Name = "Oliver", Surname = "Dale", Username = "oliver" }
            };
        }

        public void OrderBy()
        {
            var list = _userList.OrderBy( x => x.Name );
        }

        public void OrderByDescending()
        {
            var list = _userList.OrderByDescending( x => x.Name );
        }

        public void ThenBy()
        {
            var list = _userList.OrderBy( x => x.Surname ).ThenBy( x => x.Name );
            var list2 = _userList.OrderByDescending( x => x.Surname ).ThenBy( x => x.Name );
        }

        public void ThenByDescending()
        {
            var list = _userList.OrderBy( x => x.Surname ).ThenByDescending( x => x.Name );
            var list2 = _userList.OrderByDescending( x => x.Surname ).ThenByDescending( x => x.Name );
        }

        public void Reverse()
        {
            _userList.Reverse();
        }
    }
}