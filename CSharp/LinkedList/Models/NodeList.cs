using static System.Console;
namespace LinkedList.Models
{
    // this class contain logic to connect all node in our LinkedList Structure
    public class NodeList
    {
        //this is the head of our linkedList chain
        Node head = null;
        Node tail = null;
        public int size = 0;
        public void AddLast(object obj)
        {
            Node node = new Node();
            node.data = obj;

            //====> O(1) - kinds of performance
            // When nodelist is empty
            // Step 1: make a node
            // put head = node
            // and tail  = node
            if (head == null)
            {
                head = node;
                tail = node;
                size++;
            }
            else
            {
                // When a node exist in nodelist
                // current tails next = node
                // this tail = node

                tail.next = node;
                node.prev = tail;
                tail = node;
                size++;
            }

            // ========> O(n) senario with out "tail" implimentaion
            //if (head == null)
            //{
            //    head = node;
            //    head.next = null;
            //}
            //else
            //{
            //    Node currentNode = head;
            //    // loop and find the last node
            //    while (currentNode.next != null)
            //    {
            //        currentNode = currentNode.next;
            //    }
            //    // null this means last elements last node
            //    currentNode.next = node;
            //    node.next = null;
            //}
        }
        public void AddFirst(object obj)
        {

            Node node = new Node();
            node.data = obj;
            //====> O(1) - kinds of performance
            // When nodelist is empty
            // Step 1: make a node
            // put head = node
            // and tail  = node
            if (head == null)
            {
                head = node;
                tail = node;
                size++;
            }
            else
            {
                // When a node exist in nodelist
                // current heads next = node
                // this head = node

               

                node.next = head;
                head.prev = node ;

                head = node;
                size++;

                //    self.tail.next = node
                //node.prev = self.tail
                //self.tail = node
                //self.size += 1
            }

            // ==========> O(n) senario prespectiv without 'tail' implimentation
            //Node node = new Node();
            ////this now first node so current node becomes the next
            //node.data = obj;
            //node.next = head;
            //// new node becomes the head
            //head = node;
        }
        public void ReadAll()
        {
            Node currentNode = head;
            // loop until the last node
            while (currentNode.next != null)
            {
                WriteLine(currentNode.data);
                currentNode = currentNode.next; 
            }
            WriteLine(currentNode.data);
            WriteLine($"Length of Linked list : {size}");
        }
        private void RemoveNode(Node node)
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
        public void Remove(object obj)
        {
            Node currentNode = head;

            while (currentNode!=null)
            {
                if (currentNode.data == obj)
                {
                  RemoveNode(currentNode);
                }
                currentNode = currentNode.next;
            }


        }
    }

}


