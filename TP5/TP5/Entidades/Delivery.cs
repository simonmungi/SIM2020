using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entidades.StateServidor;

namespace TP5.Entidades
{
    class Delivery : Servidor
    {

        public Delivery()
        {
            nombre = "Delivery";
            estado = new Libre();
        }
    }
}
