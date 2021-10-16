using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5Aplicada.Entidades
{
    public class Inventario
    {
        public int ExistenciaProducto { get; set; }
        public string NombreProducto { get; set; }
        public string MarcaProducto { get; set; }
        public double PrecioProducto { get; set; }

        public Inventario()
        {
            ExistenciaProducto = 0;
            NombreProducto = "";
            MarcaProducto = "";
            PrecioProducto = 0;
        }

        public Inventario(int existenciaproducto, string nombreproducto, string marcaproducto, double precioproducto)
        {
            ExistenciaProducto = existenciaproducto;
            NombreProducto = nombreproducto;
            MarcaProducto = marcaproducto;
            PrecioProducto = precioproducto;
        }
    }
}
