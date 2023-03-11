using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TesteJRapp
{
    public partial class FormPurchaseOrder : Form
    {

        public FormPurchaseOrder(string IdClient, string NameClient, string LastNameClient)
        {
            InitializeComponent();
            txtIdClient.Text = IdClient;
            txtClientName.Text = NameClient;
            txtClientLastName.Text = LastNameClient;
            txtProductAmount.Enabled = true;
        }

        // Variáveis para consultas SQL
        Connection con = new Connection();
        string sql;
        MySqlCommand cmd;
        //para pegar a data atual
        DateTime currentdate = DateTime.Now;

        string IdProduct;
        string IdOrder;

        private void DisableButtons()
        {
            btnDeleteProduct.Enabled = false;
            btnIncludeProduct.Enabled = false;
            btnSaveOrder.Enabled = false;
            btnShowProducts.Enabled = false;
            btnCancelOrder.Enabled = false;
        }
        private void EnableButtons()
        {
            btnDeleteProduct.Enabled = true;
            btnIncludeProduct.Enabled = true;
            btnSaveOrder.Enabled = true;
            btnShowProducts.Enabled=true;
            btnCancelOrder.Enabled=true;
        }

        private void EnableInput()
        {
            txtProductAmount.Enabled = true;
            txtSearchProducts.Enabled = true;
        }
        private void DisableInput() 
        {
            txtProductAmount.Enabled = false;
            txtSearchProducts.Enabled = false;
        }
        private void ClearInput()
        {
            txtProductName.Text = string.Empty;
            txtProductAmount.Text = string.Empty;
            txtSearchProducts.Text = string.Empty;
            txtProductID.Text = string.Empty;
            txtTotalOrder.Text = string.Empty;
            txtProductDescription.Text = string.Empty;
        }
        // *********** GRID DE SELEÇÃO DE PRODUTOS
        private void FormatGridProductsSearch()
        {
            GridProductsSearch.Columns[0].HeaderText = "Cod";
            GridProductsSearch.Columns[1].HeaderText = "Name";
            GridProductsSearch.Columns[2].HeaderText = "Description";
            GridProductsSearch.Columns[3].HeaderText = "Price";
            GridProductsSearch.Columns[4].HeaderText = "Registration Date";

            GridProductsSearch.Columns[0].Visible = false;
            GridProductsSearch.Columns[2].Visible = false;
            GridProductsSearch.Columns[4].Visible = false;
        }
        private void ListGridProductsSearch()
        {
            con.OpenConnection();
            sql = "SELECT * FROM product ORDER BY Name ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridProductsSearch.DataSource = dt;
            con.CloseConnection();

            FormatGridProductsSearch();
        }
        // ***************************************************

        //----------- GRID DO PEDIDO ----------
        private void FormatGridProductsOrder()
        {
            GridProductsOrder.Columns[0].HeaderText = "Cod";
            GridProductsOrder.Columns[1].HeaderText = "id cliente";
            GridProductsOrder.Columns[2].HeaderText = "id product";
            GridProductsOrder.Columns[3].HeaderText = "Order Date";
            GridProductsOrder.Columns[4].HeaderText = "Total amount";
            GridProductsOrder.Columns[5].HeaderText = "Product Name";

            GridProductsOrder.Columns[0].Visible = false;
            GridProductsOrder.Columns[1].Visible = false;
            GridProductsOrder.Columns[3].Visible = false;
        }
        private void ListGridProductsOrder()
        {
            con.OpenConnection();
            sql = "SELECT purchaseorder.IdOrder ,purchaseorder.IdClient, " +
                "         purchaseorder.IdProduct, purchaseorder.OrderDate, " +
                "         purchaseorder.TotalAmount, product.Name " +
                "    FROM purchaseorder, product " +
                "   WHERE purchaseorder.IdProduct = product.IdProduct " +
                "     AND IdClient = @IdClient ";

            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@IdClient", txtIdClient);
            cmd.Parameters.AddWithValue("@IdOrder", IdOrder);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridProductsOrder.DataSource = dt;
            con.CloseConnection();

            FormatGridProductsOrder();
        }

        // Busca de produtos por nome ou descrição
        private void ProductNameSearch()
        {
            con.OpenConnection();
            sql = "SELECT * FROM product WHERE ((Name LIKE @Name) OR (Description LIKE @Name)) ORDER BY Name ASC";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@Name", "%" + txtSearchProducts.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridProductsSearch.DataSource = dt;
            con.CloseConnection();

            FormatGridProductsSearch();

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            FormSearchClient fmr = new FormSearchClient();
            fmr.ShowDialog();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            DisableButtons();
            DisableInput();
            ClearInput();
            GridProductsSearch.DataSource = null;//limpar lista
            GridProductsOrder.DataSource = null;
            this.Close();
        }

        private void btnShowProducts_Click(object sender, EventArgs e)
        {
            if (txtSearchProducts.ToString().Trim() != "")
            {
                ProductNameSearch();
            }
            else
            {
                ListGridProductsSearch();
            }
        }

        private void GridProductsSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // para pegar a PK do registro que está sendo referenciado
            IdProduct = GridProductsSearch.CurrentRow.Cells[0].Value.ToString();

            // para preencher os campos com a linha selecionada na grid:
            txtProductID.Text = GridProductsSearch.CurrentRow.Cells[0].Value.ToString();
            txtProductName.Text = GridProductsSearch.CurrentRow.Cells[1].Value.ToString();
            txtProductDescription.Text = GridProductsSearch.CurrentRow.Cells[2].Value.ToString();
        }

        private void txtProductAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla digitada é um número ou tecla de controle (por exemplo, backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnIncludeProduct_Click(object sender, EventArgs e)
        {
            if (txtProductAmount.Text == "")
            {
                txtProductAmount.Text = "1";
            }
            if (txtProductName.Text.ToString().Trim() == "")
            {
                MessageBox.Show("First select product");
                ClearInput();
                return;
            }

            con.OpenConnection();
            
            sql = "IF EXISTS (SELECT * FROM purchaseorder WHERE IdProduct = @Idproduct)" +
                "      BEGIN  UPDATE purchaseorder " +
                "        SET TotalAmount = TotalAmount + 1 " +
                "     WHERE IdProduct = @IdProduct" +
                "       END "  +
                "      ELSE "  +
                "     BEGIN INSERT INTO purchaseorder " +
                "    (purchaseorder.IdClient, purchaseorder.IdProduct, purchaseorder.CurrentDate, purchaseorder.TotalAmount) " +
                "          VALUES (@TotalAmount, @TotalAmount)" +
                "      END";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@IdClient", txtIdClient.Text);
            cmd.Parameters.AddWithValue("@IdProduct", txtProductID.Text);
            cmd.Parameters.AddWithValue("@currentdate", currentdate); //insere a data atual no DB
            cmd.Parameters.AddWithValue("@TotalAmount", txtProductAmount.Text);
            cmd.ExecuteNonQuery();
            con.CloseConnection();

            ClearInput();

            ListGridProductsOrder();

        }

        private void txtClientName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FormPurchaseOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
