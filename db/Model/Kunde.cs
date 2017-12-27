using System;

namespace ConceptsDB.Model
{
	class Kunde
    {
		public Adresse Lieferadresse { get; set; }

		public Adresse Rechnungsadresse { get; set; }

		public int KundenId { get; set; }

		public string Vorname { get; set; }

		public string Nachname { get; set; }

		public DateTime Geburtstag { get; set; }

		public Kunde(Adresse lieferadresse, Adresse rechnungsadresse, int kundenId, string vorname, string nachname, DateTime geburtstag)
		{
			this.Lieferadresse = lieferadresse;
			this.Rechnungsadresse = rechnungsadresse;
			this.KundenId = kundenId;
			this.Vorname = vorname;
			this.Nachname = nachname;
			this.Geburtstag = geburtstag;
		}
	}
}
