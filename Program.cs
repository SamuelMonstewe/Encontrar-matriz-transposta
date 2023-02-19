using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09Pag82
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Matriz = { {1,2,3,4,5}, 
                              {1,2,3,4,5},
                              {1,2,3,4,5}
                            };
            int[,] MatrizTransposta = new int[5, 3];
            string texto = "Matriz transposta: \n \n";

            for (int j = 0; j < Matriz.GetLength(1); j++) 
            {
                for (int i = 0 ; i < Matriz.GetLength(0); i++) 
                {
                    MatrizTransposta[j, i] = Matriz[i, j];
                    texto += MatrizTransposta[j, i] + "\t";
                }
                texto += "\n";
            }
            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}
