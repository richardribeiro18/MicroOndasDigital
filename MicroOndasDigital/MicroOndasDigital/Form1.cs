using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace MicroOndasDigital
{
    public partial class PrincipalFrm : Form
    {
        Micro VerificarBLL;
        String Caractere;
        Timer TmTestarInicio;

        public PrincipalFrm()
        {
            InitializeComponent();

            this.Size = new Size(445, 345);

            TmTestarInicio = new Timer();
            TmTestarInicio.Interval = 1000;
            TmTestarInicio.Tick += TmTestarInicio_Tick;
            TmTestarInicio.Start();

            VerificarBLL = new BLL.Micro();

            CmbProgramaAquecimento.DataSource = VerificarBLL.ProgramaAquecimento;
            CmbProgramaAquecimento.DisplayMember = "Nome";
            CmbProgramaAquecimento.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.Micro Verificarbll = new BLL.Micro();

            Models.Aquecer objAquecimento = new Aquecer();


        }
        private void TmTestarInicio_Tick(object sender, EventArgs e)
        {
            TxtMostraCaractere.Text = VerificarBLL.mensagem?.ToString();
        }



        private void IniciarAquecimento()
        {
            var Ret = string.Empty;

            Task transac = Task.Factory.StartNew(() => Ret = VerificarBLL.LigarMicroondas());
            Task aguardaTransac = Task.Factory.StartNew(() =>
            {
                Task.WaitAll(transac); 
                transac.Dispose(); 
            });

            TmTestarInicio.Start();
        }

        private void BtnPausar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            VerificarBLL.NovoProgramaAquecimento(TxtNomeProgramaNovo.Text,
                                                 MtbTempoNovo.Text.Remove(2, 1),
                                                 MtbPotenciaNovo.Text,
                                                 TxtInstrucoesNovo.Text,
                                                 TxtCaractereNovo.Text);

            CmbProgramaAquecimento.DataSource = null;
            CmbProgramaAquecimento.DataSource = VerificarBLL.ProgramaAquecimento;
            CmbProgramaAquecimento.DisplayMember = "Nome";
            CmbProgramaAquecimento.SelectedIndex = -1;

            TxtNomeProgramaNovo.ResetText();
            MtbTempoNovo.ResetText();
            MtbPotenciaNovo.ResetText();
            TxtInstrucoesNovo.ResetText();
            TxtCaractereNovo.ResetText();

            TxtNomeProgramaNovo.Enabled = false;
            MtbTempoNovo.Enabled = false;
            MtbPotenciaNovo.Enabled = false;
            TxtInstrucoesNovo.Enabled = false;
            TxtCaractereNovo.Enabled = false;
            BtnNovoPrograma.Enabled = true;
            BtnGravarPrograma.Enabled = false;
            this.Size = new Size(445, 345);

        }



        private void CmbProgramaAquecimento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = CmbProgramaAquecimento.SelectedIndex;
            if (index > -1)
            {
                VerificarBLL.objAquecimento = new Aquecer();
                VerificarBLL.objAquecimento = VerificarBLL.ProgramaAquecimento.ElementAt(index);
                MtbTempo.Text = VerificarBLL.objAquecimento.Tempo.ToString();
                MtbPotencia.Text = VerificarBLL.objAquecimento.Potencia.ToString();
                TxtInstrucaoAquecimento.Text = VerificarBLL.objAquecimento.Instrucoes.ToString();
                Caractere = VerificarBLL.objAquecimento.Caracter.ToString();
            }
            else
            {
                MtbTempo.ResetText();
                MtbPotencia.ResetText();
                TxtInstrucaoAquecimento.ResetText();
                Caractere = ".";
            }
        }

        private void BtnNovoPrograma_Click(object sender, EventArgs e)
        {
            TxtNomeProgramaNovo.ResetText();
            MtbTempoNovo.ResetText();
            MtbPotenciaNovo.ResetText();
            TxtInstrucoesNovo.ResetText();
            TxtCaractereNovo.ResetText();

            TxtNomeProgramaNovo.Enabled = true;
            MtbTempoNovo.Enabled = true;
            MtbPotenciaNovo.Enabled = true;
            TxtInstrucoesNovo.Enabled = true;
            TxtCaractereNovo.Enabled = true;
            BtnNovoPrograma.Enabled = false;
            BtnGravarPrograma.Enabled = true;
            TxtNomeProgramaNovo.Focus();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            int tempo = -1, potencia = -1;
            int.TryParse(MtbTempo.Text.Replace(":", "").Trim(), out tempo);
            int.TryParse(MtbPotencia.Text.Trim(), out potencia);
            VerificarBLL.Inicio(tempo.ToString(), potencia.ToString(), Caractere);
            IniciarAquecimento();

        }

        private void BtnIniciarRapido_Click(object sender, EventArgs e)
        {
            VerificarBLL.InicioRapido();
            MtbTempo.Text = VerificarBLL.objAquecimento.Tempo;
            MtbPotencia.Text = VerificarBLL.objAquecimento.Potencia;

            IniciarAquecimento();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            TxtNomeProgramaNovo.Enabled = false;
            MtbTempoNovo.Enabled = false;
            MtbPotenciaNovo.Enabled = false;
            TxtInstrucoesNovo.Enabled = false;
            TxtCaractereNovo.Enabled = false;
            BtnNovoPrograma.Enabled = true;
            BtnGravarPrograma.Enabled = false;
            this.Size = new Size(445, 345);
        }

        private void BtnAdicionarPrograma_Click(object sender, EventArgs e)
        {
            this.Size = new Size(813, 345);
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            TmTestarInicio.Stop();
            CmbProgramaAquecimento.Text = ""; 
            TxtInstrucaoAquecimento.Text = "";
            MtbTempo.Text = "";
            MtbPotencia.Text = "";
            TxtMostraCaractere.Text = "";
        }

        private void BtnPausar_Click_1(object sender, EventArgs e)
        {
            if (BtnPausar.Text == "PAUSAR")
            {
                TmTestarInicio.Stop();
                BtnPausar.Text = "CONTINUAR";
            }
            else
            {
                TmTestarInicio.Start();
                BtnPausar.Text = "PAUSAR";
            }
        }
    }
}
