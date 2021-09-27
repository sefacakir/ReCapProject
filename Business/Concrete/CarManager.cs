using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cars;
        public CarManager(ICarDal carDal)
        {
            _cars = carDal;
        }
        public List<Car> GetAll()
        {
            return _cars.GetAll();
        }

        public List<Car> GetAllByCategoryId(int id)
        {
            return _cars.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetByDailyPrice(int min, int max)
        {
            return _cars.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }
    }
}
