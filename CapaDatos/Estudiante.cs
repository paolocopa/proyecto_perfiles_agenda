using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Estudiante : Conexion
    {
        public Estudiante()
        {
            id = 0;
            registro = "";
            nombre = "";
            apellido = "";
            email = "";
            telefono = "";
            celular = "";
            id_carrera = 0;
            id_tesis = 0;
        }

        #region Atributos
        private int id;
        private string registro;
        private string nombre;
        private string apellido;
        private string email;
        private string telefono;
        private string celular;
        private int id_carrera;
        private int id_tesis;

        #endregion
        #region Propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Registro
        {
            get { return registro; }
            set { registro = value; }
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
        public int Id_carrera
        {
            get { return id_carrera; }
            set { id_carrera = value; }
        }
        public int Id_tesis
        {
            get { return id_tesis; }
            set { id_tesis = value; }
        }

        #endregion

        #region Metodos


        public void NuevaEstudiante()
        {
            abrirConexion();
            string insertSQL = " INSERT INTO estudiante VALUES (" + Id + ",'" + Registro + "','" + Nombre + "','" + Apellido + "','" + Email + "','" + Telefono + "','" + Celular + "'," + Id_carrera + " ," + Id_tesis + " ,'','' ); ";
            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(insertSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();

        }
        public void ModificarEstudiante(int id)
        {
            abrirConexion();
            string updateSQL = " UPDATE estudiante " +
                         " SET registro = '" + Registro + "', nombre = '" + Nombre + "', apellido = '" + Apellido + "', email = '" + Email + "', telefono = '" + Telefono + "', celular = '" + Celular + "',id_carrera = " + Id_carrera + ", id_tesis =  " + Id_tesis + "  " +
                         " WHERE id = " + id + " ; ";

            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(updateSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();


        }
        public void EliminarEstudiante(int id)
        {
            abrirConexion();
            string deleteSQL = " DELETE FROM estudiante WHERE id = " + id + " ; ";
            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(deleteSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();


        }
        public void ObtenerEstudiantes()
        {
            abrirConexion();
            string selectSQL = "SELECT * FROM estudiante ; ";

            SQLiteCommand command = new SQLiteCommand(selectSQL, Cnx);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                //reader.GetInt32(0) + reader.GetString(1) 
            }
        }

        #endregion
    }
}
