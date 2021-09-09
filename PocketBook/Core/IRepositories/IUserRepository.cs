using PocketBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PocketBook.Core.IRepositories
{
    public interface IUserRepository:IGenericRepository<User>
    {
        //Task<string> GetFirsNameAndLastName(Guid id);
    }
}
