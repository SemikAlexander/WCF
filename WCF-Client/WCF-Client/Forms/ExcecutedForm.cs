using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCF_Client.Connection;
using WCF_Client.ServiceReference1;

namespace WCF_Client.Forms
{
    public partial class ExcecutedForm : Form
    {
        private List<ServiceStation> serviceStations;
        private List<ServicesOnStation> servicesOnStations;
        private List<CarBrand> carsBrand;

        public ExcecutedForm()
        {
            InitializeComponent();
        }

        public List<ServiceStation> ServiceStations { get => serviceStations; set => serviceStations = value; }

        private void ExcecutedForm_Load(object sender, EventArgs e)
        {
            ServiceStations = ServiceConnection.Service.GetAllServiceStations().ToList();
            for (int i = 0; i < ServiceStations.Count; i++)
                serviceStationsComboBox.Items.Add(ServiceStations[i].Name);

            carsBrand = ServiceConnection.Service.GetAllCars().ToList();
            for (int i = 0; i < carsBrand.Count; i++)
                carBrandComboBox.Items.Add(carsBrand[i].Name);
        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(priceTextBox.Text) == false)
            {
                int stationID = serviceStations[serviceStationsComboBox.SelectedIndex].Id;
                int serviceID = servicesOnStations[servicesComboBox.SelectedIndex].Id;
                int carBrandID = carsBrand[carBrandComboBox.SelectedIndex].Id;
                int price = Convert.ToInt32(priceTextBox.Text);
                DateTime date = dateTimePicker.Value;

                string format = "yyyy-MM-dd";

                if (ServiceConnection.Service.AddExecutedService(stationID, carBrandID, serviceID, date.ToString(format)) == 1)
                {
                    MessageBox.Show("Запись добавлена!");
                    priceTextBox.Text = "";
                }
                else
                    MessageBox.Show("Запись уже существует!");
            }
        }

        private void serviceStationsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            servicesComboBox.Items.Clear();

            int stationID = serviceStations[serviceStationsComboBox.SelectedIndex].Id;

            servicesOnStations = ServiceConnection.Service.GetAllServicesOnStation(stationID).ToList();
            for (int i = 0; i < servicesOnStations.Count; i++)
                servicesComboBox.Items.Add(servicesOnStations[i].Name);
        }

        private void servicesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceTextBox.Text = servicesOnStations[servicesComboBox.SelectedIndex].Price.ToString();
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}