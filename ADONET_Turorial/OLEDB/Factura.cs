using System;
using System.Data.SqlTypes;

namespace OLEDB
{
    public class Factura
    {
        private int NumFactura { get;   }
        private String Nombre { get;   }
        private String NombreProducto { get;  }
        private int Cantidad { get;   }
        private int CantidadTotal { get;  }

        public Factura(int numFactura, string nombre, string nombreProducto, int cantidad, int cantidadTotal)
        {
            NumFactura = numFactura;
            Nombre = nombre;
            NombreProducto = nombreProducto;
            Cantidad = cantidad;
            CantidadTotal = cantidadTotal;
        }

        public override string ToString()
        {
            return NumFactura + " " + Nombre + " " + NombreProducto + " " + Cantidad + " " + CantidadTotal;
        }
    }
}