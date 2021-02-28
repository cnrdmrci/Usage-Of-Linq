using System;
using Operations.Aggregation;
using Operations.Concatenation;
using Operations.Conversions;
using Operations.Filtering;
using Operations.Grouping;
using Operations.Join;
using Operations.Partition;
using Operations.Projection;
using Operations.Quantifier;
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
            ConversionOperations();
            ConcatenationOperations();
            AggregationOperations();
            QuantifierOperations();
            PartitionOperators();
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

        static void ConversionOperations()
        {
            ConversionOperations conversionOperations = new ConversionOperations();
            conversionOperations.AsEnumerable();
            conversionOperations.AsQueryable();
            conversionOperations.Cast();
            conversionOperations.OfType();
            conversionOperations.ToArray();
            conversionOperations.ToDictionary();
            conversionOperations.ToList();
            conversionOperations.ToLookup();
        }

        static void ConcatenationOperations()
        {
            ConcatenationOperations concatenationOperations = new ConcatenationOperations();
            concatenationOperations.Concat();
        }

        static void AggregationOperations()
        {
            AggregationOperations aggregationOperations = new AggregationOperations();
            aggregationOperations.Aggregate();
            aggregationOperations.Average();
            aggregationOperations.Count();
            aggregationOperations.LongCount();
            aggregationOperations.Max();
            aggregationOperations.Min();
            aggregationOperations.Sum();
        }

        static void QuantifierOperations()
        {
            QuantifierOperations quantifierOperations = new QuantifierOperations();
            quantifierOperations.All();
            quantifierOperations.Any();
            quantifierOperations.Contains();
        }

        static void PartitionOperators()
        {
            PartitionOperators partitionOperators = new PartitionOperators();
            partitionOperators.Skip();
            partitionOperators.SkipWhile();
            partitionOperators.Take();
            partitionOperators.TakeWhile();
        }

    }
}
