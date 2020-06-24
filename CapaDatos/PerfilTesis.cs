using System;
using System.Collections.Generic;
using System.Data;
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
            string insertSQL = " INSERT INTO perfil_tesis VALUES ( null , '" + Tema + "', '" + Estado + "', '" + Fecha_presentacion_perfil + "','" + Fecha_aprobacion_tesis + "', " + Id_licenciado + ", '','' ); ";
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

        public DataTable PerfilesAprobadosNoAgendados()
        {
            abrirConexion();
            string sql = " SELECT * FROM perfil_tesis WHERE perfil_tesis.id not in (SELECT agenda.id from agenda) and  (perfil_tesis.estado like '%Aprobado%'); ";
            SQLiteCommand cmd = new SQLiteCommand(sql, Cnx);
            DataTable items = new DataTable();
            items.Load(cmd.ExecuteReader());
            return items;


        }
        public DataTable PerfilSeleccionado(int id)
        {
            string sql = " SELECT * FROM ( SELECT perfil_tesis.id as id_perfil ,estudiante.registro as registro, estudiante.nombre as nombre, estudiante.apellido as apellido, carrera.nombre as carrera,perfil_tesis.tema as tema, licenciado.nombre as tutornombre, licenciado.apellido as tutorapellido from perfil_tesis, estudiante, carrera, licenciado where perfil_tesis.id = estudiante.id_tesis and estudiante.id_carrera = carrera.id and licenciado.id = perfil_tesis.id_licenciado )" +
                                " WHERE id_perfil = " + id + "; ";
            //
            string sql1 = " SELECT * from (SELECT perfil_tesis.id as id_perfil ,estudiante.registro as registro, estudiante.nombre as nombre, estudiante.apellido as apellido, carrera.nombre as carrera,perfil_tesis.tema as tema, licenciado.nombre as tutornombre, licenciado.apellido as tutorapellido, examen_grado.id as id_examen from perfil_tesis, estudiante, carrera, licenciado, examen_grado where perfil_tesis.id = estudiante.id_tesis and estudiante.id_carrera = carrera.id and licenciado.id = perfil_tesis.id_licenciado and examen_grado.id_estudiante = estudiante.id )" +
                         " WHERE id_perfil = " + id + "; ";
            abrirConexion();
            SQLiteCommand cmd = new SQLiteCommand(sql1, Cnx);
            DataTable items = new DataTable();
            items.Load(cmd.ExecuteReader());
            return items;

        }
        public int UltimoId()
        {
            int id = 0;
            string sql = "  SELECT * FROM perfil_tesis WHERE ID = (SELECT MAX(ID) FROM perfil_tesis); ";
            abrirConexion();
            SQLiteCommand cmd = new SQLiteCommand(sql, Cnx);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);

            }
            return id;
        }
        public DataTable mostrarPerfiles()
        {
            string sql = " SELECT es.registro as Registro, es.nombre as Nombre, es.apellido as Apellido , es.email as Email, es.telefono as Telefono, es.celular as Celular, pf.tema as Tema,pf.estado as Estado, pf.fecha_presentacion_perfil as Fecha_Presentacion, lic.nombre as Tutor, ca.nombre as Carrera, fa.nombre as Facultad  "+
                "  FROM facultad fa INNER JOIN carrera ca on ca.id_facultad = fa.id INNER JOIN estudiante es on es.id_carrera = ca.id INNER JOIN perfil_tesis pf ON es.id_tesis = pf.id INNER JOIN licenciado lic ON pf.id_licenciado = lic.id;  ";
            abrirConexion();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, Cnx);
            DataTable ds = new DataTable();
            da.Fill(ds);
            Cnx.Close();
            return ds;
        }
        public DataTable mostrarPerfiles(string criterio)
        {
            string sql = " SELECT es.registro as Registro, es.nombre as Nombre, es.apellido as Apellido , es.email as Email, es.telefono as Telefono, es.celular as Celular, pf.tema as Tema,pf.estado as Estado, pf.fecha_presentacion_perfil as Fecha_Presentacion, lic.nombre as Tutor, ca.nombre as Carrera, fa.nombre as Facultad  " +
                "  FROM facultad fa INNER JOIN carrera ca on ca.id_facultad = fa.id INNER JOIN estudiante es on es.id_carrera = ca.id INNER JOIN perfil_tesis pf ON es.id_tesis = pf.id INNER JOIN licenciado lic ON pf.id_licenciado = lic.id  "+
                " WHERE Carrera LIKE '%" + criterio + "%'  ";
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
