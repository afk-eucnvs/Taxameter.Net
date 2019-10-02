using System;
using System.Threading;
using System.Threading.Tasks;

namespace Taxameter
{
    public class TaxameterTUI
    {
        readonly ITaxameter meter;

        public TaxameterTUI(ITaxameter meter)
        {
            this.meter = meter;
        }

        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Afstand: ");
            Console.WriteLine("Tid: ");
            Console.WriteLine("Pris: ");

            Console.ForegroundColor = ConsoleColor.White;


            using (new Timer(s =>
            {
                Console.SetCursorPosition(10, 0);
                Console.Write($"{meter.AfstandKm:F2} km                        ");

                Console.SetCursorPosition(10, 1);
                var tid = DateTime.Now - meter.TurStartet ?? TimeSpan.Zero;
                Console.Write($"{tid:hh\\:mm\\:ss}                        ");

                Console.SetCursorPosition(10, 2);
                Console.Write($"{meter.BeregnPris():F2} DKK                    ");

                Console.SetCursorPosition(0, 5);
            }, null, 0, 200))
            {
                while (true)
                {
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        if (meter.TurStartet.HasValue)
                        {
                            Console.SetCursorPosition(0, 10);
                            Console.WriteLine($"Tak for turen. Det bliver {meter.BeregnPris():F2} DKK");
                            meter.SlutTur();
                        }
                        else
                        {
                            Console.SetCursorPosition(0, 10);
                            Console.WriteLine("                                                      ");
                            meter.StartTur();
                        }
                    }
                    else if (key.Key == ConsoleKey.Escape)
                    {
                        return;
                    }
                }
            }
        }
    }
}
