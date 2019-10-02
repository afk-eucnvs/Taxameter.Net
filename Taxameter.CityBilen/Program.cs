using System;

namespace Taxameter.CityBilen
{
    class Program
    {
        static void Main()
        {
            ITaxameter meter = null;// Opgave 3: her kommer til at stå new Taxameter(...)

            using (Driver.Simulate(meter))
            {
                var tui = new TaxameterTUI(meter);

                tui.Run();
            }
        }
    }
}
