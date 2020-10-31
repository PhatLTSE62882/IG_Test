using IG_Test.DataAccess.Context;
using IG_Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IG_Test.DataAccess.Repository
{
    public class IG_ServiceRepository : Repository<IG_Service>, IIG_ServiceRepository
    {
        private readonly IGContext dbContext;
        public IG_ServiceRepository(IGContext _dbContext) : base(_dbContext)
        {
            dbContext = _dbContext;
        }
        public Task<IG_Service> Get_IG_Service(string serviceCode, string passcode)
        {
            return dbContext.IG_Service.FirstOrDefaultAsync(x => x.serviceCode.Equals(serviceCode) && x.servicePasscode.Equals(passcode));
        }
    }
}
