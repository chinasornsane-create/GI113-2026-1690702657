namespace lab08/*
 * Student ID :1690702657
 * Name       :chinasorn saneewong na authaya
 * Section    :129C
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */
{ }
internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 12, 7, 30, 4, 19, 25, 9, 18 };
        int sum;
        float average;
        int maximum;
        int minimum;
        void Start()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Number " + (i + 1) + ": " + numbers[i]);
            }
        }
        sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        System.Array.Sort(numbers);
        foreach (int n in numbers)
        {
            Console.WriteLine("Sorted: " + n);
        }
        average = (float)sum / numbers.Length;
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);
        maximum = numbers[0];
        minimum = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maximum)
            {
                maximum = numbers[i];
            }
            if (numbers[i] < minimum)
            {
                minimum = numbers[i];
            }
        }
        Console.WriteLine("Maximum: " + maximum);
        Console.WriteLine("Minimum: " + minimum);



    }
}