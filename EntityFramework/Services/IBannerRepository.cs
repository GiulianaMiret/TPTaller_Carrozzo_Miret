using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using System.Linq.Expressions;
using System.Data.Entity;

namespace EntityFramework.Services
{
    public interface IBannerRepository : IRepository<Banner>
    {
        void CambiarFuente(int pIdBannerRSS, int pIdFuente);

        List<BannerRSS> GetAllRss();

        List<BannerTextoFijo> GetAllTXT();

        List<Banner> GetAllBannerRSS();

        List<Banner> GetAllBannerTXT();
    }
}
