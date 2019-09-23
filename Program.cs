/*
 * Name: Angela Robinson
 * Date: 9/22/2019
 * Class: CSC382 Data Structures and Algorithms
 * Assignment: Binary Search Tree
 * 
 * Description: 
 * This program is designed to test the library classes of ARBinarySearchTree
 * To evaluate this data structure, write your program to read from an array of unsorted integers. 
 * You could also read from a data file (with the filename passed as a command line parameter) and populates the data structure.
 * 
 * Rigorous testing is expected! Be sure to include tests for attempting to remove a node from an empty BST, 
 * attempting to insert a duplicate node, removing a node with no children, removing a node with one child, 
 * and removing a node with two children. Be sure to verify the BST organization and structure are correct.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using ARBinarySearchTree;

namespace BST_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diagnostic Stopwatch to use when I perform actions on the bst
            Stopwatch sw = new Stopwatch();

            //create random generated int arrays to test with
            int[] smallArray = new int[10];
            //int[] hundredArray = new int[100];
            //int[] thousandArray = new int[1000];
            //int[] tenThousandArray = new int[10000];
            int[] hundredThousandArray = new int[100000];
            var random = new Random();
            //add random numbers into the arrays
            for (int i = 0; i < hundredThousandArray.Length; i++)
            {
                
                int num = random.Next(100000);

                hundredThousandArray[i] = num;

                //if (i < 10000)
                //{
                //    tenThousandArray[i] = num;
                //}

                //if (i < 1000)
                //{
                //    thousandArray[i] = num;
                //}

                //if (i < 100)
                //{
                //    hundredArray[i] = num;
                //}

                //if (i < 10)
                //{
                //    smallArray[i] = num;
                //}
            }

            smallArray[0] = 40760;
            smallArray[1] = 24803;
            smallArray[2] = 6631;
            smallArray[3] = 83263;
            smallArray[4] = 13465;
            smallArray[5] = 82011;
            smallArray[6] = 27771;
            smallArray[7] = 47601;
            smallArray[8] = 73871;
            smallArray[9] = 83613;


            BST<int> myTree = new BST<int>();

            try
            {
                //try and remove a node on an empty tree
                myTree.Remove(3);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message + " \n" + ex.StackTrace);
            }
            

            try
            {
                //adding small array to tree
                Console.WriteLine("Adding to tree: ");
                foreach (var item in smallArray)
                {
                    Console.Write(item + " ");
                    myTree.Add(item);
                }

                BSTNode<int>[] preorder = new BSTNode<int>[myTree.Count];
                myTree.CopyTo(preorder, 0);

                Console.WriteLine();//readability
                Console.WriteLine();

                //show the tree as a preorder processing
                Console.WriteLine("My Tree processed as preorder: ");
                foreach(var item in preorder)
                {
                    Console.Write(item.Data + " ");                    
                }
                

            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message + " \n" + ex.StackTrace);
            }

            try
            {
                //show Minimum
                Console.WriteLine();//readability
                Console.WriteLine();
                var min = myTree.Minimum();
                Console.WriteLine("The minimum value in my tree is: " + min);

                //show Maximum
                Console.WriteLine();
                var max = myTree.Maximum();
                Console.WriteLine("The Maximum value in my tree is: " + max);

                //attempt to insert a duplicate
                Console.WriteLine();
                Console.WriteLine("Attempting to add duplicate value of 27771");
                myTree.Add(27771);
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);// + " \n" + ex.StackTrace);
            }

            try
            {
                Console.WriteLine();//readability

                //attempt to delete node without any children
                Console.WriteLine("attempt to delete node without any children: 27771");
                myTree.Remove(27771);


                BSTNode<int>[] preorder = new BSTNode<int>[myTree.Count];
                myTree.CopyTo(preorder, 0);

                Console.WriteLine();//readability
                

                //show the tree as a preorder processing
                Console.WriteLine("My Tree processed as preorder: ");
                foreach (var item in preorder)
                {
                    Console.Write(item.Data + " ");
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message + " " + ex.StackTrace);
            }

            try
            {
                Console.WriteLine();//readability

                //attempt to delete node without any children
                Console.WriteLine("attempt to delete node with 1 children: 82011");
                myTree.Remove(82011);


                BSTNode<int>[] preorder = new BSTNode<int>[myTree.Count];
                myTree.CopyTo(preorder, 0);

                Console.WriteLine();//readability

                //show the tree as a preorder processing
                Console.WriteLine("My Tree processed as preorder: ");
                foreach (var item in preorder)
                {
                    Console.Write(item.Data + " ");
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message + " " + ex.StackTrace);
            }

            try
            {
                Console.WriteLine();//readability

                //attempt to delete node without any children
                Console.WriteLine("attempt to delete node with 2 children: 83263");
                myTree.Remove(83263);


                BSTNode<int>[] preorder = new BSTNode<int>[myTree.Count];
                myTree.CopyTo(preorder, 0);

                Console.WriteLine();//readability

                //show the tree as a preorder processing
                Console.WriteLine("My Tree processed as preorder: ");
                foreach (var item in preorder)
                {
                    Console.Write(item.Data + " ");
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message + " " + ex.StackTrace);
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
