namespace Mathematics.Test
{
    public class AdvMathTest
    {
        [Fact]
        public void AreaTest()
        {
            var math = new AdvMath();
            var result = math.CalculateArea(3, 4);
            Assert.True(result == 12, $"{result} is not the expected number");
        }

        [Fact]
        public void SquareTest()
        {
            var math = new AdvMath();
            var result = math.CalculateSquare(3);
            Assert.True(result == 9, $"{result} is not the expected number");
        }

        [Fact]
        public void SquareRootTest()
        {
            var math = new AdvMath();
            var result = math.CalculateSquareRoot(49);
            Assert.True(result == 7, $"{result} is not the expected number");
        }

        [Fact]
        public void PythagoreanTest()
        {
            var math = new AdvMath();
            var result = math.PythagoreanTheorem(3, 4);
            Assert.True(result == 5, $"{result} is not the expected number");
        }
    }
}
