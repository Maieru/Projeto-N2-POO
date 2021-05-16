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

namespace Projeto_N2_POO.Forms
{
    public partial class frGerenciarPedagio : frBase
    {
        public frGerenciarPedagio()
        {
            InitializeComponent();

            if (Dados.Pedagios.Count == 0)
                ExibeTelaDeErro();
        }
        public void ExibeTelaDeErro()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pi
        }
    }
}
