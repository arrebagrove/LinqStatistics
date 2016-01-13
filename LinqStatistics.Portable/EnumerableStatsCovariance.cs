﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqStatistics
{
    public static partial class EnumerableStats
    {
    	
        /// <summary>
        /// Computes the Covariance of two sequences of nullable int values.
        /// </summary>
        /// <param name="source">The first sequence of nullable int values to calculate the Covariance of.</param>
        /// <param name="other">The second sequence of nullable int values to calculate the Covariance of.</param>
        /// <returns>The Covariance of the two sequence of values.</returns>
        public static double? Covariance(this IEnumerable<int?> source, IEnumerable<int?> other)
        {
            IEnumerable<int> values = source.AllValues();
            if (values.Any())
                return values.Covariance(other.AllValues());

            return null;
        }

        /// <summary>
        /// Computes the Covariance of two sequences of int  values.
        /// </summary>
        /// <param name="source">The first sequence of int values to calculate the Covariance of.</param>
        /// <param name="other">The second sequence of int values to calculate the Covariance of.</param>
        /// <returns>The Covariance of the two sequence of values.</returns>
        public static double Covariance(this IEnumerable<int> source, IEnumerable<int> other)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (other == null)
                throw new ArgumentNullException("other");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            if (!other.Any())
                throw new InvalidOperationException("other sequence contains no elements");

            // convert to lists so we can get items by index without enumerating within the loop below
            var listSource = source.ToList();
            var listOther = other.ToList();

            if (listSource.Count != listOther.Count)
                throw new InvalidOperationException("Collections are not of the same length");

            var avgSource = listSource.Average();
            var avgOther = listOther.Average();
            
            double covariance = 0;
            int n = listSource.Count;
            for (int i = 0; i < n; i++)
            {
                covariance += (double)((listSource[i] - avgSource) * (listOther[i] - avgOther));
            }

            return (double)(covariance / n); 
        }               
 	
        /// <summary>
        /// Computes the Covariance of two sequences of nullable long values.
        /// </summary>
        /// <param name="source">The first sequence of nullable long values to calculate the Covariance of.</param>
        /// <param name="other">The second sequence of nullable long values to calculate the Covariance of.</param>
        /// <returns>The Covariance of the two sequence of values.</returns>
        public static double? Covariance(this IEnumerable<long?> source, IEnumerable<long?> other)
        {
            IEnumerable<long> values = source.AllValues();
            if (values.Any())
                return values.Covariance(other.AllValues());

            return null;
        }

        /// <summary>
        /// Computes the Covariance of two sequences of long  values.
        /// </summary>
        /// <param name="source">The first sequence of long values to calculate the Covariance of.</param>
        /// <param name="other">The second sequence of long values to calculate the Covariance of.</param>
        /// <returns>The Covariance of the two sequence of values.</returns>
        public static double Covariance(this IEnumerable<long> source, IEnumerable<long> other)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (other == null)
                throw new ArgumentNullException("other");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            if (!other.Any())
                throw new InvalidOperationException("other sequence contains no elements");

            // convert to lists so we can get items by index without enumerating within the loop below
            var listSource = source.ToList();
            var listOther = other.ToList();

            if (listSource.Count != listOther.Count)
                throw new InvalidOperationException("Collections are not of the same length");

            var avgSource = listSource.Average();
            var avgOther = listOther.Average();
            
            double covariance = 0;
            int n = listSource.Count;
            for (int i = 0; i < n; i++)
            {
                covariance += (double)((listSource[i] - avgSource) * (listOther[i] - avgOther));
            }

            return (double)(covariance / n); 
        }               
 	
        /// <summary>
        /// Computes the Covariance of two sequences of nullable decimal values.
        /// </summary>
        /// <param name="source">The first sequence of nullable decimal values to calculate the Covariance of.</param>
        /// <param name="other">The second sequence of nullable decimal values to calculate the Covariance of.</param>
        /// <returns>The Covariance of the two sequence of values.</returns>
        public static decimal? Covariance(this IEnumerable<decimal?> source, IEnumerable<decimal?> other)
        {
            IEnumerable<decimal> values = source.AllValues();
            if (values.Any())
                return values.Covariance(other.AllValues());

            return null;
        }

        /// <summary>
        /// Computes the Covariance of two sequences of decimal  values.
        /// </summary>
        /// <param name="source">The first sequence of decimal values to calculate the Covariance of.</param>
        /// <param name="other">The second sequence of decimal values to calculate the Covariance of.</param>
        /// <returns>The Covariance of the two sequence of values.</returns>
        public static decimal Covariance(this IEnumerable<decimal> source, IEnumerable<decimal> other)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (other == null)
                throw new ArgumentNullException("other");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            if (!other.Any())
                throw new InvalidOperationException("other sequence contains no elements");

            // convert to lists so we can get items by index without enumerating within the loop below
            var listSource = source.ToList();
            var listOther = other.ToList();

            if (listSource.Count != listOther.Count)
                throw new InvalidOperationException("Collections are not of the same length");

            var avgSource = listSource.Average();
            var avgOther = listOther.Average();
            
            double covariance = 0;
            int n = listSource.Count;
            for (int i = 0; i < n; i++)
            {
                covariance += (double)((listSource[i] - avgSource) * (listOther[i] - avgOther));
            }

            return (decimal)(covariance / n); 
        }               
 	
        /// <summary>
        /// Computes the Covariance of two sequences of nullable float values.
        /// </summary>
        /// <param name="source">The first sequence of nullable float values to calculate the Covariance of.</param>
        /// <param name="other">The second sequence of nullable float values to calculate the Covariance of.</param>
        /// <returns>The Covariance of the two sequence of values.</returns>
        public static float? Covariance(this IEnumerable<float?> source, IEnumerable<float?> other)
        {
            IEnumerable<float> values = source.AllValues();
            if (values.Any())
                return values.Covariance(other.AllValues());

            return null;
        }

        /// <summary>
        /// Computes the Covariance of two sequences of float  values.
        /// </summary>
        /// <param name="source">The first sequence of float values to calculate the Covariance of.</param>
        /// <param name="other">The second sequence of float values to calculate the Covariance of.</param>
        /// <returns>The Covariance of the two sequence of values.</returns>
        public static float Covariance(this IEnumerable<float> source, IEnumerable<float> other)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (other == null)
                throw new ArgumentNullException("other");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            if (!other.Any())
                throw new InvalidOperationException("other sequence contains no elements");

            // convert to lists so we can get items by index without enumerating within the loop below
            var listSource = source.ToList();
            var listOther = other.ToList();

            if (listSource.Count != listOther.Count)
                throw new InvalidOperationException("Collections are not of the same length");

            var avgSource = listSource.Average();
            var avgOther = listOther.Average();
            
            double covariance = 0;
            int n = listSource.Count;
            for (int i = 0; i < n; i++)
            {
                covariance += (double)((listSource[i] - avgSource) * (listOther[i] - avgOther));
            }

            return (float)(covariance / n); 
        }               
 	
        /// <summary>
        /// Computes the Covariance of two sequences of nullable double values.
        /// </summary>
        /// <param name="source">The first sequence of nullable double values to calculate the Covariance of.</param>
        /// <param name="other">The second sequence of nullable double values to calculate the Covariance of.</param>
        /// <returns>The Covariance of the two sequence of values.</returns>
        public static double? Covariance(this IEnumerable<double?> source, IEnumerable<double?> other)
        {
            IEnumerable<double> values = source.AllValues();
            if (values.Any())
                return values.Covariance(other.AllValues());

            return null;
        }

        /// <summary>
        /// Computes the Covariance of two sequences of double  values.
        /// </summary>
        /// <param name="source">The first sequence of double values to calculate the Covariance of.</param>
        /// <param name="other">The second sequence of double values to calculate the Covariance of.</param>
        /// <returns>The Covariance of the two sequence of values.</returns>
        public static double Covariance(this IEnumerable<double> source, IEnumerable<double> other)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (other == null)
                throw new ArgumentNullException("other");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            if (!other.Any())
                throw new InvalidOperationException("other sequence contains no elements");

            // convert to lists so we can get items by index without enumerating within the loop below
            var listSource = source.ToList();
            var listOther = other.ToList();

            if (listSource.Count != listOther.Count)
                throw new InvalidOperationException("Collections are not of the same length");

            var avgSource = listSource.Average();
            var avgOther = listOther.Average();
            
            double covariance = 0;
            int n = listSource.Count;
            for (int i = 0; i < n; i++)
            {
                covariance += (double)((listSource[i] - avgSource) * (listOther[i] - avgOther));
            }

            return (double)(covariance / n); 
        }               
     }
}