using System;
namespace Taxameter
{

    public class Taxameter : ITaxameter
    {
        public decimal AfstandKm { get; private set; }
        public DateTime? TurStartet { get; private set; }

        public Taxameter()
        {
            // Strengt taget ikke nødvendigt, da en decimal defaulter til 0, og en Nullable<T> defaulter til null.
            AfstandKm = 0;
            TurStartet = null;
        }

        public void StartTur()
        {
            TurStartet = DateTime.Now;
        }

        // skal afslutte turen - dvs nulstille afstand og TurStartet
        public void SlutTur()
        {
            AfstandKm = 0;
            TurStartet = null;
        }

        // Bilens km tæller er koblet op på taxameteret, og fortæller et par gange i sekundet
        // hvor langt den har kørt siden sidste melding.
        public void Kor(decimal deltaAfstandKm)
        {
            AfstandKm += 10 * deltaAfstandKm;
        }

        // Det fysiske taxameter spørger om prisen løbende for at vise prisen til kunden.
        // Denne metode må ikke ændre noget i Taxameter klassen, men skal bare fortælle hvad
        // prisen er på turen indtil videre.
        public decimal BeregnPris()
        {
            var time = DateTime.Now - TurStartet;
            if (time.HasValue)
            {
                var minutes = (decimal)(time.Value / TimeSpan.FromMinutes(1));
                return 39 + (minutes * 6.25m) + (8.50m * AfstandKm);
            }
            else
            {
                return 0;
            }
        }
    }
}
