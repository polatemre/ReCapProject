using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFuelService
    {
        IResult Add(Fuel fuel);
        IResult Update(Fuel fuel);
        IResult Delete(Fuel fuel);
        IDataResult<List<Fuel>> GetAll();
        IDataResult<Fuel> GetById(int id);
    }
}
