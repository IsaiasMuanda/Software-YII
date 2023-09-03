namespace Projecto_YII.Projecto.YII.View
{
    partial class FormCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoria));
            tabControlCategoria = new TabControl();
            tabPage1 = new TabPage();
            textBoxPesquisarCateg = new TextBox();
            dataGridViewCat = new DataGridView();
            tabPage2 = new TabPage();
            buttonRemoverCat = new Button();
            labelCodigoCat = new Label();
            label3 = new Label();
            buttonEditarCat = new Button();
            buttonGuardar = new Button();
            label2 = new Label();
            textBoxDescricao = new TextBox();
            label1 = new Label();
            textBoxCategoria = new TextBox();
            pictureBoxLimpar = new PictureBox();
            tabControlCategoria.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCat).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLimpar).BeginInit();
            SuspendLayout();
            // 
            // tabControlCategoria
            // 
            tabControlCategoria.Controls.Add(tabPage1);
            tabControlCategoria.Controls.Add(tabPage2);
            tabControlCategoria.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlCategoria.Location = new Point(29, 0);
            tabControlCategoria.Name = "tabControlCategoria";
            tabControlCategoria.SelectedIndex = 0;
            tabControlCategoria.Size = new Size(972, 604);
            tabControlCategoria.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(textBoxPesquisarCateg);
            tabPage1.Controls.Add(dataGridViewCat);
            tabPage1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(964, 571);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lista De Categorias";
            // 
            // textBoxPesquisarCateg
            // 
            textBoxPesquisarCateg.BorderStyle = BorderStyle.FixedSingle;
            textBoxPesquisarCateg.Location = new Point(8, 89);
            textBoxPesquisarCateg.Name = "textBoxPesquisarCateg";
            textBoxPesquisarCateg.Size = new Size(658, 26);
            textBoxPesquisarCateg.TabIndex = 1;
            textBoxPesquisarCateg.TextChanged += textBox1_TextChanged;
            // 
            // dataGridViewCat
            // 
            dataGridViewCat.BackgroundColor = Color.White;
            dataGridViewCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCat.Location = new Point(8, 130);
            dataGridViewCat.Name = "dataGridViewCat";
            dataGridViewCat.RowHeadersWidth = 51;
            dataGridViewCat.RowTemplate.Height = 29;
            dataGridViewCat.Size = new Size(658, 372);
            dataGridViewCat.TabIndex = 0;
            dataGridViewCat.CellClick += dataGridViewCat_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(pictureBoxLimpar);
            tabPage2.Controls.Add(buttonRemoverCat);
            tabPage2.Controls.Add(labelCodigoCat);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(buttonEditarCat);
            tabPage2.Controls.Add(buttonGuardar);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textBoxDescricao);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(textBoxCategoria);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(964, 571);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dados Cadastrais";
            // 
            // buttonRemoverCat
            // 
            buttonRemoverCat.BackColor = Color.FromArgb(45, 45, 48);
            buttonRemoverCat.FlatAppearance.BorderColor = Color.Gray;
            buttonRemoverCat.FlatAppearance.MouseDownBackColor = Color.White;
            buttonRemoverCat.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonRemoverCat.FlatStyle = FlatStyle.Flat;
            buttonRemoverCat.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRemoverCat.ForeColor = Color.White;
            buttonRemoverCat.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRemoverCat.Location = new Point(655, 481);
            buttonRemoverCat.Name = "buttonRemoverCat";
            buttonRemoverCat.Size = new Size(180, 31);
            buttonRemoverCat.TabIndex = 196;
            buttonRemoverCat.Text = "Remover";
            buttonRemoverCat.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRemoverCat.UseVisualStyleBackColor = false;
            buttonRemoverCat.Click += buttonRemoverCat_Click_1;
            // 
            // labelCodigoCat
            // 
            labelCodigoCat.AutoSize = true;
            labelCodigoCat.ForeColor = Color.Green;
            labelCodigoCat.Location = new Point(373, 227);
            labelCodigoCat.Name = "labelCodigoCat";
            labelCodigoCat.Size = new Size(59, 20);
            labelCodigoCat.TabIndex = 195;
            labelCodigoCat.Text = "----------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(295, 227);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 194;
            label3.Text = "Código";
            // 
            // buttonEditarCat
            // 
            buttonEditarCat.BackColor = Color.FromArgb(45, 45, 48);
            buttonEditarCat.FlatAppearance.BorderColor = Color.Gray;
            buttonEditarCat.FlatAppearance.MouseDownBackColor = Color.White;
            buttonEditarCat.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonEditarCat.FlatStyle = FlatStyle.Flat;
            buttonEditarCat.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditarCat.ForeColor = Color.White;
            buttonEditarCat.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditarCat.Location = new Point(413, 481);
            buttonEditarCat.Name = "buttonEditarCat";
            buttonEditarCat.Size = new Size(180, 31);
            buttonEditarCat.TabIndex = 193;
            buttonEditarCat.Text = "Actualizar";
            buttonEditarCat.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEditarCat.UseVisualStyleBackColor = false;
            buttonEditarCat.Click += buttonEditarCat_Click_1;
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
            buttonGuardar.Location = new Point(177, 481);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(180, 31);
            buttonGuardar.TabIndex = 192;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(177, 227);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 5;
            label2.Text = "Descrição";
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.BorderStyle = BorderStyle.FixedSingle;
            textBoxDescricao.Location = new Point(177, 263);
            textBoxDescricao.Multiline = true;
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(658, 196);
            textBoxDescricao.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(177, 115);
            label1.Name = "label1";
            label1.Size = new Size(164, 21);
            label1.TabIndex = 3;
            label1.Text = "Tipo De Categoria";
            // 
            // textBoxCategoria
            // 
            textBoxCategoria.BorderStyle = BorderStyle.FixedSingle;
            textBoxCategoria.Location = new Point(177, 152);
            textBoxCategoria.Name = "textBoxCategoria";
            textBoxCategoria.Size = new Size(658, 26);
            textBoxCategoria.TabIndex = 2;
            // 
            // pictureBoxLimpar
            // 
            pictureBoxLimpar.Cursor = Cursors.Hand;
            pictureBoxLimpar.Image = (Image)resources.GetObject("pictureBoxLimpar.Image");
            pictureBoxLimpar.Location = new Point(841, 433);
            pictureBoxLimpar.Name = "pictureBoxLimpar";
            pictureBoxLimpar.Size = new Size(27, 26);
            pictureBoxLimpar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLimpar.TabIndex = 203;
            pictureBoxLimpar.TabStop = false;
            pictureBoxLimpar.Click += pictureBoxLimpar_Click;
            // 
            // FormCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1032, 643);
            Controls.Add(tabControlCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCategoria";
            Text = "FormCategoria";
            Load += FormCategoria_Load;
            tabControlCategoria.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCat).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLimpar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlCategoria;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBoxPesquisarCateg;
        private DataGridView dataGridViewCat;
        private Label label2;
        private TextBox textBoxDescricao;
        private Label label1;
        private TextBox textBoxCategoria;
        private Button buttonEditarCat;
        private Button buttonGuardar;
        private Label labelCodigoCat;
        private Label label3;
        private Button buttonRemoverCat;
        private PictureBox pictureBoxLimpar;
    }
}