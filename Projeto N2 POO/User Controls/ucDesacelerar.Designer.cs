
namespace Projeto_N2_POO.User_Controls
{
    partial class ucDesacelerar
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
            this.btnAcelarar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAcelarar
            // 
            this.btnAcelarar.AutoSize = true;
            this.btnAcelarar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAcelarar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAcelarar.FlatAppearance.BorderSize = 0;
            this.btnAcelarar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnAcelarar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcelarar.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcelarar.ForeColor = System.Drawing.Color.White;
            this.btnAcelarar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcelarar.Location = new System.Drawing.Point(0, 0);
            this.btnAcelarar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAcelarar.Name = "btnAcelarar";
            this.btnAcelarar.Size = new System.Drawing.Size(150, 150);
            this.btnAcelarar.TabIndex = 33;
            this.btnAcelarar.Text = "Desacelerar";
            this.btnAcelarar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAcelarar.UseVisualStyleBackColor = false;
            this.btnAcelarar.Click += new System.EventHandler(this.btnAcelarar_Click);
            // 
            // ucDesacelerar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnAcelarar);
            this.Name = "ucDesacelerar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcelarar;
    }
}
