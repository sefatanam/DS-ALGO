using System;

namespace BinarySearchTree
{
    public class TreeNode
    {
        
        //property to store the nodes Data could be a key and object pair
        public int Data { get; set; }
        public TreeNode RightNode { get; set; } //Right Child
        public TreeNode LeftNode { get; set; } //left Child
        public bool IsDeleted { get; set; } //soft delete variable


        //Node constructor
        public TreeNode (int value)
        {
            Data = value;
        }

        //Method to set soft delete
        public void Delete ()
        {
            IsDeleted = true;
        }

        public TreeNode Find (int value)
        {
            //this node is the starting current node
            TreeNode currentNode = this;

            //loop through this node and all of the children of this node
            while (currentNode != null)
            {
                //if the current nodes Data is equal to the value passed in return it
                if (value == currentNode.Data && IsDeleted == false)//soft delete check
                {
                    return currentNode;
                }
                else if (value > currentNode.Data)//if the value passed in is greater than the current Data then go to the right child
                {
                    currentNode = currentNode.RightNode;
                }
                else//otherwise if the value is less than the current nodes Data the go to the left child node 
                {
                    currentNode = currentNode.LeftNode;
                }
            }
            //Node not found
            return null;
        }

        public TreeNode FindRecursive (int value)
        {
            //value passed in matches nodes Data return the node
            if (value == Data && IsDeleted == false)
            {
                return this;
            }
            else if (value < Data && LeftNode != null)//if the value passed in is less than the current Data then go to the left child
            {
                return LeftNode.FindRecursive(value);
            }
            else if (RightNode != null)//if its great then go to the right child node
            {
                return RightNode.FindRecursive(value);
            }
            else
            {
                return null;
            }
        }


        //recursively calls insert down the tree until it find an open spot
        public void Insert (int value)
        {
            //if the value passed in is greater or equal to the Data then insert to right node
            if (value >= Data)
            {   //if right child node is null create one
                if (RightNode == null)
                {
                    RightNode = new TreeNode(value);
                }
                else
                {//if right node is not null recursivly call insert on the right node
                    RightNode.Insert(value);
                }
            }
            else
            {//if the value passed in is less than the Data then insert to left node
                if (LeftNode == null)
                {//if the LeftNode is null then create a new node
                    LeftNode = new TreeNode(value);
                }
                else
                {//if the left node is not null then recursively call insert on the left node
                    LeftNode.Insert(value);
                }
            }
        }

        public Nullable<int> SmallestValue ()
        {
            // once we reach the last left node we return its Data
            if (LeftNode == null)
            {
                return Data;
            }
            else
            {//otherwise keep calling the next left node
                return LeftNode.SmallestValue();
            }
        }

        internal Nullable<int> LargestValue ()
        {   // once we reach the last right node we return its Data
            if (RightNode == null)
            {
                return Data;
            }
            else
            {//otherwise keep calling the next right node
                return RightNode.LargestValue();
            }
        }

        //Number return in ascending order
        //Left->Root->Right Nodes recursively of each subtree 
        public void InOrderTraversal ()
        {
            //first go to left child its children will be null so we print its Data
            if (LeftNode != null)
                LeftNode.InOrderTraversal();
            //Then we print the root node 
            Console.Write(Data + " ");

            //Then we go to the right node which will print itself as both its children are null
            if (RightNode != null)
                RightNode.InOrderTraversal();
        }


        //Root->Left->Right Nodes recursively of each subtree 
        public void PreOrderTraversal ()
        {
            //First we print the root node 
            Console.Write(Data + " ");

            //Then go to left child its children will be null so we print its Data
            if (LeftNode != null)
                LeftNode.PreOrderTraversal();

            //Then we go to the right node which will print itself as both its children are null
            if (RightNode != null)
                RightNode.PreOrderTraversal();
        }

        //Left->Right->Root Nodes recursively of each subtree 
        public void PostorderTraversal ()
        {
            //First go to left child its children will be null so we print its Data
            if (LeftNode != null)
                LeftNode.PostorderTraversal();

            //Then we go to the right node which will print itself as both its children are null
            if (RightNode != null)
                RightNode.PostorderTraversal();

            //Then we print the root node 
            Console.Write(Data + " ");
        }


        public int Height ()
        {
            //return 1 when leaf node is found
            if (this.LeftNode == null && this.RightNode == null)
            {
                return 1; //found a leaf node
            }

            int left = 0;
            int right = 0;

            //recursively go through each branch
            if (this.LeftNode != null)
                left = this.LeftNode.Height();
            if (this.RightNode != null)
                right = this.RightNode.Height();

            //return the greater height of the branch
            if (left > right)
            {
                return (left + 1);
            }
            else
            {
                return (right + 1);
            }

        }

        public int NumberOfLeafNodes ()
        {
            //return 1 when leaf node is found
            if (this.LeftNode == null && this.RightNode == null)
            {
                return 1; //found a leaf node
            }

            int leftLeaves = 0;
            int rightLeaves = 0;

            //recursively call NumOfLeafNodes returning 1 for each leaf found
            if (this.LeftNode != null)
            {
                leftLeaves = LeftNode.NumberOfLeafNodes();
            }
            if (this.RightNode != null)
            {
                rightLeaves = RightNode.NumberOfLeafNodes();
            }

            //add values together 
            return leftLeaves + rightLeaves;
        }

        public bool IsBalanced ()
        {
            int LeftHeight = LeftNode != null ? LeftNode.Height() : 0;
            int RightHeight = RightNode != null ? RightNode.Height() : 0;

            int heightDifference = LeftHeight - RightHeight;

            if (Math.Abs(heightDifference) > 1)
            {
                return false;
            }
            else
            {
                return ((LeftNode != null ? LeftNode.IsBalanced() : true) && (RightNode != null ? RightNode.IsBalanced() : true));
            }
        }
    }
}
