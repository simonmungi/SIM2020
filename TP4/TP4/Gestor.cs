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
        public int _DIAS;
        int _CANT_FRASCOS;
        int _GRAMOS_X_FRASCO;
        double _COSTO_X_FRASCO;
        double _PRECIO_VENTA; //REVISAR -> LO MISMO QUE _COSTO_FALTANTE
        double _STOCK_MAX;
        int _FRECUENCIA_COMPRA;
        int _HORAS_MAN;
        int _HORAS_TAR;
        double _COSTO_FALTANTE = 1; //REVISAR -> ORIGINAL ES $100 POR 100g NO SE SI ASÍ ESTÁ BIEN 
        double _MEDIA_M = 75;
        double _MEDIA_T = 70;
        double _SIGMA = 15;
        public double _STOCK_INICIAL = 340;

        public double[] vector_estados1 = new double[35];
        public double[] vector_estados2 = new double[35];

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
                if (num >= vec[i, 1] && num <= vec[i, 2]) return vec[i, 0];
            }
            return -1;
        }

        public void simular(int i)
        {
            //Ordenado igual que en el Excel

            //ORDEN
            //|0 Dia| 1 Compra |2 Rand |3 Demora|4 Disponible |5 Disponible (g)

            //DEMANDA
            //|6 Rand mañana|7 Rand Normal 1| 8 Rand N 2|9 Demanda M| 10 Demanda T|11 Demanda Total

            //VENTAS
            //|12 Ventas (g) |13 Ganancia |14 Acum |15 G Media

            //STOCK
            //|16 Stock Remanente (g) |17 Stock rem frascos |18 Porcentaje almacenado|19 Porcentaje dias faltante
            //|20) 0 a 2 | 21) 2 a 5 | 22) 5 a 8 |23) 8 o más

            //COSTOS
            //|24) Faltante|25) Compra|26) Acumulado
            vector_estados2[0]++;
            //---------------------------------ORDEN----------------------------------------------------------//
            // compra
            vector_estados2[1] = vector_estados1[1] == 0 ? _FRECUENCIA_COMPRA : vector_estados1[1] - 1; 
            vector_estados2[2] = vector_estados2[1] == 0 ? aleatorio.generarAleatorio() : -1;
            if (vector_estados1[3] > 0) { vector_estados2[3] = vector_estados1[3] - 1; } //si la cantidad de dias restantes no es 0, le resto 1
            else {
                if (vector_estados2[2] > 0) { vector_estados2[3] = buscar(vector_estados2[2], dist_demora);}//se hizo un pedido, busco su prob de demora
                else { vector_estados2[3] = -1;}//no se está esperando nada
                }
            vector_estados2[4] = vector_estados2[3] == 0 ? 2 : 0;
            vector_estados2[5] = vector_estados2[4] * _GRAMOS_X_FRASCO;

            //----------------------------------DEMANDA---------------------------------------------------------//
            vector_estados2[6] = aleatorio.generarAleatorio();
            vector_estados2[7] = vector_estados2[6] >= 0.5 ? aleatorio.generarAleatorio() : -1;
            vector_estados2[8] = vector_estados2[6] >= 0.5 ? aleatorio.generarAleatorio() : -1;
            vector_estados2[9] = vector_estados2[6] >= 0.5 ? aleatorio.generarRandNormal(vector_estados2[7], vector_estados2[8], _MEDIA_M, _SIGMA) : 50;
            vector_estados2[10] = aleatorio.generarRandExponencial(_MEDIA_T);
            vector_estados2[11] = vector_estados2[10] + vector_estados2[9];

            //---------------------------------VENTAS----------------------------------------------------------//
            double disponible_dia = (vector_estados1[16] + vector_estados2[5]) > _STOCK_MAX ? _STOCK_MAX : (vector_estados1[16] + vector_estados2[5]);//lo que me quedó de ayer más lo que pudo llegar hoy
            vector_estados2[12] = vector_estados2[11] < disponible_dia ? vector_estados2[11] : vector_estados1[16];
            double faltante = (disponible_dia - vector_estados2[11]) < 0 ? (disponible_dia - vector_estados2[11]) : 0;

            vector_estados2[13] = vector_estados2[12] * _PRECIO_VENTA;
            vector_estados2[14] = vector_estados2[13] + vector_estados1[14];
            if (i != 0)
            {
                vector_estados2[15] = (1/i)*((i - 1)*vector_estados1[15] + vector_estados2[13]); //Ganancia Media
            }
            //---------------------------------STOCK----------------------------------------------------------//
            double remanente = Math.Round(vector_estados1[16] - vector_estados2[12] + vector_estados2[5],3);
            vector_estados2[16] = (remanente) > _STOCK_MAX ? _STOCK_MAX : remanente;
            vector_estados2[17] = Math.Round(vector_estados2[16] / _GRAMOS_X_FRASCO,3);
            vector_estados2[18] = Math.Round(vector_estados2[16] / _STOCK_MAX,3);
            vector_estados2[30]=faltante != 0 ? vector_estados2[30] += 1 : vector_estados2[30] += 0; //contador dias con faltante
            vector_estados2[19] = vector_estados2[30] / (i + 1);

            //cuento la cantidad de frascos guardados
            if (vector_estados2[17] < 2) vector_estados2[31]++;
            else if (2 <= vector_estados2[17] && vector_estados2[17] < 5) vector_estados2[32]++;
            else if (5 <= vector_estados2[17] && vector_estados2[17] < 8) vector_estados2[33]++;
            else if (vector_estados2[17] > 8) vector_estados2[34]++;

            vector_estados2[20] = vector_estados2[31]/ (i+1);
            vector_estados2[21] = vector_estados2[32]/ (i+1);
            vector_estados2[22] = vector_estados2[33]/ (i+1);
            vector_estados2[23] = vector_estados2[34]/ (i+1);

            //---------------------------------COSTOS----------------------------------------------------------//

            //vector_estados2[20] = faltante < 0 ? faltante * _COSTO_FALTANTE : 0;
            vector_estados2[24] = faltante * _COSTO_FALTANTE;
            vector_estados2[25] = vector_estados2[1] == 0 ? vector_estados2[4] * _COSTO_X_FRASCO : 0;
            vector_estados2[26] = vector_estados2[24] + vector_estados2[25] + vector_estados1[26];
            //-------------------------------------------------------------------------------------------------//

            vector_estados1 = vector_estados2;   
        }

        public Gestor(string dias, string cantFrascos, string gramos, string costoFrasco, string precioVenta, string stockMax, string frecuenciaCompra, string horasM, string horasT)
        {
            _DIAS = Convert.ToInt32(dias);
            _CANT_FRASCOS = Convert.ToInt32(cantFrascos);
            _GRAMOS_X_FRASCO = Convert.ToInt32(gramos);
            _COSTO_X_FRASCO = Convert.ToDouble(costoFrasco);
            _PRECIO_VENTA = Convert.ToDouble(precioVenta)/100; //REVISAR
            _STOCK_MAX = Convert.ToInt32(stockMax) * Convert.ToInt32(gramos);
            _FRECUENCIA_COMPRA = Convert.ToInt32(frecuenciaCompra) - 1;
            _HORAS_MAN = Convert.ToInt32(horasM);
            _HORAS_TAR = Convert.ToInt32(horasT);
        }
    }
}
