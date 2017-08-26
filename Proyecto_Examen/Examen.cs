using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Examen
{
    public class Examen
    {
        public int CodigoExamen { set; get; }
        public string NombreExamen { set; get; }
        public DateTime FechaCreacion { set; get; }
        public string Indicaciones { set; get; }
        public DateTime InicioExamen { set; get; }
        public DateTime FinalExamen { set; get; }
    }
}
