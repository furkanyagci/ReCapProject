using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            List<Rental> rentacar = _rentalDal.GetAll(ra => ra.CarId == rental.CarId);  //(GetById(rental.CarId) == null) ? null : GetById(rental.CarId);
            int sonDeger = rentacar.Count-1;
            if (rentacar[sonDeger].ReturnDate!=null)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.CarRentalSuccess);
            }
            else
            {
                return new ErrorResult(Messages.CarNotRental);
            }
        }

        public void Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
        }
        public void Update(Rental rental)
        {
            _rentalDal.Update(rental);
        }

        public List<Rental> GetAll()
        {
            return _rentalDal.GetAll();
        }

        public Rental GetById(int id)
        {
            return _rentalDal.Get(r => r.Id == id);
        }
    }
}
