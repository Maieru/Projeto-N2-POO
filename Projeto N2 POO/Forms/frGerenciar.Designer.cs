
namespace Projeto_N2_POO.Forms
{
    partial class frGerenciar
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
            this.btnEmpinar = new System.Windows.Forms.Button();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.btnAtracar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSelecaoPedagio = new System.Windows.Forms.ComboBox();
            this.btnPagarPedagio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterarLimpador = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmpinar
            // 
            this.btnEmpinar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmpinar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnEmpinar.FlatAppearance.BorderSize = 0;
            this.btnEmpinar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnEmpinar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpinar.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpinar.ForeColor = System.Drawing.Color.White;
            this.btnEmpinar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpinar.Location = new System.Drawing.Point(102, 417);
            this.btnEmpinar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmpinar.Name = "btnEmpinar";
            this.btnEmpinar.Size = new System.Drawing.Size(370, 46);
            this.btnEmpinar.TabIndex = 41;
            this.btnEmpinar.Text = "Empinar Todos os Véiculos";
            this.btnEmpinar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpinar.UseVisualStyleBackColor = false;
            this.btnEmpinar.Click += new System.EventHandler(this.btnEmpinar_Click);
            // 
            // btnAtacar
            // 
            this.btnAtacar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAtacar.FlatAppearance.BorderSize = 0;
            this.btnAtacar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnAtacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtacar.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtacar.ForeColor = System.Drawing.Color.White;
            this.btnAtacar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtacar.Location = new System.Drawing.Point(102, 340);
            this.btnAtacar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(370, 46);
            this.btnAtacar.TabIndex = 40;
            this.btnAtacar.Text = "Atacar com Todos os Veículos";
            this.btnAtacar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtacar.UseVisualStyleBackColor = false;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // btnAtracar
            // 
            this.btnAtracar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtracar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAtracar.FlatAppearance.BorderSize = 0;
            this.btnAtracar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnAtracar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtracar.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtracar.ForeColor = System.Drawing.Color.White;
            this.btnAtracar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtracar.Location = new System.Drawing.Point(102, 263);
            this.btnAtracar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAtracar.Name = "btnAtracar";
            this.btnAtracar.Size = new System.Drawing.Size(370, 46);
            this.btnAtracar.TabIndex = 39;
            this.btnAtracar.Text = "Atracar Todos os Veículos";
            this.btnAtracar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtracar.UseVisualStyleBackColor = false;
            this.btnAtracar.Click += new System.EventHandler(this.btnAtracar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.cmbSelecaoPedagio);
            this.groupBox1.Controls.Add(this.btnPagarPedagio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(102, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 129);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagar Pedágio com Todos os Veículos";
            // 
            // cmbSelecaoPedagio
            // 
            this.cmbSelecaoPedagio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelecaoPedagio.FormattingEnabled = true;
            this.cmbSelecaoPedagio.Location = new System.Drawing.Point(84, 32);
            this.cmbSelecaoPedagio.Name = "cmbSelecaoPedagio";
            this.cmbSelecaoPedagio.Size = new System.Drawing.Size(254, 25);
            this.cmbSelecaoPedagio.TabIndex = 1;
            // 
            // btnPagarPedagio
            // 
            this.btnPagarPedagio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPagarPedagio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnPagarPedagio.FlatAppearance.BorderSize = 0;
            this.btnPagarPedagio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnPagarPedagio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarPedagio.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarPedagio.ForeColor = System.Drawing.Color.White;
            this.btnPagarPedagio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagarPedagio.Location = new System.Drawing.Point(84, 64);
            this.btnPagarPedagio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPagarPedagio.Name = "btnPagarPedagio";
            this.btnPagarPedagio.Size = new System.Drawing.Size(203, 46);
            this.btnPagarPedagio.TabIndex = 37;
            this.btnPagarPedagio.Text = "Pagar";
            this.btnPagarPedagio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagarPedagio.UseVisualStyleBackColor = false;
            this.btnPagarPedagio.Click += new System.EventHandler(this.btnPagarPedagio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedágio:";
            // 
            // btnAlterarLimpador
            // 
            this.btnAlterarLimpador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterarLimpador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAlterarLimpador.FlatAppearance.BorderSize = 0;
            this.btnAlterarLimpador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnAlterarLimpador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarLimpador.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarLimpador.ForeColor = System.Drawing.Color.White;
            this.btnAlterarLimpador.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarLimpador.Location = new System.Drawing.Point(102, 26);
            this.btnAlterarLimpador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterarLimpador.Name = "btnAlterarLimpador";
            this.btnAlterarLimpador.Size = new System.Drawing.Size(370, 46);
            this.btnAlterarLimpador.TabIndex = 36;
            this.btnAlterarLimpador.Text = "Alterar Limpador de Todos os Veículos";
            this.btnAlterarLimpador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarLimpador.UseVisualStyleBackColor = false;
            this.btnAlterarLimpador.Click += new System.EventHandler(this.btnAlterarLimpador_Click);
            // 
            // frGerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 500);
            this.Controls.Add(this.btnEmpinar);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.btnAtracar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAlterarLimpador);
            this.Name = "frGerenciar";
            this.Text = "frGerenciar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlterarLimpador;
        private System.Windows.Forms.Button btnPagarPedagio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSelecaoPedagio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtracar;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Button btnEmpinar;
    }
}