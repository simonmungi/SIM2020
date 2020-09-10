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

        //


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
