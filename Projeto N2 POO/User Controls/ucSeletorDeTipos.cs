using Projeto_N2_POO.Enumeradores;
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
    public partial class ucSeletorDeTipos : UserControl
    {
        public List<EnumTipoVeiculo> TiposMarcados
        {
            get
            {
                List<EnumTipoVeiculo> aux = new List<EnumTipoVeiculo>();

                foreach(Control control in Controls)
                    if ((control as CheckBox).Checked)
                        aux.Add((EnumTipoVeiculo)Convert.ToInt32(control.Tag));

                if (aux.Count > 0)
                    return aux;
                else
                    return null;
            }
            set
            {
                if (value == null)
                    return;
                if (value.Count == 0)
                    throw new Exception("Não foi possível selecionar os tipos.");

                foreach (Control controle in Controls)
                    if (value.Contains((EnumTipoVeiculo)Convert.ToInt32(controle.Tag)))
                        (controle as CheckBox).Checked = true;
                    else
                        (controle as CheckBox).Checked = false;
            }
        }
        public ucSeletorDeTipos()
        {
            InitializeComponent();
        }
    }
}
