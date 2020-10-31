using IG_Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IG_Test.DataAccess.Repository
{
    public interface IIG_Login_ServiceRepository:IRepository<IG_Login_Service>
    {
        Task<IG_Login_Service> Create_LoginService(IG_Login_Service model);
    }
}
