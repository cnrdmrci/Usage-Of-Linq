using System.Linq;

namespace Operations.Aggregation
{
    public class AggregationOperations
    {
        private readonly int[] _numberList = new int[]{1,2,3,4,5,6,7,8,9,10,11};
        private readonly int[] _numberList2 = new int[]{1};
        private readonly int[] _numberList3 = new int[]{};
        public AggregationOperations()
        {
            
        }

        public void Aggregate()
        {
            int sum = _numberList.Aggregate((prevSum,current) => prevSum + current);
            string aggregatedNumberString = _numberList.Select( x => x.ToString()).Aggregate((prev,current) => prev + "," + current);
            string aggregatedNumberString2 = _numberList2.Select( x => x.ToString()).Aggregate((prev,current) => prev + "," + current);

            //will exception for empty list
            //string aggregatedNumberString3 = _numberList3.Select( x => x.ToString()).Aggregate((prev,current) => prev + "," + current);

            string seed = string.Empty;
            string aggregatedNumberString4 = _numberList3.Select( x => x.ToString()).Aggregate(seed,(prev,current) => prev + "," + current).TrimStart(',');

            //on other side with string.Join works well
            var list1 = string.Join(",",_numberList);
            var list2 = string.Join(",",_numberList2);
            var list3 = string.Join(",",_numberList3);
        }

        public void Average()
        {
            double avarage = _numberList.Average();
        }

        public void Count()
        {
            int count = _numberList.Count();
        }

        public void LongCount()
        {
            long count = _numberList.LongCount();
        }

        public void Max()
        {
            int max = _numberList.Max();
        }

        public void Min()
        {
            int min = _numberList.Min();
        }

        public void Sum()
        {
            int sum = _numberList.Sum();
        }

    }


}