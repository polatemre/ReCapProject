﻿using DataAccess.Abstract;
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
        readonly List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>{
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=1000,Description="asds1",ModelYear="2021" },
                new Car{Id=2,BrandId=2,ColorId=2,DailyPrice=1200,Description="asds2",ModelYear="2020" },
                new Car{Id=3,BrandId=3,ColorId=2,DailyPrice=3000,Description="asds3",ModelYear="2019" },
                new Car{Id=4,BrandId=3,ColorId=3,DailyPrice=1400,Description="asds4",ModelYear="2018" },
                new Car{Id=5,BrandId=4,ColorId=3,DailyPrice=2400,Description="asds5",ModelYear="2017" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.Where(c => c.Id == id).SingleOrDefault();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
