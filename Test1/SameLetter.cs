//using System;
//using Xunit;

//namespace Test1
//{
//    public class UnitTest1
//    {
//        [Fact]
//        public void Test11()
//        {
//            Assert.NotEqual(4,4);
//        }
//    }
//}

using Xunit;

namespace Test1
{
    using System;
    using Xunit;


    public class SolutionTest
    {
        [Fact]
        public void TrueTests()
        {
            Assert.Equal(1, Kata.SameCase('a', 'u'));
            Assert.Equal(1, Kata.SameCase('A', 'U'));
            Assert.Equal(1, Kata.SameCase('Q', 'P'));
            Assert.Equal(1, Kata.SameCase('w', 'y'));
            Assert.Equal(1, Kata.SameCase('c', 'm'));
            Assert.Equal(1, Kata.SameCase('N', 'W'));
        }

        [Fact]
        public void FalseTests()
        {
            Assert.Equal(0, Kata.SameCase('a', 'U'));
            Assert.Equal(0, Kata.SameCase('A', 'u'));
            Assert.Equal(0, Kata.SameCase('Q', 'p'));
            Assert.Equal(0, Kata.SameCase('w', 'Y'));
            Assert.Equal(0, Kata.SameCase('c', 'M'));
            Assert.Equal(0, Kata.SameCase('N', 'w'));
        }

        [Fact]
        public void NotLetters()
        {
            Assert.Equal(-1, Kata.SameCase('a', '*'));
            Assert.Equal(-1, Kata.SameCase('A', '%'));
            Assert.Equal(-1, Kata.SameCase('Q', '1'));
            Assert.Equal(-1, Kata.SameCase('w', '-'));
            Assert.Equal(-1, Kata.SameCase('c', '8'));
            Assert.Equal(-1, Kata.SameCase('N', ':'));
        }
    }
}

public class Kata
    {
        public static int SameCase(char a, char b)
        {
            if (!char.IsLetter(a) || !char.IsLetter(b))
                return -1;
            return char.IsLower(a) == char.IsLower(b) ? 1 : 0;
        }
    }