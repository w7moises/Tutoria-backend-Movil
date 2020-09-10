using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutoFinder.Entity
{
    public class Tarjeta
    {
        public int TarjetaId { get; set; }
        public string Fecha_expiración { get; set; }
        public string Nombre_poseedor { get; set; }
        public string Numero_tarjeta { get; set; }
    }
}
