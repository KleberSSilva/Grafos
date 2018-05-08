using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GrafoLA
{
    public class Grafo
    {
        private Dictionary<int, List<int>> LA;

        public Grafo()
        {
            LA = new Dictionary<int, List<int>>();
        }
        public int Ordem()
        {
            return LA.Count;
        }
        public bool inserirVertice(int vertice)
        {
            try
            {
                if (LA.Keys.Contains(vertice))
                {
                    Console.Write("Vértice já utilizado!");
                    return false;
                }
                else
                {
                    LA.Add(vertice, new List<int>());
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool RemoveVertice(int vertice)
        {
            try
            {
                if (LA.Keys.Contains(vertice))
                {
                    LA.Remove(vertice);
                    foreach (var item in LA)
                    {
                        if (item.Value.Contains(vertice))
                        {
                            item.Value.Remove(vertice);
                        }
                    }
                    return true;
                }
                else
                {
                    Console.Write("Vértice não existe!");
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool InserirAresta(int v1, int v2)
        {
            try
            {
                if (LA.Keys.Contains(v1))
                {
                    if (LA.Keys.Contains(v2))
                    {
                        LA[v1].Add(v2);
                        if (v2 != v1)
                        {
                            LA[v2].Add(v1);
                        }
                        return true;
                    }
                    else
                    {
                        throw new Exception("Vértice [v2] não encontrado!");
                    }
                }
                else
                {
                    throw new Exception("Vértice [v1] não encontrado!");
                }
            }
            catch (Exception Err)
            {
                Console.Write(Err.Message);
                return false;
            }
        }
        public bool RemoverAresta(int v1, int v2)
        {
            try
            {
                if(LA.Keys.Contains(v1))
                {
                    if(LA.Keys.Contains(v2) && LA[v1].Contains(v2))
                    {
                        LA[v1].Remove(v2);
                        LA[v2].Remove(v1);
                        return true;
                    }
                    else
                    {
                        throw new Exception("Aresta não encontrada!");
                    }
                }
                else
                {
                    throw new Exception("Vértice [v1] não encontrado!");
                }
            }
            catch (Exception err)
            {
                Console.Write(err.Message);
                return false;
            }
        }
        public int Grau(int vertice)
        {
            int grau=0;
            try
            {
                for (int i = 0; i < LA[vertice].Count; i++)
                {
                    grau++;
                }
                return grau;
            }
            catch (IndexOutOfRangeException)
            {
                return 0;
            }
        }
        public bool Completo()
        {
            if(LA.Count>0)
            {
                bool completo = true;
                foreach(var item in LA)
                {
                    if((LA.Count-1) != (item.Value.Count))
                    {
                        for (int j = 0; j < item.Value.Count; j++)
                        {
                            if (item.Key != item.Value[j])
                            {
                                completo = false;
                            }
                        }
                    }
                }
                return completo;
            }
            else
            {
                throw new Exception("Grafo não possui vértices.\n");
                //Console.Write("Grafo não possui vértices.\n");
            }
        }
        public bool Regular()
        {
            if (LA.Count > 0)
            {
                int count = 0;
                int[] grau = new int[LA.Count];
                grau.Initialize();
                foreach (var item in LA)
                {
                    for (int j = 0; j < item.Value.Count; j++)
                    {
                        grau[count]++;
                    }
                    count++;
                }
                int controle = grau[0];
                for (int i = 0; i < LA.Count; i++)
                {
                    if (controle != grau[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                throw new Exception("Grafo não possui vértices.\n");
            }
        }
        public void ShowLA()
        {      
            if (LA.Count == 0 || LA == null)
            {
                Console.WriteLine("Grafo NÃO possui vértices!\n");
            }
            else
            {
                foreach (var item in LA)
                {
                    bool unico;
                    unico = true;

                    Console.Write("[v" + (item.Key) + "]: ");
                    for (int j = 0; j < item.Value.Count; j++)
                    {
                        if (unico)
                        {
                            Console.Write(item.Value[j]);
                            unico = false;
                        }
                        else
                            Console.Write("," + item.Value[j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        public void SequenciaGraus()
        {
            int count = 0;
            int[] grau = new int[LA.Count];
            grau.Initialize();
            foreach (var item in LA)
            {
                for (int j = 0; j < item.Value.Count; j++)
                {
                    grau[count]++;
                }
                count++;
            }
            Array.Sort(grau);
            for (int i = 0; i < LA.Count; i++)
            {
                Console.Write(grau[i] + ", ");
            }
            Console.WriteLine("\n");
        }
        public void VerticesAdjacentes(int vertice)
        {
            int cont = 0;
            try
            {
                if (LA.Keys.Contains(vertice))
                {
                    for (int i = 0; i < LA[vertice].Count; i++)
                    {
                        Console.Write("[v" + (LA[vertice][i]) + "], ");
                        cont++;
                    }
                    Console.WriteLine("\n");
                    if (cont == 0)
                    {
                        Console.WriteLine("\nO vértice [v" + vertice + "] não possui vertices adjacentes!\n\n");
                    }
                }
                else
                {
                    throw new Exception("Vértice não encontrado!\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public bool Isolado(int vertice)
        {
            if (LA.Keys.Contains(vertice))
            {
                if (LA[vertice].Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new Exception("Vértice [" + vertice +"] não encontrado!\n");
            }
        }
        public bool Impar(int vertice)
        {
            if (LA.Keys.Contains(vertice))
            {
                if (LA[vertice].Count % 2 == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                throw new Exception("Vértice [" + vertice + "] não encontrado!\n");
            }
        }
        public bool Par(int vertice)
        {
            if (LA.Keys.Contains(vertice))
            {
                if (LA[vertice].Count % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new Exception("Vértice [" + vertice + "] não encontrado!\n");
            }
        }
        public bool Adjacentes(int v1, int v2)
        {
            if (LA.Keys.Contains(v1))
            {
                if (LA.Keys.Contains(v2))
                {
                    if (LA[v1].Contains(v2) || LA[v2].Contains(v1))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    throw new Exception("Vértice [v2] não encontrado.\n");
                }
            }
            else
            {
                throw new Exception("Vértice [v1] não encontrado.\n");
            }
        }
    }
}


