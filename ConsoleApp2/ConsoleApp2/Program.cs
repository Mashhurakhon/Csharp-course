enum week
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

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
        // условные операторы
        bool enable = true;
        if (12 == 1213 && enable)
        {
            Console.WriteLine("Disabled");
        }
        else
        {
            Console.WriteLine("Enabled");
        }
        
        string name = "Alice";
        switch (name)
        {
            case "Ali":
                Console.WriteLine("first");
                break;
            case "Alice":
                Console.Write("second");
                break;
        }
        
        var day = week.Saturday;
        
        switch (day)
        {
            case week.Monday:
                break;
            case week.Tuesday:
                break;
            case week.Wednesday:
                break;
            case week.Thursday:
                break;
            case week.Friday:
                break;
            case week.Saturday:
                break;
            case week.Sunday:
                break;
        }
        
        
        // IEnumerable<int> numbers = new int[] { 1, 2, 3, 4, 5 };
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };
        
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     Console.WriteLine($"Index: {i} - value: {numbers[i]}");
        // }

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

        string name2 = "Ali";
        Test(ref name2);
        
        Console.WriteLine(name2);
        void Test(ref string fullname)
        {
            fullname = "newName";
        }

        int summa1 = Sum(1, 2, 3, 45);
        Console.WriteLine($"Summa: {summa1}");

        int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
        
        // рекурсия

        int Factorial(int number)
        {
            if (number < 0)
                return 0;
            if (number < 1)
                return 1;

            return number * Factorial(number - 1);
        }

        int fact = Factorial(5);
        Console.WriteLine($"Factorial: {fact}");
    }
    
    
}


