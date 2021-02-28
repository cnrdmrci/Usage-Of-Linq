using System.Linq;

namespace Operations.Equality
{
    public class EqualityOperations
    {
        private readonly int[] _list1;
        private readonly int[] _list2;
        private readonly int[] _list3;
        private readonly int[] _list4;
        public EqualityOperations()
        {
            _list1 = new int[] {1, 2, 3, 4};
            _list2 = new int[] {1, 2, 3, 4};
            _list3 = new int[] {1, 3, 2, 4};

            _list4 = _list1;
        }

        public void SequenceEqual()
        {
            var IsTrue1 = _list1.SequenceEqual(_list2); //true
            var IsTrue2 = _list2.SequenceEqual(_list3); //false

            var IsTrue3 = _list1.SequenceEqual(_list4); //true

            var IsTrue4 = _list1.Equals(_list4); //true
            var IsTrue5 = _list1.Equals(_list2); //false
        }


    }


}