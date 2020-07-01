using static System.Console;

namespace LinkedList.Models
{
    public class TNodeList<T>
    { 
        TNode<T> head = null;
        TNode<T> tail = null;
        public int size=0;
        public void AddLast(T obj)
        {
            TNode<T>node = new TNode<T>();
            node.data = obj;
            if (head == null)
            {
                head = node;
                tail = node;
                size++;
            }
            else
            {
                tail.next = node;
                tail = node;
                size++;
            }
        }
        public void AddFirst(T obj)
        {
            TNode<T> node = new TNode<T>();
            node.data = obj;
            if (head == null)
            {
                head = node;
                tail = node;
                size++;
            }
            else
            {
                node.next = head;
                head = node;
                size++;
            }
        }

        public void Remove(T obj)
        {

        }
        public void ReadAll()
        {
            TNode<T> currentTNode = head;
            while (currentTNode.next != null)
            {
                WriteLine(currentTNode.data);
                currentTNode = currentTNode.next;
            }
            WriteLine(currentTNode.data);
            WriteLine($"Total Size of this Linked List : {size}");
        }
    }
}
