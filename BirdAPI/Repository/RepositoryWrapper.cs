using System;
using System.Collections.Generic;
using System.Text;
using Repository.Contracts;
using Repository.Data;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _context;
        private ISpeciesRepository _species;

        public ISpeciesRepository Species
        {
            get
            {
                if (_species == null)
                {
                    _species = new SpeciesRepository(_context);
                }
                return _species;
            }
        }

        public RepositoryWrapper(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
