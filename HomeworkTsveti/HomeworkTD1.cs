using System;
using Utils;

namespace HomeworkTsveti
{
    public class HomeworkTD1
    {

        //Да се напише програма, която въвежда n цели числаи проверява дали сред тях съществува число, 
        //което е равно на сумата на всички останали.Ако има такъв елемент, се отпечатва "Yes" + неговата
        //стойност, в противен случай - "No" + разликата между най-големия елемент и сумата на останалите(по абсолютна стойност). 

        //Да се напише програма която чете n на брой числа и намира най-голямото от тях

        //Масив - въвеждаме стойностите от конзолата, на екрана извеждаме най-голямата сума на два елемента от масива 

        public void ChooseAction()
        {
            Console.WriteLine("Hello, choose an action: " +
                "press 1 for max sum comparison, " +
                "press 2 for is even, " +
                "press 3 for the sum of the two largest elements, " +
                "press 9 for exit");

            bool shouldContinue = true;
            while (shouldContinue)
            {
                shouldContinue = false;
                int userChoise = int.Parse(Console.ReadLine());
                switch (userChoise)
                {
                    case 1:
                        CompareSumWithMaxNumber();
                        break;
                    case 2:
                        IsEvenWithInput();
                        break;
                    case 3:
                        SumOfTheTwoLargestElements();
                        break;
                    case 9:
                        Console.WriteLine("Terminating.");
                        break;
                    default:
                        Console.WriteLine("Please, choose 1, 2 or 3 to continue or 9 to exit");
                        shouldContinue = true;
                        break;
                }
            }
        }

        //Масив - въвеждаме стойностите от конзолата, на екрана извеждаме най-голямата сума на два елемента от масива

        //Homework
        //  {1,1,1,2,2}
        // 1 - 3 times, 2 - 2 times
        public void CountNumbersOfArray(int[] numbers)
        {
            Array.Sort(numbers);

            int count = 1;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{numbers[i]} - {count}");
                    count = 1;
                }
            }
            //Print the last item
            Console.WriteLine($"{numbers[numbers.Length - 1]} - {count}");

            //int count = 1;
            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] == numbers[i - 1]) {
            //        count++;
            //    } else
            //    {
            //        Console.WriteLine($"{numbers[i - 1]} - {count}");
            //        count = 1;
            //    }

            //    if (i == numbers.Length - 1)
            //    {
            //        Console.WriteLine($"{numbers[i]} - {count}");
            //    }
            //}
        }
        private void SumOfTheTwoLargestElements()
        {

            Console.WriteLine("Enter the number of items: ");
            int numberOfItems = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = new int[numberOfItems];
            int bigNum1 = 0;
            int bigNum2 = 0;

            for (int i = 0; i < numberOfItems; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
                if (arrayOfNumbers[i] > bigNum1)
                {
                    bigNum2 = bigNum1;
                    bigNum1 = arrayOfNumbers[i];
                }
                else if (arrayOfNumbers[i] > bigNum2)
                {
                    bigNum2 = arrayOfNumbers[i];
                }

            }

            Console.WriteLine($"The sum of the two largest elements is: { bigNum1 + bigNum2}");
        }

        private void IsEvenWithInput()
        {
            Console.WriteLine("Please, enter a number:");
            int numberIsEven = int.Parse(Console.ReadLine());
            if (Helpers.IsEven(numberIsEven))
            {
                Console.WriteLine($"The number {numberIsEven} is even");
            }
            else
                Console.WriteLine($"The number {numberIsEven} is not even");
        }

        private void CompareSumWithMaxNumber()
        {
            Console.WriteLine("Enter the number of items:");

            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNum = 0;

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Enter a number for index {i}");
                int temp = int.Parse(Console.ReadLine());
                maxNum = Math.Max(temp, maxNum);
                sum += temp;
            }

            if (sum - maxNum == maxNum)
            {
                Console.WriteLine($"Yes - {maxNum}");
            }
        }
    }
}
