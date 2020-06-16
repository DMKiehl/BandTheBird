using System;
using System.Collections.Generic;
using System.Text;
using Repository.Models;

namespace Repository.Contracts
{
    public interface ISpeciesRepository : IRepositoryBase<Species>
    {
        IEnumerable<Species> GetAllSpecies();

        Species GetById(int id);

        void AddSpecies(Species species);

        void UpdateSpecies(Species species);

        void DeleteSpecies(Species species);
    }
}
