using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutoFinder.Entity;

namespace TutoFinder.Dto
{
    public class DocenteCreateDto
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string Domicilio { get; set; }
        public string Correo { get; set; }
        public double Costo { get; set; }
        public bool Status_Disponibilidad { get; set; }
        public string Numero_cuenta { get; set; }
        public bool Status_Membresia { get; set; }
        public string Membresia { get; set; }
    }
    public class DocenteUpdateDto
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string Domicilio { get; set; }
        public string Correo { get; set; }
        public double Costo { get; set; }
        public bool Status_Disponibilidad { get; set; }
        public string Numero_cuenta { get; set; }
        public bool Status_Membresia { get; set; }
        public string Membresia { get; set; }
    }
    public class DocenteDto
    {
        public int DocenteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string Domicilio { get; set; }
        public string Correo { get; set; }
        public double Costo { get; set; }
        public bool Status_Disponibilidad { get; set; }
        public string Disponibilidad { get; set; }
        public string Numero_cuenta { get; set; }
        public bool Status_Membresia { get; set; }
        public string Membresia { get; set; }

    }
    public class DocenteDtoPresentar
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public string Domicilio { get; set; }
        public string Correo { get; set; }
        public double Costo { get; set; }
        public string Disponibilidad { get; set; }
        public string Numero_cuenta { get; set; }
        public string Membresia { get; set; }
    }
}
