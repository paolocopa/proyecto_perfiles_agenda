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

        public DataTable Agendas()
        {
            return objagenda.MostrarAgendas();
        }

        public bool Agenda_insert(int id, int id_perfil, int id_examen, string fecha, string hora, string aula)
        {
            objagenda.Id = id;
            objagenda.Fecha_presentacion = fecha;
            objagenda.Hora = hora;
            objagenda.Aula = aula;
            objagenda.Id_tesis = id_perfil;
            objagenda.Id_examen_grado = id_examen;
            objagenda.NuevaAgenda();

            //falta hacer el metodo en capaDatos.Agenda e instanciarlo s
            return true;

        }
        public bool Agenda_Update( string fecha, string hora, string aula, int id)
        {
            objagenda.Id = id;
            objagenda.Fecha_presentacion = fecha;
            objagenda.Hora = hora;
            objagenda.Aula = aula;

            objagenda.ModificarAgenda();

            return true;
        }
        
    }
}
