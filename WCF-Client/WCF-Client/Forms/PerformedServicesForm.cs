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

namespace WCF_Client.Forms
{
    public partial class PerformedServicesForm : Form
    {
        private List<ServiceReference1.ServiceStation> serviceStations;
        private List<ServiceReference1.ServicesPerformed> servicesPerformeds;
        private ServiceReference1.Statistic statistic;

        private int idStation = -1;

        public PerformedServicesForm()
        {
            InitializeComponent();
        }

        private void fillDataGridView(int IDStation)
        {
            dataGridView1.Rows.Clear();

            int totalAmount = 0;

            if (!filterCheckBox.Checked)
                servicesPerformeds = ServiceConnection.Service.GetAllexecutedServicesOnStation(idStation).ToList();
            else
            {
                DateTime fromDate = fromDateTimePicker.Value;
                DateTime untilDate = untilDateTimePicker.Value;

                string format = "yyyy-MM-dd";

                servicesPerformeds = ServiceConnection.Service.GetAllexecutedServicesOnStationWithFilter(idStation, fromDate.ToString(format), untilDate.ToString(format)).ToList();
            }

            for (int i = 0; i < servicesPerformeds.Count; i++)
            {
                dataGridView1.Rows.Add
                (
                    servicesPerformeds[i].nameCar,
                    servicesPerformeds[i].year,
                    servicesPerformeds[i].nameService,
                    servicesPerformeds[i].price,
                    servicesPerformeds[i].date
                );

                totalAmount += servicesPerformeds[i].price;
            }

            countServicesSTOTextBox.Text = servicesPerformeds.Count.ToString();
            totalAmountSTOTextBox.Text = totalAmount.ToString();
        }

        private void PerformedServicesForm_Load(object sender, EventArgs e)
        {
            serviceStations = ServiceConnection.Service.GetAllServiceStations().ToList();
            for (int i = 0; i < serviceStations.Count; i++)
                serviceStationsComboBox.Items.Add(serviceStations[i].Name);

            statistic = ServiceConnection.Service.GetStatistic();

            countServicesTextBox.Text = statistic.countServices.ToString();
            totalAmountTextBox.Text = statistic.totalAmount.ToString();
        }

        private void serviceStationsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            idStation = serviceStations[serviceStationsComboBox.SelectedIndex].Id;

            fillDataGridView(idStation);
        }

        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            idStation = serviceStations[serviceStationsComboBox.SelectedIndex].Id;

            fillDataGridView(idStation);
        }

        private void untilDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            idStation = serviceStations[serviceStationsComboBox.SelectedIndex].Id;

            fillDataGridView(idStation);
        }

        private void filterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            idStation = serviceStations[serviceStationsComboBox.SelectedIndex].Id;

            fillDataGridView(idStation);
        }
    }
}