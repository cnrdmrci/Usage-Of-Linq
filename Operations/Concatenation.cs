using System.Linq;

namespace Operations.Concatenation
{
    public class ConcatenationOperations
    {
        private readonly int[] _list1 = new int[]{1,2,3,4};
        private readonly int[] _list2 = new int[]{1,2,5,6};
        public ConcatenationOperations()
        {
            
        }

        //Note: Union removes duplicates. Concat does not.
        public void Concat()
        {
            var concatedList = _list1.Concat(_list2);
        }

    }


}