using System;
using System.Collections.Generic;
using System.DataAccess.Context;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.DataAccess.Repos.Common
{
    public abstract class RepositoryBase
    {
        protected ApplicationContext _context;
        protected RepositoryBase(ApplicationContext context)
        {
            _context = context;
        }
    }
}
