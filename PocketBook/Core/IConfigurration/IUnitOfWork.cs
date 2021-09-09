using PocketBook.Core.IRepositories;
using PocketBook.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PocketBook.Core.IConfigurration
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }

        Task CompleteAsync();
    }
}
