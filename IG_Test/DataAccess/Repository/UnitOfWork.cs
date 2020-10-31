using IG_Test.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IG_Test.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IGContext dbContext;
        public UnitOfWork(IGContext _dbContext)
        {
            dbContext = _dbContext;
            IG_ServiceRepository = new IG_ServiceRepository(dbContext);
            IG_Login_ServiceRepository = new IG_Login_ServiceRepository(dbContext);
            IG_Rating_Login_ServiceRepository = new IG_Rating_Login_ServiceRepository(dbContext);
        }

        public IIG_ServiceRepository IG_ServiceRepository { get; set; }
        public IIG_Login_ServiceRepository IG_Login_ServiceRepository { get; set; }

        public IIG_Rating_Login_ServiceRepository IG_Rating_Login_ServiceRepository { get; set; }

        public void Dispose()
        {
            dbContext.Dispose();
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }
    }
}
