using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UESAN.Store.CORE.Entities;
using UESAN.Store.CORE.Interfaces;
using UESAN.Store.INFRAESTRUCTURE.Data;

namespace UESAN.Store.INFRAESTRUCTURE.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly StoreDbContext _dbContext;

        public CategoryRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Category>> GetAll()
        {
            var result = await _dbContext.Category.ToListAsync();
            return result;

            //OTRA forma mas sismple : return await _dbContext.Category.ToListAsync();
        }
    }
}
