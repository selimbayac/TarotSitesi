namespace SelTarot.Models
{
    public class TarotCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public bool YesNoMeaning { get; set; }
        public Element Element { get; set; } // Element özelliği
        public string AdditionalMeaning { get; set; } // Ekstra anlamlar
    }
    public enum Element
    {
        Fire,    // Ateş
        Water,   // Su
        Air,     // Hava
        Earth,   // Toprak
        None     // Yok (YANKILI)
    }
}
