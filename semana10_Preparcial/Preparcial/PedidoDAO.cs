using System;
using System.Collections.Generic;
using System.Data;

namespace Preparcial
{
    public class PedidoDAO
    {
        public static List<Pedido> getLista()
        {
            string sql = "SELECT * FROM \"Pedido\"";

            DataTable dt = Conexion.realizarConsulta(sql);
            List<Pedido> lista = new List<Pedido>();
            foreach (DataRow fila in dt.Rows)
            {
                Pedido p = new Pedido();
                p.pedido_id = Convert.ToInt32(fila[0].ToString());
                p.usuario = fila[1].ToString();
                p.producto_id = Convert.ToInt32(fila[2].ToString());
                p.cantidad_pr = Convert.ToInt32(fila[3].ToString());
                p.precio_T = Convert.ToInt32(fila[4].ToString());
                lista.Add(p);
            }
            return lista;
        }
    }
}