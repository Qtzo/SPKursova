using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        private void Print(List<List<int>> sud)
        {
            int n = sud.Count;
            if (n < 2 || Math.Sqrt(n) % 1 != 0) { Console.WriteLine("wrong data"); return; }
            double sqrt = Math.Sqrt(n);
            for (int i = 0; i < n; i++)
            {
                if ((i + 1) % sqrt == 1)
                    Console.WriteLine();
                Console.Write('[');
                for (int j = 0; j < n; j++)
                {
                    if ((j + 1) % sqrt == 1 && j != 0) Console.Write("   ");

                    Console.Write(sud[i][j]);
                    if (j != n - 1) Console.Write(", ");
                }
                Console.Write(']');
                Console.WriteLine();
            }
        }


        private bool Validate(List<List<int>> sud)
        {
            int n = sud.Count;
            if (n < 2 || Math.Sqrt(n) % 1 != 0) { Console.WriteLine("wrong data"); return false; }

            double sqrt = Math.Sqrt(n);

            for (int i = 0; i < n; i++)
            {
                for (int t = 0; t < n; t++)
                {
                    for (int j = t + 1; j < n; j++)
                    {
                        if (sud[i][t] == sud[i][j]) return false;
                    }
                    for (int j = i + 1; j < n; j++)
                    {
                        if (sud[i][t] == sud[j][t]) return false;
                    }
                    if (((t + 1) / sqrt) % 1 == 0 && i < sqrt)
                    {

                        for (int a = i * Convert.ToInt32(sqrt); a < i * Convert.ToInt32(sqrt) + sqrt - 1; a++)
                        {

                            for (int s = Convert.ToInt32((t + 1) - sqrt); s < t + 1; s++)
                            {


                                for (int d = a + 1; d < i * Convert.ToInt32(sqrt) + sqrt; d++)
                                {


                                    for (int j = Convert.ToInt32((t + 1) - sqrt); j < t + 1; j++)
                                    {
                                        if (sud[d][j] == sud[a][s]) return false;
                                    }


                                }
                            }
                        }





                    }
                }
            }

            return true;

        }

        static void Main(string[] args)
        {

        }
    }
}
