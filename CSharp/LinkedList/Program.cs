using LinkedList.Models;
using static System.Console;
    
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            NodeList LinkedList = new NodeList();
            LinkedList.AddFirst("E");
            LinkedList.AddFirst("B");
            LinkedList.AddFirst("C");
            LinkedList.AddFirst("D");
            LinkedList.AddLast("1");
            LinkedList.AddLast("2");
            LinkedList.AddLast("3");
            LinkedList.AddLast("4");
            //LinkedList.Remove("5");
           LinkedList.ReadAll();
            ReadKey();
        }
    }
}
