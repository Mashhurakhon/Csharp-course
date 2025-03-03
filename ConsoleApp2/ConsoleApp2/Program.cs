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
        
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Index: {i} - value: {numbers[i]}");
        }
    }
    
}


