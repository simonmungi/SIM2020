using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Entidades.Pedido
{
    class Empanada : Pedido
    {
        double costoEmpanada = 25;

        public Empanada()
        {
            nombre = "Empanadas";
            calcularCantidad();
            calcularDemora();
            costo = cantidad * costoEmpanada;
        }

        public override void calcularCantidad()
        {
            //POISSON
            cantidad = 2222;
        }

        public override void calcularDemora()
        {
            //2.5 SI SON MENOS DE 3, 3.5 SI SON 3
            demora = 2222;
        }
    }
}
