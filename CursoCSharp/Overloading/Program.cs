using System;

namespace Overloading
{
    public class Math {
        public int sum(int a, int b) {
            return a + b;
        }

        public int sum(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }

        public int sum(int[] nums) {
            int result =0;
            int idx = 0;

            while (idx < nums.Length) {
                result += nums[idx];
                idx++;
            }
            return result;
          
        }
    }

    class program {
        static void Main(string[] args) {
           Math mat = new Math();
           Console.WriteLine(mat.sum(3, 5));
           Console.WriteLine(mat.sum("4","4"));
           Console.WriteLine(mat.sum(new int[] { 1,2,3}));  
        }
    }
}