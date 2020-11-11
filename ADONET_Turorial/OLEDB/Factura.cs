using System;
using System.Data.SqlTypes;

namespace OLEDB
{
    public class Factura
    {
        private int _numFactura;
        private String _nombre;
        private String _nombreProducto;
        private int _cantidad;
        private int _cantidadTotal;
        public Factura(int numFactura, string nombre, string nombreProducto, int cantidad, int cantidadTotal)
        {
            _numFactura = numFactura;
            _nombre = nombre;
            _nombreProducto = nombreProducto;
            _cantidad = cantidad;
            _cantidadTotal = cantidadTotal;
        }

        public override string ToString()
        {
            return _numFactura+" "+_nombre + " " + _nombreProducto + " " + _cantidad + " " + _cantidadTotal;
        }
    }
}