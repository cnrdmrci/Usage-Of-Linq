using System.Collections.Generic;
using System.Linq;

namespace Operations.Generation
{
    public class GenerationOperations
    {
        private readonly string[] _list;
        public GenerationOperations()
        {
            _list = new string[] {"item1","item2","item3","item4"};
        }

        public void DefaultIfEmpty()
        {
            var result1 = _list.DefaultIfEmpty().FirstOrDefault(); //returns item1
            var result2 = _list.Where( x => x.Length > 5 ).DefaultIfEmpty("default").FirstOrDefault(); //returns default
            var result3 = _list.Where( x => x.Length > 5 ).DefaultIfEmpty().First();  //return null;
        }

        public void Empty()
        {
            IEnumerable<string> stringList = Enumerable.Empty<string>();
            IList<string> stringList2 = Enumerable.Empty<string>().ToList();
        }

        public void Range()
        {
            IEnumerable<int> numberSequence = Enumerable.Range(1, 10);
        }

        public void Repeat()
        {
            IEnumerable<string> repeatStrings = Enumerable.Repeat("Text", 10);
        }

    }


}