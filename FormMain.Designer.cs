namespace AppTitlesAnime
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnShowTypes = new Button();
            btnShowStatus = new Button();
            btnShowGenres = new Button();
            SuspendLayout();
            // 
            // btnShowTypes
            // 
            btnShowTypes.Location = new Point(12, 12);
            btnShowTypes.Name = "btnShowTypes";
            btnShowTypes.Size = new Size(319, 39);
            btnShowTypes.TabIndex = 0;
            btnShowTypes.Text = "Отобразить список \"Типы аниме\"";
            btnShowTypes.UseVisualStyleBackColor = true;
            btnShowTypes.Click += BtnShowTypes_Click;
            // 
            // btnShowStatus
            // 
            btnShowStatus.AutoSize = true;
            btnShowStatus.Location = new Point(337, 12);
            btnShowStatus.Name = "btnShowStatus";
            btnShowStatus.Size = new Size(338, 35);
            btnShowStatus.TabIndex = 1;
            btnShowStatus.Text = "Отоброзить список \"Статусы аниме\"";
            btnShowStatus.UseVisualStyleBackColor = true;
            btnShowStatus.Click += BtnShowStatus_Click;
            // 
            // btnShowGenres
            // 
            btnShowGenres.AutoSize = true;
            btnShowGenres.Location = new Point(681, 12);
            btnShowGenres.Name = "btnShowGenres";
            btnShowGenres.Size = new Size(261, 35);
            btnShowGenres.TabIndex = 2;
            btnShowGenres.Text = "Отобразить список жанров";
            btnShowGenres.UseVisualStyleBackColor = true;
            btnShowGenres.Click += BtnShowGenres_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1257, 750);
            Controls.Add(btnShowGenres);
            Controls.Add(btnShowStatus);
            Controls.Add(btnShowTypes);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormMain";
            Text = "Главная форма";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowTypes;
        private Button btnShowStatus;
        private Button btnShowGenres;
    }
}
