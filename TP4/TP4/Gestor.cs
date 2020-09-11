using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    public class Gestor
    {
        public Aleatorio aleatorio;

        //Constantes a ingresar
        int _DIAS;
        int _CANT_FRASCOS;
        int _GRAMOS_X_FRASCO;
        double _COSTO_X_FRASCO;
        double _PRECIO_VENTA;
        int _STOCK_MAX;
        int _FRECUENCIA_COMPRA;
        int _HORAS_MAN;
        int _HORAS_TAR;

        double _MEDIA_M = 75;
        double _MEDIA_T = 70;
        double _SIGMA = 15;

        double[] vector_estados1 = new double[24];
        double[] vector_estados2 = new double[24];

        double[,] dist_demora = {{0,0,0.5},
                                 {1,0.5,0.75},
                                 {2,0.75,1},
        };

        //CREO QUE NO HACE FALTA, CON PREGUNTAR SI ES >= 0.5 ALCANZA
        //si es 1 -> 50 g, si es 2 -> dist normal 
        double[,] dist_demanda_m = {{1,0,0.5},
                                   {2,0.5,1},
        };

        double buscar(double num, double[,] vec)
        {
            for(int i =0; i<vec.Length; i++)
            {
                if (num >= vec[i, 1] && num < vec[i, 2]) return vec[i, 0];
            }
            return -1;
        }


        public void simular()
        {
            //|0 Dia| 1 Rand Mañana | 2 Rand Normal | 3 Rand Normal 2 | 4 demanda Mañana | 5 Demanda tarde | 6 Total dia | 
            //primera fila
            vector_estados1[0] = 0;


            for(int i=0; i<_DIAS; i++)
            {
                //----------------------------------DEMANDA---------------------------------------------------------//
                vector_estados2[0] = vector_estados1[0]++;
                vector_estados2[1] = aleatorio.generarAleatorio();
                vector_estados2[2] = vector_estados2[1] >= 0.5 ? aleatorio.generarAleatorio() : -1;
                vector_estados2[3] = vector_estados2[1] >= 0.5 ? aleatorio.generarAleatorio() : -1;
                vector_estados2[4] = vector_estados2[1] >= 0.5 ? aleatorio.generarRandNormal(vector_estados2[2], vector_estados2[3], _MEDIA_M, _SIGMA) : 50;
                vector_estados2[5] = aleatorio.generarRandExponencial(_MEDIA_T);
                vector_estados2[6] = vector_estados2[5] + vector_estados2[4];

                //---------------------------------VENTAS----------------------------------------------------------//



                //---------------------------------STOCK----------------------------------------------------------//

                //---------------------------------COSTOS----------------------------------------------------------//

                //---------------------------------ORDEN----------------------------------------------------------//

            }
        }



        public Gestor(string dias, string cantFrascos, string gramos, string costoFrasco, string precioVenta, string stockMax, string frecuenciaCompra, string horasM, string horasT)
        {
            _DIAS = Convert.ToInt32(dias);
            _CANT_FRASCOS = Convert.ToInt32(cantFrascos);
            _GRAMOS_X_FRASCO = Convert.ToInt32(gramos);
            _COSTO_X_FRASCO = Convert.ToDouble(costoFrasco);
            _PRECIO_VENTA = Convert.ToDouble(precioVenta);
            _STOCK_MAX = Convert.ToInt32(stockMax);
            _FRECUENCIA_COMPRA = Convert.ToInt32(frecuenciaCompra);
            _HORAS_MAN = Convert.ToInt32(horasM);
            _HORAS_TAR = Convert.ToInt32(horasT);

        }
    }
}
