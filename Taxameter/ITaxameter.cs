using System;

namespace Taxameter
{
    public interface ITaxameter
    {
        void StartTur();
        void SlutTur();

        void Kor(decimal deltaAfstand);

        decimal BeregnPris();
        decimal AfstandKm { get; }
        DateTime? TurStartet { get; }
    }
}
