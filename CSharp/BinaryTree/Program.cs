
using static System.Console;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortedNumber = { 10,14,19,26,27,31,33,35,42,44 };
            int b = BinarySearch(sortedNumber, 31);
            int r = RecursiveBinarySearch(sortedNumber, 0, sortedNumber.Length - 1, 31);
            WriteLine($"The number found at : {b} index");
            WriteLine($"The (using recursion func) number found at : {r} index");
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

        private static int RecursiveBinarySearch(int[] numbers,int left =0,int right=0, int num=0)
        {
            if (right >= left)
            {
                int mid = left + (right - left) / 2;

                if (numbers[mid] > num)
                {
                    return RecursiveBinarySearch(numbers, left, mid - 1, num);
                }
                else if (numbers[mid] < num)
                {
                    return RecursiveBinarySearch(numbers, mid + 1, right, num);
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }

    }
}
