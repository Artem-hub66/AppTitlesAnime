namespace AppTitlesAnime
{
    partial class FormAddStatus
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
            flowLayoutPanelAddStatus = new FlowLayoutPanel();
            btnSaveStatus = new Button();
            btnCancelStatus = new Button();
            panelAddStatus = new Panel();
            textBoxStatus = new TextBox();
            labelStatus = new Label();
            flowLayoutPanelAddStatus.SuspendLayout();
            panelAddStatus.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelAddStatus
            // 
            flowLayoutPanelAddStatus.Controls.Add(btnSaveStatus);
            flowLayoutPanelAddStatus.Controls.Add(btnCancelStatus);
            flowLayoutPanelAddStatus.Dock = DockStyle.Bottom;
            flowLayoutPanelAddStatus.Location = new Point(0, 82);
            flowLayoutPanelAddStatus.Name = "flowLayoutPanelAddStatus";
            flowLayoutPanelAddStatus.Padding = new Padding(10);
            flowLayoutPanelAddStatus.Size = new Size(390, 63);
            flowLayoutPanelAddStatus.TabIndex = 1;
            // 
            // btnSaveStatus
            // 
            btnSaveStatus.AutoSize = true;
            btnSaveStatus.Location = new Point(13, 13);
            btnSaveStatus.Name = "btnSaveStatus";
            btnSaveStatus.Size = new Size(115, 35);
            btnSaveStatus.TabIndex = 0;
            btnSaveStatus.Text = "Сохранить";
            btnSaveStatus.UseVisualStyleBackColor = true;
            // 
            // btnCancelStatus
            // 
            btnCancelStatus.AutoSize = true;
            btnCancelStatus.Location = new Point(134, 13);
            btnCancelStatus.Name = "btnCancelStatus";
            btnCancelStatus.Size = new Size(88, 35);
            btnCancelStatus.TabIndex = 1;
            btnCancelStatus.Text = "Отмена";
            btnCancelStatus.UseVisualStyleBackColor = true;
            // 
            // panelAddStatus
            // 
            panelAddStatus.Controls.Add(textBoxStatus);
            panelAddStatus.Controls.Add(labelStatus);
            panelAddStatus.Dock = DockStyle.Fill;
            panelAddStatus.Location = new Point(0, 0);
            panelAddStatus.Name = "panelAddStatus";
            panelAddStatus.Padding = new Padding(10);
            panelAddStatus.Size = new Size(390, 82);
            panelAddStatus.TabIndex = 2;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Dock = DockStyle.Top;
            textBoxStatus.Location = new Point(10, 35);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(370, 33);
            textBoxStatus.TabIndex = 1;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Dock = DockStyle.Top;
            labelStatus.Location = new Point(10, 10);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(128, 25);
            labelStatus.TabIndex = 0;
            labelStatus.Text = "Статус аниме";
            // 
            // FormAddStatus
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(390, 145);
            Controls.Add(panelAddStatus);
            Controls.Add(flowLayoutPanelAddStatus);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAddStatus";
            Text = "Информация о статусе";
            flowLayoutPanelAddStatus.ResumeLayout(false);
            flowLayoutPanelAddStatus.PerformLayout();
            panelAddStatus.ResumeLayout(false);
            panelAddStatus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanelAddStatus;
        private Panel panelAddStatus;
        private Button btnSaveStatus;
        private Button btnCancelStatus;
        private Label labelStatus;
        private TextBox textBoxStatus;
    }
}