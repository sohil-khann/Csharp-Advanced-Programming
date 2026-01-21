namespace PracticeProblems.App
{
    public class Calculator
    {
        public int Add(int a, int b)//For Adding two integers
        {
            return a + b;
        }

        public int Subtract(int a, int b)//For Subtracting two integers
        {
            return a - b;
        }

        public int Multiply(int a, int b)//For Multiplying two integers
        {
            return a * b;
        }

        public int Divide(int a, int b)//For Dividing two integers
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }
    }
}
