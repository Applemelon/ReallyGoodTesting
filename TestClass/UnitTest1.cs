using ReallyGoodTesting;
using System;
using Xunit;

namespace TestClass
{
    public class UnitTest1
    {
        InterfaceClass theClass = new Class();

        [Theory]
        [InlineData(0, -3)]
        [InlineData(5, -3)]
        [InlineData(6, 0)]
        [InlineData(49, 0)]
        [InlineData(50, 2)]
        [InlineData(59, 2)]
        [InlineData(60, 4)]
        [InlineData(79, 4)]
        [InlineData(80, 7)]
        [InlineData(84, 7)]
        [InlineData(85, 10)]
        [InlineData(94, 10)]
        [InlineData(95, 12)]
        [InlineData(100, 12)]
        public void ConvertIntToGrade(int percentage, int expectedResult)
        {
            Assert.Equal(theClass.ToGrade(percentage), expectedResult);
        }

        [Theory]
        [InlineData(101)]
        [InlineData(-1)]
        public void ConvertIntToGradeWrongInput(int percentage)
        {
            Assert.Throws<ArgumentException>(() => theClass.ToGrade(percentage));
        }
    }
}
