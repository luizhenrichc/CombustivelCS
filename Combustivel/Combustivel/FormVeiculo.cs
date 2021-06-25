using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combustivel
{
    public partial class FormVeiculo : Form
    {

        public FormVeiculo()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=LUIZ\SQLEXPRESS;Initial Catalog=DB_COMBUSTIVEL;User ID=sa;Password=1234";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   //BotãoCadastrarVeiculo
            Cadastro cadVeiculo = new Cadastro(txtIdVeiculo.Text, txtTipoCombustivel.Text, txtHodometro.Text);
            MessageBox.Show(cadVeiculo.mensagem);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   //BotãoAbastecer&NewForm
            FormAbastecimento Abastecer = new FormAbastecimento();
            Abastecer.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void dvgCadastro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Veiculo WHERE ID=" + txtIdVeiculo.Text;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void txtIdVeiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarVeiculo_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Veiculo SET TipoCombustivel = @tipoCombustivel, UltimaMarcacaoHodometro = @ultimaMarcacaoHodometro WHERE ID = @ID";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@ID", txtIdVeiculo.Text);
            cmd.Parameters.AddWithValue("@tipoCombustivel", txtTipoCombustivel.Text);
            cmd.Parameters.AddWithValue("@ultimaMarcacaoHodometro", txtHodometro.Text);

            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro Alterado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
