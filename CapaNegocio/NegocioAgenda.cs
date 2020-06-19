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
        public DataTable AgendasCriterio(string criterio)
        {
            return objagenda.MostrarAgendas(criterio);

        }
        
    }
}
