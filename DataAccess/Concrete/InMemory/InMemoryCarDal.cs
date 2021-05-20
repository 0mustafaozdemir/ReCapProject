using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                    new Car{Id=1, BrandId=2001, ColorId=3, DailyPrice=2000, Description="Mercedes", ModelYear=2000 },
                     new Car{Id=2, BrandId=2042, ColorId=3, DailyPrice=2000, Description="Audi", ModelYear=2000 },
                      new Car{Id=3, BrandId=2035, ColorId=3, DailyPrice=2000, Description="Bmw", ModelYear=2000 },
                       new Car{Id=4, BrandId=2020, ColorId=3, DailyPrice=2000, Description="Ferarş", ModelYear=2000 },
                        new Car{Id=5, BrandId=2010, ColorId=3, DailyPrice=2000, Description="Tofaş", ModelYear=2000 },


            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);

            _cars.Remove(carToUpdate);
        }
    }
}
