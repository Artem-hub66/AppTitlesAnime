

using AppTitlesAnime.Models;

namespace AppTitlesAnime
{
    partial class FormListGenres
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanelGenresTop = new FlowLayoutPanel();
            btnAddGenres = new Button();
            btnUpdateGenres = new Button();
            btnDeleteGenres = new Button();
            dataGridViewGenres = new DataGridView();
            panelGenresFill = new Panel();
            flowLayoutPanelGenresTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenres).BeginInit();
            panelGenresFill.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelGenresTop
            // 
            flowLayoutPanelGenresTop.BackColor = Color.Silver;
            flowLayoutPanelGenresTop.Controls.Add(btnAddGenres);
            flowLayoutPanelGenresTop.Controls.Add(btnUpdateGenres);
            flowLayoutPanelGenresTop.Controls.Add(btnDeleteGenres);
            flowLayoutPanelGenresTop.Dock = DockStyle.Top;
            flowLayoutPanelGenresTop.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flowLayoutPanelGenresTop.Location = new Point(0, 0);
            flowLayoutPanelGenresTop.Name = "flowLayoutPanelGenresTop";
            flowLayoutPanelGenresTop.Padding = new Padding(10);
            flowLayoutPanelGenresTop.Size = new Size(800, 62);
            flowLayoutPanelGenresTop.TabIndex = 0;
            // 
            // btnAddGenres
            // 
            btnAddGenres.AutoSize = true;
            btnAddGenres.Location = new Point(13, 13);
            btnAddGenres.Name = "btnAddGenres";
            btnAddGenres.Size = new Size(106, 35);
            btnAddGenres.TabIndex = 0;
            btnAddGenres.Text = "Добавить";
            btnAddGenres.UseVisualStyleBackColor = true;
            btnAddGenres.Click += BtnAddGenres_Click;
            // 
            // btnUpdateGenres
            // 
            btnUpdateGenres.AutoSize = true;
            btnUpdateGenres.Location = new Point(125, 13);
            btnUpdateGenres.Name = "btnUpdateGenres";
            btnUpdateGenres.Size = new Size(151, 35);
            btnUpdateGenres.TabIndex = 1;
            btnUpdateGenres.Text = "Редактировать";
            btnUpdateGenres.UseVisualStyleBackColor = true;
            btnUpdateGenres.Click += BtnUpdateGenres_Click;
            // 
            // btnDeleteGenres
            // 
            btnDeleteGenres.AutoSize = true;
            btnDeleteGenres.Location = new Point(282, 13);
            btnDeleteGenres.Name = "btnDeleteGenres";
            btnDeleteGenres.Size = new Size(92, 35);
            btnDeleteGenres.TabIndex = 2;
            btnDeleteGenres.Text = "Удалить";
            btnDeleteGenres.UseVisualStyleBackColor = true;
            btnDeleteGenres.Click += BtnDeleteGenres_Click;
            // 
            // dataGridViewGenres
            // 
            dataGridViewGenres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGenres.BackgroundColor = Color.White;
            dataGridViewGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGenres.Dock = DockStyle.Fill;
            dataGridViewGenres.Location = new Point(10, 10);
            dataGridViewGenres.MultiSelect = false;
            dataGridViewGenres.Name = "dataGridViewGenres";
            dataGridViewGenres.ReadOnly = true;
            dataGridViewGenres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGenres.Size = new Size(780, 368);
            dataGridViewGenres.TabIndex = 1;
            dataGridViewGenres.CellContentClick += dataGridViewGenres_CellContentClick;
            // 
            // panelGenresFill
            // 
            panelGenresFill.Controls.Add(dataGridViewGenres);
            panelGenresFill.Dock = DockStyle.Fill;
            panelGenresFill.Location = new Point(0, 62);
            panelGenresFill.Name = "panelGenresFill";
            panelGenresFill.Padding = new Padding(10);
            panelGenresFill.Size = new Size(800, 388);
            panelGenresFill.TabIndex = 2;
            panelGenresFill.Paint += panelGenresFill_Paint;
            // 
            // FormListGenres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(panelGenresFill);
            Controls.Add(flowLayoutPanelGenresTop);
            Name = "FormListGenres";
            Text = "Список жанров";
            flowLayoutPanelGenresTop.ResumeLayout(false);
            flowLayoutPanelGenresTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenres).EndInit();
            panelGenresFill.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void BtnDeleteGenres_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (dataGridViewGenres.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект? \nВсе связанные данные будут удалены.",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.No)
                return;

            int index = dataGridViewGenres.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewGenres[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Genre type = db.Genres.Find(id);

            db.Genres.Remove(type);
            db.SaveChanges();

            MessageBox.Show("Объект удалён.");

            this.dataGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenresName).ToList();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelGenresTop;
        private Button btnAddGenres;
        private Button btnUpdateGenres;
        private Button btnDeleteGenres;
        private DataGridView dataGridViewGenres;
        private Panel panelGenresFill;
    }
}