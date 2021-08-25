using LABOL;
using LADAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace LABLL
{
    public interface ILAUrlBs
    {
        IEnumerable<LAUrl> GetAll();
        IEnumerable<LAUrl> GetAll(bool IsApproved);
        LAUrl GetById(int id);
        bool Create(LAUrl laurl);
        bool Update(LAUrl laurl);
        bool Delete(int id);
    }
    public class LAUrlBs : ILAUrlBs
    {

        ILAUrlDb LAUrlDb;

        public LAUrlBs(ILAUrlDb _LAUrlDb)
        {
            LAUrlDb = _LAUrlDb;
        }
        public bool Create(LAUrl laurl)
        {
            return LAUrlDb.Create(laurl);
        }

        public bool Delete(int id)
        {
            return LAUrlDb.Delete(id);
        }

        public IEnumerable<LAUrl> GetAll()
        {
            var lAUrls = LAUrlDb.GetAll();
            return lAUrls;
        }

        public IEnumerable<LAUrl> GetAll(bool IsApproved)
        {
            var lAUrls = LAUrlDb.GetAll(IsApproved);
            return lAUrls;
        }

        public LAUrl GetById(int id)
        {
            var laurl = LAUrlDb.GetById(id);
            return laurl;
        }

        public bool Update(LAUrl laurl)
        {
            return LAUrlDb.Update(laurl);
        }
    }
}
