﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_solid_transporte
{
    public interface ITransporteTerrestre
    {
        void Acelerar(int velocidad);
        void Desacelerar(int velocidad);
        void GuardarEnBD();
    }
}
