using System;

namespace PatikaDevProje
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[9] { 7, 3, 5, 8, 2, 9, 4, 15, 6 };
            Console.WriteLine("\nOriginal Array Elements: ");
            PrintIntegerArray(numbers);
            Console.WriteLine("\nSorted Array Elements: ");
            PrintIntegerArray(InsertionSort(numbers));
            Console.WriteLine("\n");
        }
        static int[] InsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }
        public static void PrintIntegerArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i.ToString() + " ");
            }
        }
        public static int[] InsertionSortByShift(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int j;
                var insertionValue = inputArray[i];
                for (j = i; j > 0; j--)
                {
                    if (inputArray[j - 1] > insertionValue)
                    {
                        inputArray[j] = inputArray[j - 1];
                    }
                }
                inputArray[j] = insertionValue;
            }
            return inputArray;

        }
    }
}
