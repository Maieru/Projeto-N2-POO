
namespace Projeto_N2_POO.User_Controls
{
    partial class ucLabelETextbox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 2);
            this.panel1.TabIndex = 3;
            // 
            // txtEntrada
            // 
            this.txtEntrada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.txtEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEntrada.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtEntrada.ForeColor = System.Drawing.Color.White;
            this.txtEntrada.Location = new System.Drawing.Point(0, 30);
            this.txtEntrada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(129, 18);
            this.txtEntrada.TabIndex = 4;
            // 
            // lblTexto
            // 
            this.lblTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTexto.Location = new System.Drawing.Point(0, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(129, 30);
            this.lblTexto.TabIndex = 5;
            this.lblTexto.Text = "label1";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucLabelETextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucLabelETextbox";
            this.Size = new System.Drawing.Size(129, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label lblTexto;
    }
}
