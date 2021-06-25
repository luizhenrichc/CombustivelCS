using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combustivel
{
    class ConfirmarAbastecimento
    {
        ConexaoBD conexaobd = new ConexaoBD();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;
        public ConfirmarAbastecimento(string idAbastecimento, string data, string qtDeLitros)
        {
            //Comando Sql --------------------------SqlCommand
            cmd.CommandText = "insert into Abastecimento (idAbastecimento, data, qtDeLitros) values (@idAbastecimento, @data, @marcacaoHodometro, @qtDeLitros)";
            //Parametros
            cmd.Parameters.AddWithValue("@idAbastecimento", idAbastecimento);
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@qtDeLitros", qtDeLitros);

            try
            {   //Conectar ao banco --------------------Conexao
                cmd.Connection = conexaobd.conectar();
                //Executar comando
                cmd.ExecuteReader();
                //Desconectar
                conexaobd.desconectar();
                //mostrar mensagem de erro ou sucesso --Variavel
                this.mensagem = "Confirmado!!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar se conectar";

                throw;
            }
        }
    }
}
