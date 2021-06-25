using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combustivel
{
    class Consulta
    {
        ConexaoBD conexaobd = new ConexaoBD();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;
        public Consulta(string id, string tipoCombustivel, string ultimaMarcacaoHodometro)
        {
            try
            {   //Conectar ao banco --------------------Conexao
                cmd.Connection = conexaobd.conectar();
                //Executar comando
                cmd.ExecuteReader();
                //Desconectar
                conexaobd.desconectar();
                //mostrar mensagem de erro ou sucesso --Variavel
                this.mensagem = "Registros exibidos com sucesso!!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar se conectar";

                throw;
            }
        }
    }
}
