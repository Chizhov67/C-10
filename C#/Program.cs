namespace ConsoleAppGit
{
    internal class Program
    {
        public static string[] formArray(string[] array)
        {
            int count = 0;
            foreach (string element in array)
            {
                if (element.Length <= 3)
                {
                    count++;
                }

            }

            string[] newArray = new string[count];
            count = 0;

            for (int i = 0; i < array.Length;  i++)
            {
                if (array[i].Length <= 3)
                {
                    newArray[count++] = array[i];
                }
            }

            return newArray;
        }

        public static void printArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Строка №{i}: {array[i]}");
            }
        }


        static void Main(string[] args)
        {
            string[] initialArray = { "abc", "a123", "ab", "abjco", "aaaa", "ccc" };
            string[] newArray = formArray(initialArray);

            Console.WriteLine("Начальный массив:");
            printArray(initialArray);

            Console.WriteLine("\n\nСформированный массив:");
            printArray(newArray);
            Console.ReadLine();
        }
    }
}

