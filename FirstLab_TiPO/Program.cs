public class Calculator
{
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public double Multiply(int a, int b)
    {
        return a * b;
    }

    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }
        return a / b;
    }

    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        int sum = calculator.Sum(1, 2);
        Console.WriteLine($"Sum: {sum}");

        int difference = calculator.Subtract(5, 2);
        Console.WriteLine($"Difference: {difference}");

        double product = calculator.Multiply(3, 2);
        Console.WriteLine($"Product: {product}");

        try
        {
            double quotient = calculator.Divide(10, 2);
            Console.WriteLine($"Quotient: {quotient}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
    }
}
