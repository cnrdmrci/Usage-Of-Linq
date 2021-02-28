using System.Linq;

namespace Operations.Element
{
    public class ElementOperators
    {
        private readonly int[] _list;
        public ElementOperators()
        {
            _list = new int[]{1,2,3,4,5,6,7,8,9,10,10};
        }

        public void ElementAt()
        {
            int element1 = _list.ElementAt(3);
            //4

            //throw exception
            // int element2 = _list.ElementAt(11);
        }

        public void ElementAtOrDefault()
        {
            var element1 = _list.ElementAtOrDefault(3);
            //4

            var element2 = _list.ElementAtOrDefault(11);
            //default 0
        }

        public void First()
        {
            var item1 = _list.First();
            var item2 = _list.First( x => x.Equals(5));

            //throw exception
            // var item3 = _list.First( x => x.Equals(14));

            //throw exception
            // var item4 = _list.Where( x => x.Equals(14)).First();
        }

        public void FirstOrDefault()
        {
            var item = _list.FirstOrDefault();
        }

        public void Last()
        {
            var item1 = _list.Last();
            var item2 = _list.Last( x => x.Equals(5));

            //throw exception
            // var item3 = _list.Last( x => x.Equals(14));

            //throw exception
            // var item4 = _list.Where( x => x.Equals(14)).Last();
        }

        public void LastOrDefault()
        {
            var item = _list.LastOrDefault();
        }

        public void Single()
        {
            //throw exception 
            // var result1 = _list.Single();

            var result2 = _list.Where( x => x == 5 ).Single();

            var result3 = _list.Single( x => x == 5 );

            //throw exception for multiple value
            // var result4 = _list.Single( x => x == 10 );

            //throw exception for no value
            // var result5 = _list.Single( x => x == 11 );
        }

        public void SingleOrDefault()
        {
            //throw exception
            // var result1 = _list.SingleOrDefault();

            var result2 = _list.Where( x => x == 5 ).SingleOrDefault();

            //throw exception for multiple value
            // var result3 = _list.SingleOrDefault( x => x == 10 );

            //default value 0
            var result4 = _list.SingleOrDefault( x => x == 11 );
        }

        public void DefaultIfEmpty()
        {
            //used in generation operations.
        }

    }


}