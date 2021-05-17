
namespace Projeto_N2_POO.Forms
{
    partial class frGerenciarOnibus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbmPedagios = new System.Windows.Forms.ComboBox();
            this.btnPagarPedagio = new System.Windows.Forms.Button();
            this.btnAlterarLimpador = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.ucPossuiLeito = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucVelocidade = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucQtdDeEixos = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucEstadoLimpador = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucQtdPassageiro = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucModelo = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucMarca = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucIdentificacao = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucAcelerar = new Projeto_N2_POO.User_Controls.ucAcelerar();
            this.ucDesacelerar = new Projeto_N2_POO.User_Controls.ucDesacelerar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.ucPossuiLeito);
            this.groupBox1.Controls.Add(this.ucVelocidade);
            this.groupBox1.Controls.Add(this.ucQtdDeEixos);
            this.groupBox1.Controls.Add(this.ucEstadoLimpador);
            this.groupBox1.Controls.Add(this.ucQtdPassageiro);
            this.groupBox1.Controls.Add(this.btnProximo);
            this.groupBox1.Controls.Add(this.btnAnterior);
            this.groupBox1.Controls.Add(this.ucModelo);
            this.groupBox1.Controls.Add(this.ucMarca);
            this.groupBox1.Controls.Add(this.ucIdentificacao);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 400);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisa.Location = new System.Drawing.Point(242, 28);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(227, 25);
            this.txtPesquisa.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Pesquisar ( Identificacao ):";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.cbmPedagios);
            this.groupBox2.Controls.Add(this.btnPagarPedagio);
            this.groupBox2.Controls.Add(this.btnAlterarLimpador);
            this.groupBox2.Controls.Add(this.ucAcelerar);
            this.groupBox2.Controls.Add(this.ucDesacelerar);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(365, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 283);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ações";
            // 
            // cbmPedagios
            // 
            this.cbmPedagios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmPedagios.FormattingEnabled = true;
            this.cbmPedagios.Location = new System.Drawing.Point(6, 243);
            this.cbmPedagios.Name = "cbmPedagios";
            this.cbmPedagios.Size = new System.Drawing.Size(186, 25);
            this.cbmPedagios.TabIndex = 30;
            // 
            // btnPagarPedagio
            // 
            this.btnPagarPedagio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnPagarPedagio.FlatAppearance.BorderSize = 0;
            this.btnPagarPedagio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnPagarPedagio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarPedagio.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarPedagio.ForeColor = System.Drawing.Color.White;
            this.btnPagarPedagio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagarPedagio.Location = new System.Drawing.Point(6, 187);
            this.btnPagarPedagio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPagarPedagio.Name = "btnPagarPedagio";
            this.btnPagarPedagio.Size = new System.Drawing.Size(186, 46);
            this.btnPagarPedagio.TabIndex = 25;
            this.btnPagarPedagio.Text = "Pagar Pedagio";
            this.btnPagarPedagio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPagarPedagio.UseVisualStyleBackColor = false;
            this.btnPagarPedagio.Click += new System.EventHandler(this.btnPagarPedagio_Click);
            // 
            // btnAlterarLimpador
            // 
            this.btnAlterarLimpador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAlterarLimpador.FlatAppearance.BorderSize = 0;
            this.btnAlterarLimpador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnAlterarLimpador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarLimpador.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarLimpador.ForeColor = System.Drawing.Color.White;
            this.btnAlterarLimpador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarLimpador.Location = new System.Drawing.Point(6, 133);
            this.btnAlterarLimpador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterarLimpador.Name = "btnAlterarLimpador";
            this.btnAlterarLimpador.Size = new System.Drawing.Size(186, 46);
            this.btnAlterarLimpador.TabIndex = 24;
            this.btnAlterarLimpador.Text = "Alterar Limpador";
            this.btnAlterarLimpador.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlterarLimpador.UseVisualStyleBackColor = false;
            this.btnAlterarLimpador.Click += new System.EventHandler(this.btnAlterarLimpador_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnProximo.FlatAppearance.BorderSize = 0;
            this.btnProximo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.Color.White;
            this.btnProximo.Image = global::Projeto_N2_POO.Properties.Resources.SetaProximo;
            this.btnProximo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProximo.Location = new System.Drawing.Point(190, 338);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(150, 46);
            this.btnProximo.TabIndex = 20;
            this.btnProximo.Text = "Proximo";
            this.btnProximo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProximo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Image = global::Projeto_N2_POO.Properties.Resources.SetaAnterior;
            this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnterior.Location = new System.Drawing.Point(12, 338);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(150, 46);
            this.btnAnterior.TabIndex = 19;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisa.FlatAppearance.BorderSize = 0;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Image = global::Projeto_N2_POO.Properties.Resources.Lupa;
            this.btnPesquisa.Location = new System.Drawing.Point(475, 24);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(30, 30);
            this.btnPesquisa.TabIndex = 23;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // ucPossuiLeito
            // 
            this.ucPossuiLeito.BackColor = System.Drawing.Color.Transparent;
            this.ucPossuiLeito.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucPossuiLeito.ForeColor = System.Drawing.Color.White;
            this.ucPossuiLeito.Location = new System.Drawing.Point(12, 259);
            this.ucPossuiLeito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucPossuiLeito.Name = "ucPossuiLeito";
            this.ucPossuiLeito.Size = new System.Drawing.Size(328, 22);
            this.ucPossuiLeito.TabIndex = 27;
            this.ucPossuiLeito.TextoLabel1 = "Possui Leito";
            this.ucPossuiLeito.TextoLabel2 = "label1";
            // 
            // ucVelocidade
            // 
            this.ucVelocidade.BackColor = System.Drawing.Color.Transparent;
            this.ucVelocidade.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucVelocidade.ForeColor = System.Drawing.Color.White;
            this.ucVelocidade.Location = new System.Drawing.Point(12, 133);
            this.ucVelocidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucVelocidade.Name = "ucVelocidade";
            this.ucVelocidade.Size = new System.Drawing.Size(328, 22);
            this.ucVelocidade.TabIndex = 26;
            this.ucVelocidade.TextoLabel1 = "Velocidade:";
            this.ucVelocidade.TextoLabel2 = "label1";
            // 
            // ucQtdDeEixos
            // 
            this.ucQtdDeEixos.BackColor = System.Drawing.Color.Transparent;
            this.ucQtdDeEixos.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucQtdDeEixos.ForeColor = System.Drawing.Color.White;
            this.ucQtdDeEixos.Location = new System.Drawing.Point(12, 197);
            this.ucQtdDeEixos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucQtdDeEixos.Name = "ucQtdDeEixos";
            this.ucQtdDeEixos.Size = new System.Drawing.Size(328, 22);
            this.ucQtdDeEixos.TabIndex = 24;
            this.ucQtdDeEixos.TextoLabel1 = "Quantidade de Eixos:";
            this.ucQtdDeEixos.TextoLabel2 = "label1";
            // 
            // ucEstadoLimpador
            // 
            this.ucEstadoLimpador.BackColor = System.Drawing.Color.Transparent;
            this.ucEstadoLimpador.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucEstadoLimpador.ForeColor = System.Drawing.Color.White;
            this.ucEstadoLimpador.Location = new System.Drawing.Point(12, 165);
            this.ucEstadoLimpador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucEstadoLimpador.Name = "ucEstadoLimpador";
            this.ucEstadoLimpador.Size = new System.Drawing.Size(328, 22);
            this.ucEstadoLimpador.TabIndex = 23;
            this.ucEstadoLimpador.TextoLabel1 = "Estado do Limpador:";
            this.ucEstadoLimpador.TextoLabel2 = "label1";
            // 
            // ucQtdPassageiro
            // 
            this.ucQtdPassageiro.BackColor = System.Drawing.Color.Transparent;
            this.ucQtdPassageiro.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucQtdPassageiro.ForeColor = System.Drawing.Color.White;
            this.ucQtdPassageiro.Location = new System.Drawing.Point(12, 229);
            this.ucQtdPassageiro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucQtdPassageiro.Name = "ucQtdPassageiro";
            this.ucQtdPassageiro.Size = new System.Drawing.Size(328, 22);
            this.ucQtdPassageiro.TabIndex = 22;
            this.ucQtdPassageiro.TextoLabel1 = "Capacidade de Passageiro:";
            this.ucQtdPassageiro.TextoLabel2 = "label1";
            // 
            // ucModelo
            // 
            this.ucModelo.BackColor = System.Drawing.Color.Transparent;
            this.ucModelo.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucModelo.ForeColor = System.Drawing.Color.White;
            this.ucModelo.Location = new System.Drawing.Point(12, 101);
            this.ucModelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucModelo.Name = "ucModelo";
            this.ucModelo.Size = new System.Drawing.Size(328, 22);
            this.ucModelo.TabIndex = 2;
            this.ucModelo.TextoLabel1 = "Modelo:";
            this.ucModelo.TextoLabel2 = "label1";
            // 
            // ucMarca
            // 
            this.ucMarca.BackColor = System.Drawing.Color.Transparent;
            this.ucMarca.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucMarca.ForeColor = System.Drawing.Color.White;
            this.ucMarca.Location = new System.Drawing.Point(12, 69);
            this.ucMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucMarca.Name = "ucMarca";
            this.ucMarca.Size = new System.Drawing.Size(328, 22);
            this.ucMarca.TabIndex = 1;
            this.ucMarca.TextoLabel1 = "Marca:";
            this.ucMarca.TextoLabel2 = "label1";
            // 
            // ucIdentificacao
            // 
            this.ucIdentificacao.BackColor = System.Drawing.Color.Transparent;
            this.ucIdentificacao.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucIdentificacao.ForeColor = System.Drawing.Color.White;
            this.ucIdentificacao.Location = new System.Drawing.Point(12, 37);
            this.ucIdentificacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucIdentificacao.Name = "ucIdentificacao";
            this.ucIdentificacao.Size = new System.Drawing.Size(328, 22);
            this.ucIdentificacao.TabIndex = 0;
            this.ucIdentificacao.TextoLabel1 = "Identificação:";
            this.ucIdentificacao.TextoLabel2 = "label1";
            // 
            // ucAcelerar
            // 
            this.ucAcelerar.BackColor = System.Drawing.Color.Transparent;
            this.ucAcelerar.Location = new System.Drawing.Point(6, 25);
            this.ucAcelerar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucAcelerar.Name = "ucAcelerar";
            this.ucAcelerar.Size = new System.Drawing.Size(186, 46);
            this.ucAcelerar.TabIndex = 33;
            this.ucAcelerar.VeiculoControlado = null;
            // 
            // ucDesacelerar
            // 
            this.ucDesacelerar.BackColor = System.Drawing.Color.Transparent;
            this.ucDesacelerar.Location = new System.Drawing.Point(6, 79);
            this.ucDesacelerar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucDesacelerar.Name = "ucDesacelerar";
            this.ucDesacelerar.Size = new System.Drawing.Size(186, 46);
            this.ucDesacelerar.TabIndex = 34;
            this.ucDesacelerar.VeiculoControlado = null;
            // 
            // frGerenciarOnibus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frGerenciarOnibus";
            this.Text = "frGerenciarOnibus";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private User_Controls.ucLabelComTextoVariavel ucVelocidade;
        private User_Controls.ucLabelComTextoVariavel ucQtdDeEixos;
        private User_Controls.ucLabelComTextoVariavel ucEstadoLimpador;
        private User_Controls.ucLabelComTextoVariavel ucQtdPassageiro;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private User_Controls.ucLabelComTextoVariavel ucModelo;
        private User_Controls.ucLabelComTextoVariavel ucMarca;
        private User_Controls.ucLabelComTextoVariavel ucIdentificacao;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbmPedagios;
        private System.Windows.Forms.Button btnPagarPedagio;
        private System.Windows.Forms.Button btnAlterarLimpador;
        private User_Controls.ucLabelComTextoVariavel ucPossuiLeito;
        private User_Controls.ucAcelerar ucAcelerar;
        private User_Controls.ucDesacelerar ucDesacelerar;
    }
}