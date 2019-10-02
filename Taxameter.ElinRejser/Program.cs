using System;

namespace Taxameter.ElinRejser
{
    class Program
    {
        static void Main()
        {
            ITaxameter meter = null;// Bonus opgave 2: her kommer til at stå new Taxameter(...)

            using (Driver.Simulate(meter))
            {
                var tui = new TaxameterTUI(meter);

                tui.Run();
            }
        }
    }
}
