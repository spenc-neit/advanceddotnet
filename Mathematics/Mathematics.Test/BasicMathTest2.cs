namespace Mathematics.Test
{
    public class BasicMathTest2
    {
        [Fact]
        public void MulNumbersTest()
        {
            var math = new BasicMath();
            var result = math.MulNumbers(3, 2);
            Assert.True(result == 6, $"{result} is not equal to the number we were thinking");
        }

        [Fact]
        public void DivNumbersTest()
        {
            var math = new BasicMath();
            var result = math.DivNumbers(6, 2);
            Assert.True(result == 3, $"{result} is not equal to the number we were thinking");
        }

        [Fact]
        public void ListSumTest()
        {
            var math = new BasicMath();
            var list = new List<Double>{2,4,6};
            var result = math.ListSum(list);
            Assert.True(result == 12, $"{result} is not what we were thinking");
        }
    }
}
