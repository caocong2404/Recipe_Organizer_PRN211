using Microsoft.EntityFrameworkCore;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class UserRepository : RepositoryBase<User>
    {
        Recipe_Organizer_PRN211Context _context;
        DbSet<User> _dbSet;

        public UserRepository()
        {
            _context = new Recipe_Organizer_PRN211Context();
            _dbSet = _context.Set<User>();
        }
        public User getUser(string userName, string password)
        {
            var user = _dbSet.Where(entity => entity.Username == userName && entity.Password == password).FirstOrDefault();
            return user;
        }

        public bool checkUserExisted(string userName)
        {
            var user = _dbSet.Where(entity => entity.Username == userName).FirstOrDefault();
            return user != null;
        }
        public List<User> getUserByUserName(string userName)
        {
            var records = _dbSet.Where(entity => entity.Username.Contains(userName)).ToList();
            return records;
        }

        public void Add(User user)
        {
            
            _dbSet.Add(user);
            _context.SaveChanges();
        }

        public string autoGenerateID(string id)
        {
            //ACCT0001
            string result = "";
            int cutID = int.Parse(id.Substring(4, 4));
            cutID++;
            int digits = 4;
            string prefix = "ACCT";

            // Convert the current ID to string with leading zeros
            string idString = cutID.ToString().PadLeft(digits, '0');
            result = prefix + idString;

            // Combine the prefix and the formatted ID
            return result;
        }

    }
}
