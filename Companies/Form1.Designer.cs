namespace Companies
{
    partial class companiesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(companiesForm));
            this.txtOpIncome = new System.Windows.Forms.TextBox();
            this.txtNetIncome = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.companiesListBox = new System.Windows.Forms.ListBox();
            this.txtAssets = new System.Windows.Forms.TextBox();
            this.txtEmployees = new System.Windows.Forms.TextBox();
            this.txtBuyers = new System.Windows.Forms.TextBox();
            this.lblNetIncome = new System.Windows.Forms.Label();
            this.lblOpIncome = new System.Windows.Forms.Label();
            this.lblAssets = new System.Windows.Forms.Label();
            this.lblNumEmpl = new System.Windows.Forms.Label();
            this.lblBuyers = new System.Windows.Forms.Label();
            this.lblNunComp = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtPartners = new System.Windows.Forms.TextBox();
            this.lblPartners = new System.Windows.Forms.Label();
            this.lblPotential = new System.Windows.Forms.Label();
            this.lblBiggestPotential = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.txtSellers = new System.Windows.Forms.TextBox();
            this.lblSellers = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOpIncome
            // 
            this.txtOpIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpIncome.Location = new System.Drawing.Point(182, 94);
            this.txtOpIncome.Margin = new System.Windows.Forms.Padding(2);
            this.txtOpIncome.Name = "txtOpIncome";
            this.txtOpIncome.Size = new System.Drawing.Size(104, 26);
            this.txtOpIncome.TabIndex = 0;
            this.txtOpIncome.TextChanged += new System.EventHandler(this.txtOpIncome_TextChanged);
            // 
            // txtNetIncome
            // 
            this.txtNetIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetIncome.Location = new System.Drawing.Point(182, 40);
            this.txtNetIncome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNetIncome.Name = "txtNetIncome";
            this.txtNetIncome.Size = new System.Drawing.Size(104, 26);
            this.txtNetIncome.TabIndex = 1;
            this.txtNetIncome.TextChanged += new System.EventHandler(this.txtNetIncome_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.Location = new System.Drawing.Point(387, 40);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 25);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Blue;
            this.btnRemove.Location = new System.Drawing.Point(387, 94);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(74, 27);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // companiesListBox
            // 
            this.companiesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companiesListBox.FormattingEnabled = true;
            this.companiesListBox.ItemHeight = 20;
            this.companiesListBox.Location = new System.Drawing.Point(25, 41);
            this.companiesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.companiesListBox.Name = "companiesListBox";
            this.companiesListBox.Size = new System.Drawing.Size(112, 444);
            this.companiesListBox.TabIndex = 4;
            this.companiesListBox.SelectedIndexChanged += new System.EventHandler(this.companiesListBox_SelectedIndexChanged);
            // 
            // txtAssets
            // 
            this.txtAssets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssets.Location = new System.Drawing.Point(182, 154);
            this.txtAssets.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssets.Name = "txtAssets";
            this.txtAssets.Size = new System.Drawing.Size(104, 26);
            this.txtAssets.TabIndex = 5;
            this.txtAssets.TextChanged += new System.EventHandler(this.txtAssets_TextChanged);
            // 
            // txtEmployees
            // 
            this.txtEmployees.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployees.Location = new System.Drawing.Point(182, 214);
            this.txtEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployees.Name = "txtEmployees";
            this.txtEmployees.Size = new System.Drawing.Size(104, 26);
            this.txtEmployees.TabIndex = 6;
            this.txtEmployees.TextChanged += new System.EventHandler(this.txtEmployees_TextChanged);
            // 
            // txtBuyers
            // 
            this.txtBuyers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyers.Location = new System.Drawing.Point(182, 277);
            this.txtBuyers.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuyers.Multiline = true;
            this.txtBuyers.Name = "txtBuyers";
            this.txtBuyers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBuyers.Size = new System.Drawing.Size(143, 45);
            this.txtBuyers.TabIndex = 7;
            this.txtBuyers.TextChanged += new System.EventHandler(this.txtBuyers_TextChanged);
            // 
            // lblNetIncome
            // 
            this.lblNetIncome.AutoSize = true;
            this.lblNetIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetIncome.ForeColor = System.Drawing.Color.Blue;
            this.lblNetIncome.Location = new System.Drawing.Point(179, 21);
            this.lblNetIncome.Name = "lblNetIncome";
            this.lblNetIncome.Size = new System.Drawing.Size(86, 16);
            this.lblNetIncome.TabIndex = 8;
            this.lblNetIncome.Text = "Net Income";
            // 
            // lblOpIncome
            // 
            this.lblOpIncome.AutoSize = true;
            this.lblOpIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpIncome.ForeColor = System.Drawing.Color.Blue;
            this.lblOpIncome.Location = new System.Drawing.Point(179, 76);
            this.lblOpIncome.Name = "lblOpIncome";
            this.lblOpIncome.Size = new System.Drawing.Size(143, 16);
            this.lblOpIncome.TabIndex = 9;
            this.lblOpIncome.Text = "Operational Income";
            // 
            // lblAssets
            // 
            this.lblAssets.AutoSize = true;
            this.lblAssets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssets.ForeColor = System.Drawing.Color.Blue;
            this.lblAssets.Location = new System.Drawing.Point(179, 136);
            this.lblAssets.Name = "lblAssets";
            this.lblAssets.Size = new System.Drawing.Size(95, 16);
            this.lblAssets.TabIndex = 10;
            this.lblAssets.Text = "Total Assets";
            // 
            // lblNumEmpl
            // 
            this.lblNumEmpl.AutoSize = true;
            this.lblNumEmpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEmpl.ForeColor = System.Drawing.Color.Blue;
            this.lblNumEmpl.Location = new System.Drawing.Point(179, 188);
            this.lblNumEmpl.Name = "lblNumEmpl";
            this.lblNumEmpl.Size = new System.Drawing.Size(161, 16);
            this.lblNumEmpl.TabIndex = 11;
            this.lblNumEmpl.Text = "Number of Employees";
            // 
            // lblBuyers
            // 
            this.lblBuyers.AutoSize = true;
            this.lblBuyers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyers.ForeColor = System.Drawing.Color.Blue;
            this.lblBuyers.Location = new System.Drawing.Point(179, 250);
            this.lblBuyers.Name = "lblBuyers";
            this.lblBuyers.Size = new System.Drawing.Size(56, 16);
            this.lblBuyers.TabIndex = 12;
            this.lblBuyers.Text = "Buyers";
            // 
            // lblNunComp
            // 
            this.lblNunComp.AutoSize = true;
            this.lblNunComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNunComp.ForeColor = System.Drawing.Color.Blue;
            this.lblNunComp.Location = new System.Drawing.Point(21, 518);
            this.lblNunComp.Name = "lblNunComp";
            this.lblNunComp.Size = new System.Drawing.Size(201, 20);
            this.lblNunComp.TabIndex = 13;
            this.lblNunComp.Text = "Number of Companies:  ";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.ForeColor = System.Drawing.Color.Blue;
            this.lblHeight.Location = new System.Drawing.Point(21, 562);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(130, 20);
            this.lblHeight.TabIndex = 14;
            this.lblHeight.Text = "Height of tree: ";
            // 
            // txtPartners
            // 
            this.txtPartners.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartners.Location = new System.Drawing.Point(182, 362);
            this.txtPartners.Margin = new System.Windows.Forms.Padding(2);
            this.txtPartners.Multiline = true;
            this.txtPartners.Name = "txtPartners";
            this.txtPartners.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPartners.Size = new System.Drawing.Size(143, 81);
            this.txtPartners.TabIndex = 15;
            this.txtPartners.TextChanged += new System.EventHandler(this.txtPartners_TextChanged);
            // 
            // lblPartners
            // 
            this.lblPartners.AutoSize = true;
            this.lblPartners.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartners.ForeColor = System.Drawing.Color.Blue;
            this.lblPartners.Location = new System.Drawing.Point(179, 335);
            this.lblPartners.Name = "lblPartners";
            this.lblPartners.Size = new System.Drawing.Size(124, 16);
            this.lblPartners.TabIndex = 16;
            this.lblPartners.Text = "Trading Partners";
            // 
            // lblPotential
            // 
            this.lblPotential.AutoSize = true;
            this.lblPotential.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotential.ForeColor = System.Drawing.Color.Blue;
            this.lblPotential.Location = new System.Drawing.Point(352, 366);
            this.lblPotential.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPotential.Name = "lblPotential";
            this.lblPotential.Size = new System.Drawing.Size(159, 17);
            this.lblPotential.TabIndex = 17;
            this.lblPotential.Text = "Potential For Trade: ";
            this.lblPotential.Click += new System.EventHandler(this.lblPotential_Click);
            // 
            // lblBiggestPotential
            // 
            this.lblBiggestPotential.AutoSize = true;
            this.lblBiggestPotential.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiggestPotential.ForeColor = System.Drawing.Color.Blue;
            this.lblBiggestPotential.Location = new System.Drawing.Point(352, 396);
            this.lblBiggestPotential.Name = "lblBiggestPotential";
            this.lblBiggestPotential.Size = new System.Drawing.Size(198, 16);
            this.lblBiggestPotential.TabIndex = 18;
            this.lblBiggestPotential.Text = "Biggest Potential for Trade:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Blue;
            this.btnExit.Location = new System.Drawing.Point(424, 552);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 30);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(185, 470);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(140, 20);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblInvalid.Location = new System.Drawing.Point(608, 46);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(93, 16);
            this.lblInvalid.TabIndex = 23;
            this.lblInvalid.Text = "Invalid Entry";
            // 
            // txtSellers
            // 
            this.txtSellers.Location = new System.Drawing.Point(355, 279);
            this.txtSellers.Multiline = true;
            this.txtSellers.Name = "txtSellers";
            this.txtSellers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSellers.Size = new System.Drawing.Size(138, 43);
            this.txtSellers.TabIndex = 25;
            this.txtSellers.TextChanged += new System.EventHandler(this.txtSellers_TextChanged);
            // 
            // lblSellers
            // 
            this.lblSellers.AutoSize = true;
            this.lblSellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellers.ForeColor = System.Drawing.Color.Blue;
            this.lblSellers.Location = new System.Drawing.Point(352, 250);
            this.lblSellers.Name = "lblSellers";
            this.lblSellers.Size = new System.Drawing.Size(57, 16);
            this.lblSellers.TabIndex = 26;
            this.lblSellers.Text = "Sellers";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Blue;
            this.btnNew.Location = new System.Drawing.Point(424, 470);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(69, 30);
            this.btnNew.TabIndex = 27;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFile.ForeColor = System.Drawing.Color.Blue;
            this.btnSaveFile.Location = new System.Drawing.Point(424, 508);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(69, 30);
            this.btnSaveFile.TabIndex = 28;
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFile.ForeColor = System.Drawing.Color.Blue;
            this.btnLoadFile.Location = new System.Drawing.Point(526, 508);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(69, 30);
            this.btnLoadFile.TabIndex = 29;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Blue;
            this.lblSearch.Location = new System.Drawing.Point(182, 451);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(57, 16);
            this.lblSearch.TabIndex = 30;
            this.lblSearch.Text = "Search";
            // 
            // companiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblSellers);
            this.Controls.Add(this.txtSellers);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblBiggestPotential);
            this.Controls.Add(this.lblPotential);
            this.Controls.Add(this.lblPartners);
            this.Controls.Add(this.txtPartners);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblNunComp);
            this.Controls.Add(this.lblBuyers);
            this.Controls.Add(this.lblNumEmpl);
            this.Controls.Add(this.lblAssets);
            this.Controls.Add(this.lblOpIncome);
            this.Controls.Add(this.lblNetIncome);
            this.Controls.Add(this.txtBuyers);
            this.Controls.Add(this.txtEmployees);
            this.Controls.Add(this.txtAssets);
            this.Controls.Add(this.companiesListBox);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNetIncome);
            this.Controls.Add(this.txtOpIncome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "companiesForm";
            this.Text = "Companies";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOpIncome;
        private System.Windows.Forms.TextBox txtNetIncome;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox companiesListBox;
        private System.Windows.Forms.TextBox txtAssets;
        private System.Windows.Forms.TextBox txtEmployees;
        private System.Windows.Forms.TextBox txtBuyers;
        private System.Windows.Forms.Label lblNetIncome;
        private System.Windows.Forms.Label lblOpIncome;
        private System.Windows.Forms.Label lblAssets;
        private System.Windows.Forms.Label lblNumEmpl;
        private System.Windows.Forms.Label lblBuyers;
        private System.Windows.Forms.Label lblNunComp;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtPartners;
        private System.Windows.Forms.Label lblPartners;
        private System.Windows.Forms.Label lblPotential;
        private System.Windows.Forms.Label lblBiggestPotential;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblInvalid;
        private System.Windows.Forms.TextBox txtSellers;
        private System.Windows.Forms.Label lblSellers;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Label lblSearch;
    }
}

