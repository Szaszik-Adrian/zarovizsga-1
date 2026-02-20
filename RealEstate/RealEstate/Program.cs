using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate;
using System.Globalization;

namespace RealEstate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ingatlanok";
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string csvFile = "realestates.csv"; 

            List<Ad> ads = Ad.LoadFromCsv(csvFile);

            // 6. feladat: földszinti (floors == 0) átlag alapterület
            var ground = ads.Where(a => a.Floors == 0).ToList();

            double avg = ground.Average(a => a.Area);

            // magyar mintában gyakran vesszővel jelenik meg, de biztosra:
            Console.WriteLine("1. Földszinti ingatlanok átlagos alapterülete: " +
                              avg.ToString("0.00", CultureInfo.InvariantCulture) + " m2");

            double ovodaLat = 47.4164220114023;
            double ovodaLon = 19.066342425796986;

            var nearestFree = ads
                .Where(a => a.FreeOfCharge)
                .OrderBy(a => a.DistanceTo(ovodaLat, ovodaLon))
                .First();

            Console.WriteLine("2. Mesévár óvodához légvonalban legközelebbi tehermentes ingatlan adatai:");
            Console.WriteLine("Eladó neve    : " + nearestFree.Seller.Name);
            Console.WriteLine("Eladó telefonja: " + nearestFree.Seller.Phone);
            Console.WriteLine("Alapterület   : " + nearestFree.Area);
            Console.WriteLine("Szobák száma  : " + nearestFree.Rooms);

            Console.ReadLine();
        }
    }
}
