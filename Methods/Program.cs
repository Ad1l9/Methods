namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //int[] arr = { 5, 10, 55, 325, 1 };
            //Console.WriteLine(Minm(arr));

            //Task 2
            //float rad = float.Parse(Console.ReadLine());
            //Console.WriteLine($"Çevrənin sahəsi {Sahe(rad)}");

            //float width = float.Parse(Console.ReadLine());
            //float height = float.Parse(Console.ReadLine());
            //Console.WriteLine($"Düzbucaqlının sahəsi {Sahe(width,height)}");

            //float a = float.Parse(Console.ReadLine());
            //float b = float.Parse(Console.ReadLine());
            //float c = float.Parse(Console.ReadLine());
            //Console.WriteLine($"Düzbucaqlı paralelpipedin tam səthinin sahəsi {Sahe(a,b,c)}");

            float radius = float.Parse(Console.ReadLine());
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine($"Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi {Sahe(radius,a,b,c)}");
        }

        // TASK 1
        //public static int Minm(int[] arr)
        //{
        //    int min = arr[0];
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min)
        //            min = arr[i];
        //    }
        //    return min;
        //}


        // TASK 2
        public static float Sahe(float rad)
        {
            int p = 3;
            return p * (float)Math.Pow(rad, 2);
        }

        public static float Sahe(float a, float b)
        {
            return a * b;
        }

        public static float Sahe(float a, float b, float c)
        {
            return 2 * (a * b + b * c + a * c);
        }

        public static float Sahe(float rad, float a, float b, float c)
        {
            float s = ((a + b + c) / 2)*rad;

            return s;
        }


        //Task 3 Dərsdə yazılıb

    }
}