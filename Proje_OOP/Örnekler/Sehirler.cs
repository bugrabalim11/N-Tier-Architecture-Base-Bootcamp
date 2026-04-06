namespace Proje_OOP.Örnekler
{
    public class Sehirler : Bayrak // Şehirler sınıfı bayrak sınıfının bütün niteliklerini üsütne aldı
    {
        public int SehirId { get; set; }
        public string SehirAd { get; set; } = string.Empty;
        public int Nufus { get; set; }
        public string Ulke { get; set; } = string.Empty;
    }
}
