using LABOL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LADAL
{
    public interface ILAUrlDb
    {
        IEnumerable<LAUrl> GetAll();
        IEnumerable<LAUrl> GetAll(bool IsApproved);
        LAUrl GetById(int id);
        bool Create(LAUrl laUrl);
        bool Update(LAUrl laUrl);
        bool Delete(int id);
    }
    public class LAUrlDb : ILAUrlDb        
    {
        LADbContext LADbContext;

        public LAUrlDb(LADbContext _LADbContext)
        {
            LADbContext = _LADbContext;
        }
        public bool Create(LAUrl laUrl)
        {
            LADbContext.Add(laUrl);
            LADbContext.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var laUrl = LADbContext.LAUrls.Find(id);
            LADbContext.Remove<LAUrl>(laUrl);
            LADbContext.SaveChanges();
            return true;
        }

        public IEnumerable<LAUrl> GetAll()
        {
            return LADbContext.LAUrls;
        }

        public IEnumerable<LAUrl> GetAll(bool IsApproved)
        {
            return LADbContext.LAUrls.Where(x => x.IsApproved == IsApproved).Include(x=> x.Category).Include(x=> x.User);
        }

        public LAUrl GetById(int id)
        {
            var laUrl = LADbContext.LAUrls.Find(id);
            return laUrl;
        }

        public bool Update(LAUrl laUrl)
        {
            LADbContext.Update<LAUrl>(laUrl);
            LADbContext.SaveChanges();
            return true;
        }
    }
}
