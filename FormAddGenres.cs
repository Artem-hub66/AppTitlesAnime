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
using Gebre = AppTitlesAnime.Models.Genre;

namespace AppTitlesAnime
{
    public partial class FormAddGenres : Form
    {
        private AppContext db;

        internal object textBoxGenresName;
        private object dataGridViewGenres;

        public FormAddGenres()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Genres.Load();
            this.dataGridViewGenres = this.db.Genres.Local.OrderBy(o => o.GenresName).ToList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
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
            //any проверяет сущ эл в послед. Equals проверяет равенство элементов
            else if (db.Genres.Local.Any(o => o.GenresName.Equals(textBoxGenres.Text, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider.SetError(textBoxGenres, "Такое значение уже есть!");
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
