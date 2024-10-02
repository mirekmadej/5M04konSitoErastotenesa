namespace _5M04konSitoErastotenesa
{
    internal class Program
    {
        private const int N = 100;        
        static void Main(string[] args)
        {
            bool[] A = new bool[N + 1];
            for (int i = 2; i <= N; i++)
                A[i] = true;

            wypelnijTablice(A);

            Console.WriteLine("Liczby pierwsze:");
            for (int i = 2; i <= N; i++)
                if (A[i])
                    Console.Write($"{i}, ");

        }
        private static void wypelnijTablice(bool[] A)
        {
            for(int i = 2; i<= Math.Sqrt(N); i++)
            {
                if (A[i])
                    for(int j = 2*i; j <=N; j=j+i)
                        A[j] = false;
            }    
        }

    }
}
