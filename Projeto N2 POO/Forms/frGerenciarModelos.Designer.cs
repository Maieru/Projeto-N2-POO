
namespace Projeto_N2_POO.Forms
{
    partial class frGerenciarModelos
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
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.ucMarca = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucDescricao = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucCodigo = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.ucQtdCadastrado = new Projeto_N2_POO.User_Controls.ucLabelComTextoVariavel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisa.FlatAppearance.BorderSize = 0;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Image = global::Projeto_N2_POO.Properties.Resources.Lupa;
            this.btnPesquisa.Location = new System.Drawing.Point(475, 111);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(30, 30);
            this.btnPesquisa.TabIndex = 11;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisa.Location = new System.Drawing.Point(242, 115);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(227, 25);
            this.txtPesquisa.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pesquisar ( Codigo ):";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnProximo);
            this.groupBox1.Controls.Add(this.btnAnterior);
            this.groupBox1.Controls.Add(this.ucMarca);
            this.groupBox1.Controls.Add(this.ucDescricao);
            this.groupBox1.Controls.Add(this.ucCodigo);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(74, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 306);
            this.groupBox1.TabIndex = 8;
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
            // ucMarca
            // 
            this.ucMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucMarca.BackColor = System.Drawing.Color.Transparent;
            this.ucMarca.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucMarca.ForeColor = System.Drawing.Color.White;
            this.ucMarca.Location = new System.Drawing.Point(71, 186);
            this.ucMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucMarca.Name = "ucMarca";
            this.ucMarca.Size = new System.Drawing.Size(289, 22);
            this.ucMarca.TabIndex = 2;
            this.ucMarca.TextoLabel1 = "Marca:";
            this.ucMarca.TextoLabel2 = "label1";
            // 
            // ucDescricao
            // 
            this.ucDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucDescricao.BackColor = System.Drawing.Color.Transparent;
            this.ucDescricao.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucDescricao.ForeColor = System.Drawing.Color.White;
            this.ucDescricao.Location = new System.Drawing.Point(71, 119);
            this.ucDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucDescricao.Name = "ucDescricao";
            this.ucDescricao.Size = new System.Drawing.Size(289, 22);
            this.ucDescricao.TabIndex = 1;
            this.ucDescricao.TextoLabel1 = "Descrição:";
            this.ucDescricao.TextoLabel2 = "label1";
            // 
            // ucCodigo
            // 
            this.ucCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucCodigo.BackColor = System.Drawing.Color.Transparent;
            this.ucCodigo.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucCodigo.ForeColor = System.Drawing.Color.White;
            this.ucCodigo.Location = new System.Drawing.Point(71, 52);
            this.ucCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucCodigo.Name = "ucCodigo";
            this.ucCodigo.Size = new System.Drawing.Size(289, 22);
            this.ucCodigo.TabIndex = 0;
            this.ucCodigo.TextoLabel1 = "Código:";
            this.ucCodigo.TextoLabel2 = "label1";
            // 
            // ucQtdCadastrado
            // 
            this.ucQtdCadastrado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucQtdCadastrado.BackColor = System.Drawing.Color.Transparent;
            this.ucQtdCadastrado.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucQtdCadastrado.ForeColor = System.Drawing.Color.White;
            this.ucQtdCadastrado.Location = new System.Drawing.Point(127, 66);
            this.ucQtdCadastrado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucQtdCadastrado.Name = "ucQtdCadastrado";
            this.ucQtdCadastrado.Size = new System.Drawing.Size(324, 22);
            this.ucQtdCadastrado.TabIndex = 6;
            this.ucQtdCadastrado.TextoLabel1 = "Quantidade de Modelos Cadastrados: ";
            this.ucQtdCadastrado.TextoLabel2 = "label1";
            // 
            // frGerenciarModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 500);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucQtdCadastrado);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frGerenciarModelos";
            this.Text = "frGerenciarModelos";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private User_Controls.ucLabelComTextoVariavel ucMarca;
        private User_Controls.ucLabelComTextoVariavel ucDescricao;
        private User_Controls.ucLabelComTextoVariavel ucCodigo;
        private User_Controls.ucLabelComTextoVariavel ucQtdCadastrado;
    }
}