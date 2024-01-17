namespace Mathematics.Test
{
    public class BasicMathTest
    {
        [Fact]
        public void AddNumbersTest()
        {
            var math = new BasicMath();
            var result = math.AddNumbers(1, 2);
            Assert.True(result == 3, $"{result} is not equal to the number we were thinking");
        }

        [Fact]
        public void SubNumbersTest()
        {
            var math = new BasicMath();
            var result = math.SubNumbers(2, 1);
            Assert.True(result == 1, $"{result} is not equal to the number we were thinking");
        }

        [Fact]
        public void ListCountTest()
        {
            var math = new BasicMath();
            var list = new List<Double> { 2, 4, 6 };
            var result = math.ListCount(list);
            Assert.True(result == 3, $"{result} is not the number we were thinking");
        }
    }
}