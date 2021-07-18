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
    public partial class StationServicesFrom : Form
    {
        int IDStation = -1;
        string nameStation = "";
        string addressStation = "";
        string descriptionStation = "";

        public StationServicesFrom(int ID, string name, string address, string description)
        {
            InitializeComponent();

            IDStation = ID;
            nameStation = name;
            addressStation = address;
            descriptionStation = description;
        }

        private void StationServicesFrom_Load(object sender, EventArgs e)
        {
            var servicesOnStation = ServiceConnection.Service.GetAllServicesOnStation(IDStation);
            for (int i = 0; i < servicesOnStation.Length; i++)
                dataGridView1.Rows.Add(servicesOnStation[i].Id, servicesOnStation[i].Name, servicesOnStation[i].Price);

            nameTextBox.Text = nameStation;
            addressTextBox.Text = addressStation;
            descriptionTextBox.Text = descriptionStation;
        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {
            using (AddServicesForm addServices = new AddServicesForm(IDStation, nameTextBox.Text))
            {
                addServices.Show();
            }
            Close();
        }
    }
}