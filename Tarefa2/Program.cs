using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[6] { 3, 2, 1, 6, 0, 5 };
            Console.Write("Array de entrada: [");

            for (int i = 0; i < 6; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.Write("]");

            Console.WriteLine();

            int max = array.Max();
            Console.Write("raiz: " + max);

            Console.WriteLine();

            int radical = array.Max();

            List<int> leftList = new List<int>();
            List<int> rightList = new List<int>();

            bool toLeft = true;

            foreach (int item in array)
            {
                if (radical == item)
                {
                    toLeft = false;
                    continue;
                }

                if (toLeft)
                {
                    leftList.Add(item);
                }
                else
                {
                    rightList.Add(item);
                }               
            }

            int[] left = leftList.ToArray();
            int[] right = rightList.ToArray();

            Console.Write("Galhos da esquerda: ");
            Console.WriteLine("[{0}]", string.Join(", ", left));
            Console.Write("Galhos da direita: ");
            Console.WriteLine("[{0}]", string.Join(", ", right));

            Console.ReadKey();

        }
    }
}
