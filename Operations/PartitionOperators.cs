using System.Linq;

namespace Operations.Partition
{
    public class PartitionOperators
    {
        private readonly int[] _list;
        public PartitionOperators()
        {
            _list =  new int[]{1,2,3,4,5,6,7,8,9,10};
        }

        public void Skip()
        {
            var newList = _list.Skip(1);
        }

        public void SkipWhile()
        {
            //until first non-match
            var newList = _list.SkipWhile( x => x < 5);
        }

        public void Take()
        {
            var newList = _list.Take(5);
        }

        public void TakeWhile()
        {
            // returns elements from a sequence as long as the condition is true
            var newList = _list.TakeWhile( x => x < 5 );
        }

    }


}