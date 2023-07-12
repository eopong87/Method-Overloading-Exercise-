namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(0, 1, true));
            Console.WriteLine();
            Console.WriteLine(Add(5, 7, true));
            Console.WriteLine();
            Console.WriteLine(Add(-6, 3, false));
            int answer1 = Add(5, 5);
            Console.WriteLine(answer1);

            decimal answer2 = Add(3.23m, 543.42m);
            Console.WriteLine(answer2);

            string answer3 = Add(10, 10, true);
            Console.WriteLine(answer3);
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool IsMoney)
        {
            var sum = num1 + num2;

            
            if (IsMoney == true && sum == 1)
            {

                return $"{sum} dollar";

            }

            else if (IsMoney == true)
            {



                return $"{sum} dollars";
            }
            else

            {
                return $"{sum}";



            }
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}






