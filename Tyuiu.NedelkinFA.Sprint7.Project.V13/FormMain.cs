using System;
using System.Windows.Forms;
using System.Xml.Linq;
using Tyuiu.NedelkinFA.Sprint7.Project.V13.Lib;
using static System.Windows.Forms.MonthCalendar;

namespace Tyuiu.NedelkinFA.Sprint7.Project.V13
{
    public partial class FormMain : Form
    {
        private DataService _dataService;

        public FormMain()
        {
            InitializeComponent();
            _dataService = new DataService();
        }

        // Загрузка данных при старте формы
        private void FormMain_Load(object sender, EventArgs e)
        {

            UpdateCountryList();
        }

        // Обновление списка стран в DataGridView
        private void UpdateCountryList()
        {
            dgvCountries.Rows.Clear();
            foreach (var country in _dataService.Countries)
            {
                dgvCountries.Rows.Add(country.Name, country.Capital, country.Area, country.IsDeveloped, country.Population, country.PredominantNationality, country.Notes);
            }
        }

        // Добавление новой страны
        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            var country = new Country
            {
                Name = txtName.Text,
                Capital = txtCapital.Text,
                Area = Convert.ToDouble(txtArea.Text),
                IsDeveloped = chkIsDeveloped.Checked,
                Population = Convert.ToInt64(txtPopulation.Text),
                PredominantNationality = txtNationality.Text,
                Notes = txtNotes.Text
            };
            _dataService.AddCountry(country);
            _dataService.SaveData();
            UpdateCountryList();
        }

        // Сохранение данных
        private void btnSaveData_Click(object sender, EventArgs e)
        {
            _dataService.SaveData();
            MessageBox.Show("Данные успешно сохранены!");
        }

        // Загрузка данных
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            _dataService.LoadData();
            UpdateCountryList();
            MessageBox.Show("Данные успешно загружены!");
        }

        // Удаление страны
        private void btnDeleteCountry_Click(object sender, EventArgs e)
        {
            if (dgvCountries.SelectedRows.Count > 0)
            {
                var selectedRow = dgvCountries.SelectedRows[0];
                var countryName = selectedRow.Cells[0].Value.ToString();
                _dataService.RemoveCountry(countryName);
                _dataService.SaveData();
                UpdateCountryList();
            }
        }
    }
}
