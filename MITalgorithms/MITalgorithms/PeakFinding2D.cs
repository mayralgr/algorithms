using System.Linq;
/***
 A peak in 2 d is a hill


Greedy Ascent algorithm --> follow a direction to find the peak
worst case : thetha(nm)

divide and conquer -->
pick the middle column j = m / 2
find the global maximum on column j (i,j)
compare (i,j-1), (i,j), (i,j+1) // left - right
pick left if (i,j-1) > i(j)
pick right if (i,j + 1) > i(j)
then done retun
 */
namespace MITalgorithms
{
    public class PeakFinding2D
    {
        public PeakFinding2D()
        {
            int[,] array2D  = new int[,] { { 10, 8, 10, 10 }, { 14, 13, 12, 11 }, { 15, 9, 11, 21 }, { 16, 17, 19, 20 } };
            int rows        = array2D.GetLength(0);
            int columns     = array2D.GetLength(1);
            // System.Console.WriteLine(rows + " " + columns);
            int peek = peakFinding2D(array2D, 0, columns - 1);
            System.Console.WriteLine(peek);
        }

        private int peakFinding2D(int[,] array2d, int start, int end)
        {
            int column = (start + end) / 2; // the middle
            int[] columnPicked = getColumn(array2d, column); // return the column in the middle
            int globalMax = columnPicked.Max(); // get the global maximum of the column
            int index = System.Array.IndexOf(columnPicked,globalMax); // get the index of the row

            if ( column > 0 && array2d[ index, column - 1 ] > globalMax )
            {
                // go left
                return peakFinding2D(array2d, start, column - 1);

            } else if (  column < array2d.GetLength(0) - 1 && globalMax < array2d[index, column + 1] )
            {
                // go rigth
                return peakFinding2D(array2d, column + 1, end);

            }
            return array2d[index, column];
            /*foreach(int number in columnPicked)
            {
                System.Console.WriteLine(number);
            }*/

        }

        private int[] getColumn(int[,] array, int indexColumn)
        {
            int rows = array.GetLength(0);
            int[] arrayResult = new int[rows];
            for(int i = 0; i < rows; i++ )
            {
                arrayResult[i] = array[i,indexColumn];
            }
            return arrayResult;
        }
    }
}
