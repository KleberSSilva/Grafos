using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoMA
{
    public class Grafo
    {
        private int[,] MA;
        private int qtVertices;

        public Grafo(int qtVertices)
        {
            this.qtVertices = qtVertices;
            MA = new int [qtVertices, qtVertices];

            for (int i = 0; i < qtVertices; i++)
                for (int j = 0; j < qtVertices; j++)
                    MA[i, j] = 0;
        }
    
        public int Ordem()
        {
            return qtVertices;
        }

        public bool InserirAresta(int v1, int v2)
        {
            if (v1 < qtVertices && v2 < qtVertices && v1 != v2)
            {
                MA[v1, v2] = 1;
                MA[v2, v1] = 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoverAresta(int v1, int v2)
        {
            if (v1 < qtVertices && v2 < qtVertices && v1 != v2)
            {
                MA[v1, v2] = 0;
                MA[v2, v1] = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Grau(int vertice)
        {
            int grau = 0;

            for (int i = 0; i < qtVertices; i++)
                grau += MA[vertice, i];

            return grau;
        }

        public bool Completo()
        {
            for (int i = 0; i < qtVertices; i++)
                if (Grau(i) != qtVertices - 1)
                    return false;

            return true;
        }

        public bool Regular()
        {
            int grau1, grau2;

            grau1 = Grau(0);

            for (int i = 0; i < qtVertices; i++)
            {
                grau2 = Grau(i);
                if (grau1 != grau2)
                    return false;
            }

            return true;
        }

        public void ShowMA()
        {
            for (int i = 0; i < qtVertices; i++)
            {
                if (i == 0)
                {
                    Console.Write("\t");
                    for (int j = 0; j < qtVertices; j++)
                        Console.Write("[" + j + "]\t");
                    Console.WriteLine();
                }

                for (int j = 0; j < qtVertices; j++)
                {
                    if (j == 0)
                        Console.Write("[" + i + "]\t");
                    Console.Write(MA[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void ShowLA()
        {
            for (int i = 0; i < qtVertices; i++)
            {
                bool unico;
                unico = true;
                Console.Write("[" + i + "]: ");
                for (int j = 0; j < qtVertices; j++)
                    if (MA[i, j] == 1)
                        if (unico)
                        {
                            Console.Write(j);
                            unico = false;
                        }
                        else
                            Console.Write("," + j);   
                Console.WriteLine();
            }
        }

        public void SequenciaGraus()
        {
            List<int> seqGrau = new List<int>();

            for (int i = 0; i < qtVertices; i++)
                seqGrau.Add(Grau(i));
            seqGrau.Sort();

            foreach (int item in seqGrau)
                Console.Write(item + "\t");
        }

        public void VerticesAdjacentes(int vertice)
        {
            if (vertice < qtVertices)
                for (int i = 0; i < qtVertices; i++)
                    if (MA[vertice, i] == 1)
                        Console.Write(i + "\t");
        }

        public bool Isolado(int vertice)
        {
            return Grau(vertice) == 0;
        }

        public bool Impar(int vertice)
        {
            return Grau(vertice) % 2 == 1;
        }

        public bool Par(int vertice)
        {
            return !Impar(vertice);
        }

        public bool Adjacentes(int v1, int v2)
        {
            return MA[v1, v2] == 1;
        }

    }
}
