using System;
using System.Collections.Generic;
using System.Data;

namespace Preparcial
{
    public class UsuarioDAO
    {
        public static List<Usuario> getLista()
        {
            string sql = "SELECT * FROM \"Cliente\"";

            DataTable dt = Conexion.realizarConsulta(sql);
            List<Usuario> lista = new List<Usuario>();
            foreach (DataRow fila in dt.Rows)
            {
                Usuario u = new Usuario();
                u.usuario = fila[0].ToString();
                u.contrasena = fila[1].ToString();
                u.admin = Convert.ToBoolean(fila[2].ToString());
                lista.Add(u);
            }
            return lista;
        }
        
        //public static List<>
    }
}