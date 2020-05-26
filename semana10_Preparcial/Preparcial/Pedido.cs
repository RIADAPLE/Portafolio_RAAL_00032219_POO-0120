namespace Preparcial
{
    public class Pedido
    {
        public int pedido_id { get; set; }
        
        public string usuario { get; set; }
        
        public int producto_id { get; set; }
        
        public int cantidad_pr { get; set; }
        
        public int precio_T { get; set; }
        
        public Pedido()
        {
            pedido_id = 0;
            usuario = "";
            producto_id = 0;
            cantidad_pr = 0;
            precio_T = 0;
        }
    }
}