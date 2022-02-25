using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Companies
{
    public partial class frmNewCompany : Form
    {
        public companiesForm frmCompanies;
        public Company company;
        public AVLTree<Company> companyAVLTree;       
        bool txtChanged;
        public frmNewCompany(companiesForm Form1, AVLTree<Company> tree)
        {
            InitializeComponent();
            this.frmCompanies = Form1;
            this.companyAVLTree = tree;
        }
        private void frmNewCompany_Load(object sender, EventArgs e)
        {
            lblInvalid.Visible = false;
            txtChanged = false;
            txtName.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int value, netIncome=0, opIncome=0, totalAssets=0, numEmployees=0;
            bool validation = true;
            if (companyAVLTree.findItem(new Company(txtName.Text.ToUpper()))!=null 
                        || txtName.Text == string.Empty) // Checks if the name of new company is already in use
                {                                        // or thge name is empty  
                    lblInvalid.Visible = true; // It makes invalid entry label visible
                    lblInvalid.Location = new Point(375, 50); // Place the invalid entry label next to the text box
                    validation = false;
                }
                else txtName.Text = txtName.Text.ToUpper();
                    
                if (Int32.TryParse(txtNetIncome.Text, out value)) // Validation, return false if input is not an integer
                netIncome = value;
                else
                {
                    lblInvalid.Visible = true;  // It makes invalid entry label visible
                    lblInvalid.Location = new Point(375, 110);// Place the invalid entry label next to the text box
                    validation = false;
                }
                if (Int32.TryParse(txtOpIncome.Text, out value)) // Validation, return false if input is not an integer
                opIncome = value;
                else
                {
                    lblInvalid.Visible = true; // It makes invalid entry label visible
                    lblInvalid.Location = new Point(375, 165);// Place the invalid entry label next to the text box
                    validation = false;
                }
                if (Int32.TryParse(txtAssets.Text, out value)) // Validation, return false if input is not an integer
                totalAssets = value;
                else
                {
                    lblInvalid.Visible = true;// It makes invalid entry label visible
                    lblInvalid.Location = new Point(375, 225);// Place the invalid entry label next to the text box
                    validation = false;
                }
                if (Int32.TryParse(txtEmployees.Text, out value)) // Validation, return false if input is not an integer
                numEmployees = value;
                else
                {
                    lblInvalid.Visible = true; // It makes invalid entry label visible
                    lblInvalid.Location = new Point(375, 285);// Place the invalid entry label next to the text box
                    validation = false;
                }

            if (validation) // if all the inputs are vaild check for the buyers and sellers and 
            {               // construct a company object to insert into AVLTree
                string str = txtBuyers.Text.ToUpper();
                string[] buyersArray = str.Split('-', ',', ' ');
                str = txtSellers.Text.ToUpper();
                string[] sellersArray = str.Split('-', ',', ' ');
                LinkedList<string> buyers = new LinkedList<string>();      
                foreach (string buyer in buyersArray)
                {
                    if (buyer != "" && // Check if the company buyer exist in AVLTree
                        companyAVLTree.findItem(new Company(buyer)) != null &&
                        buyer != txtName.Text && //Checks the buyer name does not match the company name
                        checkArray(buyers,buyer)) // check the buyer name does not repeat in the linked list
                                        buyers.AddLast(buyer);
                }
                company = new Company(txtName.Text, netIncome,
                    opIncome, totalAssets, numEmployees, buyers);
                foreach(string seller in sellersArray)
                {
                    if (seller != "" && // check if company seller exist in AVLTree
                    companyAVLTree.findItem(new Company(seller)) != null &&
                    seller != txtName.Text && //Checks the seller name does not match the company name
                    company.checkSeller(seller))
                        company.Sellers.AddLast(seller);
                }

                foreach (string seller in company.Sellers)
                {
                    if (company.checkPartner(seller))
                        company.addPartner(seller);
                }
                frmCompanies.ShowCompForm();
                this.Close();
            }
        } // End of private void btnSave_Click(object...

        private void txtNetIncome_TextChanged(object sender, EventArgs e)
        {
            txtChanged = true;
            lblInvalid.Visible = false;
        }

        private void txtOpIncome_TextChanged(object sender, EventArgs e)
        {
            txtChanged = true;
            lblInvalid.Visible = false;
        }

        private void txtAssets_TextChanged(object sender, EventArgs e)
        {
            txtChanged = true;
            lblInvalid.Visible = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtChanged = true;
            lblInvalid.Visible = false;
        }

      private void frmNewCompany_Load_1(object sender, EventArgs e)
        {
            lblInvalid.Visible = false;
            txtChanged = false;
            txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmCompanies.Show();
            this.Close();
        }
        public bool checkArray(LinkedList<string> array, string str )
        {
            foreach(string s in array)
            {
                if (str.CompareTo(s) == 0) return false;
            }
            return true;
        }
    }
}
