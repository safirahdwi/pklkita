using adminLTE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adminLTE.Data.Repository
{
    public interface IRepository
    {
        editPublikasi GetPublikasi(int id);
        List<editPublikasi> GetAllPublikasis();
        void AddPublikasi(editPublikasi publikasi);
        void UpdatePublikasi(editPublikasi publikasi);
        void RemovePublikasi(int id);

        Task<bool> SaveChangesAsync();
    }
}
