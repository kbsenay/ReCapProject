﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
           
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
          
        }

        public IResult Delete(Car car)
        {
            
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);

        }

        public IDataResult<List<Car>> GetAll()
        {
            //if (DateTime.Now.Hour==22)
            //{
            //    return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            //}
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>
                (_carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max),Messages.CarsListed);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p=>p.CarId==id),Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetByModelYear(int year)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ModelYear == year),Messages.CarsListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            //if (DateTime.Now.Hour == 02)
            //{
            //    return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            //}
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.CarsListed);
        }

        public IResult Update(Car car)
        {
                _carDal.Update(car);
                return new SuccessResult(Messages.CarUpdate);  
        }
    }
}
