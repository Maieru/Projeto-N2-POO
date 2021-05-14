
namespace Projeto_N2_POO.Forms
{
    partial class frCadastroMarca
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
            this.grpVeiculos = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.ucCodigo = new Projeto_N2_POO.User_Controls.ucLabelETextbox();
            this.ucDescricao = new Projeto_N2_POO.User_Controls.ucLabelETextbox();
            this.ucSeletorDeTipos = new Projeto_N2_POO.User_Controls.ucSeletorDeTipos();
            this.ucCheckAndUncheck1 = new Projeto_N2_POO.User_Controls.ucCheckAndUncheck();
            this.grpVeiculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVeiculos
            // 
            this.grpVeiculos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpVeiculos.Controls.Add(this.ucSeletorDeTipos);
            this.grpVeiculos.Controls.Add(this.ucCheckAndUncheck1);
            this.grpVeiculos.ForeColor = System.Drawing.Color.White;
            this.grpVeiculos.Location = new System.Drawing.Point(288, 101);
            this.grpVeiculos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpVeiculos.Name = "grpVeiculos";
            this.grpVeiculos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpVeiculos.Size = new System.Drawing.Size(275, 298);
            this.grpVeiculos.TabIndex = 2;
            this.grpVeiculos.TabStop = false;
            this.grpVeiculos.Text = "Tipo de Veiculos Manufaturados";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = global::Projeto_N2_POO.Properties.Resources.iconfinder_save_3325027;
            this.btnSalvar.Location = new System.Drawing.Point(36, 343);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSalvar.Size = new System.Drawing.Size(192, 35);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ucCodigo
            // 
            this.ucCodigo.BackColor = System.Drawing.Color.Transparent;
            this.ucCodigo.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucCodigo.ForeColor = System.Drawing.Color.White;
            this.ucCodigo.Location = new System.Drawing.Point(36, 232);
            this.ucCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucCodigo.Name = "ucCodigo";
            this.ucCodigo.Size = new System.Drawing.Size(192, 50);
            this.ucCodigo.TabIndex = 4;
            this.ucCodigo.TextoDaLabel = "Código";
            this.ucCodigo.TextoDaTextBox = "";
            // 
            // ucDescricao
            // 
            this.ucDescricao.BackColor = System.Drawing.Color.Transparent;
            this.ucDescricao.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucDescricao.ForeColor = System.Drawing.Color.White;
            this.ucDescricao.Location = new System.Drawing.Point(36, 121);
            this.ucDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucDescricao.Name = "ucDescricao";
            this.ucDescricao.Size = new System.Drawing.Size(192, 50);
            this.ucDescricao.TabIndex = 3;
            this.ucDescricao.TextoDaLabel = "Descrição";
            this.ucDescricao.TextoDaTextBox = "";
            // 
            // ucSeletorDeTipos
            // 
            this.ucSeletorDeTipos.BackColor = System.Drawing.Color.Transparent;
            this.ucSeletorDeTipos.Location = new System.Drawing.Point(10, 26);
            this.ucSeletorDeTipos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucSeletorDeTipos.MaximumSize = new System.Drawing.Size(251, 196);
            this.ucSeletorDeTipos.MinimumSize = new System.Drawing.Size(251, 196);
            this.ucSeletorDeTipos.Name = "ucSeletorDeTipos";
            this.ucSeletorDeTipos.Size = new System.Drawing.Size(251, 196);
            this.ucSeletorDeTipos.TabIndex = 4;
            // 
            // ucCheckAndUncheck1
            // 
            this.ucCheckAndUncheck1.BackColor = System.Drawing.Color.Transparent;
            this.ucCheckAndUncheck1.ControleComandado = this.grpVeiculos;
            this.ucCheckAndUncheck1.Location = new System.Drawing.Point(62, 215);
            this.ucCheckAndUncheck1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucCheckAndUncheck1.Name = "ucCheckAndUncheck1";
            this.ucCheckAndUncheck1.Size = new System.Drawing.Size(148, 78);
            this.ucCheckAndUncheck1.TabIndex = 3;
            // 
            // frCadastroMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(575, 500);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.ucCodigo);
            this.Controls.Add(this.ucDescricao);
            this.Controls.Add(this.grpVeiculos);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frCadastroMarca";
            this.Text = "frCadastroMarca";
            this.grpVeiculos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVeiculos;
        private User_Controls.ucCheckAndUncheck ucCheckAndUncheck1;
        private User_Controls.ucSeletorDeTipos ucSeletorDeTipos;
        private User_Controls.ucLabelETextbox ucDescricao;
        private User_Controls.ucLabelETextbox ucCodigo;
        private System.Windows.Forms.Button btnSalvar;
    }
}