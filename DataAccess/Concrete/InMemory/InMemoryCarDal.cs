using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{CarId=1, BrandId=1, ColorId=1, ModelYear=2015, DailyPrice=140000, Description="Ford Focus Beyaz"},
                new Car{CarId=2, BrandId=2, ColorId=1, ModelYear=2011, DailyPrice=100000, Description="Renault Fluence Beyaz"},
                new Car{CarId=3, BrandId=3, ColorId=2, ModelYear=2018, DailyPrice=200000, Description="Opel Vectra Siyah"},
            };
        }
        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == entity.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
           return _cars.Where(p=>p.CarId==carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == entity.CarId);
            carToUpdate.ColorId = entity.ColorId;
            carToUpdate.BrandId = entity.BrandId;
            carToUpdate.DailyPrice = entity.DailyPrice;
            carToUpdate.Description = entity.Description;
        }
    }
}
