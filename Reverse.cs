using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra_HW_05
{
    public class ReverseNums
    {
        public static int[] GenerateNumbers() 
        {
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++) 
            {
                Random r = new Random();
                int randNum = r.Next(int.MinValue, int.MaxValue);
                nums[i] = randNum;
            }
            return nums;
        }
        public static void Reverse(int[] nums)
        {
            int[] revNums = new int[nums.Length];
            for (int i = 0; i < revNums.Length; i++) 
            {
                revNums[i] = nums[nums.Length-1-i];
            }
            for (int i = 0; i < nums.Length; i++) 
            {
                nums[i] = revNums[i];
            }
        }
        public static void PrintNumbers(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
