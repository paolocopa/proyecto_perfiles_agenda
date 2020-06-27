using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.dto
{
    public class Licenciado :Conexion {
        public Licenciado() {}

        public List<LicenciadoDTO> cargarListado() {
            List<LicenciadoDTO> list = new List<LicenciadoDTO>();
            SQLiteConnection con = getConn();
            con.Open();
            string column = "c.*";
            column += ",d.tipo";
            column += ",d.funcion_licenciado";
            column += ",d.descripcion AS descripcion_tpl";

            string query = "SELECT " + column + " FROM licenciado c ";
            query += "INNER JOIN tipo_licenciado d ON d.id = c.id_tipo_licenciado ";
            SQLiteCommand command = new SQLiteCommand(query, con);            
            SQLiteDataReader result = command.ExecuteReader();
            if (result.HasRows) {
                int i = 0;
                while (result.Read()) {
                    LicenciadoDTO next = new LicenciadoDTO();
                    next.n = i;
                    next.id = int.Parse(result["id"].ToString());
                    next.nombre = result["nombre"].ToString();
                    next.apellido = result["apellido"].ToString();
                    next.descripcion = result["descripcion"].ToString();
                    next.email = result["email"].ToString();
                    next.telefono = result["telefono"].ToString();
                    next.celular = result["celular"].ToString();
                    next.docente = int.Parse(result["docente"].ToString()) == 0 ? false : true;
                    next.id_carrera_licenciado = int.Parse(result["id_carrera_licenciado"].ToString());
                    next.id_institucion_representada = int.Parse(result["id_institucion_representada"].ToString());
                    next.id_tipo_licenciado = int.Parse(result["id_tipo_licenciado"].ToString());
                    next.creado_en = result["creado_en"].ToString();
                    next.modificado_en = result["modificado_en"].ToString();

                    next.tipoLicenciado = new TipoLicenciadoDTO();
                    next.tipoLicenciado.id = int.Parse(result["id_tipo_licenciado"].ToString());
                    next.tipoLicenciado.tipo = result["tipo"].ToString();
                    next.tipoLicenciado.funcion_licenciado = result["funcion_licenciado"].ToString();
                    next.tipoLicenciado.descripcion = result["descripcion_tpl"].ToString();
                    list.Add(next);
                    i++;
                }
            }
            result.Close();
            con.Close();
            return list;
        }
    }
}
