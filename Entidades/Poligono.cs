using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5Aplicada.Entidades
{
    public class Poligono
    {
        public int Lados { get; set; }
        public int Longitud { get; set; }
        public int Area { get; set; }

        public Poligono()
        {
            Lados = 0;
            Longitud = 0;
            Area = 0;
        }

        public Poligono(int lados, int longitud, int area)
        {
            Lados = lados;
            Longitud = longitud;
            Area = area;
        }



    }
}
