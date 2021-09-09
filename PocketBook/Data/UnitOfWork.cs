using Microsoft.Extensions.Logging;
using PocketBook.Core.IConfigurration;
using PocketBook.Core.IRepositories;
using PocketBook.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PocketBook.Data
{
    public class UnitOfWork:IUnitOfWork,IDisposable
    {
        private readonly AppDbContext _context;
        private readonly ILogger _logger;
        public IUserRepository Users { get; set; }
       
        public UnitOfWork(AppDbContext context,ILoggerFactory loggerFactory)
        {
           _context = context;
            _logger = loggerFactory.CreateLogger("logs");

            Users = new UserRepository(_context, _logger);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
