using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Entidades.Pedido
{
    class Pizza : Pedido
    {
        double costoPizza = 250;

        public Pizza()
        {
            nombre = "Pizza";
            calcularCantidad();
            calcularDemora();
            costo = cantidad * costoPizza;
        }

        public override void calcularCantidad()
        {
            cantidad = 1;
        }

        public override void calcularDemora()
        {
            //UNIFORME
            demora = 2222;
        }
    }
}
