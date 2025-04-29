namespace AppTitlesAnime
{
    partial class FormAddGenres
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
            components = new System.ComponentModel.Container();
            flowLayoutPanelAddGenres = new FlowLayoutPanel();
            btnSaveGenres = new Button();
            btnCancelGenres = new Button();
            panelAddGenres = new Panel();
            textBoxGenres = new TextBox();
            labelGenres = new Label();
            errorProvider = new ErrorProvider(components);
            flowLayoutPanelAddGenres.SuspendLayout();
            panelAddGenres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelAddGenres
            // 
            flowLayoutPanelAddGenres.Controls.Add(btnSaveGenres);
            flowLayoutPanelAddGenres.Controls.Add(btnCancelGenres);
            flowLayoutPanelAddGenres.Dock = DockStyle.Bottom;
            flowLayoutPanelAddGenres.Location = new Point(0, 82);
            flowLayoutPanelAddGenres.Name = "flowLayoutPanelAddGenres";
            flowLayoutPanelAddGenres.Padding = new Padding(10);
            flowLayoutPanelAddGenres.Size = new Size(419, 58);
            flowLayoutPanelAddGenres.TabIndex = 1;
            // 
            // btnSaveGenres
            // 
            btnSaveGenres.AutoSize = true;
            btnSaveGenres.DialogResult = DialogResult.OK;
            btnSaveGenres.Location = new Point(13, 13);
            btnSaveGenres.Name = "btnSaveGenres";
            btnSaveGenres.Size = new Size(115, 35);
            btnSaveGenres.TabIndex = 0;
            btnSaveGenres.Text = "Сохранить";
            btnSaveGenres.UseVisualStyleBackColor = true;
            btnSaveGenres.Click += btnSaveGenres_Click;
            // 
            // btnCancelGenres
            // 
            btnCancelGenres.AutoSize = true;
            btnCancelGenres.DialogResult = DialogResult.Cancel;
            btnCancelGenres.Location = new Point(134, 13);
            btnCancelGenres.Name = "btnCancelGenres";
            btnCancelGenres.Size = new Size(88, 35);
            btnCancelGenres.TabIndex = 1;
            btnCancelGenres.Text = "Отмена";
            btnCancelGenres.UseVisualStyleBackColor = true;
            // 
            // panelAddGenres
            // 
            panelAddGenres.Controls.Add(textBoxGenres);
            panelAddGenres.Controls.Add(labelGenres);
            panelAddGenres.Dock = DockStyle.Fill;
            panelAddGenres.Location = new Point(0, 0);
            panelAddGenres.Name = "panelAddGenres";
            panelAddGenres.Padding = new Padding(10);
            panelAddGenres.Size = new Size(419, 82);
            panelAddGenres.TabIndex = 0;
            // 
            // textBoxGenres
            // 
            textBoxGenres.Dock = DockStyle.Top;
            textBoxGenres.Location = new Point(10, 35);
            textBoxGenres.Name = "textBoxGenres";
            textBoxGenres.Size = new Size(399, 33);
            textBoxGenres.TabIndex = 1;
            textBoxGenres.TextChanged += TextBoxGenres_TextChanges;
            textBoxGenres.Validating += TextBoxGenres_Validating;
            // 
            // labelGenres
            // 
            labelGenres.AutoSize = true;
            labelGenres.Dock = DockStyle.Top;
            labelGenres.Location = new Point(10, 10);
            labelGenres.Name = "labelGenres";
            labelGenres.Size = new Size(120, 25);
            labelGenres.TabIndex = 0;
            labelGenres.Text = "Жанр аниме";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormAddGenres
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(419, 140);
            Controls.Add(panelAddGenres);
            Controls.Add(flowLayoutPanelAddGenres);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAddGenres";
            Text = "Информация о жанре аниме";
            flowLayoutPanelAddGenres.ResumeLayout(false);
            flowLayoutPanelAddGenres.PerformLayout();
            panelAddGenres.ResumeLayout(false);
            panelAddGenres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanelAddGenres;
        private Panel panelAddGenres;
        private Button btnSaveGenres;
        private Button btnCancelGenres;
        private Label labelGenres;
        protected internal TextBox textBoxGenres;
        private ErrorProvider errorProvider;
    }
}