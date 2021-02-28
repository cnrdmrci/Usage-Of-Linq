using System.Linq;

namespace Operations.Quantifier
{
    public class QuantifierOperations
    {
        private readonly object[] _list;
        public QuantifierOperations()
        {
            _list = new object[]{1,2,3,4,5,6,7,8,9};
        }

        public void All()
        {
            bool IsOnlyContainsInt = _list.All( x => x is int);
        }

        public void Any()
        {
            bool IsAnyValueExist = _list.Any();
            bool IsContainsAny5 = _list.Any( x => (int)x == 5 );
        }

        public void Contains()
        {
            bool IsContains5 = _list.Contains(5);
        }

    }


}