using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.dto
{
    public class CarreraDTO {
        public int n = 0;
        public int id = 0;
        public string nombre = null;
        public int id_facultad = 0;
        public string creado_en = null;
        public string modificado_en = null;
        public CarreraDTO() {}
        override
        public string ToString() {
            return nombre;
        }
    }
}
