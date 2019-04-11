using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntityFramework.Services;
using Core.Models;

namespace DigitalBillboardTest
{
    [TestClass]
    public class IRepositoryTest
    {
        [TestMethod]
        public void InsertTest()
        {
            //Arrange
            Banner banner;
            banner.Nombre = "banner de prueba";
            banner.HoraInicio = new TimeSpan(11, 02, 07);
            banner.HoraFin = new TimeSpan(11, 17, 07);
            banner.Id = 0;
            banner.Estado = true;
            banner.FechaInicio = new DateTime(2019, 05, 21);
            banner.FechaFin = new DateTime(2019, 05, 24);

            //Act
            IRepository<Banner> repository;
            repository.Insert(banner);

            //Assert
        }
    }
}
