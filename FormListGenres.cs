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
            dataGridViewGenres.Columns["AnimeTitles"].Visible = false;

            //изменение названий заголовков столбцов
            dataGridViewGenres.Columns["GenresName"].HeaderText = "Жанр аниме";

        }

        private void panelGenresFill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAddGenres_Click(object sender, EventArgs e)
        {
            FormAddGenres formAddGenres = new FormAddGenres();
            formAddGenres.ShowDialog();
        }

        private void dataGridViewGenres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
