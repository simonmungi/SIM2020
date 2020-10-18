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

            //Columnas
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





            //Primer fila
            vectorAnterior[col_num_iteracion] = 1;
            vectorAnterior[col_evento] = "Inicio";
            vectorAnterior[col_reloj] = 0;

            vectorAnterior[col_num_pedido] = "-";
            vectorAnterior[col_proximo_pedido] = 1;

            Generador gen = new Poisson();
            double proximo = gen.generar(5);

            vectorAnterior[col_tiempo_entre_pedidos] = proximo;
            vectorAnterior[col_tiempo_proximo_pedido] = vectorAnterior[col_reloj] + vectorAnterior[col_tiempo_entre_pedidos];

            Pedido pedido = new Pedido();
            Pedido siguiente = pedido.siguientePedido();

            vectorAnterior[col_tipo_pedido] = siguiente.nombre;
            vectorAnterior[col_cantidad] = siguiente.cantidad;
            vectorAnterior[col_costo] = siguiente.costo;

            pantalla.cargarLinea(0,vectorAnterior);


            


            //Columnas
            /*
             * int iteracion = 0;
             * int reloj = 1;
             
             
             */

            //inicializacion


        }

    }
}
