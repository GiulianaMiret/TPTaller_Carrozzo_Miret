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
    public interface IBannerRepository
    {
        //List<BannerRSS> GetAllRss();

        //List<BannerTextoFijo> GetAllTXT();

        Banner GetBannerNow();

        Dictionary<string, List<Banner>> AvailableTimes(DateTime pFechaInicio, DateTime pFechaFin);

        bool AvailableHours(Banner pBanner, Dictionary<string, List<Banner>> pDictionary);
    }
}
