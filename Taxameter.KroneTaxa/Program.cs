using System;

namespace Taxameter.KroneTaxa
{
    class Program
    {
        static void Main()
        {
            var meter = new Taxameter(); // Opgave 2: her kommer til at stå new Taxameter(...)

            using (Driver.Simulate(meter))
            {
                var tui = new TaxameterTUI(meter);

                tui.Run();
            }
        }
    }
}
