using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ExamenGrado : Conexion
    {
        public ExamenGrado()
        {
            id = 0;
            fecha_aprobacion = "";
            id_estudiante = 0;

        }
        #region Atributos
        private int id;
        private string fecha_aprobacion;
        private int id_estudiante;


        #endregion

        #region Propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Fecha_aprobacion
        {
            get { return fecha_aprobacion; }
            set { fecha_aprobacion = value; }
        }
        public int Id_estudiante
        {
            get { return id_estudiante; }
            set { id_estudiante = value; }
        }

        #endregion


        #region Metodos

        public void NuevoExamenGrado()
        {
            abrirConexion();
            string insertSQL = " INSERT INTO examen_grado VALUES ( " + Id + ",'" + Fecha_aprobacion + "'," + Id_estudiante + ", '', ''  ); ";
            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(insertSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();

        }
        public void ModificarExamenGrade()
        {
            abrirConexion();
            string updateSQL = " UPDATE examen_grado " +
                         " SET fecha_aprobacion = '" + Fecha_aprobacion + "', id_estudiante = " + Id_estudiante + " " +
                         " WHERE id = " + id + " ; ";

            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(updateSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();
        }
        public void EliminarExamenGrado()
        {
            abrirConexion();
            string deleteSQL = " DELETE FROM examen_grado WHERE id = " + id + " ; ";
            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(deleteSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();

        }


        #endregion
    }
}
