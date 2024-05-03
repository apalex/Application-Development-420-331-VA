using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;

namespace Assignment04
{
    public partial class Form1 : Form
    {
        private HttpClient client;
        private int currentIndex = 0;
        private const string api = "https://anapioficeandfire.com/api/houses/";

        public Form1()
        {
            client = new HttpClient();
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            await LoadHouse(currentIndex);
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0 && currentIndex != 1)
            {
                currentIndex--;
                await LoadHouse(currentIndex);
            } else if (currentIndex == 1)
            {
                txtBoxName.Text = "";
                txtBoxRegion.Text = "";
                txtBoxCoatOfArms.Text = "";
                currentIndex--;
            }
        }

        private async Task LoadHouse(int index)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(api + index);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                House house = JsonConvert.DeserializeObject<House>(responseBody);
                DisplayHouse(house);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error fetching house: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayHouse(House house)
        {
            txtBoxName.Text = house.Name;
            txtBoxRegion.Text = house.Region;
            txtBoxCoatOfArms.Text = house.CoatOfArms;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class House
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string CoatOfArms { get; set; }
    }
}
