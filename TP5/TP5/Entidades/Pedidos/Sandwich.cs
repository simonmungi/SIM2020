using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Generadores;

namespace TP5.Entidades.Pedidos
{
    class Sandwich : Pedido
    {
        double costoSandwich = 500;
        double media = 10;
        double desv = 5;

        public Sandwich()
        {
            generador = new Normal();
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
            demora = generador.generar(media,desv);
        }
    }
}
