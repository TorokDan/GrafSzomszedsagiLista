using System;
using System.Collections.Generic;

namespace GrafSzomszedsagiLista
{
    public class Graph<T>
    {
        private List<T> _nodes;
        private List<List<T>> _edges;

        public Graph()
        {
            _nodes = new List<T>();
            _edges = new List<List<T>>();
        }

        public delegate void ExternalProcessor(T item);
        public void AddNode(T node)
        {
            _nodes.Add(node);
            _edges.Add(new List<T>());
        }

        public void AddEdge(T from, T to)
        {
            _edges[_nodes.IndexOf(from)].Add(to);
            _edges[_nodes.IndexOf(to)].Add(from);
        }

        public bool HasEdge(T from, T to) => _edges[_nodes.IndexOf(from)].Contains(to);

        public List<T> Neighbors(T node) => _edges[_nodes.IndexOf(node)];

        /// <summary>
        /// Szélességi bejáráás
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void BFS(T from, ExternalProcessor _method)
        {
            ExternalProcessor method = _method;
            Queue<T> queue = new Queue<T>();
            List<T> list = new List<T>();

            queue.Enqueue(from);
            list.Add(from);

            while (queue.Count != 0)
            {
                T tmp = queue.Dequeue();
                method?.Invoke(tmp);

                foreach (var x in Neighbors(tmp))
                {
                    if (!list.Contains(x))
                    {
                        queue.Enqueue(x);
                        list.Add(x);
                    }
                }
            }
        }

        /// <summary>
        /// Mélységi bejárás
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void DFS(T from, ExternalProcessor _method)
        {
            List<T> list = new List<T>();
            DFSRec(from, list, _method);
        }

        private void DFSRec(T from, List<T> list, ExternalProcessor _method)
        {
            ExternalProcessor method = _method;
            list.Add(from);
            method?.Invoke(from);
            foreach (var item in _edges[_nodes.IndexOf(from)])
                if (!list.Contains(item))
                    DFSRec(item, list, method);
        }
    }
}