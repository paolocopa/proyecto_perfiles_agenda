using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class PerfilTesis : Conexion
    {
        public PerfilTesis()
        {
            id = 0;
            tema = "";
            estado = "";
            fecha_presentacion_perfil = "";
            fecha_aprobacion_tesis = "";
            id_licenciado = 0;

        }
        #region atributos 

        private int id;
        private string tema;
        private string estado;
        private string fecha_presentacion_perfil;
        private string fecha_aprobacion_tesis;
        private int id_licenciado;

        #endregion
        #region Propiedades

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Tema
        {
            get { return tema; }
            set { tema = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string Fecha_presentacion_perfil
        {
            get { return fecha_presentacion_perfil; }
            set { fecha_presentacion_perfil = value; }
        }
        public string Fecha_aprobacion_tesis
        {
            get { return fecha_aprobacion_tesis; }
            set { fecha_aprobacion_tesis = value; }
        }
        public int Id_licenciado
        {
            get { return id_licenciado; }
            set { id_licenciado = value; }

        }


        #endregion
        #region Metodos

        public void NuevoPerfil()
        {
            abrirConexion();
            string insertSQL = " INSERT INTO perfil_tesis VALUES (" + Id + ", '" + Tema + "', '" + Estado + "', '" + Fecha_presentacion_perfil + "','" + Fecha_aprobacion_tesis + "', " + Id_licenciado + ", '','' ); ";
            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(insertSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();
        }
        public void ModificarPerfil(int id)
        {
            abrirConexion();
            string updateSQL = " UPDATE perfil_tesis " +
                         " SET tema = '" + Tema + "', estado = '" + Estado + "', fecha_presentacion_perfil = '" + Fecha_presentacion_perfil + "', fecha_aprobacion_tesis = '" + Fecha_aprobacion_tesis + "', id_licenciado = " + Id_licenciado + " " +
                         " WHERE id = " + id + " ; ";

            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(updateSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();

        }
        public void EliminarPerfil(int id)
        {
            abrirConexion();
            string deleteSQL = " DELETE FROM perfil_tesis WHERE id = " + id + " ; ";
            SQLiteTransaction sqlTransaction = Cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(deleteSQL, Cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();
        }


        #endregion
    }
}
