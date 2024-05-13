using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_solid_transporte
{
    public interface ITransporteAereo        //Aca no se cumplia el principio de segregacion de interfaces
    {                                        //al no dividir el transporte en transporte aereo y transporte terrestre
        void Acelerar(int velocidad);
        void Desacelerar(int velocidad);
        void Volar(int altitud);
    }
}
