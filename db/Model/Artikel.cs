namespace ConceptsDB.Model
{
	class Artikel
    {
		public string Bezeichnung { get; set; }
		public int ArtikelId { get; set; }
		public decimal Preis { get; set; }
		public int Bestand { get; set; }
		
		public Artikel(string bezeichnung, int artikelId, decimal preis, int bestand)
		{
			this.Bezeichnung = bezeichnung;
			this.ArtikelId = artikelId;
			this.Preis = preis;
			this.Bestand = bestand;
		}
	}
}
