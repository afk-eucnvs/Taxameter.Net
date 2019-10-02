namespace Taxameter
{
    public interface ITaxameter
    {
        void StartTur();
        void SlutTur();
        void Kor(decimal deltaAfstand);
        decimal BeregnPris();
    }
}
