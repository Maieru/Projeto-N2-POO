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
    public partial class ucLabelETextbox : UserControl
    {
        public string TextoDaLabel
        {
            get => lblTexto.Text;
            set => lblTexto.Text = value;
        }
        public string TextoDaTextBox
        {
            get => txtEntrada.Text;
            set => txtEntrada.Text = value;
        }



        public ucLabelETextbox()
        {
            InitializeComponent();
        }
    }
}
