namespace ControleCarros.Models
{
    public class CarroModel
    {
        public int Id { get; set; }
        public string? Fabricante { get; set; }
        public int Modelo { get; set; }
        public int Ano { get; set; }
        public int Categoria { get; set; }

    }
}