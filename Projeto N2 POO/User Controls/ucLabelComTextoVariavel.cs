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
    public partial class ucLabelComTextoVariavel : UserControl
    {
        public string TextoLabel1
        {
            get => lblTexto1.Text;
            set => lblTexto1.Text = value;
        }
        public string TextoLabel2
        {
            get => lblTexto2.Text;
            set => lblTexto2.Text = value;
        }
        public ucLabelComTextoVariavel()
        {
            InitializeComponent();
        }
    }
}
