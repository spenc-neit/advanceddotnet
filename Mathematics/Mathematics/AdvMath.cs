namespace Mathematics
{
    public class AdvMath
    {
        /*1. Calculate Area (Height * Width)

        2. Calculate the average of a list of doubles.

        3. Calculate Value Squared (Singular value multiplied by itself)

        4. Calculate Pythagorean Theorem (a2 + b2 = c2). ***HINT The third function should help you with that.

        Example if your function passes in a=3 and b = 4 then your function should return 5.

        To get the Square Root of a number in C# do some research on Math.Sqrt()

        Lastly, Write Unit Tests for all of these functions. Create a new test class for these tests.*/

        public double CalculateArea(double height, double width)
        {
            return height * width;
        }

        public double CalculateSquare(double number)
        {
            return number * number;
        }

        public double CalculateSquareRoot(double number)
        {
            return Math.Sqrt(number);
        }

        public double PythagoreanTheorem(double a, double b)
        {
            return CalculateSquareRoot(CalculateSquare(a) + CalculateSquare(b));
        }

    }
}
