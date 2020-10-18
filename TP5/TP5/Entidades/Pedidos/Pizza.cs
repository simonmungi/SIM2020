using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Generadores;

namespace TP5.Entidades.Pedidos
{
    class Pizza : Pedido
    {
        double costoPizza = 250;
        double a = 15;
        double b = 18;

        public Pizza()
        {
            generador = new Uniforme();
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
            demora = generador.generar(a,b);
        }
    }
}
