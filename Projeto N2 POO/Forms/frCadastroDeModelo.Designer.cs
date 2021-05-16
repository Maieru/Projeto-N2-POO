
namespace Projeto_N2_POO.Forms
{
    partial class frCadastroDeModelo
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmMarca = new System.Windows.Forms.ComboBox();
            this.ucCodigo = new Projeto_N2_POO.User_Controls.ucLabelETextbox();
            this.ucDescricao = new Projeto_N2_POO.User_Controls.ucLabelETextbox();
            this.cbmTipoVeiculo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = global::Projeto_N2_POO.Properties.Resources.iconfinder_save_3325027;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(186, 369);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(203, 46);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Marca:";
            // 
            // cbmMarca
            // 
            this.cbmMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbmMarca.BackColor = System.Drawing.Color.White;
            this.cbmMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmMarca.FormattingEnabled = true;
            this.cbmMarca.Location = new System.Drawing.Point(311, 156);
            this.cbmMarca.Name = "cbmMarca";
            this.cbmMarca.Size = new System.Drawing.Size(203, 25);
            this.cbmMarca.Sorted = true;
            this.cbmMarca.TabIndex = 10;
            this.cbmMarca.SelectedIndexChanged += new System.EventHandler(this.cbmMarca_SelectedIndexChanged);
            // 
            // ucCodigo
            // 
            this.ucCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucCodigo.BackColor = System.Drawing.Color.Transparent;
            this.ucCodigo.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucCodigo.ForeColor = System.Drawing.Color.White;
            this.ucCodigo.Location = new System.Drawing.Point(74, 226);
            this.ucCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucCodigo.Name = "ucCodigo";
            this.ucCodigo.Size = new System.Drawing.Size(203, 50);
            this.ucCodigo.TabIndex = 12;
            this.ucCodigo.TextoDaLabel = "Código";
            this.ucCodigo.TextoDaTextBox = "";
            // 
            // ucDescricao
            // 
            this.ucDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucDescricao.BackColor = System.Drawing.Color.Transparent;
            this.ucDescricao.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucDescricao.ForeColor = System.Drawing.Color.White;
            this.ucDescricao.Location = new System.Drawing.Point(74, 131);
            this.ucDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucDescricao.Name = "ucDescricao";
            this.ucDescricao.Size = new System.Drawing.Size(203, 50);
            this.ucDescricao.TabIndex = 11;
            this.ucDescricao.TextoDaLabel = "Descrição";
            this.ucDescricao.TextoDaTextBox = "";
            // 
            // cbmTipoVeiculo
            // 
            this.cbmTipoVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbmTipoVeiculo.BackColor = System.Drawing.Color.White;
            this.cbmTipoVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmTipoVeiculo.FormattingEnabled = true;
            this.cbmTipoVeiculo.Location = new System.Drawing.Point(311, 251);
            this.cbmTipoVeiculo.Name = "cbmTipoVeiculo";
            this.cbmTipoVeiculo.Size = new System.Drawing.Size(203, 25);
            this.cbmTipoVeiculo.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tipo de Veiculo";
            // 
            // frCadastroDeModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(575, 500);
            this.Controls.Add(this.cbmTipoVeiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ucCodigo);
            this.Controls.Add(this.ucDescricao);
            this.Controls.Add(this.cbmMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frCadastroDeModelo";
            this.Text = "frCadastroDeModelo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmMarca;
        private User_Controls.ucLabelETextbox ucCodigo;
        private User_Controls.ucLabelETextbox ucDescricao;
        private System.Windows.Forms.ComboBox cbmTipoVeiculo;
        private System.Windows.Forms.Label label2;
    }
}