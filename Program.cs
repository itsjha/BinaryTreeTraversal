                                                                                                                      using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace PopulateBinaryTree
{
    public class Node
    {
        public int value;
        public Node leftNode;
        public Node rightNode;
    }

    public class BinaryTree
    {
        public Node insert(Node root, int val)
        {
            if (root == null)
            {
                root = new Node();
                root.value = val;
            }
            else if (val < root.value)
            {
                root.leftNode = insert(root.leftNode, val);
            }
            else
            {
                root.rightNode = insert(root.rightNode, val);
            }
            return root;
        }


        public void traverseInOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            
            traverseInOrder(root.leftNode);
            Console.WriteLine(root.value);
            traverseInOrder(root.rightNode);
        }

        public void traversePreOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.value);
            traversePreOrder(root.leftNode);
            traversePreOrder(root.rightNode);
        }

        public void traversePostOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            traversePostOrder(root.leftNode);
            traversePostOrder(root.rightNode);
            Console.WriteLine(root.value);
        }
    }

   
    public class BinarySearchTree
        {
            static void Main(string[] args)
            {

                Node root = null;
                BinaryTree btr = new BinaryTree();
                root = btr.insert(root, 6);
                root = btr.insert(root, 2);
                root = btr.insert(root, 3);
                root = btr.insert(root, 11);
                root = btr.insert(root, 1);
                root = btr.insert(root, 30);
                root = btr.insert(root, 9);
                root = btr.insert(root, 13);
                root = btr.insert(root, 18);

                Console.WriteLine("InOrder Traversal : ");
                btr.traverseInOrder(root);
                Console.WriteLine("PreOrder Traversal : ");
                btr.traversePreOrder(root);
                Console.WriteLine("PostOrder Traversal : ");
                btr.traversePostOrder(root);
                
                Console.ReadKey();

            }
        }
  
    //    class BinarySearchTree
    //   {
    //    static void Main(string[] args)
    //    {
    //         Node root = null;
    //         BinaryTree bst = new BinaryTree(); 
    //         int SIZE = 2000000; 
    //         int[] a = new int[SIZE]; 
 
 
    //         Console.WriteLine("Generating random array with {0} values...", SIZE); 
 
 
    //         Random random = new Random(); 
 
    //         for (int i = 0; i < SIZE; i++) 
    //         { 
    //             a[i] = random.Next(10000); 
    //         } 
 
 
    //         Console.WriteLine("Filling the tree with {0} nodes...", SIZE); 
 
 
    //         for (int i = 0; i < SIZE; i++) 
    //         { 
    //             root = bst.insert(root, a[i]); 
    //         } 

    //         Console.ReadKey(); 

    //    }
    //}
}
