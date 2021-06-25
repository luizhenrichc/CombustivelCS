using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combustivel
{
    class Abastecimento
    {
        Veiculo veiculo = new Veiculo();
        public static int idGeral = 0;
        int  idAbastecimento;
        string data;
        public double qtDeLitros, custoAbastecimento;
        int marcacaoHodometro;
        public double valorDoCusto;

        public Abastecimento()
        {
            this.gerarId();
        }

        public int getIdAbastecimento()
        {
            return idAbastecimento;
        }

        public string getData()
        {
            return data;
        }

        public void setData(string data)
        {
            this.data = data;
        }

        public double getQtDeLitros()
        {
            return qtDeLitros;
        }

        public void setQtDeLitros(double qtDeLitros)
        {
           this.qtDeLitros = qtDeLitros;
        }
        public double getCustoAbastecimento()
        {
            return custoAbastecimento;
        }
        public void setCustoAbastecimento(double custoAbastecimento)
        {
            this.custoAbastecimento = custoAbastecimento;
        }
     
        public int getMarcacaoHodometro()
        {
            return marcacaoHodometro;
        }
        public void setMarcacaoHodometro(int marcacaoHodometro)
        {
            this.marcacaoHodometro = marcacaoHodometro;
        }

        public void gerarId()
        {
            this.idAbastecimento = ++idGeral;
        }

        public double calcularCustoAbastecimento()
        {
            if (veiculo.getTipoCombustivel() == "G")
            {
                valorDoCusto = getQtDeLitros() * 3.80;
            }
            if (veiculo.getTipoCombustivel() == "E")
            {
                valorDoCusto = getQtDeLitros() * 3.40;
            }
            if (veiculo.getTipoCombustivel() == "D")
            {
                valorDoCusto = getQtDeLitros() * 2.50;
            }
            return valorDoCusto;
        }

        public void registrarAbastecimento()
        {
            veiculo.setKmPercorrido(getMarcacaoHodometro() - veiculo.getUltimaMarcacaoHodometro());
            veiculo.setUltimaMarcacaoHodometro(getMarcacaoHodometro());
        }

    }
}
