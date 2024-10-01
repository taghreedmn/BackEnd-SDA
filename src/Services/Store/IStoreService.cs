using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FusionTech.src.Entity;

namespace FusionTech.src.Service.Console
{
    public interface IStoreService
    {
        Task<Store> GetByIdAsync(Guid id);
        Task<Store> CreateOneAsync(Store newStore);
        Task<List<Store>> GetAllAsync();
        Task<bool> UpdateOneAsync(Store updateStore);
        Task<bool> DeleteOneAsync(Guid id);
    }
}
