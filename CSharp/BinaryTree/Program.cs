
using static System.Console;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortedNumber = { 2, 4, 7, 12, 15, 19, 46, 65, 66, 67, 68, 69, 70, 71, 74, 89, 111, 112, 114, 223, 445, 446, 555, 556, 558, 668, 676, 4566, 334234, 2344356, 456434, 23434534, 234543246, 2345462, 323234422, 333333333, 234324534 };
            int g = BinarySearch(sortedNumber, 558);
            Write($"The number found at : {g} index");
            ReadKey();
        }


        // O ( log n ) 
        private static int BinarySearch(int[] numbers, int num)
        {
            int left = 0;
            int right = numbers.Length - 1;
            int mid = 0;  // (left+right)/2
            int foundElement = 0;

            while (right >= left)
            {
                //mid = (left+right)/2
                //prevent integer overflow when adding L and R we alter the algorithm
                //m = (L+R )/2
                //m= L/2 + L/2 + ( L+R )/2 ---> Add L/2 and -L/2 so they negate each other
                //m= L/2 + L/2 + L/2 + R/2 ---> Separate them into indivisual divisions so we can combine them
                //m= L/2 + L/2  + R/2 - L/2---> reorder
                //m = 2* L/2 + ( R-L)/2 ---> combined elements
                //m = L + ( R -L )/2 ---> simplyfiy and we arived at our solution


                mid = left + (right - left) / 2;
                foundElement = numbers[mid];
                // when found element is grater , it -1 becomes our right bound
                if (foundElement > num)
                {
                    right = mid - 1;

                }// when found element is less , it -1 becomes our left bound
                else if (foundElement < num)
                {
                    left = mid + 1;
                }//found the element
                else
                {
                    return mid;
                }
            }
            return -1;
        }



    }
}
