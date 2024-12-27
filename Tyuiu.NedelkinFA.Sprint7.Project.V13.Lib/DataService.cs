using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Tyuiu.NedelkinFA.Sprint7.Project.V13.Lib
{
    public class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public double Area { get; set; }
        public bool IsDeveloped { get; set; }
        public long Population { get; set; }
        public string PredominantNationality { get; set; }
        public string Notes { get; set; }
    }

    public class DataService
    {
        private const string FilePath = "countries.json";

        public List<Country> Countries { get; private set; }

        public DataService()
        {
            Countries = new List<Country>();
        }

        // Загрузка данных из файла
        public void LoadData()
        {
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                Countries = JsonSerializer.Deserialize<List<Country>>(json) ?? new List<Country>();
            }
        }

        // Сохранение данных в файл
        public void SaveData()
        {
            var json = JsonSerializer.Serialize(Countries, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        // Добавление новой страны
        public void AddCountry(Country country)
        {
            Countries.Add(country);
        }

        // Поиск страны по имени
        public Country GetCountryByName(string name)
        {
            return Countries.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        // Удаление страны по имени
        public void RemoveCountry(string name)
        {
            var country = GetCountryByName(name);
            if (country != null)
            {
                Countries.Remove(country);
            }
        }
    }
}
