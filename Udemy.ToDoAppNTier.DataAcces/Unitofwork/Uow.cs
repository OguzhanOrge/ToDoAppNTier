using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.ToDoAppNTier.DataAcces.Context;
using Udemy.ToDoAppNTier.DataAcces.Interfaces;
using Udemy.ToDoAppNTier.DataAcces.Repositories;
using Udemy.ToDoAppNTier.Entities.Domains;

namespace Udemy.ToDoAppNTier.DataAcces.Unitofwork
{
    public class Uow : IUow
    {
        private readonly ToDoContext _context;

        public Uow(ToDoContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChages()
        {
           await _context.SaveChangesAsync();
        }
    }
}
