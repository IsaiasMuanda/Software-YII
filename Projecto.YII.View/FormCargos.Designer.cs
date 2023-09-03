namespace Projecto_YII.Projecto.YII.View
{
    partial class FormCargos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargos));
            tabControlCargo = new TabControl();
            tabPage1 = new TabPage();
            textBoxPesquisarCargo = new TextBox();
            dataGridViewCargo = new DataGridView();
            tabPage2 = new TabPage();
            pictureBoxLimpar = new PictureBox();
            buttonRemoverCargo = new Button();
            labelCodigoCargo = new Label();
            label3 = new Label();
            buttonEditarCargo = new Button();
            buttonGuardar = new Button();
            label1 = new Label();
            textBoxCargo = new TextBox();
            tabControlCargo.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCargo).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLimpar).BeginInit();
            SuspendLayout();
            // 
            // tabControlCargo
            // 
            tabControlCargo.Controls.Add(tabPage1);
            tabControlCargo.Controls.Add(tabPage2);
            tabControlCargo.Location = new Point(38, 3);
            tabControlCargo.Name = "tabControlCargo";
            tabControlCargo.SelectedIndex = 0;
            tabControlCargo.Size = new Size(1026, 642);
            tabControlCargo.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(textBoxPesquisarCargo);
            tabPage1.Controls.Add(dataGridViewCargo);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1018, 609);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cargos Registrados";
            // 
            // textBoxPesquisarCargo
            // 
            textBoxPesquisarCargo.BorderStyle = BorderStyle.FixedSingle;
            textBoxPesquisarCargo.Location = new Point(17, 79);
            textBoxPesquisarCargo.Name = "textBoxPesquisarCargo";
            textBoxPesquisarCargo.Size = new Size(658, 26);
            textBoxPesquisarCargo.TabIndex = 3;
            textBoxPesquisarCargo.KeyPress += textBoxPesquisarCargo_KeyPress;
            // 
            // dataGridViewCargo
            // 
            dataGridViewCargo.BackgroundColor = Color.White;
            dataGridViewCargo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCargo.Location = new Point(17, 120);
            dataGridViewCargo.Name = "dataGridViewCargo";
            dataGridViewCargo.RowHeadersWidth = 51;
            dataGridViewCargo.RowTemplate.Height = 29;
            dataGridViewCargo.Size = new Size(658, 372);
            dataGridViewCargo.TabIndex = 2;
            dataGridViewCargo.CellClick += dataGridViewCargo_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(pictureBoxLimpar);
            tabPage2.Controls.Add(buttonRemoverCargo);
            tabPage2.Controls.Add(labelCodigoCargo);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(buttonEditarCargo);
            tabPage2.Controls.Add(buttonGuardar);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(textBoxCargo);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1018, 609);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Operações";
            // 
            // pictureBoxLimpar
            // 
            pictureBoxLimpar.Cursor = Cursors.Hand;
            pictureBoxLimpar.Image = (Image)resources.GetObject("pictureBoxLimpar.Image");
            pictureBoxLimpar.Location = new Point(843, 228);
            pictureBoxLimpar.Name = "pictureBoxLimpar";
            pictureBoxLimpar.Size = new Size(27, 26);
            pictureBoxLimpar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLimpar.TabIndex = 204;
            pictureBoxLimpar.TabStop = false;
            pictureBoxLimpar.Click += pictureBoxLimpar_Click;
            // 
            // buttonRemoverCargo
            // 
            buttonRemoverCargo.BackColor = Color.FromArgb(45, 45, 48);
            buttonRemoverCargo.FlatAppearance.BorderColor = Color.Gray;
            buttonRemoverCargo.FlatAppearance.MouseDownBackColor = Color.White;
            buttonRemoverCargo.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonRemoverCargo.FlatStyle = FlatStyle.Flat;
            buttonRemoverCargo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRemoverCargo.ForeColor = Color.White;
            buttonRemoverCargo.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRemoverCargo.Location = new Point(652, 383);
            buttonRemoverCargo.Name = "buttonRemoverCargo";
            buttonRemoverCargo.Size = new Size(180, 31);
            buttonRemoverCargo.TabIndex = 203;
            buttonRemoverCargo.Text = "Remover";
            buttonRemoverCargo.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRemoverCargo.UseVisualStyleBackColor = false;
            buttonRemoverCargo.Click += buttonRemoverCargo_Click;
            // 
            // labelCodigoCargo
            // 
            labelCodigoCargo.AutoSize = true;
            labelCodigoCargo.ForeColor = Color.Green;
            labelCodigoCargo.Location = new Point(257, 296);
            labelCodigoCargo.Name = "labelCodigoCargo";
            labelCodigoCargo.Size = new Size(59, 20);
            labelCodigoCargo.TabIndex = 202;
            labelCodigoCargo.Text = "----------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(179, 296);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 201;
            label3.Text = "Código";
            // 
            // buttonEditarCargo
            // 
            buttonEditarCargo.BackColor = Color.FromArgb(45, 45, 48);
            buttonEditarCargo.FlatAppearance.BorderColor = Color.Gray;
            buttonEditarCargo.FlatAppearance.MouseDownBackColor = Color.White;
            buttonEditarCargo.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonEditarCargo.FlatStyle = FlatStyle.Flat;
            buttonEditarCargo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditarCargo.ForeColor = Color.White;
            buttonEditarCargo.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditarCargo.Location = new Point(410, 383);
            buttonEditarCargo.Name = "buttonEditarCargo";
            buttonEditarCargo.Size = new Size(180, 31);
            buttonEditarCargo.TabIndex = 200;
            buttonEditarCargo.Text = "Actualizar";
            buttonEditarCargo.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEditarCargo.UseVisualStyleBackColor = false;
            buttonEditarCargo.Click += buttonEditarCargo_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.FromArgb(45, 45, 48);
            buttonGuardar.FlatAppearance.BorderColor = Color.Gray;
            buttonGuardar.FlatAppearance.MouseDownBackColor = Color.White;
            buttonGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGuardar.ForeColor = Color.White;
            buttonGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonGuardar.Location = new Point(179, 383);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(180, 31);
            buttonGuardar.TabIndex = 199;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(179, 191);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 198;
            label1.Text = "Tipo De Cargo";
            // 
            // textBoxCargo
            // 
            textBoxCargo.BorderStyle = BorderStyle.FixedSingle;
            textBoxCargo.Location = new Point(179, 228);
            textBoxCargo.Name = "textBoxCargo";
            textBoxCargo.Size = new Size(658, 26);
            textBoxCargo.TabIndex = 197;
            // 
            // FormCargos
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1172, 693);
            Controls.Add(tabControlCargo);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCargos";
            Text = "FormCargos";
            Load += FormCargos_Load;
            tabControlCargo.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCargo).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLimpar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlCargo;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button buttonRemoverCargo;
        private Label labelCodigoCargo;
        private Label label3;
        private Button buttonEditarCargo;
        private Button buttonGuardar;
        private Label label1;
        private TextBox textBoxCargo;
        private TextBox textBoxPesquisarCargo;
        private DataGridView dataGridViewCargo;
        private TabControl tabControlCategoria;
        private Button buttonRemoverCat;
        private Button buttonEditarCat;
        private Label label2;
        private TextBox textBoxDescricao;
        private PictureBox pictureBoxLimpar;
    }
}