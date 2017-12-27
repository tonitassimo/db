using System.Collections.Generic;

namespace ConceptsDB.Model
{
	class Auftrag
    {
		public Kunde Kunde { get; set; }
		public IEnumerable<Artikel> Artikel { get; set; }
		public int AuftragId { get; set; }

		public Auftrag(Kunde kunde, IEnumerable<Artikel> artikel, int auftragId)
		{
			this.Kunde = kunde;
			this.Artikel = artikel;
			this.AuftragId = auftragId;
		}
	}
}
