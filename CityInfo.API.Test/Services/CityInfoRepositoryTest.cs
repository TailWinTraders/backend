using CityInfo.API.DbContexts;
using CityInfo.API.Services;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace CityInfo.API.Test.Services
{
    [TestClass]
    public class CityInfoRepositoryTest 
    {

        private static async Task<CityInfoContext> GetDbContext()
        {
            var _options = new DbContextOptionsBuilder<CityInfoContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

            var databaseContext = new CityInfoContext(_options);
            await databaseContext.Database.EnsureCreatedAsync();
            return databaseContext;
        }

        [Fact]
        [TestMethod]
        public async Task TestGetCities()
        {
            var dbContext = GetDbContext();
            var cityInfoRepository = new CityInfoRepository(dbContext.Result);

            var result = await cityInfoRepository.GetCitiesAsync();

            Assert.IsNotNull(result);
        }


        [Fact]
        [TestMethod]
        public async Task TestGetCityById()
        {
            var dbContext = GetDbContext();
            var cityInfoRepository = new CityInfoRepository(dbContext.Result);

            var cityId = 1;

            var result = await cityInfoRepository.GetCityAsync(cityId, false);

            Assert.IsNotNull(result);
            Assert.AreEqual(cityId, result.Id);
        }

    }
}