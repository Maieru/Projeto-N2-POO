
namespace Projeto_N2_POO.Forms
{
    partial class frGerenciarPedagio
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
            this.ucQtdCadastrado = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucValorTotalRecebido = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.ucValorArrecadado = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucLocalizacao = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucIdentificacao = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucQtdCadastrado
            // 
            this.ucQtdCadastrado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucQtdCadastrado.BackColor = System.Drawing.Color.Transparent;
            this.ucQtdCadastrado.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucQtdCadastrado.ForeColor = System.Drawing.Color.White;
            this.ucQtdCadastrado.Location = new System.Drawing.Point(125, 36);
            this.ucQtdCadastrado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucQtdCadastrado.Name = "ucQtdCadastrado";
            this.ucQtdCadastrado.Size = new System.Drawing.Size(324, 22);
            this.ucQtdCadastrado.TabIndex = 0;
            this.ucQtdCadastrado.TextoLabel1 = "Quantidade de Pedagios Cadastrados: ";
            this.ucQtdCadastrado.TextoLabel2 = "label1";
            // 
            // ucValorTotalRecebido
            // 
            this.ucValorTotalRecebido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucValorTotalRecebido.BackColor = System.Drawing.Color.Transparent;
            this.ucValorTotalRecebido.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucValorTotalRecebido.ForeColor = System.Drawing.Color.White;
            this.ucValorTotalRecebido.Location = new System.Drawing.Point(125, 76);
            this.ucValorTotalRecebido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucValorTotalRecebido.Name = "ucValorTotalRecebido";
            this.ucValorTotalRecebido.Size = new System.Drawing.Size(324, 22);
            this.ucValorTotalRecebido.TabIndex = 1;
            this.ucValorTotalRecebido.TextoLabel1 = "Quantidade Total de Valor Recebido:";
            this.ucValorTotalRecebido.TextoLabel2 = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnProximo);
            this.groupBox1.Controls.Add(this.btnAnterior);
            this.groupBox1.Controls.Add(this.ucValorArrecadado);
            this.groupBox1.Controls.Add(this.ucLocalizacao);
            this.groupBox1.Controls.Add(this.ucIdentificacao);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(72, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 306);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa:";
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
            this.btnProximo.Location = new System.Drawing.Point(256, 243);
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
            this.btnAnterior.Location = new System.Drawing.Point(25, 243);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(150, 46);
            this.btnAnterior.TabIndex = 19;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // ucValorArrecadado
            // 
            this.ucValorArrecadado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucValorArrecadado.BackColor = System.Drawing.Color.Transparent;
            this.ucValorArrecadado.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucValorArrecadado.ForeColor = System.Drawing.Color.White;
            this.ucValorArrecadado.Location = new System.Drawing.Point(71, 186);
            this.ucValorArrecadado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucValorArrecadado.Name = "ucValorArrecadado";
            this.ucValorArrecadado.Size = new System.Drawing.Size(289, 22);
            this.ucValorArrecadado.TabIndex = 2;
            this.ucValorArrecadado.TextoLabel1 = "Valor Arrecadado:";
            this.ucValorArrecadado.TextoLabel2 = "label1";
            // 
            // ucLocalizacao
            // 
            this.ucLocalizacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucLocalizacao.BackColor = System.Drawing.Color.Transparent;
            this.ucLocalizacao.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucLocalizacao.ForeColor = System.Drawing.Color.White;
            this.ucLocalizacao.Location = new System.Drawing.Point(71, 119);
            this.ucLocalizacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucLocalizacao.Name = "ucLocalizacao";
            this.ucLocalizacao.Size = new System.Drawing.Size(289, 22);
            this.ucLocalizacao.TabIndex = 1;
            this.ucLocalizacao.TextoLabel1 = "Localização:";
            this.ucLocalizacao.TextoLabel2 = "label1";
            // 
            // ucIdentificacao
            // 
            this.ucIdentificacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucIdentificacao.BackColor = System.Drawing.Color.Transparent;
            this.ucIdentificacao.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucIdentificacao.ForeColor = System.Drawing.Color.White;
            this.ucIdentificacao.Location = new System.Drawing.Point(71, 52);
            this.ucIdentificacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucIdentificacao.Name = "ucIdentificacao";
            this.ucIdentificacao.Size = new System.Drawing.Size(289, 22);
            this.ucIdentificacao.TabIndex = 0;
            this.ucIdentificacao.TextoLabel1 = "Identificação:";
            this.ucIdentificacao.TextoLabel2 = "label1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisar ( Identificação ):";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisa.Location = new System.Drawing.Point(240, 116);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(227, 25);
            this.txtPesquisa.TabIndex = 4;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisa.FlatAppearance.BorderSize = 0;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Image = global::Projeto_N2_POO.Properties.Resources.Lupa;
            this.btnPesquisa.Location = new System.Drawing.Point(473, 112);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(30, 30);
            this.btnPesquisa.TabIndex = 5;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // frGerenciarPedagio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 500);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucValorTotalRecebido);
            this.Controls.Add(this.ucQtdCadastrado);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frGerenciarPedagio";
            this.Text = "frGerenciarPedagio";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.ucLabelComTextoVariavel ucQtdCadastrado;
        private User_Controls.ucLabelComTextoVariavel ucValorTotalRecebido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisa;
        private User_Controls.ucLabelComTextoVariavel ucValorArrecadado;
        private User_Controls.ucLabelComTextoVariavel ucLocalizacao;
        private User_Controls.ucLabelComTextoVariavel ucIdentificacao;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
    }
}