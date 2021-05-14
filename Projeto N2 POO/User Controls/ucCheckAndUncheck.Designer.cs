
namespace Projeto_N2_POO.User_Controls
{
    partial class ucCheckAndUncheck
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marcar Todos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desarcar Todos";
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.FlatAppearance.BorderSize = 0;
            this.btnDesmarcar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDesmarcar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnDesmarcar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnDesmarcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesmarcar.Image = global::Projeto_N2_POO.Properties.Resources.UncheckIcon;
            this.btnDesmarcar.Location = new System.Drawing.Point(3, 33);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(24, 24);
            this.btnDesmarcar.TabIndex = 4;
            this.btnDesmarcar.UseVisualStyleBackColor = true;
            this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click);
            // 
            // btnMarcar
            // 
            this.btnMarcar.FlatAppearance.BorderSize = 0;
            this.btnMarcar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMarcar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMarcar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnMarcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcar.Image = global::Projeto_N2_POO.Properties.Resources.CheckIcon;
            this.btnMarcar.Location = new System.Drawing.Point(3, 3);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(24, 24);
            this.btnMarcar.TabIndex = 0;
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // ucCheckAndUncheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnDesmarcar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMarcar);
            this.Name = "ucCheckAndUncheck";
            this.Size = new System.Drawing.Size(139, 61);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDesmarcar;
        private System.Windows.Forms.Button btnMarcar;
    }
}
