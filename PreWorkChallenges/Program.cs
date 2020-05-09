using System;

namespace PreWorkChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge 01: Array Max Result");
            ArrayMax();
            Console.WriteLine("Challenge 02: Leap Year Calculator");
            CheckLeapYear();
            Console.WriteLine("Challenge 03: Perfect Sequence");
            CheckPerfectSequenceHandler();
            Console.WriteLine("Challenge 04: Sum of Rows");
            SumOfRowsHandler();
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
        public static void CheckPerfectSequenceHandler()
        {
            int[] perfectArray = new int[3] { 1, 3, 2 };
            int[] notSoPerfectArray = new int[3] { 1, -3, 2 };
            string perfectArrayString = String.Join(", ", perfectArray);
            string notSoPerfectArrayString = String.Join(", ", notSoPerfectArray);

            Console.WriteLine($"[{notSoPerfectArrayString}] {CheckPerfectSequence(notSoPerfectArray)}");
            Console.WriteLine($"[{perfectArrayString}] {CheckPerfectSequence(perfectArray)}");
        }
        public static string CheckPerfectSequence(int[] array)
        {
            string answer = "is not a perfect sequence";
            int sum = 0;
            int product = 1;
            bool negTest = true;
            int length = array.Length;
            for (int i = 0; i < length; i++)
            { 
                if(array[i] <= 0)
                {
                    negTest = false; 
                }
                sum += array[i];
                product = product * array[i];
            }
            if(negTest == true && sum == product)
            {
                answer = "is a prefect sequence";
            }
            return answer;
        }
        public static void SumOfRowsHandler()
        {
            int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            int[] result = SumOfRows(myArray);
            string resultString = String.Join(", ", result);
            Console.WriteLine($"[{resultString}]");
        }

        public static int[] SumOfRows(int[,] inputArray)
        {
            int lengthOuter = inputArray.GetLength(0);
            int lengthInner = inputArray.GetLength(1);
            int[] answer = new int[lengthOuter];
            int sum = 0;

            for (int i = 0; i < lengthOuter; i++)
            {
                sum = 0;
                for (int j = 0; j < lengthInner; j++)
                {
                    sum += inputArray[i, j];
                }
                answer[i] = sum;
            }
            return answer;
        }
    
    }
}
