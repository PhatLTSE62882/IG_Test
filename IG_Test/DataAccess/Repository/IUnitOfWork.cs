using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IG_Test.DataAccess.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IIG_ServiceRepository IG_ServiceRepository { get; }
        IIG_Login_ServiceRepository IG_Login_ServiceRepository { get; }
        IIG_Rating_Login_ServiceRepository IG_Rating_Login_ServiceRepository { get; }

        void Save();
    }
}
