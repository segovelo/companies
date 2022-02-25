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
    public partial class frmSearch : Form
    {
        public companiesForm frmCompanies;
        public AVLTree<Company> companyAVLTree;
        bool txtChanged;
        LinkedList<Company> companies = new LinkedList<Company>();

        public frmSearch(companiesForm Form1, AVLTree<Company> tree)
        {
            InitializeComponent();
            this.frmCompanies = Form1;
            this.companyAVLTree = tree;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int value = 0;
            int min = 0;
            int max = 0;
            bool validity = true;
            lblInvalid.Visible = false;
           
            if (searchListBox.Items.Count > 0) searchListBox.Items.Clear();
            if (Int32.TryParse(txtMin.Text, out value))
                min = value;
            else
            {
                validity = false;
                lblInvalid.Visible = true;
                lblInvalid.Location = new Point(155, 130);
            }
            if (Int32.TryParse(txtMax.Text, out value))
                max = value;
            else
            {
                validity = false;
                lblInvalid.Visible = true;
                lblInvalid.Location = new Point(330, 130);
            }
            if (max <= min)
            {
                validity = false;
                lblInvalid.Visible = true;
                lblInvalid.Location = new Point(330, 130);
            }

            if (validity)
            {
                companies = companyAVLTree.searchNetIncome(min, max);
                if (companies.Count != 0)
                {
                    foreach (Company company in companies)
                    {
                        searchListBox.Items.Add(company.Name);
                    }
                    searchListBox.SetSelected(0, true);
                    searchListBox.Focus();
                }
                else
                {
                    searchListBox.Items.Add((string)"Not");
                    searchListBox.Items.Add((string)"Found");
                    lblNetIncome.Text = "Net Income: ";
                }
            }

        } // End of void btnSearch(...

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCompanies.Show();
            this.Close();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            lblInvalid.Visible = false;
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            lblInvalid.Visible = false;
            txtChanged = true;
        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {
            lblInvalid.Visible = false;
            txtChanged = true;
        }

        private void searchListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(companies.Count>0)
             lblNetIncome.Text = "Net Income: " + companies.ElementAt(searchListBox.SelectedIndex).NetIncome;
        }
    }
}
