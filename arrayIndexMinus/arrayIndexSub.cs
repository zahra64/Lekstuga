using System;
using System.Linq;
using Xunit;

namespace t1
{
    using System;


    public class KataTests
    {

        [Fact]


        public void SampleTest()
        {
            Assert.Equal(0, Kata.SumOfDifferences(new int[] { }));
            Assert.Equal(0, Kata.SumOfDifferences(new int[] { 0 }));
            Assert.Equal(0, Kata.SumOfDifferences(new int[] { 1 }));
            Assert.Equal(0, Kata.SumOfDifferences(new int[] { -1 }));
            Assert.Equal(34, Kata.SumOfDifferences(new int[] { -17, 17 }));
            Assert.Equal(9, Kata.SumOfDifferences(new int[] { 2, 1, 10 }));
            Assert.Equal(2, Kata.SumOfDifferences(new int[] { -3, -2, -1 }));
            Assert.Equal(0, Kata.SumOfDifferences(new int[] { 1, 1, 1, 1, 1 }));
            Assert.Equal(0, Kata.SumOfDifferences(new int[] { 0, 0, 0, 0, 0 }));
            Assert.Equal(4, Kata.SumOfDifferences(new int[] { 1, 2, 3, 4, 5 }));
            Assert.Equal(29, Kata.SumOfDifferences(new int[] { 0, 29, 24, 17 }));
            Assert.Equal(50, Kata.SumOfDifferences(new int[] { 25, 24, -25, 2 }));
            Assert.Equal(22, Kata.SumOfDifferences(new int[] { -26, -4, -8, -8 }));
        }
    }


    public static class Kata
    {
        public static int SumOfDifferences(int[] arr)
        {
            if (arr.Length < 2)
            {
                return 0;
            }

            Array.Sort(arr);
            Array.Reverse(arr);
            int[] newArr = new int[arr.Length - 1];
            int result = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                newArr[i] = arr[i] - arr[i + 1];
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                result = result + newArr[i];
            }

            return result;
        }


        //return arr.Any() ? arr.Max() - arr.Min() : 0;

        // return arr.Length > 1 ? arr.Max() - arr.Min() : 0;

        // return x.Select(e => e * 2).ToArray();
    }
}
