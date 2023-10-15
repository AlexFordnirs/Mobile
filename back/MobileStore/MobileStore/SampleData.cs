using System.Linq;
using MobileStore.Models;

namespace MobileStore
{
    public static class SampleData
    {
        public static void Initialize(MobileContext context)
        {
            if (!context.Phones.Any())
            {
                context.Phones.AddRange(
                    new Phone
                    {
                        Name = "iPhone X",
                        Company = "Apple",
                        Price = 600
                    },
                    new Phone
                    {
                        Name = "iPhone 11",
                        Company = "Apple",
                        Price = 800
                    },
                    new Phone
                    {
                        Name = "iPhone 12",
                        Company = "Apple",
                        Price = 800
                    },
                    new Phone
                    {
                        Name = "iPhone 13",
                        Company = "Apple",
                        Price = 1000
                    },
                    new Phone
                    {
                        Name = "Samsung Galaxy Edge",
                        Company = "Samsung",
                        Price = 550
                    },
                    new Phone
                    {
                        Name = "Samsung Galaxy s8+",
                        Company = "Samsung",
                        Price = 650
                    },
                    new Phone
                    {
                        Name = "Samsung Galaxy 22",
                        Company = "Samsung",
                        Price = 650
                    },
                    new Phone
                    {
                        Name = "Samsung Galaxy Fold",
                        Company = "Samsung",
                        Price = 2000
                    },
                    new Phone
                    {
                        Name = "Pixel",
                        Company = "Google",
                        Price = 300
                    },
                    new Phone
                    {
                        Name = "Pixel 2",
                        Company = "Google",
                        Price = 500
                    },
                    new Phone
                    {
                        Name = "Pixel 3",
                        Company = "Google",
                        Price = 800
                    }
                );
                context.SaveChanges();
            }
        }
    }
}