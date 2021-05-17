
namespace Projeto_N2_POO.Forms
{
    partial class frCadastro
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
            this.btnInstanciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInstanciar
            // 
            this.btnInstanciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInstanciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnInstanciar.FlatAppearance.BorderSize = 0;
            this.btnInstanciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnInstanciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstanciar.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstanciar.ForeColor = System.Drawing.Color.White;
            this.btnInstanciar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInstanciar.Location = new System.Drawing.Point(102, 227);
            this.btnInstanciar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInstanciar.Name = "btnInstanciar";
            this.btnInstanciar.Size = new System.Drawing.Size(370, 46);
            this.btnInstanciar.TabIndex = 37;
            this.btnInstanciar.Text = "Instanciar Veiculos Automaticamente";
            this.btnInstanciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInstanciar.UseVisualStyleBackColor = false;
            this.btnInstanciar.Click += new System.EventHandler(this.btnInstanciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(114, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "ATENÇÃO: Isso apagará todos os dados armazenados !";
            // 
            // frCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInstanciar);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frCadastro";
            this.Text = "frCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstanciar;
        private System.Windows.Forms.Label label1;
    }
}