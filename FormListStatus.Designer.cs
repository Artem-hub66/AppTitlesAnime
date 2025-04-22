
using AppTitlesAnime.Models;

namespace AppTitlesAnime
{
    partial class FormListStatus
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
            flowLayoutPanelStatusTop = new FlowLayoutPanel();
            btnAddStatus = new Button();
            btnUpdateStatus = new Button();
            btnDeleteStatus = new Button();
            panelStatusFill = new Panel();
            dataGridViewStatus = new DataGridView();
            flowLayoutPanelStatusTop.SuspendLayout();
            panelStatusFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatus).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelStatusTop
            // 
            flowLayoutPanelStatusTop.BackColor = Color.Silver;
            flowLayoutPanelStatusTop.Controls.Add(btnAddStatus);
            flowLayoutPanelStatusTop.Controls.Add(btnUpdateStatus);
            flowLayoutPanelStatusTop.Controls.Add(btnDeleteStatus);
            flowLayoutPanelStatusTop.Dock = DockStyle.Top;
            flowLayoutPanelStatusTop.Location = new Point(0, 0);
            flowLayoutPanelStatusTop.Name = "flowLayoutPanelStatusTop";
            flowLayoutPanelStatusTop.Padding = new Padding(10);
            flowLayoutPanelStatusTop.Size = new Size(850, 57);
            flowLayoutPanelStatusTop.TabIndex = 0;
            // 
            // btnAddStatus
            // 
            btnAddStatus.AutoSize = true;
            btnAddStatus.Location = new Point(13, 13);
            btnAddStatus.Name = "btnAddStatus";
            btnAddStatus.Size = new Size(106, 35);
            btnAddStatus.TabIndex = 0;
            btnAddStatus.Text = "Добавить";
            btnAddStatus.UseVisualStyleBackColor = true;
            btnAddStatus.Click += BtnAddStatus_Click;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.AutoSize = true;
            btnUpdateStatus.Location = new Point(125, 13);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(151, 35);
            btnUpdateStatus.TabIndex = 1;
            btnUpdateStatus.Text = "Редактировать";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += BtnUpdateStatus_Click;
            // 
            // btnDeleteStatus
            // 
            btnDeleteStatus.AutoSize = true;
            btnDeleteStatus.Location = new Point(282, 13);
            btnDeleteStatus.Name = "btnDeleteStatus";
            btnDeleteStatus.Size = new Size(92, 35);
            btnDeleteStatus.TabIndex = 2;
            btnDeleteStatus.Text = "Удалить";
            btnDeleteStatus.UseVisualStyleBackColor = true;
            btnDeleteStatus.Click += BtnDeleteStatus_Click;
            // 
            // panelStatusFill
            // 
            panelStatusFill.Controls.Add(dataGridViewStatus);
            panelStatusFill.Dock = DockStyle.Fill;
            panelStatusFill.Location = new Point(0, 57);
            panelStatusFill.Name = "panelStatusFill";
            panelStatusFill.Padding = new Padding(10);
            panelStatusFill.Size = new Size(850, 399);
            panelStatusFill.TabIndex = 1;
            // 
            // dataGridViewStatus
            // 
            dataGridViewStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStatus.BackgroundColor = Color.White;
            dataGridViewStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStatus.Dock = DockStyle.Fill;
            dataGridViewStatus.Location = new Point(10, 10);
            dataGridViewStatus.MultiSelect = false;
            dataGridViewStatus.Name = "dataGridViewStatus";
            dataGridViewStatus.ReadOnly = true;
            dataGridViewStatus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStatus.Size = new Size(830, 379);
            dataGridViewStatus.TabIndex = 0;
            // 
            // FormListStatus
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(850, 456);
            Controls.Add(panelStatusFill);
            Controls.Add(flowLayoutPanelStatusTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormListStatus";
            Text = "Список статусов";
            flowLayoutPanelStatusTop.ResumeLayout(false);
            flowLayoutPanelStatusTop.PerformLayout();
            panelStatusFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatus).EndInit();
            ResumeLayout(false);
        }

        private void BtnDeleteStatus_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (dataGridViewStatus.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект? \nВсе связанные данные будут удалены.",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.No)
                return;

            int index = dataGridViewStatus.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewStatus[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Status type = db.Statuses.Find(id);

            db.Statuses.Remove(type);
            db.SaveChanges();

            MessageBox.Show("Объект удалён.");

            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelStatusTop;
        private Button btnAddStatus;
        private Button btnUpdateStatus;
        private Button btnDeleteStatus;
        private Panel panelStatusFill;
        private DataGridView dataGridViewStatus;
    }
}