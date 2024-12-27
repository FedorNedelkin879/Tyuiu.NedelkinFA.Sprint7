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
            // �������������� DataService ����� ������ ������
            _dataService = new DataService();
        }

        [TearDown]
        public void TearDown()
        {
            // ������� �������� ���� ����� ������� �����
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
                Name = "������",
                Capital = "������",
                Area = 17098242,
                IsDeveloped = false,
                Population = 145912025,
                PredominantNationality = "�������",
                Notes = "����� ������� ������ �� ����������."
            };

            // Act
            _dataService.AddCountry(country);

            // Assert
            var addedCountry = _dataService.GetCountryByName("������");
            Assert.IsNotNull(addedCountry);
            Assert.AreEqual("������", addedCountry.Name);
        }

        [Test]
        public void RemoveCountry_ShouldRemoveCountryFromList()
        {
            // Arrange
            var country = new Country
            {
                Name = "���",
                Capital = "���������",
                Area = 9833517,
                IsDeveloped = true,
                Population = 331893745,
                PredominantNationality = "����������",
                Notes = "������ � ���������� ����������."
            };
            _dataService.AddCountry(country);

            // Act
            _dataService.RemoveCountry("���");

            // Assert
            var removedCountry = _dataService.GetCountryByName("���");
            Assert.IsNull(removedCountry);
        }

        [Test]
        public void SaveData_ShouldSaveCountriesToFile()
        {
            // Arrange
            var country = new Country
            {
                Name = "��������",
                Capital = "������",
                Area = 357022,
                IsDeveloped = true,
                Population = 83240525,
                PredominantNationality = "�����",
                Notes = "������������� ������� ������."
            };
            _dataService.AddCountry(country);
            _dataService.SaveData();

            // Act
            _dataService.LoadData();

            // Assert
            var loadedCountry = _dataService.GetCountryByName("��������");
            Assert.IsNotNull(loadedCountry);
            Assert.AreEqual("��������", loadedCountry.Name);
        }
    }
}
