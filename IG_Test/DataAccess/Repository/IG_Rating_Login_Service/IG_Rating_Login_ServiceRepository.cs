using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using IG_Test.DataAccess.Context;
using IG_Test_Data;

namespace IG_Test.DataAccess.Repository
{
    public class IG_Rating_Login_ServiceRepository : Repository<IG_Rating_Login_Service>, IIG_Rating_Login_ServiceRepository
    {
        private readonly IGContext dbContext;
        public IG_Rating_Login_ServiceRepository(IGContext _dbContext):base(_dbContext)
        {
            dbContext = _dbContext;
        }

    }
}
