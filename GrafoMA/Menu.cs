using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoMA
{
    public class Menu
    {
        static public void MenuMatriz()
        {
            bool repete = true;
            int menu = -1, controleInt = 0, qtdVertice = 0, v1 = 0, v2 = 0;

            Console.WriteLine("Informe o número de vértices do grafo:");
            qtdVertice = int.Parse(Console.ReadLine());

            Grafo g = new Grafo(qtdVertice);
            Console.Clear();
            repete = true;

            while (repete)
            {
                do
                {
                    try
                    {
                        Console.WriteLine("\n______________________________________________________________________________________\n" +
                            "*** Grafo que utiliza a estrutura de dados Matriz de Adjacência ***\n\n" +
                            "\nEscolha uma opção no menu abaixo:\n" +
                            "1- Inserir aresta.\n" +
                            "2- Remover aresta.\n" +
                            "3- Imprimir Ordem do Grafo.\n" +
                            "4- Imprimir MA. \n"+
                            "5- Imprimir LA.\n" +
                            "6- Imprimir Sequencia de Graus.\n" +
                            "7- Imprimir vertices adjacentes.\n" +
                            "8- Verificar vértice isolado.\n" +
                            "9- Verificar se vértice é par.\n" +
                            "10- Verificar se vértice é impar.\n" +
                            "11- Verificar se dois vértices são adjacentes.\n" +
                            "12- Verificar se o Grafo é completo.\n" +
                            "13- Verificar se o Grafo é regular.\n\n" +
                            "DIGITE -1 PARA ENCERRAR. \n" +
                            "______________________________________________________________________________________");
                        menu = int.Parse(Console.ReadLine());
                        Console.Clear();
                        repete = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("ERRO NO VALOR DIGITADO.");
                        System.Threading.Thread.Sleep(1000); //Faz o programa esperar 3 segundos para o usuário ver a mensagem e depois continua                       
                        Console.Clear();
                    }
                } while (repete);
                repete = true;

                switch (menu)
                {
                    case 1:
                        do
                        {
                            try
                            {
                                Console.WriteLine("Digite o vértice [1]: ");
                                v1 = int.Parse(Console.ReadLine());
                                repete = false;
                            }
                            catch (FormatException)
                            {
                                Console.Clear();
                                Console.WriteLine("ERRO NO VALOR DIGITADO");
                            }
                        } while (repete);
                        repete = true;
                        do
                        {
                            try
                            {
                                Console.WriteLine("Digite o vértice [2]: ");
                                v2 = int.Parse(Console.ReadLine());
                                repete = false;
                            }
                            catch (FormatException)
                            {
                                Console.Clear();
                                Console.WriteLine("ERRO NO VALOR DIGITADO");
                            }
                        } while (repete);
                        repete = true;
                        if (g.InserirAresta(v1, v2))
                        {
                            Console.WriteLine("\nAresta adicionada com sucesso!\n");
                        }
                        else
                        {
                            Console.WriteLine("\nAresta NÃO adicionada!\n\n");
                        }
                        break;
                    case 2:
                        do
                        {
                            try
                            {
                                Console.WriteLine("Digite o vertice 1: ");
                                v1 = int.Parse(Console.ReadLine());
                                repete = false;
                            }
                            catch (FormatException)
                            {
                                Console.Clear();
                                Console.WriteLine("ERRO NO VALOR DIGITADO");
                            }
                        } while (repete);
                        repete = true;
                        do
                        {
                            try
                            {
                                Console.WriteLine("Digite o vertice 2: ");
                                v2 = int.Parse(Console.ReadLine());
                                repete = false;
                            }
                            catch (FormatException)
                            {
                                Console.Clear();
                                Console.WriteLine("ERRO NO VALOR DIGITADO");
                            }
                        } while (repete);
                        repete = true;
                        if (g.RemoverAresta(v1, v2))
                        {
                            Console.WriteLine("\nAresta removida com sucesso!\n\n");
                        }
                        else
                        {
                            Console.WriteLine("\nAresta NÃO removida.\n\n");
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nA ordem do grafo é: " + g.Ordem() + "\n\n");
                        break;
                    case 4:
                        g.ShowMA();
                        break;
                    case 5:
                        g.ShowLA();
                        break;
                    case 6:
                        g.SequenciaGraus();
                        break;
                    case 7:
                        do
                        {
                            try
                            {
                                Console.WriteLine("Digite o vértice que deseja verificar seus adjacentes: ");
                                controleInt = int.Parse(Console.ReadLine());
                                repete = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("ERRO NO VALOR DIGITADO.");
                            }
                        } while (repete);
                        repete = true;
                        Console.Clear();
                        g.VerticesAdjacentes(controleInt);
                        break;
                    case 8:
                        do
                        {
                            try
                            {
                                Console.WriteLine("Digite o vértice que deseja verificar se é Isolado: ");
                                controleInt = int.Parse(Console.ReadLine());
                                repete = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("ERRO NO VALOR DIGITADO.");
                            }
                        } while (repete);
                        repete = true;
                        Console.Clear();
                        try
                        {
                            if (g.Isolado(controleInt))
                            {
                                Console.WriteLine("\nVértice isolado.\n\n");
                            }
                            else
                            {
                                Console.WriteLine("\nVértice NÃO isolado.\n\n");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 9:
                        do
                        {
                            try
                            {
                                Console.WriteLine("Digite o vértice que deseja verificar se é Par: ");
                                controleInt = int.Parse(Console.ReadLine());
                                repete = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("ERRO NO VALOR DIGITADO.");
                            }
                        } while (repete);
                        repete = true;
                        Console.Clear();
                        try
                        {
                            if (g.Par(controleInt))
                            {
                                Console.WriteLine("\nVértice Par.\n\n");
                            }
                            else
                            {
                                Console.WriteLine("\nVértice NÃO Par.\n\n");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 10:
                        do
                        {
                            try
                            {
                                Console.WriteLine("Digite o vértice que deseja verificar se é Impar: ");
                                controleInt = int.Parse(Console.ReadLine());
                                repete = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("ERRO NO VALOR DIGITADO.");
                            }
                        } while (repete);
                        repete = true;
                        Console.Clear();
                        try
                        {
                            if (g.Impar(controleInt))
                            {
                                Console.WriteLine("\nVértice Impar.\n\n");
                            }
                            else
                            {
                                Console.WriteLine("\nVértice NÃO Impar.\n\n");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 11:
                        do
                        {
                            try
                            {
                                Console.WriteLine("Digite o vertice 1: ");
                                v1 = int.Parse(Console.ReadLine());
                                repete = false;
                            }
                            catch (FormatException)
                            {
                                Console.Clear();
                                Console.WriteLine("ERRO NO VALOR DIGITADO");
                            }
                        } while (repete);
                        repete = true;
                        do
                        {
                            try
                            {
                                Console.WriteLine("Digite o vertice 2: ");
                                v2 = int.Parse(Console.ReadLine());
                                repete = false;
                            }
                            catch (FormatException)
                            {
                                Console.Clear();
                                Console.WriteLine("ERRO NO VALOR DIGITADO");
                            }
                        } while (repete);
                        repete = true;
                        try
                        {
                            if (g.Adjacentes(v1, v2))
                            {
                                Console.WriteLine("\nVértices adjacentes.\n");
                            }
                            else
                            {
                                Console.WriteLine("\nVértices NÃO adjacentes.\n");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 12:
                        try
                        {
                            if (g.Completo())
                            {
                                Console.WriteLine("\nGRAFO COMPLETO.\n");
                            }
                            else
                            {
                                Console.WriteLine("\nGRAFO NÃO É COMPLETO.\n");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 13:
                        try
                        {
                            if (g.Regular())
                            {
                                Console.WriteLine("\nGRAFO É REGULAR.\n");
                            }
                            else
                            {
                                Console.WriteLine("\nGRAFO NÃO É REGULAR.\n");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case -1:
                        repete = false;
                        break;
                }
            }
        }
    }
}
