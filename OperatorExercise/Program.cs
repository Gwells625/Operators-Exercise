namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static void PrintAreaOfCircle()
        {   //------PrintAreaOfACircle();
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with a radius of {radius} is {Math.Round(AreaOfCircle(radius), 3)}");
        }
        static void Main(string[] args)
        {   //------Exercise 1----------
            int a = 17;
            int b = 4;
            
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            
            int quotient = a / b;
            int remainder = a % b;
            
            Console.WriteLine("Exercise 1: Arithmetic Operations");
            Console.WriteLine($"{a} + {b} = {sum}");
            Console.WriteLine($"{a} - {b} = {difference}");
            Console.WriteLine($"{a} * {b} = {product}");
            Console.WriteLine($"{a} / {b} = {quotient} remainder {remainder}");
            Console.WriteLine();
            //Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            
            PrintAreaOfCircle();

            Console.WriteLine("Thought Exercise: Prefix vs Postfix");
            int i = 3;
            int j = 4;
            int k = ++i * j++;//i becomes 4 before use, j is used as 4 then becomes 5

            Console.WriteLine($"k = {k}"); // What will this output? 4 * 4 = 16
        }
    }
}
