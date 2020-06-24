using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class NegocioPerfil
    {
        Carrera carrera = new Carrera();
        Licenciado licenciado = new Licenciado();
        PerfilTesis perfiltesis = new PerfilTesis();
        Estudiante estudiante = new Estudiante();

        public NegocioPerfil()
        {
            

        }


        #region FrmNuevoPerfil

        public DataTable cargarCarreras()
        {
            return carrera.Carreras();
        }
        public DataTable cargarLicenciados()
        {
            return licenciado.Licenciados();
        }
        public bool Perfil_insert(string tema, string estado, string fecha_presentacion,string registro, string nombre, string  apellido, string email, string telefono, string celular, int id_carrera, int id_licenciado)
        {
            try
            {
                perfiltesis.Tema = tema;
                perfiltesis.Estado = estado;
                perfiltesis.Fecha_presentacion_perfil = fecha_presentacion;
                perfiltesis.Fecha_aprobacion_tesis = "";
                perfiltesis.Id_licenciado = id_licenciado;
                perfiltesis.NuevoPerfil();
                estudiante.Registro = registro;
                estudiante.Nombre = nombre;
                estudiante.Apellido = apellido;
                estudiante.Email = email;
                estudiante.Telefono = telefono;
                estudiante.Celular = celular;
                estudiante.Id_carrera = id_carrera;
                estudiante.Id_tesis = perfiltesis.UltimoId();
                estudiante.NuevaEstudiante();
                return true;
            }
            catch
            {
                return false;
            }
               
            
    
           
        }
        
        #endregion
    }
}
