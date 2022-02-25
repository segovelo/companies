using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Companies
{
    public class Company : IComparable<Company>
    {
        private string name;
        private int netIncome;
        private int opIncome;
        private int totalAssets;
        private int numEmployees;
        private int potentialTrade;
        private LinkedList<string> buyers;
        private LinkedList<string> sellers;
        private LinkedList<string> partners;

        public Company(string name, int netIncome, int opIncome,
            int totalAssets, int numEmployees, LinkedList<string> buyers)
        {
            this.name = name;
            this.netIncome = netIncome;
            this.opIncome = opIncome;
            this.totalAssets = totalAssets;
            this.numEmployees = numEmployees;
            this.potentialTrade = 0;
            this.buyers = new LinkedList<string>();
            foreach(string buyer in buyers)
            {
               if (buyer != "" && buyer != " ") this.buyers.AddLast(buyer);
            }
            this.sellers = new LinkedList<string>();
            this.partners = new LinkedList<string>(this.buyers);
        }
        public Company(string name)
        {
            this.name = name;
            this.netIncome = 0;
            this.opIncome = 0;
            this.totalAssets = 0;
            this.numEmployees = 0;
            this.potentialTrade = 0;
            this.buyers = null;
            this.sellers = null;
            this.partners = null;
        }
        public Company()
        {
            this.name = null;
            this.netIncome = 0;
            this.opIncome = 0;
            this.totalAssets = 0;
            this.numEmployees = 0;
            this.potentialTrade = 0;
            this.buyers = null;
            this.sellers = null;
            this.partners = null;
        }

        public string Name // Property for Name
        {
            get { return name; }
            set { name = value; }
        }

        public int NetIncome // Property for Net Income
        {
            get { return netIncome; }
            set { netIncome = value; }
        }

        public int OpIncome // Property for Operating Income
        {
            get { return opIncome; }
            set { opIncome = value; }
        }

        public int TotalAssets // Property for Total Assets
        {
            get { return totalAssets; }
            set { totalAssets = value; }
        }
        public int NumEmployees // Property for Total Employees
        {
            get { return numEmployees; }
            set { numEmployees = value; }
        }
        public int PotentialTrade
        {
            get { return potentialTrade;}
            set { potentialTrade = value;}
        }

        public LinkedList<string> Buyers
        {
            get { return buyers; }
            set { buyers = value; }
        }
        public LinkedList<string> Sellers
        {
            get { return sellers; }
            set { sellers = value; }
        }
        public LinkedList<string> Partners
        {
            get { return partners;}
            set { partners = value;}
        }
        public string getPartners()
        {
            string s = "";
            foreach(string p in this.Partners)
            {
                s += p;
            }
            return s;
        }
        public string getName() { return name;}
        public override string ToString()
        {
            return this.Name;
        }
        public LinkedList<string> getBuyers() { return buyers;}
        public void addBuyer(string buyer) { this.buyers.AddLast(buyer); }
        public void clearBuyers() { this.buyers.Clear(); }
        public void addSeller(string seller) { this.Sellers.AddLast(seller); }
        public void clearSellers() { this.Sellers.Clear(); }
        public void addSellers(string[] str)
        {
            foreach(string s in str)
            {
                if(s!="" && s!=" " && s!= this.Name)this.addSeller(s);
            }
        }
        public void addPartner(string partner) { this.Partners.AddLast(partner);}
        public void clearPartners() { this.Partners.Clear();}
        public int CompareTo(Company aux)
        {
            //Company aux = (Company)other;
            return this.name.CompareTo(aux.name);
        }

        public bool checkBuyer(string seller)
        {
            if (this.Buyers.Count == 0) return true;
            foreach(string buyer in this.Buyers)
            {
                if (buyer.CompareTo(seller) == 0) return false;
            }
            return true;
        }
        public bool checkSeller(string seller)
        {
            if (this.Sellers.Count == 0) return true;
            foreach (string partner in this.Sellers)
            {
                if (partner.CompareTo(seller) == 0) return false;
            }
            return true;
        }

        public bool checkPartner(string seller)
        {
            if (this.Partners.Count == 0) return true;
            foreach (string partner in this.Partners)
            {
                if (partner.CompareTo(seller) == 0) return false;
            }
            return true;
        }

        public void remove(string s)
        {
            this.partners.Remove(s);
        }

        public string getData()
        {
            string details = "\n\tName: " + this.Name;
            details += "\n\tNet Income: " + this.NetIncome;
            details += "\n\tOp Income: " + this.OpIncome;
            details += "\n\tTotal Assets: " + this.TotalAssets;
            details += "\n\tNum of Employees: " + this.NumEmployees;
            details += "\n\tBuyers: ";
            if (Buyers.Count > 0)
            {
                details += "[";
                foreach (string buyer in Buyers)
                {
                    details += buyer;
                    if ((Buyers.Last.Value.ToString()).CompareTo(buyer) == 0) details += "]";
                    else details += "; ";
                }
            }
            details += "\n\tSellers: ";
            if (Sellers.Count > 0)
            {
                details += "[";
                foreach (string seller in Sellers)
                {
                    details += seller;
                    if ((Sellers.Last.Value.ToString()).CompareTo(seller) == 0) details += "]";
                    else details += "; ";
                }
            }
            return details;
        } // End of public string getData(...
    }
}
