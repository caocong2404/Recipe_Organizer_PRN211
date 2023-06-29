using Microsoft.EntityFrameworkCore;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class RecipeHasCategoryRepository : RepositoryBase<RecipeHasCategoryRepository>
    {
        Recipe_Organizer_PRN211Context _context;
        DbSet<RecipeHasCategoryRepository> _dbSet;

        public RecipeHasCategoryRepository()
        {
            _context = new Recipe_Organizer_PRN211Context();
            _dbSet = _context.Set<RecipeHasCategoryRepository>();
        }

        //public bool deleteCategoty(string titlte)
        //{

        //    var records = _dbSet.Where(entity => entity.Title.Contains(titlte)).ToList();
        //    return true;
        //}

    }
}
