using System;
using System.Collections.Generic;

namespace GrafSzomszedsagiLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<string> teszt = new Graph<string>();
            
            teszt.AddNode("elso");
            teszt.AddNode("masodik");
            teszt.AddNode("harmadik");
            teszt.AddNode("negyedik");
            
            teszt.AddEdge("elso", "masodik");
            teszt.AddEdge("elso", "harmadik");
            teszt.AddEdge("elso", "negyedik");
            teszt.AddEdge("masodik", "harmadik");

            Console.WriteLine(teszt.HasEdge("elso", "masodik"));
            Console.WriteLine(teszt.HasEdge("harmadik", "negyedik"));

            List<string> tmp = teszt.Neighbors("elso");

            teszt.DFS("elso", Console.WriteLine);
            ;
        }
    }
}