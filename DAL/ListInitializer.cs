using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using StreamCar.Models;

namespace StreamCar.DAL
{
    public class ListInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ListContext>
    {
        protected override void Seed(ListContext context)
        {
            var cars = new List<Car>
            {
                new Car { Year=2014, Value=38000, Mileage=30040, Colour="White", Transmission=Transmissions.Automatic, MakeName=MakeNames.Audi, ModelName=ModelNames.Q3},
                new Car { Year=2017, Value=63000, Mileage=10200, Colour="Blue", Transmission=Transmissions.Automatic, MakeName=MakeNames.BMW, ModelName=ModelNames.BMW330i},
                new Car { Year=2013, Value=34000, Mileage=48200, Colour="Black", Transmission=Transmissions.Automatic, MakeName=MakeNames.Cadillac, ModelName=ModelNames.XT5},
                new Car { Year=2016, Value=71000, Mileage=13560, Colour="Red", Transmission=Transmissions.Manual, MakeName=MakeNames.Dodge, ModelName=ModelNames.Hellcat}
            };
            cars.ForEach(c => context.Car.Add(c));
            context.SaveChanges();
        }
    }
}