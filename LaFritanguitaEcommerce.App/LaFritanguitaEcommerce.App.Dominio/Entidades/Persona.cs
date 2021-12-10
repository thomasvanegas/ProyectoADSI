using System;

namespace LaFritanguitaEcommerce.App.Dominio.Entidades
{
    public class Persona
    {

        // Atributos de la clase Persona
        private string id { get; set; }
        private string rol { get; set; }
        private string contrasena { get; set; }
        private string nombre { get; set; }
        private string apellidos { get; set; }
        private string tipoDocumento { get; set; }
        private string numeroDocumento { get; set; }
        private DateTime fechaNacimiento { get; set; } // Cambiar a tipo de dato -> DateTime -> using System;
        private short edad { get; set; }
        private Sexo sexo { get; set; }
        private string numeroCelular { get; set; }
        private string correoElectronico { get; set; }
        private string barrioResidencia { get; set; }
        private string direccionResidencia { get; set; }

    }
}