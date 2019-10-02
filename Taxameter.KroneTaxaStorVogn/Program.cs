using System;

namespace Taxameter.KroneTaxaStorVogn
{
    class Program
    {
        static void Main()
        {
            ITaxameter meter = null; // Opgave 2: her kommer til at stå new Taxameter(...)

            using (Driver.Simulate(meter))
            {
                var tui = new TaxameterTUI(meter);
                tui.Run();
            }
        }
    }
}
