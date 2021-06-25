using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Combustivel
{
    public class ConexaoBD
    {
        SqlConnection con = new SqlConnection();

        //Construtor
        public ConexaoBD()
        {
            con.ConnectionString = @"Data Source=LUIZ\SQLEXPRESS;Initial Catalog=DB_COMBUSTIVEL;User ID=sa;Password=1234";
        }

        //Método Conectar
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con; 
        }

        //Método Desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

            return;

        }
    }
}
