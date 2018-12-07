using System;
using System.Collections.Generic;
using System.Linq;
using Vanguard.Data;
using Vanguard.Models;

namespace Vanguard.Services
{
    public class SqlNewsData : NewsService
    {
        private VanguardDbContext _context;

        public SqlNewsData(VanguardDbContext context)
        {
            _context = context;
        }

        public News Add(News news)
        {
            _context.News.Add(news);
            _context.SaveChanges();
            return news;
        }

        public void Delete(int id)
        {
            _context.News.Remove(Get(id));
            _context.SaveChanges();
        }

        public News Get(int id)
        {
            return _context.News.FirstOrDefault(n => n.Id == id);
        }

        public IEnumerable<News> GetAll()
        {
            return _context.News.OrderBy(n => n.Id);
        }
    }
}
