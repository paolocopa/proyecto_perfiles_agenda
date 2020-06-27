using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.dto;
using System.Windows;

namespace CapaDatos
{
    public class Estudiante : Conexion {
        public Estudiante() {
        }
        #region method

        public List<EstudianteDTO> cargarListado(string uid, string busqueda) {
            List<EstudianteDTO> list = new List<EstudianteDTO>();
            SQLiteConnection con = getConn();
            con.Open();
            string column = "c.*";
            column += ",d.id_facultad";
            column += ",e.tema";
            column += ",e.estado";
            column += ",e.fecha_recepcion_titulacion";
            column += ",e.fecha_aprobacion_jefe_carrera";
            column += ",e.calificacion";
            column += ",e.id_tutor";
            column += ",e.estado_defensa";
            column += ",d.nombre AS nombre_carrera";
            column += ",f.id AS id_licenciado";
            column += ",f.nombre AS nombre_licenciado";
            column += ",f.apellido AS apellido_licenciado";
            column += ",f.email AS email_licenciado";
            column += ",f.telefono AS telefono_licenciado";
            column += ",f.celular AS celular_licenciado";
            column += ",f.descripcion AS descripcion_licenciado";
            column += ",f.docente";
            column += ",f.id_tipo_licenciado";
            column += ",f.id_institucion_representada";
            column += ",f.id_carrera_licenciado";
            column += ",g.tipo AS tipo_licenciado";
            column += ",g.funcion_licenciado";
            column += ",g.descripcion AS descripcion_tipo_licenciado";

            string query = "SELECT " + column + " FROM estudiante c ";
            query += "INNER JOIN carrera d ON d.id = c.id_carrera ";
            query += "INNER JOIN perfil_tesis e ON e.id = c.id_tesis ";
            query += "INNER JOIN licenciado f ON f.id = e.id_tutor ";
            query += "INNER JOIN tipo_licenciado g ON g.id = f.id_tipo_licenciado ";
            query += "WHERE c.id_carrera = @uid ";
            if (busqueda != null) {
                query += " AND  ( ";
                query += " c.nombre || c.apellido LIKE @find ";
                query += " OR f.nombre || f.apellido LIKE @find ";
                query += " OR e.tema LIKE @find ";
                query += " OR c.registro LIKE @find ";
                query += " OR e.estado = @eqfind ";
                query += "  ) ";
            }
            //System.Diagnostics.Debug.WriteLine(query);
            SQLiteCommand command = new SQLiteCommand(query, con);
            command.Parameters.Add(new SQLiteParameter("@uid", uid));
            if (busqueda != null ) {
                command.Parameters.Add(new SQLiteParameter("@eqfind", busqueda));
                command.Parameters.Add(new SQLiteParameter("@find", "%"+ busqueda + "%"));
            } 
            command.Prepare();
            SQLiteDataReader result = command.ExecuteReader();
            if (result.HasRows) {
                int i = 0;
                while (result.Read()) {
                    EstudianteDTO next = new EstudianteDTO();      

                    next.n = i;
                    next.id = int.Parse(result["id"].ToString());
                    next.registro = result["registro"].ToString();
                    next.nombre = result["nombre"].ToString();
                    next.apellido = result["apellido"].ToString();
                    next.email = result["email"].ToString();
                    next.telefono = result["telefono"].ToString();
                    next.celular = result["celular"].ToString();
                    next.id_carrera = int.Parse(result["id_carrera"].ToString());
                    next.id_tesis = int.Parse(result["id_tesis"].ToString());
                    next.creado_en = result["creado_en"].ToString();
                    next.modificado_en = result["modificado_en"].ToString();
                    //next.direccion = result["direccion"].ToString();

                    next.perfilTesis = new PerfilTesisDTO();
                    next.perfilTesis.id = int.Parse( result["id_tesis"].ToString() );
                    next.perfilTesis.tema = result["tema"].ToString();
                    next.perfilTesis.estado = result["estado"].ToString();
                    next.perfilTesis.fecha_aprobacion_jefe_carrera = result["fecha_aprobacion_jefe_carrera"].ToString();
                    next.perfilTesis.fecha_recepcion_titulacion = result["fecha_recepcion_titulacion"].ToString();
                    next.perfilTesis.id_tutor = int.Parse(result["id_tutor"].ToString());

                    next.perfilTesis.licenciado = new LicenciadoDTO();
                    next.perfilTesis.licenciado.id = int.Parse(result["id_licenciado"].ToString());
                    next.perfilTesis.licenciado.nombre = result["nombre_licenciado"].ToString();
                    next.perfilTesis.licenciado.apellido = result["apellido_licenciado"].ToString();
                    next.perfilTesis.licenciado.descripcion = result["descripcion_licenciado"].ToString();
                    next.perfilTesis.licenciado.email = result["email_licenciado"].ToString();
                    next.perfilTesis.licenciado.telefono = result["telefono_licenciado"].ToString();
                    next.perfilTesis.licenciado.celular = result["celular_licenciado"].ToString();
                    next.perfilTesis.licenciado.id_carrera_licenciado = int.Parse(result["id_carrera_licenciado"].ToString());
                    next.perfilTesis.licenciado.id_institucion_representada = int.Parse(result["id_institucion_representada"].ToString());
                    next.perfilTesis.licenciado.id_tipo_licenciado = int.Parse(result["id_tipo_licenciado"].ToString());
                    next.perfilTesis.licenciado.docente = int.Parse(result["docente"].ToString()) == 0 ? false : true;

                    next.perfilTesis.licenciado.tipoLicenciado = new TipoLicenciadoDTO();
                    next.perfilTesis.licenciado.tipoLicenciado.id = int.Parse(result["id_tipo_licenciado"].ToString());
                    next.perfilTesis.licenciado.tipoLicenciado.tipo = result["tipo_licenciado"].ToString();
                    next.perfilTesis.licenciado.tipoLicenciado.funcion_licenciado = result["funcion_licenciado"].ToString();
                    next.perfilTesis.licenciado.tipoLicenciado.descripcion = result["descripcion_tipo_licenciado"].ToString();

                    next.carrera = new CarreraDTO();
                    next.carrera.id = int.Parse(result["id_carrera"].ToString());
                    next.carrera.nombre = result["nombre_carrera"].ToString();
                    next.carrera.id_facultad = int.Parse(result["id_facultad"].ToString());                               

                    list.Add(next);                    
                    i++;
                }
            }
            result.Close();
            con.Close();
            return list;
        }

