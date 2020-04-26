using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial7.Services
{
    public interface IDbService
    {
        bool CheckIndex(string index);
    }
}
