﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_N2_POO.Interfaces
{
    interface IVeiculoComLimpador
    {
        bool LimpadorLigado { get; }
        string AlteraLimpador();
    }
}
