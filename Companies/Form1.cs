using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Companies
{
    public partial class companiesForm : Form
    {
        frmNewCompany formNewComp;
        frmSearch formSearch;
        AVLTree<Company> companyAVLTree;
        Company companyWanted;
        AutoCompleteStringCollection autoCompleteNames;
        MainMenu companyFormMenu;
        MenuItem menuSave, menuNew, menuFind;
        int biggestPotentialTrade = 0;
        string companyBiggestPotential;
        bool txtBuyersChanged;
        bool txtSellersChanged;
        bool txtChanged;
        public void ShowCompForm()
        {           
                foreach (string buyer in formNewComp.company.Buyers)
                {
                    Company company = companyAVLTree.findItem(new Company(buyer));
                    if (company != null)
                    {
                        company.addSeller(formNewComp.company.Name);
                        company.addPartner(formNewComp.company.Name);
                        company.PotentialTrade += formNewComp.company.NetIncome;
                        formNewComp.company.PotentialTrade += company.NetIncome;
                    }
                }
                foreach (string seller in formNewComp.company.Sellers)
                {
                    Company company = companyAVLTree.findItem(new Company(seller));
                    if (company != null)
                    {
                        company.addBuyer(formNewComp.company.Name);
                        if (company.checkPartner(formNewComp.company.Name))
                        {
                            company.addPartner(formNewComp.company.Name);
                            company.PotentialTrade += formNewComp.company.NetIncome;
                            formNewComp.company.PotentialTrade += company.NetIncome;
                        }
                    }
                }
                companyAVLTree.insertItem(formNewComp.company);
                companiesListBox.Items.Clear();
                companyAVLTree.inOrder(companiesListBox);
                autoCompleteNames.Add(formNewComp.company.Name);
                this.Show();
                companiesListBox.SetSelected(companiesListBox.Items.IndexOf(formNewComp.company.Name), true);
                companiesListBox.Focus();
                biggestPotential();
                treeDetails();                     
        } // End of public void ShowCompForm()
        protected void ShowFormNewComp(){
            formNewComp = new frmNewCompany(this, companyAVLTree);
            formNewComp.Size = new System.Drawing.Size(600, 650);
            formNewComp.StartPosition = FormStartPosition.CenterScreen;
            formNewComp.Show();
        }
        protected void HideFormNewComp()
        {
            formNewComp.Hide();
        }
        // companiesForm construct, initialize component and load menus
        public companiesForm()
        {
            InitializeComponent();
            companyFormMenu = new MainMenu();
            MenuItem File = companyFormMenu.MenuItems.Add("&File");
            menuNew = new MenuItem("&New",
                new EventHandler(this.btnNew_Click), Shortcut.CtrlN);
            menuNew.Enabled = false;
            File.MenuItems.Add(menuNew);
            File.MenuItems.Add(new MenuItem("&Open",
                 new EventHandler(this.FileOpen_clicked), Shortcut.CtrlO));
            menuSave = new MenuItem("&Save", 
                 new EventHandler(this.FileSave_clicked), Shortcut.CtrlS);
            menuSave.Enabled = false;
            File.MenuItems.Add(menuSave);
            File.MenuItems.Add(new MenuItem("&Exit", 
                new EventHandler(this.Exit_clicked)));
            MenuItem Search = companyFormMenu.MenuItems.Add("&Search");
            menuFind = new MenuItem("&Find", new EventHandler(this.findNetIncome));
            menuFind.Enabled = false;
            Search.MenuItems.Add(menuFind);
            this.Menu = companyFormMenu;
        }
        // Method shows new search form and hide main application form
        public void findNetIncome(object sender, EventArgs e)
        {
            formSearch = new frmSearch(this, companyAVLTree);
            formSearch.Size = new System.Drawing.Size(550, 350);
            formSearch.StartPosition = FormStartPosition.CenterScreen;
            formSearch.Show();
            this.Hide();

            //return companies;
        }
        private void FileOpen_clicked(object sender, EventArgs e)
        {
            loadFile();
        }
        private void FileSave_clicked(object sender, EventArgs e)
        {
            saveFile();
        }
        // method activated when exit button clicked, shows a dialog box
        private void Exit_clicked(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Do you really want to close the application?","ALERT",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
           if (result == DialogResult.Yes)
                 this.Close();
        }
        //Load the form, set to disabled all the controls other than loadFile and exit buttons
        private void Form1_Load(object sender, EventArgs e)
        {
            lblInvalid.Visible = false;
            btnNew.Enabled = false;
            btnSave.Enabled = false;
            btnSaveFile.Enabled = false;
            btnRemove.Enabled = false;
            txtAssets.Enabled = false;
            txtNetIncome.Enabled = false;
            txtOpIncome.Enabled = false;
            txtEmployees.Enabled = false;
            txtBuyers.Enabled = false;
            txtSearch.Enabled = false;
            txtSellers.Enabled = false;
            txtPartners.Enabled = false;
        } // End of void Form1_Load(...)

         private void companiesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            controlsRefresh();
            
        }
        // Method activated when delete button clicked on, shows a dialog box
      private void btnRemove_Click(object sender, EventArgs e)
        {
            if (companiesListBox.Items.Count > 0)
            {
                string nameCompanyToRemove = companiesListBox.SelectedItem.ToString();//Get the name of company to delete
                //Shows dialog box asking for confirmation before delete company
                DialogResult result = MessageBox.Show("Do you really want to delete "+
                    nameCompanyToRemove+" company from application ?", 
                    "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {     // construct a company object only with name , no economic data at this stage            
                    Company companyToRemove = new Company(nameCompanyToRemove);
                    // Use the findItem() function to find the company, then put the full compmay object in company toRemove 
                    companyToRemove = companyAVLTree.findItem(companyToRemove);
                    autoCompleteNames.Remove(nameCompanyToRemove); // remove the name of company from autoCompleteNames object
                    int index = companiesListBox.SelectedIndex;
                    if (companiesListBox.Items.Count > 1)
                    {
                        foreach (string buyer in companyToRemove.Buyers)
                        {
                            Company company = companyAVLTree.findItem(new Company(buyer));
                            if (company != null)
                            {
                                company.Sellers.Remove(companyToRemove.Name);
                            }
                        }

                        foreach (string seller in companyToRemove.Sellers)
                        {
                            Company company = companyAVLTree.findItem(new Company(seller));
                            if (company != null)
                            {
                                company.Buyers.Remove(companyToRemove.Name);
                            }
                        }

                        foreach (string partner in companyToRemove.Partners)
                        {
                            Company company = companyAVLTree.findItem(new Company(partner));
                            if (company != null)
                            {
                                company.Partners.Remove(companyToRemove.Name);
                                company.PotentialTrade -= companyToRemove.NetIncome;
                            }
                        }

                        if (index > 0) companiesListBox.SetSelected(index - 1, true);
                        else companiesListBox.SetSelected(index + 1, true);
                    } // end of  if (companiesListBox.Items.Count > 1)
                    else
                    {
                        txtNetIncome.Text = string.Empty;
                        txtOpIncome.Text = string.Empty;
                        txtAssets.Text = string.Empty;
                        txtEmployees.Text = string.Empty;
                        txtBuyers.Text = string.Empty;
                        txtPartners.Text = string.Empty;
                        txtSearch.Text = string.Empty;
                        lblPotential.Text = "Potential for Trade:";
                        lblBiggestPotential.Text = "Biggest Potential for Trade:";
                    } // End of else
                    companyAVLTree.removeItem(companyToRemove); // Remove the the node holding companyToRemove from tree
                    companiesListBox.Items.RemoveAt(index); // Remove the company name from ListBox
                    treeDetails(); // Update tree details
                    biggestPotential();
                } // End of  if (result == DialogResult.Yes)
            } // End of   if (companiesListBox.Items.Count > 0)
        } // End of private void btnRemove_Click(object...
        
        // Method Edit/ save changes made manually to the company financial information 
        private void btnSave_Click(object sender, EventArgs e)
        {
            int value = 0;
            lblInvalid.Visible = false;
            bool validation = true;
            if (txtChanged)
            {
                if (Int32.TryParse(txtNetIncome.Text, out value)) // Validation, return false if input is not an integer
                    companyWanted.NetIncome = value;            
                else
                {
                    lblInvalid.Visible = true;  // It makes invalid entry label visible
                    lblInvalid.Location = new Point(291, 46); // Place the invalid entry label next to the text box
                    validation = false;
                }
                if (Int32.TryParse(txtOpIncome.Text, out value)) // Validation, return false if input is not an integer
                    companyWanted.OpIncome = value;               
                else
                {
                    lblInvalid.Visible = true;  // It makes invalid entry label visible
                    lblInvalid.Location = new Point(291, 100); // Place the invalid entry label next to the text box
                    validation = false;
                }
                if (Int32.TryParse(txtAssets.Text, out value)) // Validation, return false if input is not an integer
                    companyWanted.TotalAssets = value;
                else
                {
                    lblInvalid.Visible = true;  // It makes invalid entry label visible
                    lblInvalid.Location = new Point(291, 160); // Place the invalid entry label next to the text box
                    validation = false;
                }
                if (Int32.TryParse(txtEmployees.Text, out value))  // Validation, return false if input is not an integer       
                    companyWanted.NumEmployees = value;
                else
                {
                    lblInvalid.Visible = true;   // It makes invalid entry label visible
                    lblInvalid.Location = new Point(291, 220); // Place the invalid entry label next to the text box
                    validation = false;
                }
            } // end if (txtChanged)
            //This block of code checks wether the lis of buyers and sellers changed and
            //update the potential trade of all trading partners 
            if (txtBuyersChanged && validation)
            {
                string b = txtBuyers.Text.ToUpper() + " - ";              
                string[] buyers = b.Split('-',',',' ');
                bool deleted = true;
                foreach(string deletedBuyer in companyWanted.Buyers)
                { // With these nested foreach loops I find if a buyer was deleted from textBox
                    foreach (string newBuyer in buyers)
                    {
                        if (newBuyer==" " || deletedBuyer.CompareTo(newBuyer) == 0)
                        {
                            deleted = false;
                            goto BuyerFound;
                        }                  
                    }                   
                    if (deleted) // if a buyer was deleted update the sellers and 
                    {             //   partners  lists for that buyer company      
                        Company company = companyAVLTree.findItem(new Company(deletedBuyer));
                        if (company != null)
                        {
                            company.Sellers.Remove(companyWanted.Name);
                            if (company.checkBuyer(companyWanted.Name))
                            {
                                company.Partners.Remove(companyWanted.Name);
                                company.PotentialTrade -= companyWanted.NetIncome;
                            }
                        }
                    }
                    BuyerFound: deleted = true;
                }
                // the foreach bellow checks if a new buyer was added to the text box
                foreach (string newBuyer in buyers)
                {
                    if (companyWanted.checkBuyer(newBuyer))
                    {
                        Company company = companyAVLTree.findItem(new Company(newBuyer));
                        if (company != null &&
                              newBuyer.CompareTo(companyWanted.getName()) != 0)
                        {
                            company.addSeller(companyWanted.Name);
                            if (company.checkPartner(companyWanted.Name))
                            {
                                company.addPartner(companyWanted.Name);
                                company.PotentialTrade += companyWanted.NetIncome;
                            }
                        }
                    }
                } // end of foreach(string buyer...
                companyWanted.clearBuyers();
                companyWanted.clearPartners();
                companyWanted.PotentialTrade = 0;
                foreach (string buyer in buyers)
                {
                    Company company = companyAVLTree.findItem(new Company(buyer));
                    if (buyer.CompareTo(companyWanted.getName()) != 0 &&
                       companyWanted.checkBuyer(buyer) && company != null)
                    {
                        companyWanted.addBuyer(buyer);                                               
                        companyWanted.addPartner(buyer);
                        companyWanted.PotentialTrade += company.NetIncome;                      
                    }
                }  // end of foreach(string buyer...  
                foreach(string seller in companyWanted.Sellers)
                {
                    if (companyWanted.checkPartner(seller))
                    {
                        companyWanted.addPartner(seller);
                        companyWanted.PotentialTrade +=
                                companyAVLTree.findItem(new Company(seller)).NetIncome;
                    }
                }  // end of foreach(string seller...  
                txtBuyersChanged = false;
                txtSellers.Enabled = true;
            } // End of  if (txtBuyersChanged)

            if (txtSellersChanged && validation)
            {
                string str = txtSellers.Text.ToUpper()+" - ";
                string[] sellers = str.Split('-', ',',' ');
                bool deleted = true;
                foreach (string deletedSeller in companyWanted.Sellers)
                {
                    foreach (string newSeller in sellers)
                    {
                        if (newSeller == " " || deletedSeller.CompareTo(newSeller) == 0)
                        {
                            deleted = false;
                            goto SellerFound;
                        }
                    }
                    if (deleted)
                    {
                        Company company = companyAVLTree.findItem(new Company(deletedSeller));
                        company.Buyers.Remove(companyWanted.Name);
                        if (company.checkSeller(companyWanted.Name))
                        {
                            company.Partners.Remove(companyWanted.Name);
                            company.PotentialTrade -= companyWanted.NetIncome;
                        }
                    } // End of if (deleted)
                    SellerFound: deleted = true;
                } // End of foreach (string deletedSeller...

                foreach (string newSeller in sellers)
                {
                    if (companyWanted.checkSeller(newSeller))
                    {
                        Company company = companyAVLTree.findItem(new Company(newSeller));
                        if (company != null && company.checkBuyer(companyWanted.getName()) &&
                            newSeller.CompareTo(companyWanted.getName()) != 0)
                        {
                            company.addBuyer(companyWanted.Name);
                            if (company.checkPartner(companyWanted.Name))
                            {
                                company.PotentialTrade += companyWanted.NetIncome;
                                company.addPartner(companyWanted.Name);
                            }
                        }
                    }
                } // end of foreach(string newSeller...

                companyWanted.clearSellers();
                companyWanted.clearPartners();
                companyWanted.PotentialTrade = 0;
                foreach (string buyer in companyWanted.Buyers)
                {                                    
                    companyWanted.addPartner(buyer);
                    companyWanted.PotentialTrade +=
                                companyAVLTree.findItem(new Company(buyer)).NetIncome;
                    
                }  // end of foreach(string seller...

                foreach (string seller in sellers)
                {
                    Company company = companyAVLTree.findItem(new Company(seller));
                    if (seller.CompareTo(companyWanted.getName()) != 0 &&
                           companyWanted.checkSeller(seller) &&
                           company != null)
                    {
                        companyWanted.addSeller(seller);
                        if (companyWanted.checkPartner(seller))
                        {
                            companyWanted.addPartner(seller);
                            companyWanted.PotentialTrade += company.NetIncome;
                        }
                    }
                }  // end of foreach(string buyer...
                txtSellersChanged = false;
                txtBuyers.Enabled = true;
            }// End of  if (txtPartnersChanged)
            if (validation)
            {
                companyAVLTree.findNode(companyWanted).Data = companyWanted;
                biggestPotential();
                controlsRefresh();
            }
        } // End of   private void btnSave_Click(object...

        // Method to display number of companies and tree height
        public void treeDetails()
        {
            lblNunComp.Text = "Number of Companies " + companyAVLTree.Count().ToString();
            lblHeight.Text = "Height of tree " + companyAVLTree.height().ToString();
        }
        // Function to return the autocompletionCollection loaded with the name of companies
        public AutoCompleteStringCollection LoadCompanyNames(string[] names){
            foreach (string n in names)
                  autoCompleteNames.Add(n);
            return autoCompleteNames;
        }
        // Button method to exit application
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to close the application?", "ALERT",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                  this.Close();
        }
        // Method to search a company using its name and autocomplete features
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string name = txtSearch.Text.ToUpper();
            if (autoCompleteNames.Contains(name))
            {       
               if (companiesListBox.Items.Count > 0)
                {              
                    companyWanted = new Company(name);// construct a company object only with company name
                    companyWanted = companyAVLTree.findItem(companyWanted);
                    txtNetIncome.Text = companyWanted.NetIncome.ToString();
                    txtOpIncome.Text = companyWanted.OpIncome.ToString();
                    txtAssets.Text = companyWanted.TotalAssets.ToString();
                    txtEmployees.Text = companyWanted.NumEmployees.ToString();
                    lblPotential.Text = companyWanted.getName() + 
                        " - Potential for Trade: " + companyWanted.PotentialTrade;
                    string buyers = "";
                    int j = 0;
                    foreach (string buyer in companyWanted.Buyers)
                    {
                        buyers += buyer;
                        j++;
                        if (j < companyWanted.Buyers.Count)
                            buyers += " - ";
                    } // End of foreach(string
                    txtBuyers.Text = buyers;

                    string sellers = "";
                    j = 0;
                    foreach (string seller in companyWanted.Sellers)
                    {
                        sellers += seller;
                        j++;
                        if (j < companyWanted.Sellers.Count)
                            sellers += " - ";
                    } // End of foreach(string
                    txtSellers.Text = sellers;

                    string partners = "";
                    j = 0;
                    foreach (string partner in companyWanted.Partners)
                    {
                        partners += partner;
                        j++;
                        if (j < companyWanted.Partners.Count)
                            partners += " - ";
                    } // End of foreach(string
                    txtPartners.Text = partners;
                } // End of if (companiesListBox.Items.Count > 0)
                if(!btnRemove.Focused)
                    companiesListBox.SetSelected(
                        companiesListBox.Items.IndexOf(name), true);
            } // End of if (autoCompleteNames...)
        } // End of private void txtSearch_TextChanged(...

        // Method activated when text box search clicked on, delete the content 
        private void txtSearch_Click(object sender, EventArgs e)
        {
                txtSearch.Text = "";
        }
        // Method activated when text box Buyers content changed
        // set the boolean to true, disabled text box sellers to avoid conflict
        private void txtBuyers_TextChanged(object sender, EventArgs e)
        {
            txtBuyersChanged = true;
            if (txtBuyers.Focused) txtSellers.Enabled = false;
        }
        // Method activated when text box Sellers content changed
        // set the boolean to true, disabled text box buyers to avoid conflict
        private void txtSellers_TextChanged(object sender, EventArgs e)
        {
            txtSellersChanged = true;
            if (txtSellers.Focused) txtBuyers.Enabled = false;
        }
       private void txtPartners_TextChanged(object sender, EventArgs e)
        {
         }

        private void txtBuyers_OnClick(object sender, EventArgs e)
        {
          
        } 

        private void txtNetIncome_TextChanged(object sender, EventArgs e)
        {
            txtChanged = true;
        }

        private void txtOpIncome_TextChanged(object sender, EventArgs e)
        {
            txtChanged = true;
        }

        private void txtAssets_TextChanged(object sender, EventArgs e)
        {
            txtChanged = true;
        }

        private void txtEmployees_TextChanged(object sender, EventArgs e)
        {
            txtChanged = true;
        }

        private void lblPotential_Click(object sender, EventArgs e)
        {

        }
        // Method to refresh/update all controls after selection, insertion or removal of a company
        public void controlsRefresh()
        {
            txtBuyersChanged = false; // Set the booleans for changes in textBoxes to false
            txtChanged = false;
            txtSellersChanged = false; // Set the booleans for changes in textBoxes to false
            txtBuyers.Enabled = true;  // Set the text boxes to Enabled
            txtSellers.Enabled = true;
            lblInvalid.Visible = false; // Make invalid entry label invisible
            if (companiesListBox.Items.Count > 0)
            {
                string name = companiesListBox.SelectedItem.ToString();
                companyWanted = new Company(name); // Construct a company object only with company name, no economic data inside companyWanted     
                // Find the company object inside the tree and put it in companyWanted 
                companyWanted = companyAVLTree.findItem(companyWanted);
                txtNetIncome.Text = companyWanted.NetIncome.ToString(); // Feed the text Boxes with the data from the company object
                txtOpIncome.Text = companyWanted.OpIncome.ToString();  // Feed the text Boxes with the data from the company object
                txtAssets.Text = companyWanted.TotalAssets.ToString(); // Feed the text Boxes with the data from the company object
                txtEmployees.Text = companyWanted.NumEmployees.ToString(); // Feed the text Boxes with the data from the company object
                lblPotential.Text = companyWanted.getName() +  // Feed the label with company Potential for trade
                    " - Potential for Trade: " + companyWanted.PotentialTrade;
                string buyers = "";
                int j = 0; // Block of code to display buyers
                foreach (string buyer in companyWanted.Buyers)
                {
                    buyers += buyer;
                    j++;
                    if (j < companyWanted.Buyers.Count)
                        buyers += " - ";
                } // End of foreach(string
                txtBuyers.Text = buyers;  // Feed the text box buyers with a list of buyers of companyWanted

                string sellers = "";
                j = 0; // Block of code to display sellers
                foreach (string seller in companyWanted.Sellers)
                {
                    sellers += seller;
                    j++; 
                    if (j < companyWanted.Sellers.Count)
                        sellers += " - ";
                } // End of foreach(string
                txtSellers.Text = sellers; // Feed the text box sellers with a list of sellers of companyWanted

                string partners = "";
                j = 0; // Block of code to display partners
                foreach (string partner in companyWanted.Partners)
                {
                    partners += partner;
                    j++;
                    if (j < companyWanted.Partners.Count)
                        partners += " - ";
                } // End of foreach(string
                txtPartners.Text = partners; // Feed the text box partners with a list of partners of companyWanted
                if (!txtSearch.Focused)
                    txtSearch.Text = name;
            } // End of if (companiesListBox.Items.Count > 0)
        } // End of public void controlsRefresh()
        // Method activated when new company button clicked
        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowFormNewComp(); // Call method to show a frmNewCompany form
            this.Hide(); // Hide the main application form
        }
        //method activated when button save clicked, shows a dialog box to save the current file
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            saveFile();
        }  // End of private void btnSaveFile_Click(object ...
        //Method saveFile() 
        private void saveFile()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "cvs Files (*.csv)|*.csv|txt Files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFile.FilterIndex = 1;
            saveFile.RestoreDirectory = true;
            // saveFile.Title = "Save File";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                var companiesData = new StringBuilder();
                companiesData.AppendLine("Company,NET Income,Operating Income," +
                    "Total Assets,Number of Employees,Buyers");
                foreach (Company company in companyAVLTree.getCompanies())
                {
                    string name = company.Name;
                    string netIncome = company.NetIncome.ToString();
                    string opIncome = company.OpIncome.ToString();
                    string totalAssets = company.TotalAssets.ToString();
                    string numEmployees = company.NumEmployees.ToString();
                    string buyers = "[";
                    int i = 1;
                    foreach (string buyer in company.Buyers)
                    {
                        if (i < company.Buyers.Count)
                        {
                            buyers += buyer + ";";
                            i++;
                        }
                        else buyers += buyer + "]";
                    }
                    string newLine = $"{name},{netIncome},{opIncome}," +
                           $"{totalAssets},{numEmployees},{buyers}";
                    companiesData.AppendLine(newLine);
                } // End of foreach(Comp...
                File.WriteAllText(saveFile.FileName, companiesData.ToString());
            } // End of if(saveFile...
        } // End of private void saveFile()
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            loadFile();
        } // End of private void btnLoadFile_Click(object...

        private void loadFile()
        {
            string path = "Companies";
            OpenFileDialog loadFile = new OpenFileDialog();
            loadFile.Filter = "cvs Files (*.csv)|*.csv|txt Files (*.txt)|*.txt|All files (*.*)|*.*";
            loadFile.FilterIndex = 1;
            loadFile.RestoreDirectory = true;
            string dir = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\");
            loadFile.InitialDirectory = Path.GetFullPath(dir);
            if (loadFile.ShowDialog() == DialogResult.OK)
            {
                companyAVLTree = new AVLTree<Company>();
                autoCompleteNames = new AutoCompleteStringCollection();
                companiesListBox.Items.Clear();
                string[] headers = new string[6]; //column headers
                                                  // Block for loading companies.csv
                const int MAX_LINES_FILE = 50000;
                string[] AllLines = new string[MAX_LINES_FILE];
                //set a string variable with the location of the data file. Use ReadAllLines to read the data
                //string path = @"\companies.csv";
                path = loadFile.FileName.ToString();
                AllLines = File.ReadAllLines(path);
                foreach (string line in AllLines)
                {
                    if (line.StartsWith("Company")) //found first line - headers
                    {
                        headers = line.Split(',');
                    } // End of if(line.Start...
                    else
                    {
                        //split data using commas
                        string[] columns = line.Split(',');
                        columns[5] = columns[5].Substring(1);
                        // read the full set of buyers
                        string[] buyers = columns[5].Split(';', '[', ']');

                        Company aCompany = new Company(columns[0], int.Parse(columns[1]), int.Parse(columns[2]),
                                               int.Parse(columns[3]), int.Parse(columns[4]),
                                               new LinkedList<string>(buyers));
                        companyAVLTree.insertItem(aCompany);

                    }// End of else
                } // End of foreach(line....         
                  // Load company names on to List Box 
                companyAVLTree.inOrder(companiesListBox);

                // Find the trading Partners for each company
                companyAVLTree.fillTradingPartners();
                biggestPotential();
                txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = LoadCompanyNames(companyAVLTree.companyNames());
                treeDetails();
                companiesListBox.SetSelected(0, true);
                companiesListBox.Focus();
                this.Text = path;
                btnNew.Enabled = true;
                btnSave.Enabled = true;
                btnSaveFile.Enabled = true;
                btnRemove.Enabled = true;
                txtAssets.Enabled = true;
                txtNetIncome.Enabled = true;
                txtOpIncome.Enabled = true;
                txtEmployees.Enabled = true;
                txtBuyers.Enabled = true;
                txtSearch.Enabled = true;
                txtSellers.Enabled = true;
                txtPartners.Enabled = true;
                menuSave.Enabled = true;
                menuNew.Enabled = true;
                menuFind.Enabled = true;
            }
        }
        public void biggestPotential(){
            biggestPotentialTrade = 0;
            companyAVLTree.maxPotentialTrade(ref biggestPotentialTrade,
                        ref companyBiggestPotential);
            lblBiggestPotential.Text = "Biggest Potential for Trade: " +
                         companyBiggestPotential + " - " +
                         biggestPotentialTrade.ToString();
        }
    } // End of public partial class companiesForm : Form
} // End of namespace companies
