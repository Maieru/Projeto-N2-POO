
namespace Projeto_N2_POO.Forms
{
    partial class frGerenciarAviaoDeGuerra
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
            this.btnArremeter = new System.Windows.Forms.Button();
            this.btnDecolar = new System.Windows.Forms.Button();
            this.btnPousar = new System.Windows.Forms.Button();
            this.ucAcelerar = new Projeto_N2_POO.User_Controls.ucAcelerar();
            this.ucDesacelerar = new Projeto_N2_POO.User_Controls.ucDesacelerar();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucVelocidade = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucQtdPassageiro = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.ucModelo = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucMarca = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucIdentificacao = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucVoando = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.btnEjetar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.btnEjetar);
            this.groupBox2.Controls.Add(this.btnAtacar);
            this.groupBox2.Controls.Add(this.btnArremeter);
            this.groupBox2.Controls.Add(this.btnDecolar);
            this.groupBox2.Controls.Add(this.btnPousar);
            this.groupBox2.Controls.Add(this.ucAcelerar);
            this.groupBox2.Controls.Add(this.ucDesacelerar);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(365, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 400);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ações";
            // 
            // btnArremeter
            // 
            this.btnArremeter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnArremeter.FlatAppearance.BorderSize = 0;
            this.btnArremeter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnArremeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArremeter.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArremeter.ForeColor = System.Drawing.Color.White;
            this.btnArremeter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArremeter.Location = new System.Drawing.Point(6, 290);
            this.btnArremeter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnArremeter.Name = "btnArremeter";
            this.btnArremeter.Size = new System.Drawing.Size(186, 46);
            this.btnArremeter.TabIndex = 37;
            this.btnArremeter.Text = "Arremeter";
            this.btnArremeter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnArremeter.UseVisualStyleBackColor = false;
            this.btnArremeter.Click += new System.EventHandler(this.btnArremeter_Click);
            // 
            // btnDecolar
            // 
            this.btnDecolar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDecolar.FlatAppearance.BorderSize = 0;
            this.btnDecolar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnDecolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecolar.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecolar.ForeColor = System.Drawing.Color.White;
            this.btnDecolar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecolar.Location = new System.Drawing.Point(6, 237);
            this.btnDecolar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDecolar.Name = "btnDecolar";
            this.btnDecolar.Size = new System.Drawing.Size(186, 46);
            this.btnDecolar.TabIndex = 36;
            this.btnDecolar.Text = "Decolar";
            this.btnDecolar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDecolar.UseVisualStyleBackColor = false;
            this.btnDecolar.Click += new System.EventHandler(this.btnDecolar_Click);
            // 
            // btnPousar
            // 
            this.btnPousar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnPousar.FlatAppearance.BorderSize = 0;
            this.btnPousar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnPousar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPousar.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPousar.ForeColor = System.Drawing.Color.White;
            this.btnPousar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPousar.Location = new System.Drawing.Point(6, 184);
            this.btnPousar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPousar.Name = "btnPousar";
            this.btnPousar.Size = new System.Drawing.Size(186, 46);
            this.btnPousar.TabIndex = 35;
            this.btnPousar.Text = "Pousar";
            this.btnPousar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPousar.UseVisualStyleBackColor = false;
            this.btnPousar.Click += new System.EventHandler(this.btnPousar_Click);
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
            this.ucDesacelerar.Location = new System.Drawing.Point(6, 78);
            this.ucDesacelerar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucDesacelerar.Name = "ucDesacelerar";
            this.ucDesacelerar.Size = new System.Drawing.Size(186, 46);
            this.ucDesacelerar.TabIndex = 34;
            this.ucDesacelerar.VeiculoControlado = null;
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
            this.btnPesquisa.TabIndex = 24;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisa.Location = new System.Drawing.Point(242, 27);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(227, 25);
            this.txtPesquisa.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Pesquisar ( Identificacao ):";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.ucVelocidade);
            this.groupBox1.Controls.Add(this.ucQtdPassageiro);
            this.groupBox1.Controls.Add(this.btnProximo);
            this.groupBox1.Controls.Add(this.btnAnterior);
            this.groupBox1.Controls.Add(this.ucModelo);
            this.groupBox1.Controls.Add(this.ucMarca);
            this.groupBox1.Controls.Add(this.ucIdentificacao);
            this.groupBox1.Controls.Add(this.ucVoando);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 400);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa:";
            // 
            // ucVelocidade
            // 
            this.ucVelocidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucVelocidade.BackColor = System.Drawing.Color.Transparent;
            this.ucVelocidade.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucVelocidade.ForeColor = System.Drawing.Color.White;
            this.ucVelocidade.Location = new System.Drawing.Point(12, 127);
            this.ucVelocidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucVelocidade.Name = "ucVelocidade";
            this.ucVelocidade.Size = new System.Drawing.Size(328, 22);
            this.ucVelocidade.TabIndex = 24;
            this.ucVelocidade.TextoLabel1 = "Velocidade:";
            this.ucVelocidade.TextoLabel2 = "label1";
            // 
            // ucQtdPassageiro
            // 
            this.ucQtdPassageiro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucQtdPassageiro.BackColor = System.Drawing.Color.Transparent;
            this.ucQtdPassageiro.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucQtdPassageiro.ForeColor = System.Drawing.Color.White;
            this.ucQtdPassageiro.Location = new System.Drawing.Point(12, 195);
            this.ucQtdPassageiro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucQtdPassageiro.Name = "ucQtdPassageiro";
            this.ucQtdPassageiro.Size = new System.Drawing.Size(328, 22);
            this.ucQtdPassageiro.TabIndex = 22;
            this.ucQtdPassageiro.TextoLabel1 = "Capacidade de Passageiro:";
            this.ucQtdPassageiro.TextoLabel2 = "label1";
            // 
            // btnProximo
            // 
            this.btnProximo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnProximo.FlatAppearance.BorderSize = 0;
            this.btnProximo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.Color.White;
            this.btnProximo.Image = global::Projeto_N2_POO.Properties.Resources.SetaProximo;
            this.btnProximo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProximo.Location = new System.Drawing.Point(190, 347);
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
            this.btnAnterior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Image = global::Projeto_N2_POO.Properties.Resources.SetaAnterior;
            this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnterior.Location = new System.Drawing.Point(12, 347);
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
            this.ucModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucModelo.BackColor = System.Drawing.Color.Transparent;
            this.ucModelo.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucModelo.ForeColor = System.Drawing.Color.White;
            this.ucModelo.Location = new System.Drawing.Point(12, 93);
            this.ucModelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucModelo.Name = "ucModelo";
            this.ucModelo.Size = new System.Drawing.Size(328, 22);
            this.ucModelo.TabIndex = 2;
            this.ucModelo.TextoLabel1 = "Modelo:";
            this.ucModelo.TextoLabel2 = "label1";
            // 
            // ucMarca
            // 
            this.ucMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucMarca.BackColor = System.Drawing.Color.Transparent;
            this.ucMarca.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucMarca.ForeColor = System.Drawing.Color.White;
            this.ucMarca.Location = new System.Drawing.Point(12, 59);
            this.ucMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucMarca.Name = "ucMarca";
            this.ucMarca.Size = new System.Drawing.Size(328, 22);
            this.ucMarca.TabIndex = 1;
            this.ucMarca.TextoLabel1 = "Marca:";
            this.ucMarca.TextoLabel2 = "label1";
            // 
            // ucIdentificacao
            // 
            this.ucIdentificacao.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            // ucVoando
            // 
            this.ucVoando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucVoando.BackColor = System.Drawing.Color.Transparent;
            this.ucVoando.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucVoando.ForeColor = System.Drawing.Color.White;
            this.ucVoando.Location = new System.Drawing.Point(12, 161);
            this.ucVoando.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucVoando.Name = "ucVoando";
            this.ucVoando.Size = new System.Drawing.Size(328, 22);
            this.ucVoando.TabIndex = 25;
            this.ucVoando.TextoLabel1 = "Está em Voo:";
            this.ucVoando.TextoLabel2 = "label1";
            // 
            // btnAtacar
            // 
            this.btnAtacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAtacar.FlatAppearance.BorderSize = 0;
            this.btnAtacar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnAtacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtacar.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtacar.ForeColor = System.Drawing.Color.White;
            this.btnAtacar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtacar.Location = new System.Drawing.Point(6, 131);
            this.btnAtacar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(186, 46);
            this.btnAtacar.TabIndex = 38;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAtacar.UseVisualStyleBackColor = false;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // btnEjetar
            // 
            this.btnEjetar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnEjetar.FlatAppearance.BorderSize = 0;
            this.btnEjetar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnEjetar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjetar.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjetar.ForeColor = System.Drawing.Color.White;
            this.btnEjetar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEjetar.Location = new System.Drawing.Point(6, 343);
            this.btnEjetar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEjetar.Name = "btnEjetar";
            this.btnEjetar.Size = new System.Drawing.Size(186, 46);
            this.btnEjetar.TabIndex = 39;
            this.btnEjetar.Text = "Ejetar";
            this.btnEjetar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEjetar.UseVisualStyleBackColor = false;
            this.btnEjetar.Click += new System.EventHandler(this.btnEjetar_Click);
            // 
            // frGerenciarAviaoDeGuerra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frGerenciarAviaoDeGuerra";
            this.Text = "frGerenciarAviaoDeGuerra";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnArremeter;
        private System.Windows.Forms.Button btnDecolar;
        private System.Windows.Forms.Button btnPousar;
        private User_Controls.ucAcelerar ucAcelerar;
        private User_Controls.ucDesacelerar ucDesacelerar;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private User_Controls.ucLabelComTextoVariavel ucVelocidade;
        private User_Controls.ucLabelComTextoVariavel ucQtdPassageiro;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private User_Controls.ucLabelComTextoVariavel ucModelo;
        private User_Controls.ucLabelComTextoVariavel ucMarca;
        private User_Controls.ucLabelComTextoVariavel ucIdentificacao;
        private User_Controls.ucLabelComTextoVariavel ucVoando;
        private System.Windows.Forms.Button btnEjetar;
        private System.Windows.Forms.Button btnAtacar;
    }
}