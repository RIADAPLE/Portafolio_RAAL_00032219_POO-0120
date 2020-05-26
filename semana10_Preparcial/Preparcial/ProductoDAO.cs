using System;
using System.Collections.Generic;
using System.Data;

namespace Preparcial
{
    public class ProductoDAO
    {
        public static List<Prodcuto> getLista()
        {
            string sql = "SELECT * FROM \"Inventario\"";

            DataTable dt = Conexion.realizarConsulta(sql);
            List<Prodcuto> lista = new List<Prodcuto>();
            foreach (DataRow fila in dt.Rows)
            {
                Prodcuto p = new Prodcuto();
                p.producto_id = Convert.ToInt32(fila[0].ToString());
                p.cantidad = Convert.ToInt32(fila[1].ToString());
                p.precio = Convert.ToInt32(fila[2].ToString());
                p.nombre1 = fila[3].ToString();
                p.descripcion = fila[4].ToString();
                lista.Add(p);
            }
            return lista;
        }
    }
}