using System;

namespace PreWorkChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //ArrayMax();
            CheckLeapYear();
        }
        public static void ArrayMax()
        {
            int[] inputs = new int[5];
            for (int i = 0; i < inputs.Length; i++)
            {
                Console.WriteLine("Enter a number between 1 and 10");
                inputs[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter a number to score");
            int testNumber = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                if (testNumber == inputs[i])
                {
                    count++;
                }
            }
            int score = count * testNumber;
            Console.WriteLine("The score is " + score);
            Console.ReadLine();
        }

        public static void CheckLeapYear()
        {
            string answer = "";
            Console.Write("Enter year to check if it was a Leap Year: ");
            int testYear = Int32.Parse(Console.ReadLine());
            if (testYear % 4 == 0)
            {
                if(testYear % 100 == 0)
                {
                    if (testYear % 400 == 0)
                    {
                        answer = $"Yes, {testYear} was a Leap Year!";
                    } else
                    {
                        answer = $"No, {testYear} was not a Leap Year!";
                    }
                } else
                {
                    answer = $"Yes, {testYear} was a Leap Year!";
                }
            } else
            {
                answer = $"No, {testYear} was not a Leap Year!";
            }
            Console.WriteLine(answer);
        }
    
    }
}
