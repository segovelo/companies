using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies
{
    public class Node<T> where T : IComparable<T>
    {
        protected T data;
        public  int balanceFactor = 0; //Added for AVLTree
        public Node<T> Left, Right;

        public Node(T item)
        {
            data = item;
            Left = null;
            Right = null;
        }

        public Node()
        {
            data = default(T);
            Left = null;
            Right = null;
        }
        public T Data
        {
            set { data = value; }
            get { return data; }
        }

        // Properties set and get to manipulate balanceFactor
        public int BalanceFactor
        {
            set { balanceFactor = value; }
            get { return balanceFactor; }
        }
    }
}
