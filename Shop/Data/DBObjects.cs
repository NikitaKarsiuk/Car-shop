using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;

namespace Shop.Data
{
    public class DBObjects
    {
        private static Dictionary<string, Category> category;
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if(!content.Car.Any())
            {
                content.AddRange
                (
                    new Car
                    {
                        name = "Tesla",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/Tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Ford",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/Ford_Fusion.png",
                        price = 15500,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Audi A8",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/Audi_A8.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    }
                );
            }

            content.SaveChanges();
        }

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { CategoryName = "Электромобили", desc = "Современный вид транспорта"},
                        new Category { CategoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"}
                    };

                    category = new Dictionary<string, Category>();
                    
                    foreach(Category element in list)
                    {
                        category.Add(element.CategoryName, element);
                    }
                }

                return category;
            }
        }
    }
}
