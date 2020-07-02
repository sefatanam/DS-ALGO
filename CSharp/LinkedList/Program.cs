using LinkedList.Models;
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
            LinkedList.AddLast("1");
            LinkedList.AddLast("2");
            LinkedList.AddLast("3");
            LinkedList.AddLast("4");
            LinkedList.Update("4", "update");
            LinkedList.Update("E", "Anam");
            LinkedList.Update("D", "Sefat");
            LinkedList.ReadAll();
            ReadKey();
        }
    }
}
