using System;
using System.Security.Cryptography.X509Certificates;
using Mathematics;

namespace MathematicsConsole
{
    class Program
    {
        private static double _num1;
        private static double _num2;
        private static string _operand;
        private static void closeProgram()
        {
            Console.ReadLine();
            Environment.Exit(99);
        }

        static void Main()
        {
            

            string[] args = Environment.GetCommandLineArgs();
            //foreach(var a in args)
            //{
            //    Console.WriteLine(a);
            //}
            AreArgumentsValid(args);

            var basic = new BasicMath();
            var adv = new AdvMath();

            switch (_operand)
            {
                case "add":
                    Console.WriteLine($"{_num1} + {_num2} = {basic.AddNumbers(_num1, _num2)}"); 
                    break;
                case "sub":
                    Console.WriteLine($"{_num1} - {_num2} = {basic.SubNumbers(_num1, _num2)}");
                    break;
                case "mul":
                    Console.WriteLine($"{_num1} * {_num2} = {basic.MulNumbers(_num1, _num2)}");
                    break;
                case "div":
                    Console.WriteLine($"{_num1} / {_num2} = {basic.DivNumbers(_num1, _num2)}");
                    break;
                case "area":
                    Console.WriteLine($"The area of a rectangle with a height of {_num1} and a width of {_num2} is {adv.CalculateArea(_num1, _num2)}");
                    break;
                case "sqre":
                    Console.WriteLine($"{_num1} squared is {adv.CalculateSquare(_num1)}");
                    break;
                case "sqrt":
                    Console.WriteLine($"The square root of {_num1} is {adv.CalculateSquareRoot(_num1)}");
                    break;
                case "pyth":
                    Console.WriteLine($"Given sides of a triangle A ({_num1}) and B ({_num2}), C is {adv.PythagoreanTheorem(_num1, _num2)} long");
                    break;
                default:
                    Console.WriteLine($"{_operand} is not a valid operator."); 
                    break;
            }

            Console.ReadLine();
        }

        public static void AreArgumentsValid(string[] args)
        {
            if(args.Length > 4 || args.Length < 3) {
                Console.WriteLine("Provided the wrong number of arguments. Must be 2 or 3.");
                closeProgram();
            }

            if (args.Length == 3)
            {
                _operand = args[1].ToLower();
                if (_operand != "sqrt" && _operand != "sqre")
                {
                    Console.WriteLine("The only acceptable operands for 2 arguments are 'sqrt' and 'sqre'");
                    closeProgram();
                }
                _num1 = NumParser(args[2]);
            }
            else
            {
                _operand = args[1].ToLower();

                if (_operand == "sqrt" || _operand == "sqre")
                {
                    Console.WriteLine("'sqrt' and 'sqre' take only one argument alongside themselves.");
                    closeProgram();
                }

                _num1 = NumParser(args[2]);
                _num2 = NumParser(args[3]);
            }

            Console.WriteLine("Arguments are valid");

        }

        public static double NumParser(string arg)
        {
            double number;
            if(Double.TryParse(arg, out number))
            {
                return number;
            } else
            {
                Console.WriteLine($"Unable to parse {arg}.");
                closeProgram();
            }
            return 0;
        }
    }
    
}