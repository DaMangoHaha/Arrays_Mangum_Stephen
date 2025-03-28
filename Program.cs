namespace Arrays_Mangum_Stephen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gets the total number of elements from the user. Example: 5(user typed 5) = 5 Numbers the user will need to input
            Console.Write("How many elements will you give to me today?: ");
            int numberElements = int.Parse(Console.ReadLine());

            // Initializes the array
            int[] arr = new int[numberElements];

            // ACTUALLY gets the elements from the user. Example: 3(user typed 3) = 3 (is stored into the console) 
            Console.WriteLine("Giv nambr:");
            for (int i = 0; i < numberElements; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Calculates the sum of all elements inputted by the user
            int totalSum = 0;
            foreach (int num in arr)
            {
                totalSum += num;
            }
            Console.WriteLine($"Here's the sum of your numbers: {totalSum}");

            // Sorts the array in ascending order, starting from lowest number to the highest number
            Array.Sort(arr);

            // Prints the sorted array
            Console.WriteLine("I sorted your values...you're welcome: " + string.Join(", ", arr));
        }
    }
}