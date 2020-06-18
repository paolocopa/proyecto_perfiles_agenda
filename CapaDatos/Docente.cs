using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Docente : Conexion
    {

        public Docente()
        {
            id = 0;
            nombre = "";
            apellido = "";
            email = "";
            telefono = "";
            celular = "";
        }


        #region Atributos
        private int id;
        private string nombre;
        private string apellido;
        private string email;
        private string telefono;
        private string celular;



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
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }

        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; }

        }




        #endregion

        #region Metodos

        public void NuevoDocente()
        {
            abrirConexion();
            string insertSQL = " INSERT INTO docente VALUES (" + Id + ",'" + Nombre + "', '" + Apellido + "','" + Email + "', '" + Telefono + "','" + Celular + "',  '',''  ); ";
            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(insertSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();

        }
        public void ModificarDocente(int id)
        {
            abrirConexion();
            string updateSQL = " UPDATE docente " +
                         " SET nombre = '" + Nombre + "', apellido = '" + Apellido + "',  email = '" + Email + "', telefono = '" + Telefono + "', celular = '" + Celular + "'  " +
                         " WHERE id = " + id + " ; ";

            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(updateSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();

        }
        public void EliminarDocente(int id)
        {
            abrirConexion();
            string deleteSQL = " DELETE FROM docente WHERE id = " + id + " ; ";
            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(deleteSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();


        }


        #endregion
    }
}
