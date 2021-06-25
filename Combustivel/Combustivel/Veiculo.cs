using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combustivel
{
    class Veiculo
    {
        Abastecimento abastecimento = new Abastecimento();
        public static int idGeral = 0;
        public int id, ultimaMarcacaoHodometro;
        public string tipoCombustivel;
        public int kmPercorrido = 0;
        public double kmPorLitro = 0;

        public Veiculo()
        {
            this.gerarId();
        }
            
        public int getId()
        {
            return id;
        }

        public int getUltimaMarcacaoHodometro()
        {
            return ultimaMarcacaoHodometro;
        }
        public void setUltimaMarcacaoHodometro(int ultimaMarcacaoHodometro)
        {
            this.ultimaMarcacaoHodometro = ultimaMarcacaoHodometro;
        }
        public string getTipoCombustivel()
        {
            return tipoCombustivel;
        }
        public void setTipoCombustivel(string tipoCombustivel)
        {
            this.tipoCombustivel = tipoCombustivel;
        }
        public int getKmPercorrido()
        {
            return kmPercorrido;
        }
        public void setKmPercorrido(int kmPercorrido)
        {
            this.kmPercorrido = kmPercorrido;
        }
        public double getKmPorLitro()
        {
            return kmPorLitro;
        }

        public void setKmPorLitro(double kmPorLitro)
        {
            this.kmPorLitro = kmPorLitro;
        }

        public void gerarId()
        {
            this.id = ++idGeral;
        }

        public void calcularKmPercorrido(int marcacaoAtual){

            setKmPercorrido(abastecimento.getMarcacaoHodometro() - getUltimaMarcacaoHodometro());

        }
        public void atualizarMarcacao(int marcacaoAtual){

            setUltimaMarcacaoHodometro(abastecimento.getMarcacaoHodometro());

        }
        public void calcularKmPorLitro(double qtdlitro){

            setKmPorLitro(getKmPercorrido() / abastecimento.getQtDeLitros());

        }
    }
}
