namespace StringContains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a string:");
                string input = Console.ReadLine();
                CheckForVowels(input);
                Console.WriteLine("The string contains vowels.");
            }
            catch (NoVowelsException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void CheckForVowels(string input)
        {
 
            foreach (char c in input)
            {
                if (input.Contains(c))
                {
                    return;
                }
            }

            throw new NoVowelsException("The string does not contain any vowels.");
        }
    }
    }

