using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Licenciado : Conexion
    {
        public Licenciado()
        {
            id = 0;
            nombre = "";
            apellido = "";
            descripcion = "";
            email = "";
            telefono = "";
            celular = "";
            id_institucion = 0;
            id_carrera_externa = 0;
        }


        #region Atributos
        private int id;
        private string nombre;
        private string apellido;
        private string descripcion;
        private string email;
        private string telefono;
        private string celular;
        private int id_institucion;
        private int id_carrera_externa;



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
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
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
        public int Id_institucion
        {
            get { return id_institucion; }
            set { id_institucion = value; }
        }
        public int Id_carrera_externa
        {
            get { return id_carrera_externa; }
            set { id_carrera_externa = value; }
        }









        #endregion

        #region Metodos

        public void NuevoLicenciado()
        {
            abrirConexion();
            string insertSQL = " INSERT INTO licenciado VALUES (" + Id + ",'" + Nombre + "', '" + Apellido + "','" + Descripcion + "','" + Email + "', '" + Telefono + "','" + Celular + "', " + Id_institucion + "," + Id_carrera_externa + ", '',''  ); ";
            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(insertSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();

        }
        public void ModificarLicenciado(int id)
        {
            abrirConexion();
            string updateSQL = " UPDATE licenciado " +
                         " SET nombre = '" + Nombre + "', apellido = '" + Apellido + "', descripcion = '" + Descripcion + "', email = '" + Email + "', telefono = '" + Telefono + "', celular = '" + Celular + "', id_institucion = " + Id_institucion + ", id_carrera_externa = " + Id_carrera_externa + "  " +
                         " WHERE id = " + id + " ; ";

            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(updateSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();

        }
        public void EliminarLicenciado(int id)
        {
            abrirConexion();
            string deleteSQL = " DELETE FROM licenciado WHERE id = " + id + " ; ";
            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(deleteSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();


        }


        #endregion
    }
}
