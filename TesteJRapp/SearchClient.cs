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
    public partial class FormSearchClient : Form
    {
        public FormSearchClient()
        {
            InitializeComponent();
            txtSearchClient.Enabled = true;
        }

        // Variáveis para consultas SQL
        Connection con = new Connection();
        string sql;
        MySqlCommand cmd;
        string IdClient;


        private void FormatGrid()
        {
            Grid.Columns[0].HeaderText = "Cod";
            Grid.Columns[1].HeaderText = "Name";
            Grid.Columns[2].HeaderText = "Last Name";
            Grid.Columns[3].HeaderText = "Phone Number";

            Grid.Columns[0].Visible = false;
        }
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
            cmd.Parameters.AddWithValue("@Name", "%" + txtSearchClient.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
            con.CloseConnection();

            FormatGrid();

        }
        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            if (txtSearchClient.ToString().Trim() != "")
            {
                NameSearch();
            }
            else
            {
                ListGrid();
            }
        }

        private void FormSearchClient_Load(object sender, EventArgs e)
        {

        }

        private void Grid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = Grid.CurrentRow;
            string IdClient = Grid.CurrentRow.Cells[0].Value.ToString();
            string NameClient = Grid.CurrentRow.Cells[1].Value.ToString();
            string LastNameClient = Grid.CurrentRow.Cells[2].Value.ToString();
            FormPurchaseOrder FormPurchaseOrder = new FormPurchaseOrder(IdClient, NameClient, LastNameClient);
            FormPurchaseOrder.Show();
            
        }
    }
}
