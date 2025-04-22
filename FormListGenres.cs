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
using Gebre = AppTitlesAnime.Models.Genre;

namespace AppTitlesAnime
{
    public partial class FormListGenres : Form
    {
        private AppContext db;

        public FormListGenres()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Genres.Load();
            this.dataGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenresName).ToList();

            //скрытие столбцов
            dataGridViewGenres.Columns["Id"].Visible = false;
            dataGridViewGenres.Columns["AnimeTitlesGenres"].Visible = false;

            //изменение названий заголовков столбцов
            dataGridViewGenres.Columns["GenresName"].HeaderText = "Жанр аниме";

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void panelGenresFill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAddGenres_Click(object sender, EventArgs e)
        {
            FormAddGenres formAddGenres = new();
            DialogResult result = formAddGenres.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Genre type = new Genre();
            type.GenresName = formAddGenres.textBoxGenres.Text;

            db.Genres.Add(type);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenresName).ToList();
        }

        private void dataGridViewGenres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private AppContext GetDb()
        {
            return db;
        }

        private void BtnUpdateGenres_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenres.SelectedRows.Count == 0)
                return;

            int index = dataGridViewGenres.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewGenres[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Genre type = db.Genres.Find(id);
            FormAddGenres formAddGenres = new();
            type.GenresName = formAddGenres.textBoxGenres.Text;

            DialogResult result = formAddGenres.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            type.GenresName = formAddGenres.textBoxGenres.Text;
            db.Genres.Update(type);
            db.SaveChanges();

            MessageBox.Show("Объект изменён");

            this.dataGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenresName).ToList();
        }
    }
}
