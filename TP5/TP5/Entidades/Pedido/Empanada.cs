using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Generadores;

namespace TP5.Entidades.Pedido
{
    class Empanada : Pedido
    {
        double lambda = 3;
        double costoEmpanada = 25;
        public Empanada()
        {
            generador = new Poisson();
            nombre = "Empanadas";
            calcularCantidad();
            calcularDemora();
            costo = cantidad * costoEmpanada;

        }

        public override void calcularCantidad()
        {
            //POISSON
            cantidad = generador.generar(lambda);
        }

        public override void calcularDemora()
        {
            //2.5 SI SON MENOS DE 3, 3.5 SI SON 3
            demora = (int)cantidad/3 * 3.5;//3 empanadas en la olla tardan 3.5
            demora += (cantidad % 3) * 2.5; //si sobran menos de 3 tardan 2.5
        }
    }
}
