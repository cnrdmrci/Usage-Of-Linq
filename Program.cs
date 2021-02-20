using System;
using Operations.Filtering;
using Operations.Join;

namespace LinqNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            FilteringOperations();
            JoinOperations();
        }

        static void FilteringOperations()
        {
            FilteringOperations filteringOperations = new FilteringOperations();
            filteringOperations.Where();
            filteringOperations.TypeOf();
        }

        static void JoinOperations()
        {
            JoinOperations joinOperations = new JoinOperations();
            joinOperations.Join();
            joinOperations.JoinWithEqualityComparer();

            joinOperations.GroupJoin();

            joinOperations.LeftOutherJoin();
            joinOperations.LeftOutherJoinWithoutInner();

            joinOperations.RightOutherJoin();
            joinOperations.RightOutherJoinWithoutInner();

            joinOperations.FullOutherJoin();
            joinOperations.FullOutherJoinWithoutInner();

            joinOperations.CrossJoin();

        }
    }
}
