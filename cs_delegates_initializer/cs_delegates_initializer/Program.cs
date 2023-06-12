namespace cs_delegates_initializer
{
    internal class Program
    {
        static void InitArray(int[] arr, Func<int, int> func)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = func(i);
            }
        }
        static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[15];
            InitArray(arr1, (n) => new Random().Next(1, 101));
            foreach (var item in arr1)
                Console.Write(item + " ");
            Console.WriteLine();

            int[] arr2 = new int[10];
            InitArray(arr2, (n) => (int)Math.Pow(2, n + 1));
            foreach (var item in arr2)
                Console.Write(item + " ");
            Console.WriteLine();

            int[] arr3 = new int[20];
            InitArray(arr3, (n) => n * 3);
            foreach (var item in arr3)
                Console.Write(item + " ");
            Console.WriteLine();

            int[] arr4 = new int[10];
            InitArray(arr4, new(Fibonacci));
            foreach (var item in arr4)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}