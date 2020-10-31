using IG_Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IG_Test.DataAccess.Repository
{
    public interface IIG_ServiceRepository: IRepository<IG_Service>
    {
        Task<IG_Service> Get_IG_Service(string serviceCode, string passcode);
    }
}
