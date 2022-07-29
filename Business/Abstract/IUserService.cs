using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Core.Utilities.Result;

namespace Business.Abstract
{
    public interface IUserService
    {
        User GetByMail(string email);
        IResult Add(User user);

    }
}
