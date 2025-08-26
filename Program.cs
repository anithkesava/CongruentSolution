namespace Congruent_Solution
{
    public class Program
    {
        public static void NotMain(string[] args)
        {
            //string str = "anith";
            //ReverseString(str);
            //int[] array = new int[] { 1, 2, 12, 3, 412, 43, 53 };
            //SecondLargestNumber(array);
            //SwapVariable(5, 10);
            //List<string> names = new List<string> { "anith", "ashvath", "kesava", "pramanujam", "david" };
            //LongestWord(names);
            PrintFibanocci(10);
            Console.ReadLine();
        }
        public static void ReverseString(string str)
        {
            var reverse = new string(str.Reverse().ToArray());
            Console.WriteLine(reverse);
        }
        public static void SecondLargestNumber(int[] array)
        {
            var secondlargest = array.OrderByDescending(x => x).Skip(1).Take(1).FirstOrDefault();
            Console.WriteLine(secondlargest);
        }
        public static void SwapVariable(int a, int b)
        {
            Console.WriteLine($" a:{a}, b:{b}");
            (b, a) = (a, b);
            Console.WriteLine($" a:{a}, b:{b}");
        }
        public static void LongestWord(List<string> names)
        {
            List<int> wordscount = new List<int>();
            foreach (var name in names)
            {
                wordscount.Add(name.Count());
            }
            var longestwordcount = wordscount.OrderByDescending(x => x).Take(1).FirstOrDefault();
            string longestword = names.Where(x => x.Length == longestwordcount).FirstOrDefault() ?? " ";
            if (!string.IsNullOrWhiteSpace(longestword))
            {
                Console.WriteLine("the longest word in the list: " + longestword);
                return;
            }
        }
        public static bool IsPrimeNumber(int number)
        {
            if (number > 2)
            {
                return false;
            }
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % 1 == 0) return false;
            }
            return true;

        }
        public static void PrintFibanocci(int n)
        {
            int a, b, c;
            a = 0;
            b = 1;
            Console.Write($" {a}, {b}, ");
            for(int i=2; i<n;i++)
            {
                c = a + b;
                Console.Write($"{c}, ");
                a = b;
                b = c;
            }
        }
    }
    public record Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
