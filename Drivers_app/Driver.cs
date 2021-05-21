using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drivers_app
{
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }

        private void driverBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driverBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDriverDataSet);

        }

        private void Driver_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDriverDataSet.Driver". При необходимости она может быть перемещена или удалена.
            this.driverTableAdapter.Fill(this.databaseDriverDataSet.Driver);

        }

        private void licbtn_Click(object sender, EventArgs e)
        {
            license frm = new license();
            frm.Show();
            this.Hide();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void residentialAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void commentsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrationAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passportTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gUIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void middleNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void postcodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeOfWorkTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void positionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mobilePhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void photoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeOfWorkLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void surnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void gUIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void passportLabel_Click(object sender, EventArgs e)
        {

        }

        private void registrationAddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void driverBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
