﻿namespace U2_Animales.Models.ViewModels
{
    public class EspecieViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Clase { get; set; } = null!;
        public double? Peso { get; set; }
        public int? Tamaño { get; set; }
        public string Habitat { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
    }
}
