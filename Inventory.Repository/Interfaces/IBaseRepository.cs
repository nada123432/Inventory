using Inventory.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Inventory.Repository.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        
        Task<T> AddAsync(T entity);
        
        Task<T> UpdateAsync(T entity); 
        
        Task<bool> DeleteAsync(T entity); 
        
        Task<int> CountAsync();
 
    }
}
