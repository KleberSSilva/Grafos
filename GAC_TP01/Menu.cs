using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoLA
{
    public class Menu
    {
        static public void MenuLista()
        {
            bool repete = true;
            int menu = -1, controleInt = 0, v1 = 0, v2 = 0;

            Grafo g = new Grafo();

            Console.Clear();
            repete = true;
            while (repete)
            {
                do
                {
                    try
                    {
                        Console.WriteLine("\n______________________________________________________________________________________\n" +
                            "*** Grafo que utiliza a estrutura de dados Lista de Adjacência ***\n\n" +
                            "\nEscolha uma opção no menu abaixo:\n" +
                            "1- Inserir vertice\n" +
                            "2- Remover Vértice\n" +
                            "3- Inserir aresta.\n" +
                            "4- Remover aresta.\n" +
                            "5- Imprimir Ordem do Grafo.\n" +
                            "6- Imprimir LA.\n" +
                            "7- Imprimir Sequencia de Graus.\n" +
                            "8- Imprimir vertices adjacentes.\n" +
                            "9- Verificar vértice isolado.\n" +
                            "10- Verificar se vértice é par.\n" +
                            "11- Verificar se vértice é impar.\n" +
                            "12- Verificar se dois vértices são adjacentes.\n" +
                            "13- Verificar se o Grafo é completo.\n" +
                            "14- Verificar se o Grafo é regular.\n\n" +
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
                                Console.WriteLine("Digite o vertice: ");
                                v1 = int.Parse(Console.ReadLine());
                                repete = false;
                            }
                            catch (FormatException)
                            {
                                Console.Clear();
                                Console.WriteLine("ERRO NO VALOR DIGITADO");
                            }
                        } while (repete);
                        if (g.inserirVertice(v1))
                        {
                            Console.WriteLine("\nVértice adicionado com sucesso!\n\n");
                        }
                        else
                        {
                            Console.WriteLine("\nVértice NÃO adicionado.\n\n");
                        }
                        repete = true;
                        break;
                    case 2:
                        do
                        {
                            try
                            {
                                Console.WriteLine("Digite o vértice: ");
                                v1 = int.Parse(Console.ReadLine());
                                repete = false;
                            }
                            catch (FormatException)
                            {
                                Console.Clear();
                                Console.WriteLine("ERRO NO VALOR DIGITADO");
                            }
                        } while (repete);
                        if (g.RemoveVertice(v1))
                        {
                            Console.WriteLine("\nVértice removido com sucesso!\n\n");
                        }
                        else
                        {
                            Console.WriteLine("\nVertice NÃO removido.\n\n");
                        }
                        repete = true;
                        break;
                    case 3:
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
                    case 4:
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
                    case 5:
                        Console.WriteLine("\nA ordem do grafo é: " + g.Ordem() + "\n\n");
                        break;
                    case 6:
                        g.ShowLA();
                        break;
                    case 7:
                        g.SequenciaGraus();
                        break;
                    case 8:
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
                    case 9:
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
                    case 10:
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
                    case 11:
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
                    case 12:
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
                    case 13:
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

                    case 14:
                        try
                        {
                            if (g.Regular())
                            {
                                Console.WriteLine("\nGRAFO REGULAR.\n");
                            }
                            else
                            {
                                Console.WriteLine("\nGRAFO NÃO É REGULA.\n");
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
