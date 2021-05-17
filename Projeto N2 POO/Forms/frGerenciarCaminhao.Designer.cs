
namespace Projeto_N2_POO.Forms
{
    partial class frGerenciarCaminhao
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ucAcelerar = new Projeto_N2_POO.User_Controls.ucAcelerar();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmPedagios = new System.Windows.Forms.ComboBox();
            this.btnPagarPedagio = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnDescarregar = new System.Windows.Forms.Button();
            this.btnAlterarLimpador = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucVelocidade = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucCapacidadeDeCarga = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucQtdDeEixos = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucEstadoLimpador = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucQtdPassageiro = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucPesoCarregado = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.ucModelo = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucMarca = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucIdentificacao = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.ucDesacelerar = new Projeto_N2_POO.User_Controls.ucDesacelerar();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.ucAcelerar);
            this.groupBox2.Controls.Add(this.txtValor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbmPedagios);
            this.groupBox2.Controls.Add(this.btnPagarPedagio);
            this.groupBox2.Controls.Add(this.btnCarregar);
            this.groupBox2.Controls.Add(this.btnDescarregar);
            this.groupBox2.Controls.Add(this.btnAlterarLimpador);
            this.groupBox2.Controls.Add(this.ucDesacelerar);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(365, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 400);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ações";
            // 
            // ucAcelerar
            // 
            this.ucAcelerar.BackColor = System.Drawing.Color.Transparent;
            this.ucAcelerar.Location = new System.Drawing.Point(6, 25);
            this.ucAcelerar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucAcelerar.Name = "ucAcelerar";
            this.ucAcelerar.Size = new System.Drawing.Size(186, 46);
            this.ucAcelerar.TabIndex = 37;
            this.ucAcelerar.VeiculoControlado = null;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(79, 254);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(113, 25);
            this.txtValor.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Valor (kg):";
            // 
            // cbmPedagios
            // 
            this.cbmPedagios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmPedagios.FormattingEnabled = true;
            this.cbmPedagios.Location = new System.Drawing.Point(6, 225);
            this.cbmPedagios.Name = "cbmPedagios";
            this.cbmPedagios.Size = new System.Drawing.Size(186, 25);
            this.cbmPedagios.TabIndex = 32;
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
            this.btnPagarPedagio.Location = new System.Drawing.Point(6, 175);
            this.btnPagarPedagio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPagarPedagio.Name = "btnPagarPedagio";
            this.btnPagarPedagio.Size = new System.Drawing.Size(186, 46);
            this.btnPagarPedagio.TabIndex = 31;
            this.btnPagarPedagio.Text = "Pagar Pedagio";
            this.btnPagarPedagio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPagarPedagio.UseVisualStyleBackColor = false;
            this.btnPagarPedagio.Click += new System.EventHandler(this.btnPagarPedagio_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCarregar.FlatAppearance.BorderSize = 0;
            this.btnCarregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregar.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.ForeColor = System.Drawing.Color.White;
            this.btnCarregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarregar.Location = new System.Drawing.Point(6, 283);
            this.btnCarregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(186, 46);
            this.btnCarregar.TabIndex = 27;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCarregar.UseVisualStyleBackColor = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnDescarregar
            // 
            this.btnDescarregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDescarregar.FlatAppearance.BorderSize = 0;
            this.btnDescarregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnDescarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescarregar.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescarregar.ForeColor = System.Drawing.Color.White;
            this.btnDescarregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescarregar.Location = new System.Drawing.Point(6, 333);
            this.btnDescarregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDescarregar.Name = "btnDescarregar";
            this.btnDescarregar.Size = new System.Drawing.Size(186, 46);
            this.btnDescarregar.TabIndex = 26;
            this.btnDescarregar.Text = "Descarregar";
            this.btnDescarregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDescarregar.UseVisualStyleBackColor = false;
            this.btnDescarregar.Click += new System.EventHandler(this.btnDescarregar_Click);
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
            this.btnAlterarLimpador.Location = new System.Drawing.Point(6, 125);
            this.btnAlterarLimpador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterarLimpador.Name = "btnAlterarLimpador";
            this.btnAlterarLimpador.Size = new System.Drawing.Size(186, 46);
            this.btnAlterarLimpador.TabIndex = 24;
            this.btnAlterarLimpador.Text = "Alterar Limpador";
            this.btnAlterarLimpador.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlterarLimpador.UseVisualStyleBackColor = false;
            this.btnAlterarLimpador.Click += new System.EventHandler(this.btnAlterarLimpador_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.ucVelocidade);
            this.groupBox1.Controls.Add(this.ucCapacidadeDeCarga);
            this.groupBox1.Controls.Add(this.ucQtdDeEixos);
            this.groupBox1.Controls.Add(this.ucEstadoLimpador);
            this.groupBox1.Controls.Add(this.ucQtdPassageiro);
            this.groupBox1.Controls.Add(this.ucPesoCarregado);
            this.groupBox1.Controls.Add(this.btnProximo);
            this.groupBox1.Controls.Add(this.btnAnterior);
            this.groupBox1.Controls.Add(this.ucModelo);
            this.groupBox1.Controls.Add(this.ucMarca);
            this.groupBox1.Controls.Add(this.ucIdentificacao);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 400);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa:";
            // 
            // ucVelocidade
            // 
            this.ucVelocidade.BackColor = System.Drawing.Color.Transparent;
            this.ucVelocidade.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucVelocidade.ForeColor = System.Drawing.Color.White;
            this.ucVelocidade.Location = new System.Drawing.Point(12, 115);
            this.ucVelocidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucVelocidade.Name = "ucVelocidade";
            this.ucVelocidade.Size = new System.Drawing.Size(328, 22);
            this.ucVelocidade.TabIndex = 26;
            this.ucVelocidade.TextoLabel1 = "Velocidade:";
            this.ucVelocidade.TextoLabel2 = "label1";
            // 
            // ucCapacidadeDeCarga
            // 
            this.ucCapacidadeDeCarga.BackColor = System.Drawing.Color.Transparent;
            this.ucCapacidadeDeCarga.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucCapacidadeDeCarga.ForeColor = System.Drawing.Color.White;
            this.ucCapacidadeDeCarga.Location = new System.Drawing.Point(12, 175);
            this.ucCapacidadeDeCarga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucCapacidadeDeCarga.Name = "ucCapacidadeDeCarga";
            this.ucCapacidadeDeCarga.Size = new System.Drawing.Size(328, 22);
            this.ucCapacidadeDeCarga.TabIndex = 25;
            this.ucCapacidadeDeCarga.TextoLabel1 = "Capacidade Máxima de Carga:";
            this.ucCapacidadeDeCarga.TextoLabel2 = "label1";
            // 
            // ucQtdDeEixos
            // 
            this.ucQtdDeEixos.BackColor = System.Drawing.Color.Transparent;
            this.ucQtdDeEixos.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucQtdDeEixos.ForeColor = System.Drawing.Color.White;
            this.ucQtdDeEixos.Location = new System.Drawing.Point(12, 265);
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
            this.ucEstadoLimpador.Location = new System.Drawing.Point(12, 235);
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
            this.ucQtdPassageiro.Location = new System.Drawing.Point(12, 205);
            this.ucQtdPassageiro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucQtdPassageiro.Name = "ucQtdPassageiro";
            this.ucQtdPassageiro.Size = new System.Drawing.Size(328, 22);
            this.ucQtdPassageiro.TabIndex = 22;
            this.ucQtdPassageiro.TextoLabel1 = "Capacidade de Passageiro:";
            this.ucQtdPassageiro.TextoLabel2 = "label1";
            // 
            // ucPesoCarregado
            // 
            this.ucPesoCarregado.BackColor = System.Drawing.Color.Transparent;
            this.ucPesoCarregado.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucPesoCarregado.ForeColor = System.Drawing.Color.White;
            this.ucPesoCarregado.Location = new System.Drawing.Point(12, 145);
            this.ucPesoCarregado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucPesoCarregado.Name = "ucPesoCarregado";
            this.ucPesoCarregado.Size = new System.Drawing.Size(328, 22);
            this.ucPesoCarregado.TabIndex = 21;
            this.ucPesoCarregado.TextoLabel1 = "Peso Carregado:";
            this.ucPesoCarregado.TextoLabel2 = "label1";
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
            // ucModelo
            // 
            this.ucModelo.BackColor = System.Drawing.Color.Transparent;
            this.ucModelo.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucModelo.ForeColor = System.Drawing.Color.White;
            this.ucModelo.Location = new System.Drawing.Point(12, 85);
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
            this.ucMarca.Location = new System.Drawing.Point(12, 55);
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
            this.ucIdentificacao.Location = new System.Drawing.Point(12, 25);
            this.ucIdentificacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucIdentificacao.Name = "ucIdentificacao";
            this.ucIdentificacao.Size = new System.Drawing.Size(328, 22);
            this.ucIdentificacao.TabIndex = 0;
            this.ucIdentificacao.TextoLabel1 = "Identificação:";
            this.ucIdentificacao.TextoLabel2 = "label1";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisa.Location = new System.Drawing.Point(242, 27);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(227, 25);
            this.txtPesquisa.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pesquisar ( Identificacao ):";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisa.FlatAppearance.BorderSize = 0;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Image = global::Projeto_N2_POO.Properties.Resources.Lupa;
            this.btnPesquisa.Location = new System.Drawing.Point(475, 23);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(30, 30);
            this.btnPesquisa.TabIndex = 18;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // ucDesacelerar
            // 
            this.ucDesacelerar.BackColor = System.Drawing.Color.Transparent;
            this.ucDesacelerar.Location = new System.Drawing.Point(6, 75);
            this.ucDesacelerar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucDesacelerar.Name = "ucDesacelerar";
            this.ucDesacelerar.Size = new System.Drawing.Size(186, 46);
            this.ucDesacelerar.TabIndex = 38;
            this.ucDesacelerar.VeiculoControlado = null;
            // 
            // frGerenciarCaminhao
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
            this.Name = "frGerenciarCaminhao";
            this.Text = "frGerenciaCaminhao";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAlterarLimpador;
        private System.Windows.Forms.GroupBox groupBox1;
        private User_Controls.ucLabelComTextoVariavel ucEstadoLimpador;
        private User_Controls.ucLabelComTextoVariavel ucQtdPassageiro;
        private User_Controls.ucLabelComTextoVariavel ucPesoCarregado;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private User_Controls.ucLabelComTextoVariavel ucModelo;
        private User_Controls.ucLabelComTextoVariavel ucMarca;
        private User_Controls.ucLabelComTextoVariavel ucIdentificacao;
        private System.Windows.Forms.Button btnDescarregar;
        private User_Controls.ucLabelComTextoVariavel ucCapacidadeDeCarga;
        private User_Controls.ucLabelComTextoVariavel ucQtdDeEixos;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ComboBox cbmPedagios;
        private System.Windows.Forms.Button btnPagarPedagio;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private User_Controls.ucLabelComTextoVariavel ucVelocidade;
        private User_Controls.ucAcelerar ucAcelerar;
        private User_Controls.ucDesacelerar ucDesacelerar;
    }
}