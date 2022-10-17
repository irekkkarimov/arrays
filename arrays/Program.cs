using System;

class Program
{
    public static void Main()
    {
        Random random = new Random();
        int[] array = new int[random.Next(10, 20)];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next();
        }

        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if ((i != 0) && (i != (array.Length - 1)))
            {
                if ((array[i] > array[i - 1]) && (array[i] > array[i + 1]))
                {
                    counter++;
                }
                else
                {
                    continue;
                }
            }
            else if (((i == 0) && (array[i] > array[i + 1])) || ((i == (array.Length - 1)) && (array[i] > array[i - 1])))
            {
                counter++;
            }
        }

        Console.WriteLine(counter);
    }
}