using System;
using System.Collections.Generic;

namespace GrafSzomszedsagiLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<Person> teszt = new Graph<Person>();

            var stew = new Person("Stew");
            Person marge = new Person("Marge");
            Person joseph = new Person("Joseph");
            Person gerald = new Person("Gerald");
            Person zack = new Person("Zack");
            Person peter = new Person("Peter");
            Person janet = new Person("Janet");
            
            teszt.AddNode(stew);
            teszt.AddNode(marge);
            teszt.AddNode(joseph);
            teszt.AddNode(gerald);
            teszt.AddNode(zack);
            teszt.AddNode(peter);
            teszt.AddNode(janet);
            
            teszt.AddEdge(peter, janet);
            teszt.AddEdge(zack, peter);
            teszt.AddEdge(gerald, zack);
            teszt.AddEdge(joseph, zack);
            teszt.AddEdge(joseph, gerald);
            teszt.AddEdge(marge, joseph);
            teszt.AddEdge(stew, joseph);
            teszt.AddEdge(stew, marge);

            ;
        }
    }
}