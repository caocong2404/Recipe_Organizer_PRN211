using Microsoft.EntityFrameworkCore;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class CategoryRepository : RepositoryBase<Category>
    {
        Recipe_Organizer_PRN211Context _context;
        DbSet<Category> _dbSet;

        public CategoryRepository()
        {
            _context = new Recipe_Organizer_PRN211Context();
            _dbSet = _context.Set<Category>();
        }
        public List<Category> getUserByUserName(string titlte)
        {
            var records = _dbSet.Where(entity => entity.Title.Contains(titlte)).ToList();
            return records;
        }

       

    }
}
