namespace Companies
{
    partial class frmNewCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewCompany));
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSellers = new System.Windows.Forms.Label();
            this.txtSellers = new System.Windows.Forms.TextBox();
            this.lblBuyers = new System.Windows.Forms.Label();
            this.lblNumEmpl = new System.Windows.Forms.Label();
            this.lblAssets = new System.Windows.Forms.Label();
            this.lblOpIncome = new System.Windows.Forms.Label();
            this.lblNetIncome = new System.Windows.Forms.Label();
            this.txtBuyers = new System.Windows.Forms.TextBox();
            this.txtEmployees = new System.Windows.Forms.TextBox();
            this.txtAssets = new System.Windows.Forms.TextBox();
            this.txtNetIncome = new System.Windows.Forms.TextBox();
            this.txtOpIncome = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.Location = new System.Drawing.Point(213, 503);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 36);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSellers
            // 
            this.lblSellers.AutoSize = true;
            this.lblSellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellers.ForeColor = System.Drawing.Color.Blue;
            this.lblSellers.Location = new System.Drawing.Point(223, 401);
            this.lblSellers.Name = "lblSellers";
            this.lblSellers.Size = new System.Drawing.Size(94, 16);
            this.lblSellers.TabIndex = 40;
            this.lblSellers.Text = "Buying From";
            // 
            // txtSellers
            // 
            this.txtSellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellers.Location = new System.Drawing.Point(226, 430);
            this.txtSellers.Margin = new System.Windows.Forms.Padding(2);
            this.txtSellers.Multiline = true;
            this.txtSellers.Name = "txtSellers";
            this.txtSellers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSellers.Size = new System.Drawing.Size(143, 48);
            this.txtSellers.TabIndex = 39;
            // 
            // lblBuyers
            // 
            this.lblBuyers.AutoSize = true;
            this.lblBuyers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyers.ForeColor = System.Drawing.Color.Blue;
            this.lblBuyers.Location = new System.Drawing.Point(223, 316);
            this.lblBuyers.Name = "lblBuyers";
            this.lblBuyers.Size = new System.Drawing.Size(56, 16);
            this.lblBuyers.TabIndex = 38;
            this.lblBuyers.Text = "Buyers";
            // 
            // lblNumEmpl
            // 
            this.lblNumEmpl.AutoSize = true;
            this.lblNumEmpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEmpl.ForeColor = System.Drawing.Color.Blue;
            this.lblNumEmpl.Location = new System.Drawing.Point(223, 254);
            this.lblNumEmpl.Name = "lblNumEmpl";
            this.lblNumEmpl.Size = new System.Drawing.Size(161, 16);
            this.lblNumEmpl.TabIndex = 37;
            this.lblNumEmpl.Text = "Number of Employees";
            // 
            // lblAssets
            // 
            this.lblAssets.AutoSize = true;
            this.lblAssets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssets.ForeColor = System.Drawing.Color.Blue;
            this.lblAssets.Location = new System.Drawing.Point(223, 202);
            this.lblAssets.Name = "lblAssets";
            this.lblAssets.Size = new System.Drawing.Size(95, 16);
            this.lblAssets.TabIndex = 36;
            this.lblAssets.Text = "Total Assets";
            // 
            // lblOpIncome
            // 
            this.lblOpIncome.AutoSize = true;
            this.lblOpIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpIncome.ForeColor = System.Drawing.Color.Blue;
            this.lblOpIncome.Location = new System.Drawing.Point(223, 142);
            this.lblOpIncome.Name = "lblOpIncome";
            this.lblOpIncome.Size = new System.Drawing.Size(143, 16);
            this.lblOpIncome.TabIndex = 35;
            this.lblOpIncome.Text = "Operational Income";
            // 
            // lblNetIncome
            // 
            this.lblNetIncome.AutoSize = true;
            this.lblNetIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetIncome.ForeColor = System.Drawing.Color.Blue;
            this.lblNetIncome.Location = new System.Drawing.Point(223, 87);
            this.lblNetIncome.Name = "lblNetIncome";
            this.lblNetIncome.Size = new System.Drawing.Size(86, 16);
            this.lblNetIncome.TabIndex = 34;
            this.lblNetIncome.Text = "Net Income";
            // 
            // txtBuyers
            // 
            this.txtBuyers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyers.Location = new System.Drawing.Point(226, 343);
            this.txtBuyers.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuyers.Multiline = true;
            this.txtBuyers.Name = "txtBuyers";
            this.txtBuyers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBuyers.Size = new System.Drawing.Size(143, 45);
            this.txtBuyers.TabIndex = 33;
            // 
            // txtEmployees
            // 
            this.txtEmployees.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployees.Location = new System.Drawing.Point(226, 280);
            this.txtEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployees.Name = "txtEmployees";
            this.txtEmployees.Size = new System.Drawing.Size(143, 26);
            this.txtEmployees.TabIndex = 32;
            // 
            // txtAssets
            // 
            this.txtAssets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssets.Location = new System.Drawing.Point(226, 220);
            this.txtAssets.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssets.Name = "txtAssets";
            this.txtAssets.Size = new System.Drawing.Size(143, 26);
            this.txtAssets.TabIndex = 31;
            this.txtAssets.TextChanged += new System.EventHandler(this.txtAssets_TextChanged);
            // 
            // txtNetIncome
            // 
            this.txtNetIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetIncome.Location = new System.Drawing.Point(226, 105);
            this.txtNetIncome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNetIncome.Name = "txtNetIncome";
            this.txtNetIncome.Size = new System.Drawing.Size(143, 26);
            this.txtNetIncome.TabIndex = 30;
            this.txtNetIncome.TextChanged += new System.EventHandler(this.txtNetIncome_TextChanged);
            // 
            // txtOpIncome
            // 
            this.txtOpIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpIncome.Location = new System.Drawing.Point(226, 160);
            this.txtOpIncome.Margin = new System.Windows.Forms.Padding(2);
            this.txtOpIncome.Name = "txtOpIncome";
            this.txtOpIncome.Size = new System.Drawing.Size(143, 26);
            this.txtOpIncome.TabIndex = 29;
            this.txtOpIncome.TextChanged += new System.EventHandler(this.txtOpIncome_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(226, 45);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 26);
            this.txtName.TabIndex = 41;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Blue;
            this.lblName.Location = new System.Drawing.Point(223, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(118, 16);
            this.lblName.TabIndex = 42;
            this.lblName.Text = "Company Name";
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblInvalid.Location = new System.Drawing.Point(374, 51);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(93, 16);
            this.lblInvalid.TabIndex = 43;
            this.lblInvalid.Text = "Invalid Entry";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Blue;
            this.btnCancel.Location = new System.Drawing.Point(320, 503);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 36);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmNewCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 596);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSellers);
            this.Controls.Add(this.txtSellers);
            this.Controls.Add(this.lblBuyers);
            this.Controls.Add(this.lblNumEmpl);
            this.Controls.Add(this.lblAssets);
            this.Controls.Add(this.lblOpIncome);
            this.Controls.Add(this.lblNetIncome);
            this.Controls.Add(this.txtBuyers);
            this.Controls.Add(this.txtEmployees);
            this.Controls.Add(this.txtAssets);
            this.Controls.Add(this.txtNetIncome);
            this.Controls.Add(this.txtOpIncome);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewCompany";
            this.Text = "New Company";
            this.Load += new System.EventHandler(this.frmNewCompany_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSellers;
        private System.Windows.Forms.TextBox txtSellers;
        private System.Windows.Forms.Label lblBuyers;
        private System.Windows.Forms.Label lblNumEmpl;
        private System.Windows.Forms.Label lblAssets;
        private System.Windows.Forms.Label lblOpIncome;
        private System.Windows.Forms.Label lblNetIncome;
        private System.Windows.Forms.TextBox txtBuyers;
        private System.Windows.Forms.TextBox txtEmployees;
        private System.Windows.Forms.TextBox txtAssets;
        private System.Windows.Forms.TextBox txtNetIncome;
        private System.Windows.Forms.TextBox txtOpIncome;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInvalid;
        private System.Windows.Forms.Button btnCancel;
    }
}