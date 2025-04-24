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
    public partial class FormAddGenres : Form
    {
        internal object textBoxGenresName;

        public FormAddGenres()
        {
            InitializeComponent();
        }

        private void btnSaveGenres_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxGenres_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxGenres.Text))
            {
                errorProvider.SetError(textBoxGenres, "Поле не может быть пустым!");
                btnSaveGenres.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveGenres.Enabled = true;
            }
        }

        private void TextBoxGenres_TextChanges (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxGenres.Text))
            {
                errorProvider.SetError(textBoxGenres, "Поле не может быть пустым!");
                btnSaveGenres.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveGenres.Enabled = true;
            }
        }
    }
}
