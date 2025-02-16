using Microsoft.EntityFrameworkCore;
using System.Contracts.Interfaces;
using System.DataAccess.Context;

namespace System_Contracts
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;

        public UnitOfWork(ApplicationContext contex)
        {
            _context = contex;
            if (!contex.Database.CanConnect())
                contex.Database.Migrate();
        }
        public void SaveChanges()
        {

            _context.SaveChanges();
        }

    }
}
