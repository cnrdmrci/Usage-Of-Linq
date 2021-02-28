using System.Linq;

namespace Operations.Set
{
    public class SetOperations
    {
        private readonly int[] _list1;
        private readonly int[] _list2;
        public SetOperations()
        {
            _list1 = new int[] {1,1,2,2,3,3,4};
            _list2 = new int[] {1,1,2,5,6};
        }

        public void Distinct()
        {
            var distinctList = _list1.Distinct();
            //1,2,3,4
        }

        public void Except()
        {
            var exceptList = _list1.Except(_list2);
            //3,4
        }

        public void Intersect()
        {
            var intersectList = _list1.Intersect(_list2);
            //1,2
        }

        public void Union()
        {
            //Concat list with distinct
            var unionList = _list1.Union(_list2);
            //1,2,3,4,5,6
        }

    }


}