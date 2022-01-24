using System;
using System.Threading.Tasks;

namespace CasperFun.Services
{
    public interface ICasperService
    {
         Task Connect();
         Task DisConnect();
         Task<string> GetAddress();
    }
}
