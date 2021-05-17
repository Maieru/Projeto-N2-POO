using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_N2_POO.Forms
{
    public partial class frBase : Form
    {
        public frBase()
        {
            InitializeComponent();
        }
        public void LimpaCampos(Control.ControlCollection controles)
        {
            foreach (Control control in controles)
            {
                if (control is TextBox)
                    control.Text = "";
                if (control is NumericUpDown)
                    (control as NumericUpDown).Value = 0; 
                if (control is Panel || control is GroupBox || control is UserControl)
                    LimpaCampos(control.Controls);
            }
        }
        public void ExibeTelaDeErro()
        {
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            panel.Controls.Add(
            new Label
            {
                Text = "Nenhum pedágio encontrado",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            });
            Controls.Add(panel);
        }
    }
}
