namespace PracticeProblems.App;

public class MathUtils
{
    public static int Divide(int a, int b)// Method to divide two integers
    {
        if (b == 0)
        {
            throw new ArithmeticException("Division by zero is not allowed.");
        }
        return a / b;
    }
}
