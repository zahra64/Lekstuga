using System;
using System.Linq;
using Xunit;

namespace T2
{
    public class UnitTest1
    {
        [Fact]
        
            public void SampleTest()
            {
                Assert.Equal(22, Kata.SumMix(new object[] { 9, 3, "7", "3" }));
                Assert.Equal(42, Kata.SumMix(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }));
                Assert.Equal(41, Kata.SumMix(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" }));
            }
        
    }

    public class Kata
    {
        public static int SumMix(object[] x)=>
        x.Sum(i => Convert.ToInt32(i));
        // x.Sum(i => int.Parse(i.ToString()));




        //public static int SumMix(object[] x)
        //{
        //    var number = 0;

        //    foreach (var val in x)
        //    {
        //        number += int.Parse(val.ToString());
        //    }
        //    return number;
        //}



        //public static int SumMix(object[] x)

        //{ var nums = x.Select(n => System.Convert.ToInt32(n)).Sum();
        // return nums;
        // }


    }



    //    public static int PositiveSum(int[] arr)
    //    {
    //    return arr.Where(x => x > 0).Sum();


    // return arr.Sum(c => (c< 0 ? 0 : c));


    //public static int PositiveSum(int[] arr)
    //    {
    //        return (from n in arr
    //            where n > 0
    //            select n).Sum();
    //    }
    
    //}
}



