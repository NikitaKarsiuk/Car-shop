using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars 
        {
            get
            {
                return new List<Car>
                {
                    new Car { 
                        name = "Tesla", 
                        shortDesc = "", 
                        longDesc = "", 
                        img = "/img/Tesla.jpg", 
                        price = 45000, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.First()
                    }, 
                    new Car {
                        name = "Ford",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/Ford_Fusion.png",
                        price = 15500,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    }, 
                    new Car {
                        name = "Audi A8",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/Audi_A8.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
