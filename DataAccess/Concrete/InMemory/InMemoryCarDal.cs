﻿using Core.DataAccess;
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
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {

            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=4,ModelYear=2010,DailyPrice=1000,Description="Hasarsız"},
                new Car{Id=2,BrandId=1,ColorId=1,ModelYear=2011,DailyPrice=2000,Description="Ağır hasar"},
                new Car{Id=3,BrandId=2,ColorId=3,ModelYear=2012,DailyPrice=3000,Description="Temiz Araç"},
                new Car{Id=4,BrandId=2,ColorId=2,ModelYear=2013,DailyPrice=4000,Description="Sıfır gibi"},
                new Car{Id=5,BrandId=3,ColorId=5,ModelYear=2014,DailyPrice=5000,Description="Hasarsız"}
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

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        Car IEntityRepository<Car>.GetById(int entityId)
        {
            throw new NotImplementedException();
        }
    }
}
