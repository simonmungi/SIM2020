using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entidades;
using TP5.Entidades.Eventos;
using TP5.Entidades.Pedidos;
using TP5.Generadores;
using Medallion.Collections;

namespace TP5
{
    public class Gestor
    {
        public Pantalla pantalla;
        public int iteraciones = 10;
        public dynamic[] vectorAnterior;
        public dynamic[] vectorActual;

        //########### Columnas del vector ###################//
        public int col_num_iteracion = 0;
        public int col_evento = 1;
        public int col_reloj = 2;
        public int col_num_pedido = 3;
        public int col_proximo_pedido = 4;
        public int col_tiempo_entre_pedidos = 5;
        public int col_tiempo_proximo_pedido = 6;
        public int col_tipo_pedido = 7;
        public int col_cantidad = 8;
        public int col_costo = 9;

        public int col_pedido_cocinero1 = 11;
        public int col_tiempo_preparacion_cocinero1 = 12;
        public int col_proximo_fin_cocinero1 = 13;
        public int col_cola_cocinero1 = 14;
        public int col_estado_cocinero1 = 10;

        public int col_estado_cocinero2 = 15;
        public int col_pedido_cocinero2 = 16;
        public int col_tiempo_preparacion_cocinero2 = 17;
        public int col_proximo_fin_cocinero2 = 18;
        public int col_cola_cocinero2 = 19;

        public int col_estado_cocinero3 = 20;
        public int col_pedido_cocinero3 = 21;
        public int col_tiempo_preparacion_cocinero3 = 22;
        public int col_proximo_fin_cocinero3 = 23;
        public int col_cola_cocinero3 = 24;

        public int col_estado_delivery = 25;
        public int col_pedido_delivery = 26;
        public int col_tiempo_entrega_delivery = 27;
        public int col_fin_proxima_entrega_delivery = 28;
        public int col_cola_delivery = 29;

        //#####################################//

        public Gestor(Pantalla p)
        {
            pantalla = p;
        }

        public void simular()
        {
            //Inicializo objetos
            Servidor cocinero1 = new Cocinero();
            Servidor cocinero2 = new Cocinero();
            Servidor cocinero3 = new Cocinero();
            Servidor delivery = new Delivery();
            List<Pedido> pedidos = new List<Pedido>();
            var eventos = new PriorityQueue<Evento>(new EventoComp());


            vectorAnterior = new dynamic[40];
            vectorActual = new dynamic[40];

            //Primer fila
            vectorAnterior[col_num_iteracion] = 0;
            vectorAnterior[col_evento] = "Inicio";
            vectorAnterior[col_reloj] = 0;

            vectorAnterior[col_num_pedido] = "-";
            vectorAnterior[col_proximo_pedido] = 1;

            Generador gen = new Poisson();
            double proximo = gen.generar(5)/60;// esto no se si es asi

            vectorAnterior[col_tiempo_entre_pedidos] = proximo;
            vectorAnterior[col_tiempo_proximo_pedido] = vectorAnterior[col_reloj] + vectorAnterior[col_tiempo_entre_pedidos];
            
            Evento evento = new NuevoPedido(this, vectorAnterior[col_tiempo_proximo_pedido]);
            eventos.Enqueue(evento);
            
            Pedido pedido = new Pedido();
            Pedido siguiente = pedido.siguientePedido();

            vectorAnterior[col_tipo_pedido] = siguiente.nombre;
            vectorAnterior[col_cantidad] = siguiente.cantidad;
            vectorAnterior[col_costo] = siguiente.costo;

            //cocinero1
            vectorAnterior[col_estado_cocinero1] = cocinero1.estado.ToString();
            //cocinero2
            vectorAnterior[col_estado_cocinero2] = cocinero2.estado.ToString();
            //cocinero3
            vectorAnterior[col_estado_cocinero3] = cocinero3.estado.ToString();
            //delivery
            vectorAnterior[col_estado_delivery] = delivery.estado.ToString();

            vectorAnterior[39] = pedidos;

            pantalla.cargarLinea(0,vectorAnterior);

            //loop principal
            for(int i=1; i<iteraciones; i++)
            {
                vectorActual = vectorAnterior;
                evento = eventos.Dequeue();
                
                vectorActual[col_num_iteracion] = i + 1;

                evento.ocurrir(ref vectorActual,eventos,cocinero1,cocinero2,cocinero3,delivery,pedidos);

                pantalla.cargarLinea(i,vectorActual);

                /*
                if (actual[0] >= desde && actual[0] <= hasta)
                {
                    pantalla.cargarLinea(i,actual);
                }*/



            }


        }

    }
}
