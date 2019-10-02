using System;
using System.Threading;

namespace Taxameter
{
    public static class Driver
    {
        public static IDisposable Simulate(ITaxameter meter)
        {
            var random = new Random();
            var hastighed = 0m;
            return new Timer(s =>
            {
                if (meter.TurStartet.HasValue)
                {
                    var r = random.Next(100);

                    if (hastighed == 0m)
                    {
                        if (r < 20)
                        {
                            hastighed = 5;
                        }
                    }
                    else if (r < 10)
                    {
                        // 10% for at møde et lyskryds
                        hastighed = 0;
                    }
                    else if (r < 80)
                    {
                        // 70% for speeder
                        hastighed += random.Next(1, 5);
                    }
                    else
                    {
                        // 20% for brems
                        hastighed *= 0.7m;
                    }

                    hastighed = Math.Max(hastighed, 0);
                    hastighed = Math.Min(hastighed, 80);

                    meter.Kor(hastighed / 7200);
                }
            }, null, 0, 500);
        }
    }
}
