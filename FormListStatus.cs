using AppTitlesAnime.Models;
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
    public partial class FormListStatus : Form
    {
        private AppContext db;

        public FormListStatus()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            db = new AppContext();
            db.Statuses.Load();
            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();

            //скрытие столбцов
            dataGridViewStatus.Columns["Id"].Visible = false;
            dataGridViewStatus.Columns["TitlesStatuses"].Visible = false;

            //изменение названия столбца
            dataGridViewStatus.Columns["StatusName"].HeaderText = "Статус аниме";
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void BtnAddStatus_Click(object sender, EventArgs e)
        {
            FormAddStatus formAddStatus = new();
            DialogResult result = formAddStatus.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Status type = new Status();
            type.StatusName = formAddStatus.textBoxStatus.Text;

            db.Statuses.Add(type);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();
        }

        private void BtnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatus.SelectedRows.Count == 0)
                return;

            int index = dataGridViewStatus.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewStatus[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Status type = db.Statuses.Find(id);
            FormAddStatus formAddStatus = new();
            type.StatusName = formAddStatus.textBoxStatus.Text;

            DialogResult result = formAddStatus.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            type.StatusName = formAddStatus.textBoxStatus.Text;
            db.Statuses.Update(type);
            db.SaveChanges();

            MessageBox.Show("Объект изменён");

            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();
        }
    }
}
