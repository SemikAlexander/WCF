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
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
        }

        private void fillDataGridView()
        {
            dataGridView1.Rows.Clear();
            var services = ServiceConnection.Service.GetAllServices();
            for (int i = 0; i < services.Length; i++)
                dataGridView1.Rows.Add(services[i].Id, services[i].Name, services[i].Description);
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            fillDataGridView();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) == false & string.IsNullOrWhiteSpace(descriptionTextBox.Text) == false)
            {
                if (ServiceConnection.Service.InsertService(nameTextBox.Text, descriptionTextBox.Text) == 1)
                {
                    MessageBox.Show("Запись добавлена!");
                    nameTextBox.Text = descriptionTextBox.Text = "";
                    fillDataGridView();
                }
                else
                    MessageBox.Show("Запись уже существует!");
            }
        }
    }
}
