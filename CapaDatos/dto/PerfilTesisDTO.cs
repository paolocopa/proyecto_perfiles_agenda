using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.dto
{
    public class PerfilTesisDTO    {
        public int n = 0;
        public int id = 0;
        public int id_tutor = 0;
        public string tema = null;
        public string estado = null;
        public string fecha_aprobacion_jefe_carrera = null;
        public string fecha_recepcion_titulacion = null;
        public string estado_defensa = null;
        public float calificacion = 0;
        public string creado_en = null;
        public string modificado_en = null;

        public LicenciadoDTO licenciado = null;
        public PerfilTesisDTO() { }
    }
}
