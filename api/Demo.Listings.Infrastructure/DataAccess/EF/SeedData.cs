
using Demo.Listings.Infrastructure.DataAccess;
using Demo.Listings.Infrastructure.DataAccess.EF.Entities;

namespace Demo.Listings.Infrastructure
{
    public static class SeedData
    {
        public static void SeedDataToDb(ListingsDbContext context)
        {
            context.Listings.AddRange(new List<Listing>{
new Listing {
                Id = 1,
                Address = "04235 Hancock Glens, South Brettmouth, CT 68377",
                Bathrooms = 4,
                Bedrooms = 4,
                HalfBathrooms = 1,
                Latitude = -40.071434,
                Longitude = 5.701202,
                PhotoUrl = "https://example.com/photo1",
                Price = 565231,
                YearBuilt = 2004
            },
            new Listing {
                Id = 2,
                Address = "42798 Nichole Branch Apt. 244, Port Philip, IN 72942",
                Bathrooms = 2,
                Bedrooms = 1,
                HalfBathrooms = 2,
                Latitude = 88.519002,
                Longitude = 44.788677,
                PhotoUrl = "https://example.com/photo2",
                Price = 127932,
                YearBuilt = 1907
            },
            new Listing {
                Id = 3,
                Address = "79361 Salas Unions Apt. 294, Sherrihaven, MA 67529",
                Bathrooms = 3,
                Bedrooms = 2,
                HalfBathrooms = 0,
                Latitude = 56.307157,
                Longitude = -10.128527,
                PhotoUrl = "https://example.com/photo3",
                Price = 957331,
                YearBuilt = 1938
            },
            new Listing {
                Id = 4,
                Address = "6305 David Cliff, South Frank, DE 53924",
                Bathrooms = 4,
                Bedrooms = 5,
                HalfBathrooms = 3,
                Latitude = -15.923049,
                Longitude = -93.900028,
                PhotoUrl = "https://example.com/photo4",
                Price = 637492,
                YearBuilt = 1900
            },
            new Listing {
                Id = 5,
                Address = "84954 Johnson Camp Suite 156, South Carol, ND 86459",
                Bathrooms = 4,
                Bedrooms = 1,
                HalfBathrooms = 1,
                Latitude = -19.518991,
                Longitude = -8.773917,
                PhotoUrl = "https://example.com/photo5",
                Price = 971216,
                YearBuilt = 1917
            },
            new Listing {
                Id = 6,
                Address = "USNV Morgan, FPO AE 70370",
                Bathrooms = 3,
                Bedrooms = 3,
                HalfBathrooms = 3,
                Latitude = -30.447463,
                Longitude = 17.217975,
                PhotoUrl = "https://example.com/photo6",
                Price = 697592,
                YearBuilt = 1997
            },
            new Listing {
                Id = 7,
                Address = "73514 Mann Estate, Paulaburgh, IL 74054",
                Bathrooms = 5,
                Bedrooms = 5,
                HalfBathrooms = 0,
                Latitude = -16.127953,
                Longitude = -154.467688,
                PhotoUrl = "https://example.com/photo7",
                Price = 434863,
                YearBuilt = 2003
            },
            new Listing {
                Id = 20,
                Address = "PSC 2644, Box 4674, APO AE 52772",
                Bathrooms = 4,
                Bedrooms = 1,
                HalfBathrooms = 2,
                Latitude = -24.571092,
                Longitude = 48.948146,
                PhotoUrl = "https://example.com/photo20",
                Price = 350412,
                YearBuilt = 1942
            }
            });

            context.SaveChanges();
        }
    }
}
