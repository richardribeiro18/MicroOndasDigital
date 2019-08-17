using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{

    public class Aquecer
    {
        public string Nome { get; set; }
        public string Tempo { get; set; }
        public string Potencia { get; set; }
        public string Instrucoes { get; set; }
        public string Caracter { get; set; }


        public Aquecer()
        {

        }


        public Aquecer(string nome, string tempo, string potencia, string instrucoes, string caracter)
        {
            this.Nome = nome;
            this.Tempo = tempo;
            this.Potencia = potencia;
            this.Instrucoes = instrucoes;
            this.Caracter = caracter;
        }

    }
}
