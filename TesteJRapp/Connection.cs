using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteJRapp
{
    class Connection
    {
        public string conect = "SERVER=localhost; DATABASE=appven; UID=root; PWD=; PORT=3306;";

        public MySqlConnection con = null;

        //Abrir conexao
        public void OpenConnection()
        {
            try
            {
                con = new MySqlConnection(conect);
                con.Open();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Erro ao acessar Banco de dados: " + ex.Message); 
            }
        }

        //Fechar conexao
        public void CloseConnection()
        {
            try
            {
                con = new MySqlConnection(conect);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar conexão com Banco de dados: " + ex.Message);
            }
        }

    }
}
