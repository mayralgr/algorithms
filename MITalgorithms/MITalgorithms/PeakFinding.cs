using System;
// Algorithmn

/**
 * A peak mets the condition in a 1D array if any b >= a && b >= c (left, rigth)
 * in edges you just look at one side
 */

// straigforward algorithm
/**
 * Start from the left
 * walks across
 * look at n/2 elements
 * 
 * 
 * 
 * thetha = O(n)
 * O(1)
 * 
 * 
 * recursive algorithm
 * divide & conquer
 */

namespace MITalgorithms
{
    public class PeakFinding
    {
        public PeakFinding()
        {
            int[] array    = new int[] { 6, 7, 4, 3, 2, 1, 4, 5 };
            int count      = array.Length - 1;
            int res = peakFindingAlgorithm(array, 0, count);
            System.Console.WriteLine(res);
        }



        public int peakFindingAlgorithm(int[] arrayPeak, int start, int end)
        {
            int mid = (start + end) / 2;
            if ( mid > 0 && arrayPeak[ mid ] < arrayPeak[ mid - 1])
            {
                // Look on the left
                return peakFindingAlgorithm(arrayPeak, start , mid - 1 );
            } else if ( mid < arrayPeak.Length -1 &&  arrayPeak[ mid ] < arrayPeak[ mid + 1])
            {
                // Look on the right
                return peakFindingAlgorithm(arrayPeak, mid + 1, end);
            }
            return arrayPeak[ mid ];
        }


    }
}
