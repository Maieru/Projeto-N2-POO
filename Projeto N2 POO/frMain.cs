using Projeto_N2_POO.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_N2_POO
{
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
        }

        private void btnAbriMenuCadastro_Click(object sender, EventArgs e)
        {
            if (pnlCadastro.Visible)
                pnlCadastro.Visible = false;
            else
                pnlCadastro.Visible = true;
        }
    }
}
