using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using adminLTE.Models;

namespace adminLTE.Data.Repository
{
    public class Repository : IRepository
    {
        private AppDbContext _ctx;
        public Repository(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public editPublikasi GetPublikasi(int id)
        {
            return _ctx.Publikasis.FirstOrDefault(p=>p.Id == id);
        }

        public List<editPublikasi> GetAllPublikasis()
        {
            return _ctx.Publikasis.ToList();
        }

        public void AddPublikasi(editPublikasi publikasi)
        {
            _ctx.Publikasis.Add(publikasi);
        }

        public void UpdatePublikasi(editPublikasi publikasi)
        {
           _ctx.Publikasis.Update(publikasi);
        }

        void IRepository.RemovePublikasi(int id)
        {
          _ctx.Publikasis.Remove(GetPublikasi(id));
        }

        public async Task<bool> SaveChangesAsync()
        {
           if (await _ctx.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
