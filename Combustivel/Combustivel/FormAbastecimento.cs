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
    public partial class FormAbastecimento : Form
    {
        public FormAbastecimento()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=LUIZ\SQLEXPRESS;Initial Catalog=DB_COMBUSTIVEL;User ID=sa;Password=1234";

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmarAbastecimento ConfirmAbast = new ConfirmarAbastecimento(txbIdAbastecimento.Text, textBox2.Text, txtQtDeLitros.Text);
            MessageBox.Show(ConfirmAbast.mensagem);
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Veiculo WHERE ID=" + ddIdVeiculo.Text;

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

        private void FormAbastecimento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_COMBUSTIVELDataSet.Veiculo'. Você pode movê-la ou removê-la conforme necessário.
            this.veiculoTableAdapter.Fill(this.dB_COMBUSTIVELDataSet.Veiculo);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void HodometroBD_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * From Veiculo WHERE ID= @Id";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            con.Open();

            
        }

        private void ddIdVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Abastecimento SET IdAbastecimento = @idAbastecimento, Data = @data, qntDeLitros = @qtDeLitros WHERE IdVeiculo = @ID";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@ID", ddIdVeiculo.Text);
            cmd.Parameters.AddWithValue("@idAbastecimento", txbIdAbastecimento.Text);
            cmd.Parameters.AddWithValue("@data", textBox2.Text);
            cmd.Parameters.AddWithValue("@qtDeLitros", txtQtDeLitros.Text);
            

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
