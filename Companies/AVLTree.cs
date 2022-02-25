using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Companies
{
    public class AVLTree<T> : BSTree<T> where T : Company
    {
        public new void insertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);
            else if (item.CompareTo(tree.Data)< 0)
                         insertItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);

            tree.BalanceFactor = height(tree.Left) -
                                 height(tree.Right);
           if(tree.BalanceFactor <= -2) rotateLeft(ref tree);
          if (tree.BalanceFactor >= 2) rotateRight(ref tree);
        }


        public void rotateLeft()
        {
            rotateLeft(ref this.root);
        }
        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right!=null && tree.Right.BalanceFactor > 0) // Double rotate
                  rotateRight(ref tree.Right);
            if (tree != null)
            {
                Node<T> newRoot = tree.Right;
                if (newRoot != null)
                {
                    tree.Right = newRoot.Left;
                    newRoot.Left = tree;
                    tree = newRoot;
                }
            }
        }
                    

        private void rotateRight(ref Node<T> tree)
        {
            if (tree.Left!=null && tree.Left.BalanceFactor < 0) // Double Rotate
                rotateLeft(ref tree.Left);
            if(tree!= null)
            {
                Node<T> newRoot = tree.Left;
                if (newRoot != null)
                {
                    tree.Left = newRoot.Right;
                    newRoot.Right = tree;
                    tree = newRoot;
                }
            }
        }


        public new void removeItem(T item) 
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
                            else if(tree.Left == null) tree = tree.Right;
                                    else
                                    {
                                      T newRoot = leastItem(tree.Right);
                                      tree.Data = newRoot;
                                      removeItem(ref tree.Right, newRoot);
                                    }
                } // End of else
                if (tree != null)
                {
                    tree.BalanceFactor = height(tree.Left) -
                     height(tree.Right);
                    if (tree.BalanceFactor <= -2) rotateLeft(ref tree);
                    if (tree.BalanceFactor >= 2) rotateRight(ref tree);
                }
            }
        } // End of RemoveItem()

        public void inOrder(ListBox listBox)
        {
            inOrder(this.Root, listBox);
        }

        private void inOrder(Node<T> tree, ListBox listBox)
        {
            if (tree != null)
            {
                inOrder(tree.Left, listBox);
                listBox.Items.Add(tree.Data.getName());
                inOrder(tree.Right, listBox);
            }
        }// End of public void inOrder(...)

        public void fillTradingPartners()
        {
            fillTradingPartners(this.Root);
        }
        private void fillTradingPartners(Node<T> tree)
        {
            if (tree != null)
            {
                fillTradingPartners(tree.Left);
                foreach (string buyer in tree.Data.Buyers)
                {
                    Company company = this.findItem(new Company(buyer));
                    if (company != null)
                    {
                        tree.Data.PotentialTrade += company.NetIncome;
                        company.addSeller(tree.Data.Name);
                        if (company.checkBuyer(tree.Data.Name))
                        {
                            company.Partners.AddLast(tree.Data.Name);
                            company.PotentialTrade += tree.Data.NetIncome;
                        }
                    }
                }
                fillTradingPartners(tree.Right);
            }
        }// End of fillTradingPartners()

        public void maxPotentialTrade(ref int biggestPotentialTrade, 
            ref string companyBiggestPotential)
        {
            maxPotentialTrade(this.Root, ref biggestPotentialTrade, 
                ref companyBiggestPotential);
        }
        private void maxPotentialTrade(Node<T> tree, ref int biggestPotentialTrade,
            ref string companyBiggestPotential)
        {
            if(tree != null)
            {
                maxPotentialTrade(tree.Left, ref biggestPotentialTrade,
                        ref companyBiggestPotential);
                if (biggestPotentialTrade < tree.Data.PotentialTrade)
                {
                    biggestPotentialTrade = tree.Data.PotentialTrade;
                    companyBiggestPotential = tree.Data.Name;
                }
                maxPotentialTrade(tree.Right, ref biggestPotentialTrade,
                         ref companyBiggestPotential);
            }
        } // End of void maxPotentialTrade(Node<T> tree...


        public Company findItem(Company item)
        {
            return findItem(item, this.root);
        }

        private  Company findItem(Company item, Node<T> tree)
        {
            if (tree == null) return default(T);
            else
            {
                if (item.CompareTo(tree.Data) < 0) return findItem(item, tree.Left);
                if (item.CompareTo(tree.Data) > 0) return findItem(item, tree.Right);
                return tree.Data;
            }
        } // End of T findNode(...) 
        
        public string[] companyNames()
        {
            string[] names = new string[this.Count()];
            int i = 0;
            companyNames(this.Root, ref names, ref i);
            return names;
        }
        private void companyNames(Node<T> tree, ref string[] names, ref int i)
        {
            if(tree != null)
            {
                companyNames(tree.Left, ref names, ref i);
                names[i++] = tree.Data.getName();
                companyNames(tree.Right, ref names, ref i);
            }          
        }

        public LinkedList<T> getCompanies()
        {
            LinkedList<T> companiesArray = new LinkedList<T>();
            return getCompanies(this.root, companiesArray);
        }
        private LinkedList<T> getCompanies(Node<T> tree, 
            LinkedList<T> companiesArray)
        {
            if (tree != null)
            {
                getCompanies(tree.Left, companiesArray);
                companiesArray.AddLast(tree.Data);
                getCompanies(tree.Right, companiesArray);
            }
            return companiesArray;
        }
        public void Clear()
        {
            Clear(this.root);
        }
        private void Clear(Node<T> tree)
        {
            if(tree != null)
            {
                Clear(tree.Right);
                this.removeItem(tree.Data);
                Clear(tree.Left);
            }
        }// end of private void clear()

        public LinkedList<T> searchNetIncome(int min, int max)
        {
            LinkedList<T> companies = new LinkedList<T>();
            searchNetIncome(this.Root, companies, min, max);
            return companies;
        }

        private void searchNetIncome(Node<T> tree, LinkedList<T> companies, 
               int min, int max)
        {
            if (tree != null)
            {
                searchNetIncome(tree.Left, companies, min, max);
                if(tree.Data.NetIncome>=min &&
                     tree.Data.NetIncome <= max)
                {
                    companies.AddLast(tree.Data);
                }
                searchNetIncome(tree.Right, companies, min, max);
            }
        }
    }
}
