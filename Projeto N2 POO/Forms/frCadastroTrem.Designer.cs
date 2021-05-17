
namespace Projeto_N2_POO.Forms
{
    partial class frCadastroTrem
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
            this.nudCapacidadePassageiros = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQtdVagoes = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbmModelo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucIdentificacao = new Projeto_N2_POO.User_Controls.ucLabelETextbox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidadePassageiros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdVagoes)).BeginInit();
            this.SuspendLayout();
            // 
            // nudCapacidadePassageiros
            // 
            this.nudCapacidadePassageiros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudCapacidadePassageiros.Location = new System.Drawing.Point(186, 319);
            this.nudCapacidadePassageiros.Name = "nudCapacidadePassageiros";
            this.nudCapacidadePassageiros.Size = new System.Drawing.Size(203, 25);
            this.nudCapacidadePassageiros.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Capacidade de Passageiros:";
            // 
            // nudQtdVagoes
            // 
            this.nudQtdVagoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudQtdVagoes.Location = new System.Drawing.Point(186, 250);
            this.nudQtdVagoes.Name = "nudQtdVagoes";
            this.nudQtdVagoes.Size = new System.Drawing.Size(203, 25);
            this.nudQtdVagoes.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Quantidade de Vagões:";
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
            this.btnSalvar.Location = new System.Drawing.Point(186, 372);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(203, 46);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbmModelo
            // 
            this.cbmModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbmModelo.BackColor = System.Drawing.Color.White;
            this.cbmModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmModelo.FormattingEnabled = true;
            this.cbmModelo.Location = new System.Drawing.Point(186, 183);
            this.cbmModelo.Name = "cbmModelo";
            this.cbmModelo.Size = new System.Drawing.Size(203, 25);
            this.cbmModelo.Sorted = true;
            this.cbmModelo.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Modelo:";
            // 
            // ucIdentificacao
            // 
            this.ucIdentificacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucIdentificacao.BackColor = System.Drawing.Color.Transparent;
            this.ucIdentificacao.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucIdentificacao.ForeColor = System.Drawing.Color.White;
            this.ucIdentificacao.Location = new System.Drawing.Point(186, 84);
            this.ucIdentificacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucIdentificacao.Name = "ucIdentificacao";
            this.ucIdentificacao.Size = new System.Drawing.Size(203, 50);
            this.ucIdentificacao.TabIndex = 24;
            this.ucIdentificacao.TextoDaLabel = "Identificação";
            this.ucIdentificacao.TextoDaTextBox = "";
            // 
            // frCadastroTrem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 500);
            this.Controls.Add(this.nudCapacidadePassageiros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudQtdVagoes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbmModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucIdentificacao);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frCadastroTrem";
            this.Text = "frCadastroTrem";
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidadePassageiros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdVagoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudCapacidadePassageiros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQtdVagoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbmModelo;
        private System.Windows.Forms.Label label1;
        private User_Controls.ucLabelETextbox ucIdentificacao;
    }
}