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
    public partial class AddServicesForm : Form
    {
        private int id = -1;
        private string name = "";

        private List<ServiceReference1.Services> services;

        public AddServicesForm(int IDStation, string nameStation)
        {
            InitializeComponent();
            id = IDStation;
            name = nameStation;
        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(priceTextBox.Text) == false)
            {
                int serviceID = services[servicesComboBox.SelectedIndex].Id;

                if (ServiceConnection.Service.AddServiceForStation(id, serviceID, Convert.ToInt32(priceTextBox.Text)) == 1)
                {
                    MessageBox.Show("Запись добавлена!");
                    priceTextBox.Text = "";

                    fillDataGridView();
                }
                else
                    MessageBox.Show("Запись уже существует!");
            }
        }

        private void AddServicesForm_Load(object sender, EventArgs e)
        {
            fillDataGridView();

            this.Text = name;

            services = ServiceConnection.Service.GetAllServices().ToList();
            for (int i = 0; i < services.Count; i++)
                servicesComboBox.Items.Add(services[i].Name);
        }

        private void fillDataGridView()
        {
            dataGridView1.Rows.Clear();

            var servicesOnStation = ServiceConnection.Service.GetAllServicesOnStation(id);
            for (int i = 0; i < servicesOnStation.Length; i++)
                dataGridView1.Rows.Add(servicesOnStation[i].Id, servicesOnStation[i].Name, servicesOnStation[i].Price);
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
