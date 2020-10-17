using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Entidades.Pedido
{
    class Sandwich : Pedido
    {
        double costoSandwich = 500;

        public Sandwich()
        {
            nombre = "Docena Sandwich";
            calcularCantidad();
            calcularDemora();
            costo = cantidad * costoSandwich;
        }
        public override void calcularCantidad()
        {
            cantidad = 1;
        }

        public override void calcularDemora()
        {
            //NORMAL, MEDIA 10, DESV 5
            demora = 2222;
        }
    }
}
