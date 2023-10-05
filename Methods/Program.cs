namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            int[] arr = { 5, 10, 55, 325, 1 };
            Console.WriteLine(MinM(arr));

        }

        // TASK 1
        public static int MinM(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }
    }
}