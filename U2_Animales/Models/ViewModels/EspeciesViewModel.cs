namespace U2_Animales.Models.ViewModels
{
    public class EspeciesViewModel
    {
        public int IdClase { get; set; }
        public string Clase { get; set; } = null!;
        public IEnumerable<Especie> Especies { get; set; } = Enumerable.Empty<Especie>();
    }

    public class Especie
    {
        public int? IdEspecie { get; set; }
        public string Nombre { get; set; } = null!;
    }
}
