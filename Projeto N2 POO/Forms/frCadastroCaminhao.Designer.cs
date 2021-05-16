
namespace Projeto_N2_POO.Forms
{
    partial class frCadastroCaminhao
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
            this.nudQtdEixos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmModelo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucIdentificacao = new Projeto_N2_POO.User_Controls.ucLabelETextbox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.ucCargaMaxima = new Projeto_N2_POO.User_Controls.ucLabelETextbox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidadePassageiros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdEixos)).BeginInit();
            this.SuspendLayout();
            // 
            // nudCapacidadePassageiros
            // 
            this.nudCapacidadePassageiros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudCapacidadePassageiros.Location = new System.Drawing.Point(321, 198);
            this.nudCapacidadePassageiros.Name = "nudCapacidadePassageiros";
            this.nudCapacidadePassageiros.Size = new System.Drawing.Size(203, 25);
            this.nudCapacidadePassageiros.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Capacidade de Passageiros:";
            // 
            // nudQtdEixos
            // 
            this.nudQtdEixos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudQtdEixos.Location = new System.Drawing.Point(321, 114);
            this.nudQtdEixos.Name = "nudQtdEixos";
            this.nudQtdEixos.Size = new System.Drawing.Size(203, 25);
            this.nudQtdEixos.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Quantidade de Eixos:";
            // 
            // cbmModelo
            // 
            this.cbmModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbmModelo.BackColor = System.Drawing.Color.White;
            this.cbmModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmModelo.FormattingEnabled = true;
            this.cbmModelo.Location = new System.Drawing.Point(69, 197);
            this.cbmModelo.Name = "cbmModelo";
            this.cbmModelo.Size = new System.Drawing.Size(203, 25);
            this.cbmModelo.Sorted = true;
            this.cbmModelo.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 175);
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
            this.ucIdentificacao.Location = new System.Drawing.Point(69, 83);
            this.ucIdentificacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucIdentificacao.Name = "ucIdentificacao";
            this.ucIdentificacao.Size = new System.Drawing.Size(203, 50);
            this.ucIdentificacao.TabIndex = 24;
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
            this.btnSalvar.Location = new System.Drawing.Point(186, 371);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(203, 46);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ucCargaMaxima
            // 
            this.ucCargaMaxima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucCargaMaxima.BackColor = System.Drawing.Color.Transparent;
            this.ucCargaMaxima.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ucCargaMaxima.ForeColor = System.Drawing.Color.White;
            this.ucCargaMaxima.Location = new System.Drawing.Point(186, 268);
            this.ucCargaMaxima.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucCargaMaxima.Name = "ucCargaMaxima";
            this.ucCargaMaxima.Size = new System.Drawing.Size(203, 50);
            this.ucCargaMaxima.TabIndex = 34;
            this.ucCargaMaxima.TextoDaLabel = "Capacidade de Carga (kg): ";
            this.ucCargaMaxima.TextoDaTextBox = "";
            // 
            // frCadastroCaminhao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 500);
            this.Controls.Add(this.nudCapacidadePassageiros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudQtdEixos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbmModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucIdentificacao);
            this.Controls.Add(this.ucCargaMaxima);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frCadastroCaminhao";
            this.Text = "frCadastroCaminhao";
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidadePassageiros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdEixos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudCapacidadePassageiros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQtdEixos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbmModelo;
        private System.Windows.Forms.Label label1;
        private User_Controls.ucLabelETextbox ucIdentificacao;
        private User_Controls.ucLabelETextbox ucCargaMaxima;
    }
}