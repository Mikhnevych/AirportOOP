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
    public partial class Form2 : Form
    {
        DataTable bookingsTable = new DataTable();

        public Form2()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void InitializeDataGridView()
        {
            // Настройка DataGridView для отображения данных
            dataGridView1.DataSource = bookingsTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void LoadBookings()
        {
            try
            {
                string filePath = "bookings.csv";
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    bookingsTable.Columns.Add("Booking Reference");
                    bookingsTable.Columns.Add("Details");

                    while ((line = sr.ReadLine()) != null)
                    {
                        int firstCommaIndex = line.IndexOf(',');
                        if (firstCommaIndex > 0 && firstCommaIndex < line.Length - 1)
                        {
                            string bookingReference = line.Substring(0, firstCommaIndex);
                            string details = line.Substring(firstCommaIndex + 1);
                            bookingsTable.Rows.Add(bookingReference, details);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load bookings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Удаление выбранной строки
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                SaveBookings(); // Сохранение изменений
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            SaveBookings(); // Сохранение изменений
        }

        private void SaveBookings()
        {
            try
            {
                string filePath = "bookings.csv";
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (DataRow row in bookingsTable.Rows)
                    {
                        sw.WriteLine($"{row[0]},{row[1]}");
                    }
                }
                MessageBox.Show("Bookings updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save bookings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
