namespace Projecto_YII.Projecto.YII.View
{
    partial class FormRelatorios
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
            label1 = new Label();
            dataGridViewRelatorios = new DataGridView();
            dateTimePickerInicio = new DateTimePicker();
            dateTimePickerFim = new DateTimePicker();
            label2 = new Label();
            buttonRelatorioConsultar = new Button();
            buttonDetalhes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRelatorios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 87);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 0;
            label1.Text = "Data De Início";
            // 
            // dataGridViewRelatorios
            // 
            dataGridViewRelatorios.BackgroundColor = Color.White;
            dataGridViewRelatorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRelatorios.Location = new Point(12, 225);
            dataGridViewRelatorios.Name = "dataGridViewRelatorios";
            dataGridViewRelatorios.RowHeadersWidth = 51;
            dataGridViewRelatorios.RowTemplate.Height = 29;
            dataGridViewRelatorios.Size = new Size(1273, 397);
            dataGridViewRelatorios.TabIndex = 1;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Format = DateTimePickerFormat.Short;
            dateTimePickerInicio.Location = new Point(166, 83);
            dateTimePickerInicio.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(250, 26);
            dateTimePickerInicio.TabIndex = 2;
            // 
            // dateTimePickerFim
            // 
            dateTimePickerFim.Format = DateTimePickerFormat.Short;
            dateTimePickerFim.Location = new Point(166, 157);
            dateTimePickerFim.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateTimePickerFim.Name = "dateTimePickerFim";
            dateTimePickerFim.Size = new Size(250, 26);
            dateTimePickerFim.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 162);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 3;
            label2.Text = "Data Final";
            // 
            // buttonRelatorioConsultar
            // 
            buttonRelatorioConsultar.BackColor = Color.FromArgb(45, 45, 48);
            buttonRelatorioConsultar.FlatAppearance.BorderColor = Color.Gray;
            buttonRelatorioConsultar.FlatAppearance.MouseDownBackColor = Color.White;
            buttonRelatorioConsultar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonRelatorioConsultar.FlatStyle = FlatStyle.Flat;
            buttonRelatorioConsultar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRelatorioConsultar.ForeColor = Color.White;
            buttonRelatorioConsultar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRelatorioConsultar.Location = new Point(448, 152);
            buttonRelatorioConsultar.Name = "buttonRelatorioConsultar";
            buttonRelatorioConsultar.Size = new Size(261, 31);
            buttonRelatorioConsultar.TabIndex = 193;
            buttonRelatorioConsultar.Text = "Consultar";
            buttonRelatorioConsultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRelatorioConsultar.UseVisualStyleBackColor = false;
            buttonRelatorioConsultar.Click += buttonRelatorioConsultar_Click;
            // 
            // buttonDetalhes
            // 
            buttonDetalhes.BackColor = Color.FromArgb(45, 45, 48);
            buttonDetalhes.FlatAppearance.BorderColor = Color.Gray;
            buttonDetalhes.FlatAppearance.MouseDownBackColor = Color.White;
            buttonDetalhes.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonDetalhes.FlatStyle = FlatStyle.Flat;
            buttonDetalhes.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDetalhes.ForeColor = Color.White;
            buttonDetalhes.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDetalhes.Location = new Point(12, 628);
            buttonDetalhes.Name = "buttonDetalhes";
            buttonDetalhes.Size = new Size(261, 31);
            buttonDetalhes.TabIndex = 194;
            buttonDetalhes.Text = "Detalhes";
            buttonDetalhes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDetalhes.UseVisualStyleBackColor = false;
            buttonDetalhes.Click += buttonDetalhes_Click;
            // 
            // FormRelatorios
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1478, 669);
            Controls.Add(buttonDetalhes);
            Controls.Add(buttonRelatorioConsultar);
            Controls.Add(dateTimePickerFim);
            Controls.Add(label2);
            Controls.Add(dateTimePickerInicio);
            Controls.Add(dataGridViewRelatorios);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRelatorios";
            Text = "FormRelatorios";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRelatorios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePickerInicio;
        private DateTimePicker dateTimePickerFim;
        private Label label2;
        private Button buttonRelatorioConsultar;
        private Button buttonDetalhes;
        public DataGridView dataGridViewRelatorios;
    }
}