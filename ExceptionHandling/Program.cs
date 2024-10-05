namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int count = int.Parse(Console.ReadLine());
                List<int> numbers = new List<int>();
                Console.WriteLine($"Please enter {count} integers:");
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Enter number{i + 1}:");
                    int number = int.Parse(Console.ReadLine());
                    if (numbers.Contains(number))
                    {
                        throw new DuplicateNumberException($"Duplicate number found: {number}");
                    }
                    numbers.Add(number);
                }
            }
            catch (DuplicateNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
