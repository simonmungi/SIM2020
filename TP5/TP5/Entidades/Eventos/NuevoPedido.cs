﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Entidades.Eventos
{
    class NuevoPedido : Evento
    {
        public NuevoPedido(double t)
        {
            nombre = "Nuevo pedido";
            tiempo = t;
        }

    }
}
