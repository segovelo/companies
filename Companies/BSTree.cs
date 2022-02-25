using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies
{
   public class BSTree<T> : BinTree<T> where T: IComparable<T>
    {

        //root declared as protected in Parent Class – Binary Tree
        public BSTree()
        {
            root = null;
        }

        public void insertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);
            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
        }

        public int height()
        //Return the max level of the tree
        {
            return height(root);
        }

        public int height(Node<T> tree)
        {
            if (tree == null) return 0;
            else return 1 + max(height(tree.Left), height(tree.Right));
            //else return 0;
        }

        public int max(int Left, int Right)
        {
            if (Left > Right) return Left;
            else return Right;
        }

        public int Count()
        //Return the number of nodes in the tree
        {
            return Count(root);
        }

        private int Count(Node<T> tree)
        {
            if (tree == null) return 0;
            else
                return 1 + Count(tree.Left) + Count(tree.Right);

        }

        public Boolean Contains(T item, ref int counter)
        //Return true if the item is contained in the BSTree, false 	  //otherwise.
        {
            return Contains(item, root, ref counter);
        }

        private Boolean Contains(T item, Node<T> tree, ref int counter)
        {
            if (tree == null) return false;
            else
            {
                counter++;
                if (item.CompareTo(tree.Data) < 0) return Contains(item, tree.Left, ref counter);
                if (item.CompareTo(tree.Data) > 0) return Contains(item, tree.Right, ref counter);
                return true;
            }
        }

        public void removeItem(T item) //covered in lecture 16
        {
            removeItem(ref root, item);
        }

        private void removeItem(ref Node<T> tree, T item)
        {
            if (tree != null)
            {
                if (item.CompareTo(tree.Data) < 0) removeItem(ref tree.Left, item);
                else if (item.CompareTo(tree.Data) > 0) removeItem(ref tree.Right, item);
                else
                {
                    if (tree.Left == null && tree.Right == null) tree = null;
                    else if (tree.Right == null) tree = tree.Left;
                    else if (tree.Left == null) tree = tree.Right;
                    else
                    {
                        T newRoot = leastItem(tree.Right);
                        tree.Data = newRoot;
                        removeItem(ref tree.Right, newRoot);
                    }
                } // End of else
            }
        } // End of RemoveItem()

        public T leastItem(Node<T> tree)
        {
            if (tree.Left == null) return tree.Data;
            else return leastItem(tree.Left);
        }

        public void CopyTo(ref BSTree<T> tree2)
        {  //copies the nodes of this BSTree object into tree2 maintaining the same structure and order.
            CopyTo(this.root, ref tree2);
        }

        private void CopyTo(Node<T> tree, ref BSTree<T> tree2)
        {
            if (tree != null)
            {
                tree2.insertItem(tree.Data);
                CopyTo(tree.Left, ref tree2);
                CopyTo(tree.Right, ref tree2);
            }
        }

        public bool Equals(BSTree<T> tree)
        {   //returns true if this BSTree object contains the all same data as
            //tree with the same structure and ordering of data.
            return Equals(this.root, tree.root);
        }

        private bool Equals(Node<T> tree, Node<T> tree2)
        {
            if (tree != null && tree2 != null)
            {
                if (!(tree.Data.Equals(tree2.Data))) return false;
                Equals(tree.Left, tree2.Left);
                Equals(tree.Right, tree2.Right);
            }
            if (Count(tree) == Count(tree2)) return true;
                  else return false;
        }

        public bool SubTree(BSTree<T> tree)
        { //returns true if this BSTree object contains the subtree tree. 
          //A subtree of a tree T is a tree consisting of a node in T and all
          // of its descendants in T
            if (this.findNode(tree.root.Data) != null)
            {
                Console.WriteLine("\n\n\n\t The sub-Tree Root is  " + this.findNode(tree.root.Data).Data);
                return SubTree(this.findNode(tree.root.Data), tree.root);
            }
            else
            {
                Console.WriteLine("\n\n\n\t The item " + tree.root.Data + " NOT found in tree!!!");
                return false;
            }
        } // End of bool SubTree(BSTree<T> tree)

        private bool SubTree(Node<T> tree, Node<T> tree2)
        {
            return Equals(tree, tree2);
        }


        public Node<T> findNode(T item)
        {
            return findNode(item, this.root);
        }

        private  Node<T> findNode(T item, Node<T> tree)
        {
            if (tree == null)  return null;          
            else
            {
                if (item.CompareTo(tree.Data) < 0) return findNode(item, tree.Left);
                if (item.CompareTo(tree.Data) > 0) return findNode(item, tree.Right);
                 return tree;
            }
        } // End of Node<T> findNode(...)

        public T findItem(T item)
        {
            return findItem(item, this.root);
        }

        private T findItem(T item, Node<T> tree)
        {
            if (tree == null) return default(T);
            else
            {
                if (item.CompareTo(tree.Data) < 0) return findItem(item, tree.Left);
                if (item.CompareTo(tree.Data) > 0) return findItem(item, tree.Right);
                return tree.Data;
            }
        } // End of T findItem(...)


        public bool SubTree2(BSTree<T> tree)
        {        
            String buffer = "";
            String buffer2 = "";
            this.inOrder(ref buffer);
            tree.inOrder(ref buffer2);
            return buffer.Contains(buffer2);
        }
    }
}

