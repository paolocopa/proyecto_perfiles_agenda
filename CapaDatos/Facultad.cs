using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Facultad : Conexion
    {
        public Facultad()
        {
            id = 0;
            nombre = "";
        }

        #region Atributos
        private int id;
        private string nombre;

        #endregion
        #region Propiedades

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        #endregion
        #region Metodos

        public void NuevaFacultad()
        {
            abrirConexion();
            string insertSQL = " INSERT INTO facultad VALUES (" + Id + ", '" + Nombre + "', '', '' ); ";
            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(insertSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();
        }
        public void ModificarFacultad(int id)
        {
            abrirConexion();
            string updateSQL = " UPDATE facultad " +
                         " SET nombre = '" + Nombre + "'  " +
                         " WHERE id = " + id + " ; ";

            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(updateSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();

        }
        public void EliminarFacultad(int id)
        {
            abrirConexion();
            string deleteSQL = " DELETE FROM carrera WHERE id = " + id + " ; ";
            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(deleteSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();
        }

        #endregion
    }
}
