using IG_Test.DataAccess.Context;
using IG_Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IG_Test.DataAccess.Repository
{
    public class IG_Login_ServiceRepository : Repository<IG_Login_Service>, IIG_Login_ServiceRepository
    {
        private readonly IGContext dbContext;
        public IG_Login_ServiceRepository(IGContext _dbContext):base(_dbContext)
        {
            dbContext = _dbContext;
        }
        public async Task<IG_Login_Service> Create_LoginService(IG_Login_Service model)
        {
            var result = await dbContext.IG_Login_Service.AddAsync(model);
            if(result != null)
            {
                return model;
            }
            return null;
        }
    }
}
