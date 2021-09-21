using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryDal());
            List<Car> cars =  carManager.GetAll();

            foreach (var car in cars)
            {
                System.Console.WriteLine(car.Description);
            }
        }
    }
}
