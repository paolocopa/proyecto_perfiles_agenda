using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Carrera : Conexion
    {
        public Carrera()
        {
            id = 0;
            nombre = "";
            id_facultad = 0;
        }

        #region Atributos
        private int id;
        private string nombre;
        private int id_facultad;

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
        public int Id_facultad
        {
            get { return id_facultad; }
            set { id_facultad = value; }
        }


        #endregion
        #region Metodos

        public void NuevaCarrera()
        {
            abrirConexion();
            string insertSQL = " INSERT INTO carrera VALUES (" + Id + ", '" + Nombre + "', " + Id_facultad + ", '', '' ); ";
            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(insertSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();
        }
        public void ModificarCarrera(int id)
        {
            abrirConexion();
            string updateSQL = " UPDATE carrera " +
                         " SET nombre = '" + Nombre + "', id_facultad = " + Id_facultad + " " +
                         " WHERE id = " + id + " ; ";

            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(updateSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();

        }
        public void EliminarCarrera(int id)
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
