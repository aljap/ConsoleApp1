// See https://aka.ms/new-console-template for more information
namespace ConsoleCalculator
{
    public class Calculator
    {

        public double Add(double x, double y)
        {

            return x + y;
        }

        public double Subtract(double x, double y)
        {

            return x -
             y;
        }

        public double Multiply(double x, double y)
        {

            return x * y;
        }

        public double Divide(double x, double y)
        {

            if (y == 0)
            {
                throw new DivideByZeroException("Cannot be zero");

            }

            return x / y;
        }

    }
}