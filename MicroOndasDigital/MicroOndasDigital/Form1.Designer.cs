namespace MicroOndasDigital
{
    partial class PrincipalFrm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtMostraCaractere = new System.Windows.Forms.TextBox();
            this.GpbNovoPrograma = new System.Windows.Forms.GroupBox();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.TxtCaractereNovo = new System.Windows.Forms.TextBox();
            this.BtnGravarPrograma = new System.Windows.Forms.Button();
            this.BtnNovoPrograma = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtInstrucoesNovo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MtbPotenciaNovo = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MtbTempoNovo = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNomeProgramaNovo = new System.Windows.Forms.TextBox();
            this.TxtInstrucaoAquecimento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnPausar = new System.Windows.Forms.Button();
            this.BtnIniciarRapido = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbProgramaAquecimento = new System.Windows.Forms.ComboBox();
            this.MtbPotencia = new System.Windows.Forms.MaskedTextBox();
            this.MtbTempo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnAdicionarPrograma = new System.Windows.Forms.Button();
            this.GpbNovoPrograma.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtMostraCaractere
            // 
            this.TxtMostraCaractere.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtMostraCaractere.Location = new System.Drawing.Point(4, 195);
            this.TxtMostraCaractere.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMostraCaractere.Multiline = true;
            this.TxtMostraCaractere.Name = "TxtMostraCaractere";
            this.TxtMostraCaractere.ReadOnly = true;
            this.TxtMostraCaractere.Size = new System.Drawing.Size(416, 107);
            this.TxtMostraCaractere.TabIndex = 3;
            // 
            // GpbNovoPrograma
            // 
            this.GpbNovoPrograma.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GpbNovoPrograma.Controls.Add(this.BtnVoltar);
            this.GpbNovoPrograma.Controls.Add(this.TxtCaractereNovo);
            this.GpbNovoPrograma.Controls.Add(this.BtnGravarPrograma);
            this.GpbNovoPrograma.Controls.Add(this.BtnNovoPrograma);
            this.GpbNovoPrograma.Controls.Add(this.label10);
            this.GpbNovoPrograma.Controls.Add(this.TxtInstrucoesNovo);
            this.GpbNovoPrograma.Controls.Add(this.label9);
            this.GpbNovoPrograma.Controls.Add(this.label8);
            this.GpbNovoPrograma.Controls.Add(this.MtbPotenciaNovo);
            this.GpbNovoPrograma.Controls.Add(this.label7);
            this.GpbNovoPrograma.Controls.Add(this.MtbTempoNovo);
            this.GpbNovoPrograma.Controls.Add(this.label6);
            this.GpbNovoPrograma.Controls.Add(this.TxtNomeProgramaNovo);
            this.GpbNovoPrograma.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbNovoPrograma.Location = new System.Drawing.Point(427, 9);
            this.GpbNovoPrograma.Name = "GpbNovoPrograma";
            this.GpbNovoPrograma.Size = new System.Drawing.Size(385, 293);
            this.GpbNovoPrograma.TabIndex = 29;
            this.GpbNovoPrograma.TabStop = false;
            this.GpbNovoPrograma.Text = "Novo programa de aquecimento";
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(295, 14);
            this.BtnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(70, 28);
            this.BtnVoltar.TabIndex = 26;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // TxtCaractereNovo
            // 
            this.TxtCaractereNovo.Enabled = false;
            this.TxtCaractereNovo.Location = new System.Drawing.Point(308, 86);
            this.TxtCaractereNovo.MaxLength = 1;
            this.TxtCaractereNovo.Name = "TxtCaractereNovo";
            this.TxtCaractereNovo.Size = new System.Drawing.Size(57, 21);
            this.TxtCaractereNovo.TabIndex = 16;
            // 
            // BtnGravarPrograma
            // 
            this.BtnGravarPrograma.Enabled = false;
            this.BtnGravarPrograma.Location = new System.Drawing.Point(265, 258);
            this.BtnGravarPrograma.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGravarPrograma.Name = "BtnGravarPrograma";
            this.BtnGravarPrograma.Size = new System.Drawing.Size(100, 28);
            this.BtnGravarPrograma.TabIndex = 24;
            this.BtnGravarPrograma.Text = "Gravar";
            this.BtnGravarPrograma.UseVisualStyleBackColor = true;
            this.BtnGravarPrograma.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnNovoPrograma
            // 
            this.BtnNovoPrograma.Location = new System.Drawing.Point(10, 17);
            this.BtnNovoPrograma.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNovoPrograma.Name = "BtnNovoPrograma";
            this.BtnNovoPrograma.Size = new System.Drawing.Size(70, 28);
            this.BtnNovoPrograma.TabIndex = 23;
            this.BtnNovoPrograma.Text = "Novo";
            this.BtnNovoPrograma.UseVisualStyleBackColor = true;
            this.BtnNovoPrograma.Click += new System.EventHandler(this.BtnNovoPrograma_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Instruções";
            // 
            // TxtInstrucoesNovo
            // 
            this.TxtInstrucoesNovo.Enabled = false;
            this.TxtInstrucoesNovo.Location = new System.Drawing.Point(10, 132);
            this.TxtInstrucoesNovo.MaxLength = 250;
            this.TxtInstrucoesNovo.Multiline = true;
            this.TxtInstrucoesNovo.Name = "TxtInstrucoesNovo";
            this.TxtInstrucoesNovo.Size = new System.Drawing.Size(355, 123);
            this.TxtInstrucoesNovo.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 90);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Potência";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tempo ";
            // 
            // MtbPotenciaNovo
            // 
            this.MtbPotenciaNovo.Enabled = false;
            this.MtbPotenciaNovo.Location = new System.Drawing.Point(186, 86);
            this.MtbPotenciaNovo.Mask = "00";
            this.MtbPotenciaNovo.Name = "MtbPotenciaNovo";
            this.MtbPotenciaNovo.Size = new System.Drawing.Size(46, 21);
            this.MtbPotenciaNovo.TabIndex = 15;
            this.MtbPotenciaNovo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MtbPotenciaNovo.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Caractere";
            // 
            // MtbTempoNovo
            // 
            this.MtbTempoNovo.Enabled = false;
            this.MtbTempoNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbTempoNovo.Location = new System.Drawing.Point(69, 84);
            this.MtbTempoNovo.Margin = new System.Windows.Forms.Padding(4);
            this.MtbTempoNovo.Mask = "00:00";
            this.MtbTempoNovo.Name = "MtbTempoNovo";
            this.MtbTempoNovo.Size = new System.Drawing.Size(47, 22);
            this.MtbTempoNovo.TabIndex = 14;
            this.MtbTempoNovo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MtbTempoNovo.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nome";
            // 
            // TxtNomeProgramaNovo
            // 
            this.TxtNomeProgramaNovo.Enabled = false;
            this.TxtNomeProgramaNovo.Location = new System.Drawing.Point(69, 49);
            this.TxtNomeProgramaNovo.MaxLength = 20;
            this.TxtNomeProgramaNovo.Name = "TxtNomeProgramaNovo";
            this.TxtNomeProgramaNovo.Size = new System.Drawing.Size(296, 21);
            this.TxtNomeProgramaNovo.TabIndex = 13;
            // 
            // TxtInstrucaoAquecimento
            // 
            this.TxtInstrucaoAquecimento.Enabled = false;
            this.TxtInstrucaoAquecimento.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInstrucaoAquecimento.Location = new System.Drawing.Point(7, 74);
            this.TxtInstrucaoAquecimento.Multiline = true;
            this.TxtInstrucaoAquecimento.Name = "TxtInstrucaoAquecimento";
            this.TxtInstrucaoAquecimento.Size = new System.Drawing.Size(413, 30);
            this.TxtInstrucaoAquecimento.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Instruções";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(320, 146);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 40);
            this.BtnCancelar.TabIndex = 26;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click_1);
            // 
            // BtnPausar
            // 
            this.BtnPausar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPausar.Location = new System.Drawing.Point(217, 146);
            this.BtnPausar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPausar.Name = "BtnPausar";
            this.BtnPausar.Size = new System.Drawing.Size(100, 40);
            this.BtnPausar.TabIndex = 25;
            this.BtnPausar.Text = "PAUSAR";
            this.BtnPausar.UseVisualStyleBackColor = true;
            this.BtnPausar.Click += new System.EventHandler(this.BtnPausar_Click_1);
            // 
            // BtnIniciarRapido
            // 
            this.BtnIniciarRapido.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarRapido.Location = new System.Drawing.Point(111, 146);
            this.BtnIniciarRapido.Name = "BtnIniciarRapido";
            this.BtnIniciarRapido.Size = new System.Drawing.Size(100, 40);
            this.BtnIniciarRapido.TabIndex = 24;
            this.BtnIniciarRapido.Text = "INICIAR RÁPIDO";
            this.BtnIniciarRapido.UseVisualStyleBackColor = true;
            this.BtnIniciarRapido.Click += new System.EventHandler(this.BtnIniciarRapido_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Programas de aquecimento";
            // 
            // CmbProgramaAquecimento
            // 
            this.CmbProgramaAquecimento.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbProgramaAquecimento.FormattingEnabled = true;
            this.CmbProgramaAquecimento.Location = new System.Drawing.Point(7, 28);
            this.CmbProgramaAquecimento.Name = "CmbProgramaAquecimento";
            this.CmbProgramaAquecimento.Size = new System.Drawing.Size(204, 21);
            this.CmbProgramaAquecimento.TabIndex = 22;
            this.CmbProgramaAquecimento.SelectedIndexChanged += new System.EventHandler(this.CmbProgramaAquecimento_SelectedIndexChanged_1);
            // 
            // MtbPotencia
            // 
            this.MtbPotencia.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbPotencia.Location = new System.Drawing.Point(181, 114);
            this.MtbPotencia.Mask = "00";
            this.MtbPotencia.Name = "MtbPotencia";
            this.MtbPotencia.Size = new System.Drawing.Size(53, 21);
            this.MtbPotencia.TabIndex = 21;
            this.MtbPotencia.Text = "10";
            this.MtbPotencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MtbPotencia.ValidatingType = typeof(int);
            // 
            // MtbTempo
            // 
            this.MtbTempo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbTempo.Location = new System.Drawing.Point(49, 114);
            this.MtbTempo.Margin = new System.Windows.Forms.Padding(4);
            this.MtbTempo.Mask = "00:00";
            this.MtbTempo.Name = "MtbTempo";
            this.MtbTempo.Size = new System.Drawing.Size(55, 21);
            this.MtbTempo.TabIndex = 20;
            this.MtbTempo.Text = "0030";
            this.MtbTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MtbTempo.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Potência";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tempo";
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.Location = new System.Drawing.Point(4, 146);
            this.BtnIniciar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(100, 40);
            this.BtnIniciar.TabIndex = 17;
            this.BtnIniciar.Text = "INICIAR";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // BtnAdicionarPrograma
            // 
            this.BtnAdicionarPrograma.Location = new System.Drawing.Point(217, 21);
            this.BtnAdicionarPrograma.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdicionarPrograma.Name = "BtnAdicionarPrograma";
            this.BtnAdicionarPrograma.Size = new System.Drawing.Size(116, 28);
            this.BtnAdicionarPrograma.TabIndex = 30;
            this.BtnAdicionarPrograma.Text = "Adicionar Programa";
            this.BtnAdicionarPrograma.UseVisualStyleBackColor = true;
            this.BtnAdicionarPrograma.Click += new System.EventHandler(this.BtnAdicionarPrograma_Click);
            // 
            // PrincipalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 307);
            this.Controls.Add(this.BtnAdicionarPrograma);
            this.Controls.Add(this.GpbNovoPrograma);
            this.Controls.Add(this.TxtInstrucaoAquecimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnPausar);
            this.Controls.Add(this.BtnIniciarRapido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbProgramaAquecimento);
            this.Controls.Add(this.MtbPotencia);
            this.Controls.Add(this.MtbTempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.TxtMostraCaractere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PrincipalFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Microondas Digital";
            this.GpbNovoPrograma.ResumeLayout(false);
            this.GpbNovoPrograma.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMostraCaractere;
        private System.Windows.Forms.GroupBox GpbNovoPrograma;
        private System.Windows.Forms.Button BtnGravarPrograma;
        private System.Windows.Forms.Button BtnNovoPrograma;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtInstrucoesNovo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox MtbPotenciaNovo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MtbTempoNovo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNomeProgramaNovo;
        private System.Windows.Forms.TextBox TxtInstrucaoAquecimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnPausar;
        private System.Windows.Forms.Button BtnIniciarRapido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbProgramaAquecimento;
        private System.Windows.Forms.MaskedTextBox MtbPotencia;
        private System.Windows.Forms.MaskedTextBox MtbTempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.TextBox TxtCaractereNovo;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnAdicionarPrograma;
    }
}

