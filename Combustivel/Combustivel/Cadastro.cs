using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combustivel
{
    class Cadastro
    {
        ConexaoBD conexaobd = new ConexaoBD();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;
        public Cadastro(string id, string tipoCombustivel, string ultimaMarcacaoHodometro)
        {
            //Comando Sql --------------------------SqlCommand
            cmd.CommandText = "insert into Veiculo (id, tipoCombustivel, ultimaMarcacaoHodometro) values (@id, @tipoCombustivel, @ultimaMarcacaoHodometro)";
            //Parametros
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@tipoCombustivel", tipoCombustivel);
            cmd.Parameters.AddWithValue("@ultimaMarcacaoHodometro", ultimaMarcacaoHodometro);

            try
            {   //Conectar ao banco --------------------Conexao
                cmd.Connection = conexaobd.conectar();
                //Executar comando
                cmd.ExecuteReader();
                //Desconectar
                conexaobd.desconectar();
                //mostrar mensagem de erro ou sucesso --Variavel
                this.mensagem = "Cadastrado com sucesso!!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar se conectar";

            throw;
            }

        }
    }
}
