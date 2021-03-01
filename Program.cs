using System;
using Operations.Aggregation;
using Operations.Concatenation;
using Operations.Conversions;
using Operations.Element;
using Operations.Equality;
using Operations.Filtering;
using Operations.Grouping;
using Operations.Join;
using Operations.Partition;
using Operations.Projection;
using Operations.Quantifier;
using Operations.Set;
using Operations.Shorting;
using Operations.Generation;

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
            EqualityOperations();
            SetOperations();
            ElementOperators();
            GenerationOperations();
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

        static void EqualityOperations()
        {
            EqualityOperations equalityOperations = new EqualityOperations();
            equalityOperations.SequenceEqual();
        }

        static void SetOperations()
        {
            SetOperations setOperations = new SetOperations();
            setOperations.Distinct();
            setOperations.Except();
            setOperations.Intersect();
            setOperations.Union();
        }
        
        static void ElementOperators()
        {
            ElementOperators elementOperators = new ElementOperators();
            elementOperators.ElementAt();
            elementOperators.ElementAtOrDefault();
            elementOperators.First();
            elementOperators.FirstOrDefault();
            elementOperators.Last();
            elementOperators.LastOrDefault();
            elementOperators.Single();
            elementOperators.SingleOrDefault();
            elementOperators.DefaultIfEmpty();
        }

        static void GenerationOperations()
        {
            GenerationOperations generationOperations = new GenerationOperations();
            generationOperations.DefaultIfEmpty();
            generationOperations.Empty();
            generationOperations.Range();
            generationOperations.Repeat();
        }

    }
}
