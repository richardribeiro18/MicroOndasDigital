using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace BLL
{
    public class Micro
    {
        public List<Aquecer> ProgramaAquecimento { get; set; }
        public Aquecer objAquecimento { get; set; }
        public StringBuilder mensagem { get; set; }

        public Micro()
        {
            ProgramaAquecimento = new List<Aquecer>();
            InicializaProgramaAquecimento();

            this.mensagem = new StringBuilder();
        }

        private bool PotenciaValida()
        { return objAquecimento?.Potencia == "-1"; }

        private bool TempoValido()
        { return objAquecimento?.Tempo == "-1"; }

        public bool VerificaPotencia()
        {
            return (Convert.ToInt32(objAquecimento.Potencia) > 0 && Convert.ToInt32(objAquecimento.Potencia) < 11);
        }

        public bool VerificaTempo()
        {
            int tempo = Convert.ToInt32(objAquecimento.Tempo);
            return (tempo > 0 && tempo <= 200);
        }

        public string CaracterSegundo(int potencia, string caractere)
        {
            string MsgNova = "";
            for (int i = 0; i < potencia; i++)
                MsgNova += caractere;
            return MsgNova;
        }
        public string Aquecimento()
        {
            int tempo = -1, potencia = -1;
            int.TryParse(objAquecimento.Tempo, out tempo);
            int.TryParse(objAquecimento.Potencia, out potencia);
            this.mensagem.Clear();

            for (int x = 0; x < tempo; x++)
            {
                string MsgNova = "";
                for (int y = 0; y < potencia; y++)
                    MsgNova += objAquecimento.Caracter;
                this.mensagem.Append(MsgNova);
            }

            this.mensagem.Append("aquecida");
            return "aquecida";
        }

        public void InicioRapido()
        {
            objAquecimento = new Aquecer();

            objAquecimento.Potencia = "08";
            objAquecimento.Tempo = "0030";
            objAquecimento.Caracter = ".";
        }

        public void Inicio(string tempo, string potencia, string caractere)
        {
            objAquecimento = new Aquecer();

            objAquecimento.Potencia = potencia;
            objAquecimento.Tempo = tempo;
            objAquecimento.Caracter = caractere;
        }

        public string LigarMicroondas()
        {
            try
            {
                if (!TempoValido())
                {
                    if (VerificaTempo())
                    {
                        if (!PotenciaValida())
                        {
                            if (VerificaPotencia())
                            {
                                return Aquecimento();
                            }
                            else throw new System.ArgumentException("Parametrize a potência  entre 1 e 10");
                        }
                        else throw new System.ArgumentException("Parametrize uma potência antes de iniciar");
                    }
                    else throw new System.ArgumentException("Parametrize o tempo entre 1 segundo e 2 minutos");
                }
                else throw new System.ArgumentException("Parametrize o tempo antes de iniciar");
            }
            catch (System.ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "Microondas Digital - ERRO", System.Windows.Forms.MessageBoxButtons.OK);
                return "";
            }
        }

        public void InicializaProgramaAquecimento()
        {
            ProgramaAquecimento.Add(new Aquecer("Macarrão instantâneo", "0050", "07", "Programa de aquecimento de macarrão instantâneo", "*"));
            ProgramaAquecimento.Add(new Aquecer("Arroz", "0190", "09", "Programa de aquecimento de arroz", "@"));
            ProgramaAquecimento.Add(new Aquecer("Carne moída", "0060", "08", "Programa de aquecimento de carne moída", "+"));
            ProgramaAquecimento.Add(new Aquecer("Vegetais", "0050", "03", "Programa de aquecimento de vegetais", "="));
            ProgramaAquecimento.Add(new Aquecer("Pudim", "0130", "04", "Programa de aquecimento de pudim", ">"));

        }

        public void NovoProgramaAquecimento(string nome, string tempo, string potencia, string instrucoes, string caracter)
        {
            ProgramaAquecimento.Add(new Aquecer(nome, tempo, potencia, instrucoes, caracter));
        }

        public bool Gravar(Aquecer objAquecimento)
        {
            return true;
        }
    }
}

