using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IRepositoryWrapper
    {
        ISpeciesRepository Species { get; }
        void Save();
    }
}
