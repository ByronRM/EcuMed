using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace EcuMed
{
    public class Usuario
    {
        [PrimaryKey, ]
        [MaxLength(13)]
        public string cedula { get; set; }

        [MaxLength(50)]
        public string nombre { get; set; }

        [MaxLength(50)]
        public string apellido { get; set; }

        [MaxLength(50)]
        public string edad { get; set; }

        [MaxLength(50)]
        public string telefono { get; set; }

        [MaxLength(50)]
        public string correo { get; set; }

        [MaxLength(50)]
        public string direccion { get; set; }

        [MaxLength(50)]
        public string estado { get; set; }

        [MaxLength(50)]
        public string fecCreacion { get; set; }

        [MaxLength(50)]
        public string nombreUsuario { get; set; }

        [MaxLength(50)]

        public string contrasena { get; set; }
    }
}

