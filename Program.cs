using System.Globalization;

namespace ASSIGNMENT_6_1_3
{
    internal class Program
    {
        //Method to move all zeros to the end
        public static void MoveZeroes(int[] nums)
        {
            int lastNonZeroIndex = 0;

            //Move all non zero elements to the beginning of the array
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    //Swap only if its not the same index
                    if (i != lastNonZeroIndex)
                    {
                        int temp = nums[i];
                        nums[i] = nums[lastNonZeroIndex];
                        nums[lastNonZeroIndex] = temp;
                    }
                    lastNonZeroIndex++;
                }
            }
        }
        static void Main(string[] args)
        {
            // Example array with zeros and non-zero elements
            int[] nums = { 0, 1, 0, 3, 12 };

            Console.WriteLine("Original Array:");
            Console.WriteLine(string.Join(", ", nums));

            //Move all zeros to the end
            MoveZeroes(nums);

            Console.WriteLine("\nArray After Moving Zeros to the End:");
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
