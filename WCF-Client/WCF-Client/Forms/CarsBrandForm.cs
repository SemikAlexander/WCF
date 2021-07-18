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
    public partial class CarsBrandForm : Form
    {
        public CarsBrandForm()
        {
            InitializeComponent();
        }

        private void fillDataGridView()
        {
            dataGridView1.Rows.Clear();
            var carsBrand = ServiceConnection.Service.GetAllCars();
            for (int i = 0; i < carsBrand.Length; i++)
                dataGridView1.Rows.Add(carsBrand[i].Id, carsBrand[i].Name, carsBrand[i].Year);
        }

        private void addCarBandButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) == false & string.IsNullOrWhiteSpace(yearTextBox.Text) == false)
            {
                if (ServiceConnection.Service.InsertCarBrand(nameTextBox.Text, yearTextBox.Text) == 1)
                {
                    MessageBox.Show("Запись добавлена!");
                    nameTextBox.Text = yearTextBox.Text = "";
                    fillDataGridView();
                }
                else
                    MessageBox.Show("Запись уже существует!");
            }
        }

        private void CarsBrandForm_Load(object sender, EventArgs e)
        {
            fillDataGridView();
        }

        private void yearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}