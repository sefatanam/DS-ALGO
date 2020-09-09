using LinkedList.Models;
using System.Collections.Generic;
using static System.Console;
    
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {



            TNodeList<object> LinkedList = new TNodeList<object>();
            LinkedList.AddFirst("E");
            LinkedList.AddFirst("B");
            LinkedList.AddFirst("C");
            LinkedList.AddFirst("D");

            var p = new Node2(15);
            var p2 = new Node2(115);

            Dictionary<Node2, Node2> Nodes = new Dictionary<Node2, Node2>();

            Nodes.Add(p, p2);

            var test1 = Nodes[p].prev;
            var test2 = Nodes[p].data;
            var test3 = Nodes[p].next;
            Nodes[p.next] = Nodes[p.next];


            //LinkedList.AddLast("1");
            //LinkedList.AddLast("2");
            //LinkedList.AddLast("3");
            //LinkedList.AddLast("4");
            //LinkedList.Update("4", "update");
            //LinkedList.Update("E", "Anam");
            //LinkedList.Update("D", "Sefat");
            LinkedList.ReadAll();
            ReadKey();
        }
    }
}
