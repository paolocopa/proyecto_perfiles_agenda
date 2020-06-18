using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Institucion : Conexion
    {
        public Institucion()
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
        public void NuevaInstitucion()
        {
            abrirConexion();
            string insertSQL = " INSERT INTO institucion VALUES (" + Id + ", '" + Nombre + "', '', '' ); ";
            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(insertSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();
        }
        public void ModificarInstitucion(int id)
        {
            abrirConexion();
            string updateSQL = " UPDATE institucion " +
                         " SET nombre = '" + Nombre + "'  " +
                         " WHERE id = " + id + " ; ";

            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(updateSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();

        }
        public void EliminarInstitucion(int id)
        {
            abrirConexion();
            string deleteSQL = " DELETE FROM institucion WHERE id = " + id + " ; ";
            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(deleteSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();
        }



        #endregion



    }
}
