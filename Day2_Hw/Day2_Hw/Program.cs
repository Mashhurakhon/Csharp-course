enum operations
{
    plus,
    minus,
    multiply,
    division
}

class Program
{
    static void Main()
    {
        double calc(double a, double b, operations operation)
        {
            double res;
            switch (operation)
            {
                case operations.plus:
                    res = a + b;
                    break;
                case operations.minus:
                    res = a - b;
                    break;
                case operations.multiply:
                    res = a * b;
                    break;
                case operations.division:
                    res = a / b;
                    break;
                default:
                    res = 0;
                    break;
            }

            return res;
        }

        double calculation = calc(10, 15, operations.multiply);
        Console.WriteLine($"Результат вычисления: {calculation}");
    }
}