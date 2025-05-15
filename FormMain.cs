namespace AppTitlesAnime
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnShowTypes_Click(object sender, EventArgs e)
        {
            FormListTypes formListTypes = new FormListTypes();
            formListTypes.Show();

            /*FormListTypes formListTypes1 = new FormListTypes();
            formListTypes1.ShowDialog();*/
        }

        private void BtnShowStatus_Click(object sender, EventArgs e)
        {
            FormListStatus formListStatus = new FormListStatus();
            formListStatus.Show();
        }

        private void BtnShowGenres_Click(object sender, EventArgs e)
        {
            FormListGenres formListGenres = new FormListGenres();
            formListGenres.Show();
        }
    }
}
