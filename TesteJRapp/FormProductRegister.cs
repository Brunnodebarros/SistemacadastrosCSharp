using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TesteJRapp
{
    public partial class FormProductRegister : Form
    {
        public FormProductRegister()
        {
            InitializeComponent();
        }
        
        // Variáveis para consultas SQL
        Connection con = new Connection();
        string sql;
        MySqlCommand cmd;

        //para pegar a data atual
        DateTime currentdate = DateTime.Now;

        //variável do ID de registro
        string IdProduct;

        private void FormProductRegister_Load(object sender, EventArgs e)
        {
            btnNewProduct.Enabled = true;
            txtProductSearch.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EnableInput();
            btnCancel.Enabled = true;
            btnSaveProduct.Enabled = true;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("The information will be deleted", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                con.OpenConnection();
                sql = "DELETE FROM product WHERE IdProduct=@IdProduct";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@IdProduct", IdProduct);
                cmd.ExecuteNonQuery();
                con.CloseConnection();

                MessageBox.Show("Deleted record!");
            }

            ClearInput();
            DisableInput();
            DisableButtons();
            btnNewProduct.Enabled = true;
            txtProductPrice.Text = string.Empty;
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            DisableButtons();
            DisableInput();
            btnNewProduct.Enabled = true;

            if ((txtProductName.Text.ToString().Trim() == "") || (txtProductPrice.Text.ToString().Trim() == ""))
            {
                MessageBox.Show("Product name and price are required information!");
                ClearInput();
                return;
            }

            con.OpenConnection();
            sql = "INSERT INTO product (Name, Description, Price, RegistrationDate) VALUES (@Name, @Description, @Price, @currentdate)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@Name", txtProductName.Text);
            cmd.Parameters.AddWithValue("@Description", txtProductDescription.Text);
            cmd.Parameters.AddWithValue("@Price", txtProductPrice.Text);
            cmd.Parameters.AddWithValue("@currentdate", currentdate); //insere a data atual no DB
            cmd.ExecuteNonQuery();
            con.CloseConnection();

            ClearInput();
            btnSearch.Enabled = true;
            txtProductSearch.Enabled = true;

            MessageBox.Show("Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //METODOS 

        //desabilitar botões:
        private void DisableButtons()
        {
            btnSaveProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            btnChangeProduct.Enabled = false;
            btnNewProduct.Enabled = false;
            btnCancel.Enabled = false;
        }

        //habilitar botões:
        private void EnableButtons()
        {
            btnSaveProduct.Enabled = true;
            btnDeleteProduct.Enabled = true;
            btnChangeProduct.Enabled = true;
            btnNewProduct.Enabled = true;
            btnCancel.Enabled = true;
        }

        //habilitar campos
        private void EnableInput()
        {
            txtProductName.Enabled = true;
            txtProductDescription.Enabled = true;
            txtProductPrice.Enabled = true;
            
        }

        //desabilitar campos
        private void DisableInput()
        {
            txtProductName.Enabled = false;
            txtProductDescription.Enabled = false;
            txtProductPrice.Enabled = false;
        }

        //Limpar Campos
        private void ClearInput()
        {
            txtProductName.Text = string.Empty;
            txtProductDescription.Text = string.Empty;
        }

        //Formatar GRID
        private void FormatGrid()
        {
            Grid.Columns[0].HeaderText = "Cod";
            Grid.Columns[1].HeaderText = "Name";
            Grid.Columns[2].HeaderText = "Description";
            Grid.Columns[3].HeaderText = "Price";
            Grid.Columns[4].HeaderText = "Registration Date";

            Grid.Columns[0].Visible = false;
            Grid.Columns[4].Visible = false;
        }

        // CONSULTAS DA GRID

        //todos os registros
        private void ListGrid()
        {
            con.OpenConnection();
            sql = "SELECT * FROM infocliente ORDER BY Name ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
            con.CloseConnection();

            FormatGrid();
        }

        //Consulta com filtro
        private void ProductNameSearch()
        {
            con.OpenConnection();
            sql = "SELECT * FROM product WHERE ((Name LIKE @Name) OR (Description LIKE @Name)) ORDER BY Name ASC";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@Name", "%" + txtProductSearch.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
            con.CloseConnection();

            FormatGrid();

        }

        // ------------------------------------------------------------------------------------------

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableInput();
            DisableButtons();
            ClearInput();
            btnNewProduct.Enabled = true;
            btnSearch.Enabled = true;
            txtProductSearch.Enabled = true;
            txtProductPrice.Text = string.Empty;
            
        }

        private void txtProductPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtProductPrice_Leave(object sender, EventArgs e)
        { 
             txtProductPrice.Text = Convert.ToDouble(txtProductPrice.Text).ToString("F");
        }

        /*
         Para evitar que letras sejam digitadas faz com que o ponto seja substituido 
        por virgula e que exista apenas uma virgula na string
         */
        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtProductPrice.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        /*trecho para tirar a formatação para não gerar nenhuma excessão quando o txtProductPrice
        receber e perder o foco de novo com caracteres inválidos(ex.: 'R$')
        por causa da formatação que já existe no campo.
        */
        private void txtProductPrice_MouseEnter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtProductPrice.Text.Length - 1; i++)
            {
                if ((txtProductPrice.Text[i] >= '0' &&
                    txtProductPrice.Text[i] <= '9') ||
                    txtProductPrice.Text[i] == ',')
                {
                    x += txtProductPrice.Text[i];
                }
            }
            txtProductPrice.Text = x;
            txtProductPrice.SelectAll();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtProductSearch.ToString().Trim() != "")
            {
                ProductNameSearch();
            }
            else
            {
                ListGrid();
            }
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableButtons();
            btnNewProduct.Enabled = false;
            btnSaveProduct.Enabled = false;
            EnableInput();

            // para pegar a PK do registro que está sendo referenciado
            IdProduct = Grid.CurrentRow.Cells[0].Value.ToString();

            // para preencher os campos com a linha selecionada na grid:
            txtProductName.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txtProductDescription.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            txtProductPrice.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void btnChangeProduct_Click(object sender, EventArgs e)
        {
            con.OpenConnection();
            sql = "UPDATE product SET Name=@Name, Description=@Description, Price=@Price  WHERE IdProduct=@idProduct";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@IdProduct", IdProduct);
            cmd.Parameters.AddWithValue("@Name", txtProductName.Text);
            cmd.Parameters.AddWithValue("@Description", txtProductDescription.Text);
            cmd.Parameters.AddWithValue("@Price", txtProductPrice.Text);
            cmd.ExecuteNonQuery();
            con.CloseConnection();

            ClearInput();

            DisableButtons();
            DisableInput();
            btnNewProduct.Enabled = true;
            MessageBox.Show("Altered", "Alteration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtProductPrice.Text = string.Empty;
        }
    }
} 
