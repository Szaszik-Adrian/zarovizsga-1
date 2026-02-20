using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace RealEstate
{
    public class Ad
    {
        public int Id { get; set; }
        public string Description { get; set; } = "";
        public int Rooms { get; set; }
        public int Area { get; set; }
        public int Floors { get; set; }
        public Category Category { get; set; } = new Category(0, "");
        public Seller Seller { get; set; } = new Seller(0, "", "");
        public bool FreeOfCharge { get; set; }
        public string ImageUrl { get; set; } = "";
        public string LatLong { get; set; } = "";
        public DateTime CreatedAt { get; set; }

        private static bool ParseBool(string s)
        {
            s = s.Trim().ToLowerInvariant();
            return s == "true" || s == "1" || s == "igen" || s == "yes";
        }

        public double DistanceTo(double lat, double lon)
        {
            string[] t = LatLong.Split(',');
            double myLat = double.Parse(t[0], System.Globalization.CultureInfo.InvariantCulture);
            double myLon = double.Parse(t[1], System.Globalization.CultureInfo.InvariantCulture);

            double a = myLat - lat;
            double b = myLon - lon;

            return Math.Sqrt(a * a + b * b);
        }

        // 3-5. feladat
        public static List<Ad> LoadFromCsv(string fileName)
        {
            var ads = new List<Ad>();
            var lines = File.ReadAllLines(fileName);

            if (lines.Length < 2)
                return ads;

            char sep = lines[0].Contains(";") ? ';' : ',';
            var header = lines[0].Split(sep);

            var col = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            for (int i = 0; i < header.Length; i++)
                col[header[i].Trim()] = i;

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;

                var p = lines[i].Split(sep);

                int id = int.Parse(p[col["id"]]);
                string desc = p[col["description"]];
                int rooms = int.Parse(p[col["rooms"]]);
                int area = int.Parse(p[col["area"]]);
                int floors = int.Parse(p[col["floors"]]);

                ads.Add(new Ad
                {
                    Id = id,
                    Description = desc,
                    Rooms = rooms,
                    Area = area,
                    Floors = floors,

                    FreeOfCharge = ParseBool(p[col["freeOfCharge"]]),
                    ImageUrl = p[col["imageUrl"]],
                    LatLong = p[col["latlong"]],
                    CreatedAt = DateTime.Parse(p[col["createAt"]], CultureInfo.InvariantCulture),

                    Category = new Category(
                    int.Parse(p[col["categoryId"]]),
                    p[col["categoryName"]]
                    ),

                    Seller = new Seller(
                    int.Parse(p[col["sellerId"]]),
                    p[col["sellerName"]],
                    p[col["sellerPhone"]]
                        )
                });
            }

            return ads;
        }
    }
}