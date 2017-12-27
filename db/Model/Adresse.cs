namespace ConceptsDB.Model
{
	class Adresse
    {
		public string Strasse { get; set; }
		public string Hausnummer { get; set; }
		public string Telefon { get; set; }
		public string PLZ { get; set; }
		public string Ort { get; set; }
		public int AdresseId { get; set; }

		public Adresse(string Strasse, string Hausnummer, string Telefon, string PLZ, string Ort, int adresseId)
		{
			this.Strasse = Strasse;
			this.Hausnummer = Hausnummer;
			this.Telefon = Telefon;
			this.PLZ = PLZ;
			this.Ort = Ort;
			this.AdresseId = adresseId;
		}
	}
}
