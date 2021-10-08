using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class FuelManager : IFuelService
    {
        IFuelDal _fuelDal;

        public FuelManager(IFuelDal fuelDal)
        {
            _fuelDal = fuelDal;
        }

        [SecuredOperation("admin")]
        [ValidationAspect(typeof(FuelValidator))]
        public IResult Add(Fuel fuel)
        {
            _fuelDal.Add(fuel);
            return new SuccessResult(Messages.AddedFuel);
        }

        [SecuredOperation("admin")]
        public IResult Delete(Fuel fuel)
        {
            _fuelDal.Delete(fuel);
            return new SuccessResult(Messages.DeletedFuel);
        }

        public IDataResult<List<Fuel>> GetAll()
        {
            return new SuccessDataResult<List<Fuel>>(_fuelDal.GetAll());
        }

        public IDataResult<Fuel> GetById(int id)
        {
            return new SuccessDataResult<Fuel>(_fuelDal.Get(f => f.Id == id));
        }

        [SecuredOperation("admin")]
        [ValidationAspect(typeof(FuelValidator))]
        public IResult Update(Fuel fuel)
        {
            _fuelDal.Update(fuel);
            return new SuccessResult(Messages.UpdatedFuel);
        }
    }
}
