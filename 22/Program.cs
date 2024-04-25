using System;
namespace del
{
    class Programm
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Введите число элементов массива");
            n = int.Parse(Console.ReadLine());
            int[] Data = new int[n];
            int i = 0;
            while (i < n)
            {
                Console.WriteLine("Введите элемент массива");
                Data[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
                i++;
            }
            int [] Arr = Div(Data);
            foreach (int it in Arr)
            {
                if (it == 0) break;
                Console.Write($"{it} ");
            }
        }
        static int[] Div(int[] x)   
        {
            int mmin = x[0];
            for( int i = 0 ; i < x.Length-1
                ; i++)
            {

                mmin = Math.Min(mmin, x[i+1]);
            }
            int fdv = 0;
            int[] Divin = new int[mmin];
            for (int ii = 2; ii <= mmin; ii++)
            {
                int c = 0;
                for (int jj = 0 ; jj < x.Length; jj++)
                {
                    if (x[jj] % ii != 0)
                    {
                        c++;
                        break;
                    }   
                }
                if (c++ == 0)
                {
                    Divin[fdv] = ii;
                    fdv++;
                }
            }
            return Divin;
        }
    }
}