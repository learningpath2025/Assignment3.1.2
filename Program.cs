namespace Assignment3._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{IfYearIsLeap(GetYear())}");
        }

        public static int GetYear()
        {             
            Console.Write("Enter a year: ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int year))
            {
                return year;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid year.");
                return GetYear();
            }
        }

        public static bool IfYearIsLeap(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true; // Divisible by 400, so it's a leap year
                    }
                    else
                    {
                        return false; // Divisible by 100 but not by 400, so it's not a leap year
                    }
                }
                else
                {
                    return true; // Divisible by 4 but not by 100, so it's a leap year
                }
            }
            else
            {
                return false; // Not divisible by 4, so it's not a leap year
            }
        }
    }
}
