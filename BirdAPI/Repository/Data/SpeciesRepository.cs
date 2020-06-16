using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repository.Contracts;
using Repository.Models;

namespace Repository.Data
{
    public class SpeciesRepository : RepositoryBase<Species>, ISpeciesRepository
    {

        public SpeciesRepository(ApplicationDbContext applicationDbContext)
            :base(applicationDbContext)
        {

        }

        public IEnumerable<Species> GetAllSpecies()
        {
            var species = FindAll();
            return species;
        }

        public Species GetById(int id)
        {
            var thisSpecies = FindByCondition(s => s.SpeciesId == id).SingleOrDefault();
            return thisSpecies;
        }

        public void AddSpecies(Species species)
        {
            Create(species);
        }

        public void UpdateSpecies (Species species)
        {
            Update(species);
        }

        public void DeleteSpecies (Species species)
        {
            Delete(species);
        }
    }
}
