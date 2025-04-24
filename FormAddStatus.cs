using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTitlesAnime
{
    public partial class FormAddStatus : Form
    {
        internal object textBoxStatusName;

        public FormAddStatus()
        {
            InitializeComponent();
        }

        private void panelAddStatus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBoxStatus_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStatus.Text))
            {
                errorProvider.SetError(textBoxStatus, "Поле не может быть пустым!");
                btnSaveStatus.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveStatus.Enabled = true;
            }
        }

        private void TextBoxStatus_TextChanges (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStatus.Text))
            {
                errorProvider.SetError(textBoxStatus, "Поле не может быть пустым!");
                btnSaveStatus.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveStatus.Enabled = true;
            }
        }
    }
}
