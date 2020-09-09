namespace LinkedList.Models
{
    //This class represent a node of a LinkedList
    public class Node
    {
        public object data = null;
        public Node next = null;
        public Node prev= null;

    }
    
    public class Node2
    {
        public int data ;
        public Node2 next ;
        public Node2 prev;

        public Node2(int val)
        {
            data = val;
        }
    }
}
