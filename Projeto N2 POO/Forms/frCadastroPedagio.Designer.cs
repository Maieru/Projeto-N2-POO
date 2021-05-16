
namespace Projeto_N2_POO.Forms
{
    partial class frCadastroPedagio
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
            this.ucLocalizacao = new Projeto_N2_POO.User_Controls.ucLabelETextbox();
            this.ucIdentificacao = new Projeto_N2_POO.User_Controls.ucLabelETextbox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucLocalizacao
            // 
            this.ucLocalizacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucLocalizacao.BackColor = System.Drawing.Color.Transparent;
            this.ucLocalizacao.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucLocalizacao.ForeColor = System.Drawing.Color.White;
            this.ucLocalizacao.Location = new System.Drawing.Point(186, 225);
            this.ucLocalizacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucLocalizacao.Name = "ucLocalizacao";
            this.ucLocalizacao.Size = new System.Drawing.Size(203, 50);
            this.ucLocalizacao.TabIndex = 15;
            this.ucLocalizacao.TextoDaLabel = "Localização";
            this.ucLocalizacao.TextoDaTextBox = "";
            // 
            // ucIdentificacao
            // 
            this.ucIdentificacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucIdentificacao.BackColor = System.Drawing.Color.Transparent;
            this.ucIdentificacao.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucIdentificacao.ForeColor = System.Drawing.Color.White;
            this.ucIdentificacao.Location = new System.Drawing.Point(186, 116);
            this.ucIdentificacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucIdentificacao.Name = "ucIdentificacao";
            this.ucIdentificacao.Size = new System.Drawing.Size(203, 50);
            this.ucIdentificacao.TabIndex = 14;
            this.ucIdentificacao.TextoDaLabel = "Identificação";
            this.ucIdentificacao.TextoDaTextBox = "";
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
            this.btnSalvar.Location = new System.Drawing.Point(186, 342);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(203, 46);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frCadastroPedagio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 500);
            this.Controls.Add(this.ucLocalizacao);
            this.Controls.Add(this.ucIdentificacao);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frCadastroPedagio";
            this.Text = "frCadastroPedagio";
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.ucLabelETextbox ucLocalizacao;
        private User_Controls.ucLabelETextbox ucIdentificacao;
        private System.Windows.Forms.Button btnSalvar;
    }
}