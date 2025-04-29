using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppContext = AppTitlesAnime.Models.AppContext;
using Status = AppTitlesAnime.Models.Status;


namespace AppTitlesAnime
{
    public partial class FormAddStatus : Form
    {
        private AppContext db;

        internal object textBoxStatusName;
        private object dataGridViewStatus;
        private object btnSaveChanges;

        public FormAddStatus()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            db = new AppContext();
            db.Statuses.Load();
            this.dataGridViewStatus = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            this.db?.Dispose();
            this.db = null;
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
            }else if(db.Statuses.Local.Any(o => o.StatusName.Equals(textBoxStatus.Text, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider.SetError(textBoxStatus, "Такое значение уже есть!");
                btnSaveChanges = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveStatus.Enabled = true;
            }
        }
    }
}
