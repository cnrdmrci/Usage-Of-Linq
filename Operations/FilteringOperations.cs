using System.Collections.Generic;
using System.Linq;

namespace Operations.Filtering
{
    public class FilteringOperations
    {
        private readonly List<object> _objectList;
        private readonly List<int> _integerList;
        public FilteringOperations()
        {
            _objectList = new List<object>() { "Caner", 123, 34.4, 33.5 };
            _integerList = new List<int>() { 123, 234, 45, 65, 45, 65, 34 };
        }

        public void Where()
        {
            var filteredIntegerList = _integerList.Where(x => x == 123 || x == 34).ToList();
        }

        public void TypeOf()
        {
            var filteredObjectList = _objectList.OfType<double>().ToList();
        }

    }
}