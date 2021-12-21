using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SberGamesT
{
    class Program
    {
        static void Main(string[] args)
        {
            //int?[,] matrix = {
            //    {0, 0, 0, 0, 0, 0 },
            //    {0, 0, 0, 0, 0, 0 },
            //    {0, 0, 0, 0, 0, 0 },
            //    {0, 0, 2, 3, 4, 0 },
            //    {0, 1, 3, 4, 1, 1 },
            //    {1, 3, 2, 1, 1, 4 }
            //};
            int?[,] matrix2 = {
                 {0, null , 0 },
                {0, 0, 0},
                {1, 2, 2 }
            };

            Match3 test = new Match3();
            bool result = test.IsMovePosible(matrix2);
            Console.WriteLine($"result of work: {result}");
        }
    }
}
