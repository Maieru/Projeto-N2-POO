using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_N2_POO.User_Controls
{
    public partial class ucCheckAndUncheck : UserControl
    {
        public Control ControleComandado { get; set; }

        public ucCheckAndUncheck()
        {
            InitializeComponent();
        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            AlterarCheckbox(ControleComandado.Controls, true);
        }
        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            AlterarCheckbox(ControleComandado.Controls, false);
        }
        private void AlterarCheckbox(ControlCollection controles, bool marcado)
        {
            foreach (Control control in controles)
            {
                if (control.Controls != null)
                    AlterarCheckbox(control.Controls, marcado);
                if (control is CheckBox)
                    (control as CheckBox).Checked = marcado;
            }
        }
    }
}
