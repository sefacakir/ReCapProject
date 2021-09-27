using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryDal : ICarDal
    {
        //Veriler nerden geliyor.
        //simüle etmek için kendimiz oluşturalım.

        List<Car> _cars;
        public InMemoryDal()
        {
            _cars = new List<Car> {
                    new Car{Id = 1,BrandId = 1,ColorId = 1,DailyPrice=250,ModelYear=2011,Description="2011 VW Passat" },
                    new Car{Id = 2,BrandId = 2,ColorId = 2,DailyPrice=300,ModelYear=2011,Description="2011 Skoda SuperB" },
                    new Car{Id = 3,BrandId = 3,ColorId = 1,DailyPrice=350,ModelYear=2011,Description="2011 Mercedes E63" },
                    new Car{Id = 4,BrandId = 4,ColorId = 2,DailyPrice=400,ModelYear=2011,Description="2011 Audi S5" },
                    new Car{Id = 5,BrandId = 5,ColorId = 2,DailyPrice=450,ModelYear=2011,Description="2011 BMW M5" },
            };

        }

        public int GetById(Car car)
        {
            
            return _cars.SingleOrDefault(c => c.Id == car.Id).Id;
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            _cars.Remove(_cars.SingleOrDefault(c => c.Id == car.Id));
            
        }



        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
