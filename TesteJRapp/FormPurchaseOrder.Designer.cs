namespace TesteJRapp
{
    partial class FormPurchaseOrder
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
            this.GridProductsOrder = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GridProductsSearch = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnShowProducts = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductAmount = new System.Windows.Forms.TextBox();
            this.btnIncludeProduct = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.txtTotalOrder = new System.Windows.Forms.TextBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.txtSearchProducts = new System.Windows.Forms.TextBox();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.txtClientLastName = new System.Windows.Forms.TextBox();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridProductsOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProductsSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 34);
            this.label1.TabIndex = 22;
            this.label1.Text = "Purchase order";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 533);
            this.lblName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 20);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Total:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // GridProductsOrder
            // 
            this.GridProductsOrder.AllowUserToAddRows = false;
            this.GridProductsOrder.AllowUserToDeleteRows = false;
            this.GridProductsOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProductsOrder.Location = new System.Drawing.Point(23, 340);
            this.GridProductsOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridProductsOrder.Name = "GridProductsOrder";
            this.GridProductsOrder.ReadOnly = true;
            this.GridProductsOrder.Size = new System.Drawing.Size(453, 186);
            this.GridProductsOrder.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Client:";
            // 
            // txtClientName
            // 
            this.txtClientName.Enabled = false;
            this.txtClientName.Location = new System.Drawing.Point(83, 146);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(192, 25);
            this.txtClientName.TabIndex = 28;
            this.txtClientName.TextChanged += new System.EventHandler(this.txtClientName_TextChanged);
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Location = new System.Drawing.Point(83, 220);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(50, 25);
            this.txtProductID.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Product:";
            // 
            // GridProductsSearch
            // 
            this.GridProductsSearch.AllowUserToAddRows = false;
            this.GridProductsSearch.AllowUserToDeleteRows = false;
            this.GridProductsSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProductsSearch.Location = new System.Drawing.Point(505, 252);
            this.GridProductsSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridProductsSearch.Name = "GridProductsSearch";
            this.GridProductsSearch.ReadOnly = true;
            this.GridProductsSearch.Size = new System.Drawing.Size(247, 274);
            this.GridProductsSearch.TabIndex = 32;
            this.GridProductsSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProductsSearch_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Select products";
            // 
            // btnShowProducts
            // 
            this.btnShowProducts.Location = new System.Drawing.Point(683, 222);
            this.btnShowProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowProducts.Name = "btnShowProducts";
            this.btnShowProducts.Size = new System.Drawing.Size(69, 27);
            this.btnShowProducts.TabIndex = 34;
            this.btnShowProducts.Text = "Show";
            this.btnShowProducts.UseVisualStyleBackColor = true;
            this.btnShowProducts.Click += new System.EventHandler(this.btnShowProducts_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 320);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Amount:";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // txtProductAmount
            // 
            this.txtProductAmount.Enabled = false;
            this.txtProductAmount.Location = new System.Drawing.Point(83, 311);
            this.txtProductAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductAmount.Name = "txtProductAmount";
            this.txtProductAmount.Size = new System.Drawing.Size(66, 25);
            this.txtProductAmount.TabIndex = 35;
            this.txtProductAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductAmount_KeyPress);
            // 
            // btnIncludeProduct
            // 
            this.btnIncludeProduct.Location = new System.Drawing.Point(400, 308);
            this.btnIncludeProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIncludeProduct.Name = "btnIncludeProduct";
            this.btnIncludeProduct.Size = new System.Drawing.Size(76, 28);
            this.btnIncludeProduct.TabIndex = 37;
            this.btnIncludeProduct.Text = "Include";
            this.btnIncludeProduct.UseVisualStyleBackColor = true;
            this.btnIncludeProduct.Click += new System.EventHandler(this.btnIncludeProduct_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(141, 220);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(335, 25);
            this.txtProductName.TabIndex = 38;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(161, 593);
            this.btnCancelOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(107, 43);
            this.btnCancelOrder.TabIndex = 39;
            this.btnCancelOrder.Text = "Cancel order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // txtTotalOrder
            // 
            this.txtTotalOrder.Enabled = false;
            this.txtTotalOrder.Location = new System.Drawing.Point(63, 528);
            this.txtTotalOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalOrder.Name = "txtTotalOrder";
            this.txtTotalOrder.Size = new System.Drawing.Size(136, 25);
            this.txtTotalOrder.TabIndex = 40;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(346, 529);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(130, 28);
            this.btnDeleteProduct.TabIndex = 42;
            this.btnDeleteProduct.Text = "Delete product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(23, 593);
            this.btnSaveOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(130, 43);
            this.btnSaveOrder.TabIndex = 43;
            this.btnSaveOrder.Text = "Save order";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            // 
            // txtSearchProducts
            // 
            this.txtSearchProducts.Enabled = false;
            this.txtSearchProducts.Location = new System.Drawing.Point(505, 225);
            this.txtSearchProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchProducts.Name = "txtSearchProducts";
            this.txtSearchProducts.Size = new System.Drawing.Size(170, 25);
            this.txtSearchProducts.TabIndex = 45;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Enabled = false;
            this.txtProductDescription.Location = new System.Drawing.Point(83, 252);
            this.txtProductDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(393, 54);
            this.txtProductDescription.TabIndex = 47;
            // 
            // txtClientLastName
            // 
            this.txtClientLastName.Enabled = false;
            this.txtClientLastName.Location = new System.Drawing.Point(283, 146);
            this.txtClientLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClientLastName.Name = "txtClientLastName";
            this.txtClientLastName.Size = new System.Drawing.Size(269, 25);
            this.txtClientLastName.TabIndex = 48;
            // 
            // txtIdClient
            // 
            this.txtIdClient.Enabled = false;
            this.txtIdClient.Location = new System.Drawing.Point(83, 115);
            this.txtIdClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(48, 25);
            this.txtIdClient.TabIndex = 49;
            // 
            // FormPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 664);
            this.Controls.Add(this.txtIdClient);
            this.Controls.Add(this.txtClientLastName);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.txtSearchProducts);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.txtTotalOrder);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnIncludeProduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProductAmount);
            this.Controls.Add(this.btnShowProducts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GridProductsSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridProductsOrder);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPurchaseOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPurchaseOrder";
            this.Load += new System.EventHandler(this.FormPurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridProductsOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProductsSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView GridProductsOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView GridProductsSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnShowProducts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductAmount;
        private System.Windows.Forms.Button btnIncludeProduct;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.TextBox txtTotalOrder;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.TextBox txtSearchProducts;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.TextBox txtClientLastName;
        private System.Windows.Forms.TextBox txtIdClient;
    }
}