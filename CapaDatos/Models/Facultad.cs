﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class Facultad: Conexion, IMetodos
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
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }


        #endregion
        #region Metodos 

        
           

        private static string TableName = "facultad";
        public void Insert()
        {
            string sql = "  INSERT INTO " + TableName + " (  nombre  ) VALUES ( @parametro0); ";
            Object[] Parametros = new Object[] { Nombre};
            QueryBuilder(sql, Parametros);

        }
        public void Delete(int id)
        {
            string sql = " DELETE FROM " + TableName + " WHERE id = @parametro0 ; ";
            Object[] Parametros = new Object[] { id };
            QueryBuilder(sql, Parametros);

        }
        public void Update(int id)
        {
            string sql = " UPDATE " + TableName + "  SET  nombre = @parametro0   WHERE id = @parametro1 ; ";

            Object[] Parametros = new Object[] {  Nombre, id };
            QueryBuilder(sql, Parametros);

        }

        public DataTable Select()
        {
            return SelectConexion(TableName);
        }
        public int LastId()
        {

            return LastIdConexion(TableName);
        }
       
        #endregion

    }
}
