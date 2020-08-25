using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_NetFramework
{
    public interface IEstrategia
    {
        void obtenerEsperados(Gestor g);

        double generarValor(Gestor g);
    }
}
