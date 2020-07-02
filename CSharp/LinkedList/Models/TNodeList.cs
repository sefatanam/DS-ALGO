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
                node.prev = tail;
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
                head.prev = node;
                head = node;
                size++;
            }
        }
        public void Remove(T obj)
        {
            TNode<T> currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.data.Equals(obj))
                {
                    RemoveNode(currentNode);
                }
                currentNode = currentNode.next;
            }
        }

        private void RemoveNode(TNode<T> node)
        {
            if (node.prev == null)
            {
                head = node.next;
            }
            else
            {
                node.prev.next = node.next;
            }

            if (node.next == null)
            {
                tail = node.prev;
            }
            else
            {
                node.next.prev = node.prev;
            }
            size--;

        }

        public void RemoveLast()
        {
            if (tail != null)
            {
                RemoveNode(tail);
            }

        }

        public void RemoveFirst()
        {
            if (head != null)
            {
                RemoveNode(head);
            }
        }

        public void Update(T old, T now )
        {
            TNode<T> currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.data.Equals(old))
                {
                    currentNode.data=now;
                    break;
                }
                currentNode = currentNode.next;
            }
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
