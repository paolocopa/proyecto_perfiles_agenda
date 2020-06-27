using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.dto;

namespace CapaNegocio
{
    public class LicenciadoDAO
    {
        private Licenciado dao;
        public LicenciadoDAO() {
            dao = new Licenciado();
        }

        public List<LicenciadoDTO> cargarTutores() {
            return dao.cargarListado();
        }
    }
}
