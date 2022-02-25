using System;


namespace Companies
{
   public class BinTree<T> where T : IComparable<T> 
    {
        protected Node<T> root;
        public BinTree()  //creates an empty tree
        {
            root = null;
        }
        public BinTree(Node<T> node)  //creates a tree with node as the root
        {
            root = node;
        }

        public Node<T> Root
        {
            set { root = value; }
            get { return root; }
        }
        public void inOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }
        public string inOrder()
        {
            string buffer = "";
            inOrder(root, ref buffer);
            return buffer;
        }

        private void inOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString();
                inOrder(tree.Right, ref buffer);
            }
        }

        public void preOrder(ref string buffer)
        {
            preOrder(this.root, ref buffer);
        }

        private void preOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                buffer += tree.Data.ToString() + "; ";
                preOrder(tree.Left, ref buffer);
                preOrder(tree.Right, ref buffer);
            }
        }

        public void postOrder(ref string buffer)
        {
            postOrder(root, ref buffer);
        }

        private void postOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                postOrder(tree.Left, ref buffer);
                postOrder(tree.Right, ref buffer);
                buffer += tree.Data.ToString() + "; ";
            }

        }

        public void Copy(BinTree<T> tree2)
        {
            copy(ref this.root, tree2.root);
        }
           
        // Copy method using Pre-Order traversal technique
        private void copy(ref Node<T> root,  Node<T> root2)
        {
            if (root != null)
            {
                root.Data = root2.Data;
                copy(ref root.Left, root2.Left);
                copy(ref root.Right, root2.Right);
            }
        }

  
        public void Count(ref int i)
        {
            Count(this.root, ref i);
        }

        private void Count(Node<T> node, ref int i)
        {
            if (node != null)
            {
                i++;
                Count(node.Left, ref i);                
                Count(node.Right, ref i);
            }

        }
    }
}
