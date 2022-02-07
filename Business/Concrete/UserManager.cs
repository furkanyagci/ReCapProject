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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            if (user.FirstName.Length > 2 && user.Password.Length > 5)
            {
                _userDal.Add(user);
                return new SuccessResult(Messages.Added);
            }
            else
            {
                if (user.FirstName.Length <= 2)
                {
                    return new ErrorResult(Messages.NotAdded + " - " + Messages.NameInvalid);
                }
                else
                {
                    return new ErrorResult(Messages.NotAdded + " - " + Messages.UserPasswordInvalid);
                }
            }
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User GetById(int id)
        {
            return _userDal.Get(u => u.Id == id);
        }
    }
}
