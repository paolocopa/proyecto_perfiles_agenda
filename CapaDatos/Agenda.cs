using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Agenda : Conexion
    {


        public Agenda()
        {
            id = 0;
            fecha_presentacion = "";
            hora = "";
            aula = "";
            id_tesis = 0;
            id_examen_grado = 0;

        }

        #region Atributos

        private int id;
        private string fecha_presentacion;
        private string hora;
        private string aula;
        private int id_tesis;
        private int id_examen_grado;

        #endregion
        #region Propiedades

        public int Id //property
        {
            get { return id; }   // get method
            set { id = value; }  // set method
        }
        public string Fecha_presentacion //property
        {
            get { return fecha_presentacion; }   // get method
            set { fecha_presentacion = value; }  // set method
        }
        public string Hora  //property
        {
            get { return hora; }  // get method
            set { hora = value; } // set method
        }
        public string Aula  //property
        {
            get { return aula; }  // get method
            set { aula = value; } // set method

        }
        public int Id_tesis
        {
            get { return id_tesis; }  // get method
            set { id_tesis = value; } // set method

        }
        public int Id_examen_grado
        {
            get { return id_examen_grado; }  // get method
            set { id_examen_grado = value; } // set method

        }





        #endregion

        #region Metodos


        public void NuevaAgenda()
        {
            abrirConexion();
            string insertSQL = " INSERT INTO agenda VALUES (" + Id + ",'" + Fecha_presentacion + "','" + Hora + "','" + Aula + "'," + Id_tesis + "," + Id_examen_grado + ",'','' ); ";
            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(insertSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();

        }
        public void ModificarAgenda(int id)
        {
            abrirConexion();
            string updateSQL = " UPDATE agenda " +
                         " SET fecha_presentacion = '" + Fecha_presentacion + "', hora = '" + Hora + "', aula = '" + Aula + "', id_tesis = " + Id_tesis + ", id_examen_grado = " + Id_examen_grado + " " +
                         " WHERE id = " + id + " ; ";

            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(updateSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();

        }


        public void EliminarAgenda(int id)
        {
            abrirConexion();
            string deleteSQL = " DELETE FROM agenda WHERE id = " + id + " ; ";
            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(deleteSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();


        }
        public DataTable MostrarAgendas()
        {

            string sql = " select AG.id as idagenda, AG.fecha_presentacion as fecha ,AG.hora as Hora,AG.aula as Aula,PF.tema as Tema, EG.fecha_aprobacion as Fechaaprobacion, ES.registro as Registro, ES.nombre as Nombres, ES.apellido as Apellidos, CA.nombre as Carreras,FA.nombre as Facultad " +
                           " from agenda AG inner join perfil_tesis PF on AG.id_tesis = PF.id inner join examen_grado as EG on AG.id_examen_grado = EG.id inner join estudiante as ES on EG.id_estudiante = ES.id inner join carrera as CA on ES.id_carrera = CA.id inner join facultad as FA on CA.id_facultad = FA.id ";

            abrirConexion();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, Cnx);
            DataTable ds = new DataTable();
            da.Fill(ds);
            Cnx.Close();
            return ds;
        }
        public DataTable MostrarAgendas(string criterio)
        {

            string sql = " SELECT * FROM  (select AG.id as idagenda, AG.fecha_presentacion as fecha ,AG.hora as Hora,AG.aula as Aula,PF.tema as Tema, EG.fecha_aprobacion as Fechaaprobacion, ES.registro as Registro, ES.nombre as Nombres, ES.apellido as Apellidos, CA.nombre as Carreras,FA.nombre as Facultad " +
                           " from agenda AG inner join perfil_tesis PF on AG.id_tesis = PF.id inner join examen_grado as EG on AG.id_examen_grado = EG.id inner join estudiante as ES on EG.id_estudiante = ES.id inner join carrera as CA on ES.id_carrera = CA.id inner join facultad as FA on CA.id_facultad = FA.id)  " +
                           " WHERE Carreras LIKE '%"+criterio+"%'  ";

            abrirConexion();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, Cnx);
            DataTable ds = new DataTable();
            da.Fill(ds);
            Cnx.Close();
            return ds;
        }


        #endregion











    }
}
