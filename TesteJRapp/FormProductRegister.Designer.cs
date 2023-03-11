namespace TesteJRapp
{
    partial class FormProductRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.btnChangeProduct = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Product registration";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(40, 102);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 20);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Product Name:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(152, 97);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(365, 25);
            this.txtProductName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Unit price:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Enabled = false;
            this.txtProductDescription.Location = new System.Drawing.Point(153, 142);
            this.txtProductDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(365, 106);
            this.txtProductDescription.TabIndex = 16;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Location = new System.Drawing.Point(443, 59);
            this.btnNewProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(76, 28);
            this.btnNewProduct.TabIndex = 19;
            this.btnNewProduct.Text = "New";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnChangeProduct
            // 
            this.btnChangeProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnChangeProduct.Enabled = false;
            this.btnChangeProduct.Location = new System.Drawing.Point(360, 354);
            this.btnChangeProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangeProduct.Name = "btnChangeProduct";
            this.btnChangeProduct.Size = new System.Drawing.Size(74, 28);
            this.btnChangeProduct.TabIndex = 20;
            this.btnChangeProduct.Text = "Change";
            this.btnChangeProduct.UseVisualStyleBackColor = true;
            this.btnChangeProduct.Click += new System.EventHandler(this.btnChangeProduct_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Enabled = false;
            this.btnSaveProduct.Location = new System.Drawing.Point(442, 354);
            this.btnSaveProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(75, 28);
            this.btnSaveProduct.TabIndex = 21;
            this.btnSaveProduct.Text = "Save";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Enabled = false;
            this.btnDeleteProduct.Location = new System.Drawing.Point(445, 392);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(74, 28);
            this.btnDeleteProduct.TabIndex = 22;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(442, 264);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Enabled = false;
            this.txtProductPrice.Location = new System.Drawing.Point(152, 263);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(105, 25);
            this.txtProductPrice.TabIndex = 24;
            this.txtProductPrice.TextChanged += new System.EventHandler(this.txtProductPrice_TextChanged);
            this.txtProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductPrice_KeyPress);
            this.txtProductPrice.Leave += new System.EventHandler(this.txtProductPrice_Leave);
            this.txtProductPrice.MouseEnter += new System.EventHandler(this.txtProductPrice_MouseEnter);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(564, 85);
            this.Grid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(408, 335);
            this.Grid.TabIndex = 25;
            this.Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Search:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Enabled = false;
            this.txtProductSearch.Location = new System.Drawing.Point(622, 59);
            this.txtProductSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(215, 25);
            this.txtProductSearch.TabIndex = 27;
            this.txtProductSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(837, 59);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 26);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Go";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormProductRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 501);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtProductSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.btnChangeProduct);
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormProductRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormProductRegister";
            this.Load += new System.EventHandler(this.FormProductRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Button btnChangeProduct;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}