using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrafoMA;
using GrafoLA;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            INICIO:
            int opcao = 0;

            Console.Title = "TP1 Grafos Autores: Kleber Silva e Fabricio Diniz";
            Console.WriteLine("\n______________________________________________________________________________________\n" +
                            "*** PROGRAMA PARA RESOLVER ALGORÍTMO EM GRAFOS ***\n\n");
            Console.WriteLine("Informe a opção desejada:\n");
            Console.WriteLine("1 - Matriz de Adjacência");
            Console.WriteLine("2 - Lista de Adjacência");
            Console.WriteLine("0 - Sair\n");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    GrafoMA.Menu.MenuMatriz();
                    goto INICIO;
                    break;
                case 2:
                    GrafoLA.Menu.MenuLista();
                    goto INICIO;
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
