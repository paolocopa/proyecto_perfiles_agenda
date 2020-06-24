using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;


namespace CapaNegocio
{
    public class NegocioAgenda
    {
        Agenda objagenda = new Agenda();
        PerfilTesis objperfil = new PerfilTesis();

        
        #region FrmAgenda

        public DataTable Agendas()
        {
            return objagenda.MostrarAgendas();
        }
        public DataTable AgendasCriterio(string criterio)
        {
            return objagenda.MostrarAgendas(criterio);

        }
        #endregion


        #region FrmAgenda_agregar

        public bool Agenda_insert(int id, int id_perfil, int id_examen, string fecha, string hora, string aula)
        {
            objagenda.Id = id;
            objagenda.Fecha_presentacion = fecha;
            objagenda.Hora = hora;
            objagenda.Aula = aula;
            objagenda.Id_tesis = id_perfil;
            objagenda.Id_examen_grado = id_examen;


            //falta hacer el metodo en capaDatos.Agenda e instanciarlo s
            objagenda.NuevaAgenda();
            return true;

        }
        public DataTable cargarPerfilAprobadoNoAgendado()
        {
           return objperfil.PerfilesAprobadosNoAgendados();
        }
        public DataTable cargarPerfilSeleccionado(int id)
        {
            return objperfil.PerfilSeleccionado(id);
        }


        #endregion


        #region FrmAgenda_modificar


        #endregion







    }
}
