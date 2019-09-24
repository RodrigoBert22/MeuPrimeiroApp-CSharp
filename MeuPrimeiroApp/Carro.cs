using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroApp
{
    class Carro
    {
        public string Modelo;
        public string Cor;
        public int QuantidadeDePortas;
        public bool PossuiArCondicionado;

        public Carro()
        {

            Modelo = "VW Gol";
            Cor = "Preto";
            QuantidadeDePortas = 4;
            PossuiArCondicionado = false;

        }

        public string Ligar()
        {
            return "Ligado";
        }

        public string Desligar()
        {
            return "Desligado";
        }

        public string Detalhes()
        {
            return Modelo + " - " + Cor; ;
        }
    }
}
