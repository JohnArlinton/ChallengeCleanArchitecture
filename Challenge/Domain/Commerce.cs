using System;

namespace Domain
{
    public class Commerce
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CUIT { get; set; }
        public int Concept1 { get; set; }
        public int Concept2 { get; set; }
        public int Concept3 { get; set; }
        public int Concept4 { get; set; }
        public int Concept5 { get; set; }
        public int Concept6 { get; set; }
        public int CurrentBalance { get; set; }
        public bool Active { get; set; }
        public DateTime LastSale { get; set; }
    }
}