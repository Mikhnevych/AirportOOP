using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadAirports();
            InitializeControls();
        }

        private void cmbDeparture_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbReturnAirport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbEconomy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbBuisness_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFirstClass_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void DepartureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DestinantionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void returnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверка выбора пользователя и отображение соответствующего сообщения
            if (returnComboBox.SelectedIndex == 0)
            {
                // Пользователь выбрал возврат в аэропорт отправления
                MessageBox.Show("You have selected to return to the departure airport.");
            }
            else if (returnComboBox.SelectedIndex == 1)
            {
                // Пользователь выбрал продолжение из пункта назначения
                MessageBox.Show("You have selected to continue from the destination airport.");
            }
        }

        private void EconomyCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BusinessCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FirstClassCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        List<string> airports; // Список доступных аэропортов



        private void LoadAirports()
        {
            try
            {
                // Путь к файлу CSV
                string filePath = @"airports.csv";
                var lines = File.ReadAllLines(filePath);
                airports = lines.Select(line => line.Split(',')[1].Trim()).ToList();
                airports.Sort(); // Сортировка списка для удобства пользователя
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load airports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeControls()
        {
            DepartureComboBox.DataSource = new List<string>(airports);
            DestinantionComboBox.DataSource = new List<string>(airports);

            // Убедимся, что returnComboBox очищен и заполнен новыми значениями
            returnComboBox.Items.Clear();
            returnComboBox.Items.Add("Return to Departure Airport");
            returnComboBox.Items.Add("Continue from Destination");
            returnComboBox.SelectedIndex = 0; // Установка начального выбора
        }

        private void ValidateAirports()
        {
            if (DepartureComboBox.SelectedItem.ToString() == DestinantionComboBox.SelectedItem.ToString())
            {
                MessageBox.Show("Departure and destination airports cannot be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DepartureComboBox.SelectedIndex = -1;
                DestinantionComboBox.SelectedIndex = -1;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (DepartureComboBox.SelectedIndex == -1 || DestinantionComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select valid airports.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string seatType = EconomyCheckBox.Checked ? "Economy" : BusinessCheckBox.Checked ? "Business" : "First Class";
            string bookingDetails = $"Flight from {DepartureComboBox.SelectedItem} to {DestinantionComboBox.SelectedItem}, Seat Type: {seatType}";

            // Добавление запроса на подтверждение перед сохранением
            DialogResult result = MessageBox.Show("Confirm booking:\n" + bookingDetails, "Confirm Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SaveBooking(bookingDetails); // Сохранение бронирования в файл
                MessageBox.Show("Booking successful: " + bookingDetails, "Booking Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Booking cancelled.", "Booking Cancellation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveBooking(string bookingDetails)
        {
            try
            {
                string bookingReference = GenerateBookingReference();
                string filePath = "bookings.csv";
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    // Запись с уникальным идентификатором и деталями бронирования
                    sw.WriteLine($"{bookingReference},{bookingDetails}");
                }
                MessageBox.Show($"Booking saved. Reference: {bookingReference}", "Booking Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateBookingReference()
        {
            // Генерация уникального идентификатора бронирования на основе даты и времени
            return $"BR-{DateTime.Now.Ticks}";
        }

        private void AllDataBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            // Отображение Form2 как модального диалогового окна
            form2.ShowDialog();
        }
    }
}