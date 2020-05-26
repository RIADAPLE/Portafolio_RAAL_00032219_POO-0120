namespace Preparcial
{
    public class Prodcuto
    {
        public int producto_id { get; set; }
        
        public string nombre1 { get; set; }
        
        public int cantidad { get; set; }
        
        public int precio { get; set; }
        
        public string descripcion { get; set; }
        public Prodcuto()
        {
            producto_id = 0;
            nombre1 = "";
            cantidad = 0;
            precio = 0;
            descripcion = "";
        }
    }
}