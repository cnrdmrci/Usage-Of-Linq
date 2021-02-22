using System;
using Operations.Filtering;
using Operations.Grouping;
using Operations.Join;
using Operations.Projection;
using Operations.Shorting;

namespace LinqNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            FilteringOperations();
            JoinOperations();
            ProjectionOperations();
            ShortingOperations();
            GroupingOperations();
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

        static void ProjectionOperations()
        {
            ProjectionOperations projectionOperations = new ProjectionOperations();
            projectionOperations.Select();
            projectionOperations.SelectMany();
        }

        static void ShortingOperations()
        {
            ShortingOperations shortingOperations = new ShortingOperations();
            shortingOperations.OrderBy();
            shortingOperations.OrderByDescending();
            shortingOperations.ThenBy();
            shortingOperations.ThenByDescending();
            shortingOperations.Reverse();
        }
    
        static void GroupingOperations()
        {
            GroupingOperations groupingOperations = new GroupingOperations();
            groupingOperations.GroupBy();
            groupingOperations.ToLookUp();
        }
    }
}
