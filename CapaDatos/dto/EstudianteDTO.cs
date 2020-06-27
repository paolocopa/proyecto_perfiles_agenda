using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.dto
{
    public class EstudianteDTO {

        public int n = 0;
        public int id = 0;
        public string registro = null;
        public string nombre = null;
        public string apellido = null;
        public string email = null;
        public string telefono = null;
        public string celular = null;
        public string direccion = null;
        public int id_carrera = 0;
        public int id_tesis = 0;
        public string creado_en = null;
        public string modificado_en = null;

        public CarreraDTO carrera;
        public PerfilTesisDTO perfilTesis;
        public EstudianteDTO() { }
    }
}