        public List<CarreraDTO> getComboCarrera() {
            List<CarreraDTO> list = new List<CarreraDTO>();
            SQLiteConnection con = getConn();
            con.Open();
            string query = "SELECT * FROM carrera c";            
            SQLiteCommand command = new SQLiteCommand(query, con);            
            command.Prepare();
            SQLiteDataReader result = command.ExecuteReader();
            if (result.HasRows) {
                int i = 0;
                while (result.Read()) {
                    CarreraDTO next = new CarreraDTO();
                    next.n = i;
                    next.id = int.Parse(result["id"].ToString());
                    next.nombre = result["nombre"].ToString();
                    next.id_facultad = int.Parse(result["id_facultad"].ToString());
                    next.creado_en = result["creado_en"].ToString();
                    next.modificado_en = result["modificado_en"].ToString();
                    list.Add(next);
                    i++;
                }
            }
            result.Close();
            con.Close();
            return list;
        }

        public bool createEstudiante(EstudianteDTO estudiante) {
            bool res = false;
            SQLiteConnection con = getConn();
            con.Open();
            SQLiteCommand command = null;
            string query = "";
            int lastId = 0;
            try {
                query = "INSERT INTO perfil_tesis (id_tutor, tema, estado, estado_defensa) ";
                query += "VALUES (?,?,?,?); SELECT last_insert_rowid();";
                command = new SQLiteCommand(query, con);
                /*set perfil tesis*/
                command.Parameters.Add(new SQLiteParameter("param1", estudiante.perfilTesis.licenciado.id)); 
                command.Parameters.Add(new SQLiteParameter("param2", estudiante.perfilTesis.tema));
                command.Parameters.Add(new SQLiteParameter("param3", "en revision"));
                command.Parameters.Add(new SQLiteParameter("param4", "none"));
                command.Prepare();
                lastId = Convert.ToInt32(command.ExecuteScalar());

                /*set estudiante*/
                query = "INSERT INTO estudiante (registro, nombre, apellido, email, telefono, celular, id_carrera, id_tesis) ";
                query += "VALUES (?,?,?,?,?,?,?,?);";
                command = new SQLiteCommand(query, con);
                command.Parameters.Add(new SQLiteParameter("param1", estudiante.registro));
                command.Parameters.Add(new SQLiteParameter("param2", estudiante.nombre));
                command.Parameters.Add(new SQLiteParameter("param3", estudiante.apellido));
                command.Parameters.Add(new SQLiteParameter("param4", estudiante.email));
                command.Parameters.Add(new SQLiteParameter("param5", estudiante.telefono));
                command.Parameters.Add(new SQLiteParameter("param6", estudiante.celular));
                command.Parameters.Add(new SQLiteParameter("param7", estudiante.id_carrera));
                command.Parameters.Add(new SQLiteParameter("param8", lastId));

                /*execute*/
                command.Prepare();
                command.ExecuteNonQuery();
                res = true;
            } catch (SQLiteException e) {
                System.Diagnostics.Debug.WriteLine("Error execute => " + e.Message);
                //MessageBox.Show("Estudiante " + estudiante.nombre + " creado!!!");
            } catch (Exception e){
                System.Diagnostics.Debug.WriteLine("Error execute ex => " + e.Message);
            }
            con.Close();
            return res;
        }
        #endregion
    }
}
