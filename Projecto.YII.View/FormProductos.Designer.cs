namespace Projecto_YII.Projecto.YII.View
{
    partial class FormProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            textBoxPesquisarProducto = new TextBox();
            dataGridViewProductos = new DataGridView();
            label1 = new Label();
            buttonEditarProducto = new Button();
            buttonAdicionarProducto = new Button();
            buttonRemoverProducto = new Button();
            pictureBoxActualizarDataGr = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxActualizarDataGr).BeginInit();
            SuspendLayout();
            // 
            // textBoxPesquisarProducto
            // 
            textBoxPesquisarProducto.BorderStyle = BorderStyle.FixedSingle;
            textBoxPesquisarProducto.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPesquisarProducto.Location = new Point(45, 49);
            textBoxPesquisarProducto.Name = "textBoxPesquisarProducto";
            textBoxPesquisarProducto.Size = new Size(1240, 28);
            textBoxPesquisarProducto.TabIndex = 0;
            textBoxPesquisarProducto.TextChanged += textBoxPesquisarProducto_TextChanged;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.BackgroundColor = Color.White;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(45, 103);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.RowTemplate.Height = 29;
            dataGridViewProductos.Size = new Size(1240, 709);
            dataGridViewProductos.TabIndex = 116;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(45, 45, 48);
            label1.Location = new Point(485, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 117;
            label1.Text = "Productos";
            // 
            // buttonEditarProducto
            // 
            buttonEditarProducto.BackColor = Color.FromArgb(45, 45, 48);
            buttonEditarProducto.FlatAppearance.BorderColor = Color.Gray;
            buttonEditarProducto.FlatAppearance.MouseDownBackColor = Color.White;
            buttonEditarProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonEditarProducto.FlatStyle = FlatStyle.Flat;
            buttonEditarProducto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditarProducto.ForeColor = Color.White;
            buttonEditarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditarProducto.Location = new Point(293, 818);
            buttonEditarProducto.Name = "buttonEditarProducto";
            buttonEditarProducto.Size = new Size(219, 31);
            buttonEditarProducto.TabIndex = 120;
            buttonEditarProducto.Text = "Editar";
            buttonEditarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEditarProducto.UseVisualStyleBackColor = false;
            buttonEditarProducto.Click += buttonEditarProducto_Click;
            // 
            // buttonAdicionarProducto
            // 
            buttonAdicionarProducto.BackColor = Color.FromArgb(45, 45, 48);
            buttonAdicionarProducto.FlatAppearance.BorderColor = Color.Gray;
            buttonAdicionarProducto.FlatAppearance.MouseDownBackColor = Color.White;
            buttonAdicionarProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonAdicionarProducto.FlatStyle = FlatStyle.Flat;
            buttonAdicionarProducto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdicionarProducto.ForeColor = Color.White;
            buttonAdicionarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdicionarProducto.Location = new Point(44, 818);
            buttonAdicionarProducto.Name = "buttonAdicionarProducto";
            buttonAdicionarProducto.Size = new Size(219, 31);
            buttonAdicionarProducto.TabIndex = 121;
            buttonAdicionarProducto.Text = "Adicionar";
            buttonAdicionarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAdicionarProducto.UseVisualStyleBackColor = false;
            buttonAdicionarProducto.Click += buttonAdicionarProducto_Click;
            // 
            // buttonRemoverProducto
            // 
            buttonRemoverProducto.BackColor = Color.FromArgb(45, 45, 48);
            buttonRemoverProducto.FlatAppearance.BorderColor = Color.Gray;
            buttonRemoverProducto.FlatAppearance.MouseDownBackColor = Color.White;
            buttonRemoverProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonRemoverProducto.FlatStyle = FlatStyle.Flat;
            buttonRemoverProducto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRemoverProducto.ForeColor = Color.White;
            buttonRemoverProducto.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRemoverProducto.Location = new Point(540, 818);
            buttonRemoverProducto.Name = "buttonRemoverProducto";
            buttonRemoverProducto.Size = new Size(219, 31);
            buttonRemoverProducto.TabIndex = 122;
            buttonRemoverProducto.Text = "Remover";
            buttonRemoverProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRemoverProducto.UseVisualStyleBackColor = false;
            buttonRemoverProducto.Click += buttonRemoverProducto_Click;
            // 
            // pictureBoxActualizarDataGr
            // 
            pictureBoxActualizarDataGr.Cursor = Cursors.Hand;
            pictureBoxActualizarDataGr.Image = (Image)resources.GetObject("pictureBoxActualizarDataGr.Image");
            pictureBoxActualizarDataGr.Location = new Point(777, 823);
            pictureBoxActualizarDataGr.Name = "pictureBoxActualizarDataGr";
            pictureBoxActualizarDataGr.Size = new Size(27, 26);
            pictureBoxActualizarDataGr.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxActualizarDataGr.TabIndex = 203;
            pictureBoxActualizarDataGr.TabStop = false;
            pictureBoxActualizarDataGr.Click += pictureBoxActualizarDataGr_Click;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1341, 861);
            Controls.Add(pictureBoxActualizarDataGr);
            Controls.Add(buttonRemoverProducto);
            Controls.Add(buttonAdicionarProducto);
            Controls.Add(buttonEditarProducto);
            Controls.Add(label1);
            Controls.Add(dataGridViewProductos);
            Controls.Add(textBoxPesquisarProducto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProductos";
            Text = "FormProductos";
            Load += FormProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxActualizarDataGr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPesquisarProducto;
        private DataGridView dataGridViewProductos;
        private Label label1;
        private Button buttonAdicionarProducto;
        private PictureBox pictureBoxActualizarDataGr;
        public Button buttonEditarProducto;
        public Button buttonRemoverProducto;
    }
}