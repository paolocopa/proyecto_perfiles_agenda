using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.dto;

namespace CapaNegocio
{
    public class EstudianteDAO {
        private Estudiante dao;
        public EstudianteDAO() {
            dao = new Estudiante();
        }

        public List<EstudianteDTO> cargarEstudiantes(string uid, string busqueda) {
            return dao.cargarListado(uid, busqueda);
        }

        public List<CarreraDTO> cargarComboCarrera() {
            return dao.getComboCarrera();
        }

        public bool crearEstudiante(EstudianteDTO estudiante) {
            return dao.createEstudiante(estudiante);
        }
    }
}
