namespace Arrays_Mangum_Stephen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gets the number of elements from the user, whatever they may be
            Console.Write("Enter the number of elements: ");
            int numberElements = int.Parse(Console.ReadLine());

            // Initialize the array
            int[] arr = new int[numberElements];

            // ACTUALLY gets the elements from the user
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < numberElements; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Calculates the sum of all elements
            int totalSum = 0;
            foreach (int num in arr)
            {
                totalSum += num;
            }
            Console.WriteLine($"Sum of all elements: {totalSum}");

            // Sorts the array in ascending order
            Array.Sort(arr);

            // Prints the sorted array
            Console.WriteLine("Sorted array: " + string.Join(", ", arr));
        }
    }
}