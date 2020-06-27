using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.dto
{
    public class LicenciadoDTO {
        public int n = 0;
        public int id = 0;
        public string nombre = null;
        public string apellido = null;
        public string descripcion = null;
        public string email = null;
        public string telefono = null;
        public string celular = null;
        public bool docente = false;
        public int id_tipo_licenciado = 0;
        public int id_institucion_representada = 0;
        public int id_carrera_licenciado = 0;
        public string creado_en = null;
        public string modificado_en = null;

        public TipoLicenciadoDTO tipoLicenciado;
        public LicenciadoDTO() {}
    }
}
