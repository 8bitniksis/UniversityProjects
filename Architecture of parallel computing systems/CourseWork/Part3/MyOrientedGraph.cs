using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadLocks_App
{
    //===Класс, описывающий ориентированный граф
    class MyOrientedGraph
    {
        private readonly int Vertex;                                     //количество вершин
        private readonly List<List<int>> adjacency_list;                 //список смежности

        //===Конструктор класса
        public MyOrientedGraph(int Vertex)
        {
            this.Vertex = Vertex;
            adjacency_list = new List<List<int>>(Vertex);

            for (int i = 0; i < Vertex; i++)
                adjacency_list.Add(new List<int>());
        }

        //===Метод проверки существования циклов в графе
        public bool IsCyclExist(int i, bool[] visited,
                                  bool[] recStack)
        {
            // пометка текущего узла как посещенного
            // часть рекурсии
            if (recStack[i])
                return true;

            if (visited[i])
                return false;

            visited[i] = true;

            recStack[i] = true;
            List<int> children = adjacency_list[i];

            foreach (int c in children)
            {
                if (IsCyclExist(c, visited, recStack))
                {
                    Console.WriteLine(recStack[i]);
                    return true;
                }  
            }

            recStack[i] = false;

            return false;
        }

        //===Метод добавления очередного ребра в графе
        public void addEdge(int sou, int dest)
        {
            adjacency_list[sou].Add(dest);
        }

        //===Результирующий метод определения циклов в графе
        // Возвращает true если в графе есть циклы
        // или false в обратном случае
        public bool isCyclicResult()
        {
            // пометка всех вершин, как непосещенных
            // не является частью рекурсивного вызова
            bool[] visited = new bool[Vertex];
            bool[] recStack = new bool[Vertex];

            // Call the recursive helper function to
            // detect cycle in different DFS trees
            for (int i = 0; i < Vertex; i++)
            {
                if (IsCyclExist(i, visited, recStack))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
