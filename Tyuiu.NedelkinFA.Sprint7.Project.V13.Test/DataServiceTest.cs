using NUnit.Framework;
using Tyuiu.NedelkinFA.Sprint7.Project.V13.Lib;
using System.IO;

namespace Tyuiu.NedelkinFA.Sprint7.Project.V13.Test
{
    public class Tests
    {
        private const string TestFilePath = "test_countries.json";
        private DataService _dataService;

        [SetUp]
        public void SetUp()
        {
            // Инициализируем DataService перед каждым тестом
            _dataService = new DataService();
        }

        [TearDown]
        public void TearDown()
        {
            // Удаляем тестовый файл после каждого теста
            if (File.Exists(TestFilePath))
            {
                File.Delete(TestFilePath);
            }
        }

        [Test]
        public void AddCountry_ShouldAddCountryToList()
        {
            // Arrange
            var country = new Country
            {
                Name = "Россия",
                Capital = "Москва",
                Area = 17098242,
                IsDeveloped = false,
                Population = 145912025,
                PredominantNationality = "Русские",
                Notes = "Самая большая страна по территории."
            };

            // Act
            _dataService.AddCountry(country);

            // Assert
            var addedCountry = _dataService.GetCountryByName("Россия");
            Assert.IsNotNull(addedCountry);
            Assert.AreEqual("Россия", addedCountry.Name);
        }

        [Test]
        public void RemoveCountry_ShouldRemoveCountryFromList()
        {
            // Arrange
            var country = new Country
            {
                Name = "США",
                Capital = "Вашингтон",
                Area = 9833517,
                IsDeveloped = true,
                Population = 331893745,
                PredominantNationality = "Американцы",
                Notes = "Страна с крупнейшей экономикой."
            };
            _dataService.AddCountry(country);

            // Act
            _dataService.RemoveCountry("США");

            // Assert
            var removedCountry = _dataService.GetCountryByName("США");
            Assert.IsNull(removedCountry);
        }

        [Test]
        public void SaveData_ShouldSaveCountriesToFile()
        {
            // Arrange
            var country = new Country
            {
                Name = "Германия",
                Capital = "Берлин",
                Area = 357022,
                IsDeveloped = true,
                Population = 83240525,
                PredominantNationality = "Немцы",
                Notes = "Экономическая держава Европы."
            };
            _dataService.AddCountry(country);
            _dataService.SaveData();

            // Act
            _dataService.LoadData();

            // Assert
            var loadedCountry = _dataService.GetCountryByName("Германия");
            Assert.IsNotNull(loadedCountry);
            Assert.AreEqual("Германия", loadedCountry.Name);
        }
    }
}
