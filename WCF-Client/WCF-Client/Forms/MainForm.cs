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

namespace WCF_Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void fillDataGridView()
        {
            dataGridView1.Rows.Clear();

            var stations = ServiceConnection.Service.GetAllServiceStations();
            for (int i = 0; i < stations.Length; i++)
                dataGridView1.Rows.Add(stations[i].Id, stations[i].Name, stations[i].Address, stations[i].Description);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) == false
                & string.IsNullOrWhiteSpace(addressTextBox.Text) == false
                & string.IsNullOrWhiteSpace(descriptionTextBox.Text) == false)
            {
                if (ServiceConnection.Service.InsertServiceStation(nameTextBox.Text, addressTextBox.Text, descriptionTextBox.Text) == 1)
                {
                    MessageBox.Show("Запись добавлена!");
                    nameTextBox.Text = addressTextBox.Text = descriptionTextBox.Text = "";
                    fillDataGridView();
                }
                else
                    MessageBox.Show("Запись уже существует!");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            fillDataGridView();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idChosenStation = (int)dataGridView1.CurrentRow.Cells[0].Value;
            string nameStation = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string addressStation = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string descriptionStation = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            using (Forms.StationServicesFrom serviceFrom = new Forms.StationServicesFrom(idChosenStation, nameStation, addressStation, descriptionStation))
            {
                serviceFrom.Show();
            }
        }

        private void выполненнуюРаботуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Forms.ExcecutedForm excecutedForm = new Forms.ExcecutedForm())
            {
                excecutedForm.Show();
            }
        }

        private void маркиМашинToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void видыУслугToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выполенныеУслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}