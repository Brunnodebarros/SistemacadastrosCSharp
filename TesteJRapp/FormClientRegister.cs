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

namespace TesteJRapp
{
    public partial class FormClientRegister : Form
    {
       // Variáveis para consultas SQL
        Connection con = new Connection();
        string sql;
        MySqlCommand cmd;

        //variável do ID de registro
        string IdClient;

        
        public FormClientRegister()
        {
            InitializeComponent();
        }

        private void FormatGrid()
        {
            Grid.Columns[0].HeaderText = "Cod";
            Grid.Columns[1].HeaderText = "Name";
            Grid.Columns[2].HeaderText = "Last Name";
            Grid.Columns[3].HeaderText = "Phone Number";

            Grid.Columns[0].Visible = false;
        }
        private void FormClientRegister_Load(object sender, EventArgs e)
        {
            txtSearch.Enabled = true;
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
        private void NameSearch()
        {
            con.OpenConnection();
            sql = "SELECT * FROM infocliente WHERE ((Name LIKE @Name) OR (LastName LIKE @Name)) ORDER BY Name ASC";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@Name", "%" + txtSearch.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
            con.CloseConnection();

            FormatGrid();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        // Botão novo registro:
        private void btnNew_Click(object sender, EventArgs e)
        {
            EnableInput();
            txtSearch.Enabled= false;
            txtName.Focus();

            EnableButtons();
            btnNew.Enabled = false;
            btnChange.Enabled = false;
            btnSearch.Enabled = false;  
            btnDelete.Enabled = false;

        }

        // Botão de calcelar:
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableInput();
            DisableButtons();
            ClearInput();
            btnNew.Enabled = true;
            btnSearch.Enabled = true;
            txtSearch.Enabled = true;
        }

        // Botão de salvar:
        private void btnSave_Click(object sender, EventArgs e)
        {
            DisableButtons();
            DisableInput();
            btnNew.Enabled = true;

            if ((txtName.Text.ToString().Trim() == "") || (txtLastName.Text.ToString().Trim() == ""))
            {
                MessageBox.Show("First and Last name are required!");
                ClearInput();
                return;
            }
            
            con.OpenConnection();
            sql = "INSERT INTO infocliente (Name, LastName, PhoneNumber) VALUES (@Name, @LastName, @PhoneNumber)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
            cmd.ExecuteNonQuery();
            con.CloseConnection();

            ClearInput();
            btnSearch.Enabled = true;
            txtSearch.Enabled = true;

            MessageBox.Show("Saved","Save", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        // Botão de exclusão:
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("The information will be deleted", "Delete", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                con.OpenConnection();
                sql = "DELETE FROM infocliente WHERE IdClient=@IdClient";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@IdClient", IdClient);
                cmd.ExecuteNonQuery();
                con.CloseConnection();

                MessageBox.Show("Deleted record!");
            }

            ClearInput();
            DisableInput();
            DisableButtons();
            btnNew.Enabled=true;
        }     
        
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        //METODOS 

        //desabilitar botões:
        private void DisableButtons()
        {
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnChange.Enabled = false;
            btnNew.Enabled = false;
            btnCancel.Enabled = false;
        }

        //habilitar botões:
        private void EnableButtons()
        {
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnChange.Enabled = true;
            btnNew.Enabled = true;
            btnCancel.Enabled = true;
        }

        //habilitar campos
        private void EnableInput()
        {
            txtName.Enabled = true;
            txtLastName.Enabled = true;
            txtPhoneNumber.Enabled = true;
        }

        //desabilitar campos
        private void DisableInput()
        {
            txtName.Enabled = false;
            txtLastName.Enabled = false;
            txtPhoneNumber.Enabled = false;
        }

        //Limpar Campos
        private void ClearInput()
        {
            txtName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            con.OpenConnection();
            sql = "UPDATE infocliente SET Name=@Name, LastName=@LastName, PhoneNumber=@PhoneNumber WHERE IdClient=@idClient";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@IdClient", IdClient);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
            cmd.ExecuteNonQuery();
            con.CloseConnection();

            ClearInput();

            DisableButtons();
            DisableInput();
            btnNew.Enabled = true;
            MessageBox.Show("Altered", "Alteration", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ( txtSearch.ToString().Trim() != "")
            {
                NameSearch();
            }
            else
            {
                ListGrid();
            }    
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableButtons();
            btnNew.Enabled = false;
            btnSave.Enabled = false;
            EnableInput();

            // para pegar a PK do registro que está sendo referenciado
            IdClient = Grid.CurrentRow.Cells[0].Value.ToString();

            // para preencher os campos com a linha selecionada na grid:
            txtName.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            txtPhoneNumber.Text = Grid.CurrentRow.Cells[3].Value.ToString();
        }

    }
}
