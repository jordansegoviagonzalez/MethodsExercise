using System.Runtime.Serialization.Json;

namespace MethodsExercise
{
    public class Program
    {
        public static void Madlib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hellow, {userName}! What is your favorite color");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favoriteAnimal = Console.ReadLine();
            Console.WriteLine("Favorite band?");
            string favoriteBand = Console.ReadLine();
            
            Console.WriteLine(
                $"On day, {userName} was walking through the park while wearing {favoriteColor} pants. {userName} saw a {favoriteAnimal} listening to {favoriteBand}.");
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
        
        
        static void Main(string[] args)
       
        {
            //Madlib();
            //Console.WriteLine(Add (2, 2));
            //int addedNumber = Add(1, 2);
            //Console.WriteLine(Subtract(numOne: 2, numTwo: 2));
            //Console.WriteLine(Multiply(2, 2));
            //Console.WriteLine(Divide(2, 2));
            Console.WriteLine(Sum(10, 20));
        }
    }
}
