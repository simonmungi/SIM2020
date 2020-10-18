using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entidades;
using TP5.Entidades.Eventos;
using TP5.Entidades.Pedidos;
using TP5.Generadores;

namespace TP5
{
    public class Gestor
    {
        public Pantalla pantalla;
        public int iteraciones = 10;
        public dynamic[] vectorAnterior;
        public dynamic[] vectorActual;

        //########### Columnas del vector ###################//
        int col_num_iteracion = 0;
        int col_evento = 1;
        int col_reloj = 2;
        int col_num_pedido = 3;
        int col_proximo_pedido = 4;
        int col_tiempo_entre_pedidos = 5;
        int col_tiempo_proximo_pedido = 6;
        int col_tipo_pedido = 7;
        int col_cantidad = 8;
        int col_costo = 9;

        int col_estado_cocinero1 = 10;
        int col_pedido_cocinero1 = 11;
        int col_tiempo_preparacion_cocinero1 = 12;
        int col_proximo_fin_cocinero1 = 13;
        int col_cola_cocinero1 = 14;

        int col_estado_cocinero2 = 15;
        int col_pedido_cocinero2 = 16;
        int col_tiempo_preparacion_cocinero2 = 17;
        int col_proximo_fin_cocinero2 = 18;
        int col_cola_cocinero2 = 19;

        int col_estado_cocinero3 = 20;
        int col_pedido_cocinero3 = 21;
        int col_tiempo_preparacion_cocinero3 = 22;
        int col_proximo_fin_cocinero3 = 23;
        int col_cola_cocinero3 = 24;

        int col_estado_delivery = 25;
        int col_pedido_delivery = 26;
        int col_tiempo_entrega_delivery = 27;
        int col_fin_proxima_entrega_delivery = 28;
        int col_cola_delivery = 29;

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

            vectorAnterior = new dynamic[30];
            vectorActual = new dynamic[30];

            //Primer fila
            vectorAnterior[col_num_iteracion] = 1;
            vectorAnterior[col_evento] = "Inicio";
            vectorAnterior[col_reloj] = 0;

            vectorAnterior[col_num_pedido] = "-";
            vectorAnterior[col_proximo_pedido] = 1;

            Generador gen = new Poisson();
            double proximo = gen.generar(5)/60;// esto no se si es asi

            vectorAnterior[col_tiempo_entre_pedidos] = proximo;
            vectorAnterior[col_tiempo_proximo_pedido] = vectorAnterior[col_reloj] + vectorAnterior[col_tiempo_entre_pedidos];

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



            pantalla.cargarLinea(0,vectorAnterior);



        }

    }
}
