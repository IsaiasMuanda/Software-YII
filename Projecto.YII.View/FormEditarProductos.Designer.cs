namespace Projecto_YII.Projecto.YII.View
{
    partial class FormEditarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarProductos));
            panel1 = new Panel();
            pictureBoxFechar = new PictureBox();
            label11 = new Label();
            panel2 = new Panel();
            labelEditar_ID = new Label();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            labelDataEditar = new Label();
            label9 = new Label();
            comboBoxEditarFornecedor = new ComboBox();
            buttonCancelar = new Button();
            buttonGuardarEdicaoProducto = new Button();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            comboBoxEditarCategoria = new ComboBox();
            textBoxEditarDescricao = new TextBox();
            label6 = new Label();
            textBoxEditarMarcaProducto = new TextBox();
            label8 = new Label();
            label10 = new Label();
            textBoxEditarQuantidade = new TextBox();
            label7 = new Label();
            textBoxEditarPrecoProducto = new TextBox();
            textBoxEditarNomeProducto = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFechar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 205);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBoxFechar);
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1197, 66);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBoxFechar
            // 
            pictureBoxFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxFechar.Cursor = Cursors.Hand;
            pictureBoxFechar.Image = (Image)resources.GetObject("pictureBoxFechar.Image");
            pictureBoxFechar.Location = new Point(1159, 18);
            pictureBoxFechar.Name = "pictureBoxFechar";
            pictureBoxFechar.Size = new Size(25, 25);
            pictureBoxFechar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFechar.TabIndex = 45;
            pictureBoxFechar.TabStop = false;
            pictureBoxFechar.Click += pictureBoxFechar_Click;
            pictureBoxFechar.MouseEnter += pictureBoxFechar_MouseEnter;
            pictureBoxFechar.MouseLeave += pictureBoxFechar_MouseLeave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(467, 20);
            label11.Name = "label11";
            label11.Size = new Size(192, 23);
            label11.TabIndex = 0;
            label11.Text = "Editar Informações";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(labelEditar_ID);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(labelDataEditar);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(comboBoxEditarFornecedor);
            panel2.Controls.Add(buttonCancelar);
            panel2.Controls.Add(buttonGuardarEdicaoProducto);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(comboBoxEditarCategoria);
            panel2.Controls.Add(textBoxEditarDescricao);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBoxEditarMarcaProducto);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBoxEditarQuantidade);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBoxEditarPrecoProducto);
            panel2.Controls.Add(textBoxEditarNomeProducto);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(1197, 595);
            panel2.TabIndex = 1;
            // 
            // labelEditar_ID
            // 
            labelEditar_ID.AutoSize = true;
            labelEditar_ID.Location = new Point(1114, 88);
            labelEditar_ID.Name = "labelEditar_ID";
            labelEditar_ID.Size = new Size(59, 20);
            labelEditar_ID.TabIndex = 118;
            labelEditar_ID.Text = "----------";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(1048, 88);
            label12.Name = "label12";
            label12.Size = new Size(64, 20);
            label12.TabIndex = 117;
            label12.Text = "Código";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 264);
            pictureBox1.TabIndex = 116;
            pictureBox1.TabStop = false;
            // 
            // labelDataEditar
            // 
            labelDataEditar.AutoSize = true;
            labelDataEditar.Location = new Point(389, 375);
            labelDataEditar.Name = "labelDataEditar";
            labelDataEditar.Size = new Size(29, 20);
            labelDataEditar.TabIndex = 115;
            labelDataEditar.Text = "----";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(389, 159);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 114;
            label9.Text = "*Fornecedor";
            // 
            // comboBoxEditarFornecedor
            // 
            comboBoxEditarFornecedor.BackColor = SystemColors.Control;
            comboBoxEditarFornecedor.FormattingEnabled = true;
            comboBoxEditarFornecedor.Location = new Point(389, 195);
            comboBoxEditarFornecedor.Name = "comboBoxEditarFornecedor";
            comboBoxEditarFornecedor.Size = new Size(221, 28);
            comboBoxEditarFornecedor.TabIndex = 113;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(0, 122, 205);
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(940, 455);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(233, 34);
            buttonCancelar.TabIndex = 112;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonGuardarEdicaoProducto
            // 
            buttonGuardarEdicaoProducto.BackColor = Color.FromArgb(0, 122, 205);
            buttonGuardarEdicaoProducto.Cursor = Cursors.Hand;
            buttonGuardarEdicaoProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            buttonGuardarEdicaoProducto.FlatStyle = FlatStyle.Flat;
            buttonGuardarEdicaoProducto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGuardarEdicaoProducto.ForeColor = Color.White;
            buttonGuardarEdicaoProducto.Location = new Point(704, 455);
            buttonGuardarEdicaoProducto.Name = "buttonGuardarEdicaoProducto";
            buttonGuardarEdicaoProducto.Size = new Size(233, 34);
            buttonGuardarEdicaoProducto.TabIndex = 111;
            buttonGuardarEdicaoProducto.Text = "Confirmar";
            buttonGuardarEdicaoProducto.UseVisualStyleBackColor = false;
            buttonGuardarEdicaoProducto.Click += buttonGuardarEdicaoProducto_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(389, 430);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 110;
            label2.Text = "Quantidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(448, 252);
            label4.Name = "label4";
            label4.Size = new Size(30, 20);
            label4.TabIndex = 109;
            label4.Text = "Kzs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(389, 252);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 108;
            label3.Text = "Preço";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(389, 88);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 107;
            label5.Text = "Categoria";
            // 
            // comboBoxEditarCategoria
            // 
            comboBoxEditarCategoria.BackColor = SystemColors.Control;
            comboBoxEditarCategoria.FormattingEnabled = true;
            comboBoxEditarCategoria.Location = new Point(389, 124);
            comboBoxEditarCategoria.Name = "comboBoxEditarCategoria";
            comboBoxEditarCategoria.Size = new Size(221, 28);
            comboBoxEditarCategoria.TabIndex = 106;
            // 
            // textBoxEditarDescricao
            // 
            textBoxEditarDescricao.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditarDescricao.Location = new Point(704, 283);
            textBoxEditarDescricao.Multiline = true;
            textBoxEditarDescricao.Name = "textBoxEditarDescricao";
            textBoxEditarDescricao.Size = new Size(469, 112);
            textBoxEditarDescricao.TabIndex = 105;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(704, 243);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 104;
            label6.Text = "*Descrição";
            // 
            // textBoxEditarMarcaProducto
            // 
            textBoxEditarMarcaProducto.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditarMarcaProducto.Location = new Point(704, 195);
            textBoxEditarMarcaProducto.Name = "textBoxEditarMarcaProducto";
            textBoxEditarMarcaProducto.Size = new Size(469, 26);
            textBoxEditarMarcaProducto.TabIndex = 103;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(704, 167);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 102;
            label8.Text = "*Marca";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(704, 88);
            label10.Name = "label10";
            label10.Size = new Size(150, 20);
            label10.TabIndex = 101;
            label10.Text = "Nome Do Producto";
            // 
            // textBoxEditarQuantidade
            // 
            textBoxEditarQuantidade.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditarQuantidade.Location = new Point(389, 453);
            textBoxEditarQuantidade.Name = "textBoxEditarQuantidade";
            textBoxEditarQuantidade.Size = new Size(221, 26);
            textBoxEditarQuantidade.TabIndex = 100;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(389, 328);
            label7.Name = "label7";
            label7.Size = new Size(141, 20);
            label7.TabIndex = 99;
            label7.Text = "Data De Validade";
            // 
            // textBoxEditarPrecoProducto
            // 
            textBoxEditarPrecoProducto.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditarPrecoProducto.Location = new Point(389, 280);
            textBoxEditarPrecoProducto.Name = "textBoxEditarPrecoProducto";
            textBoxEditarPrecoProducto.Size = new Size(221, 26);
            textBoxEditarPrecoProducto.TabIndex = 98;
            // 
            // textBoxEditarNomeProducto
            // 
            textBoxEditarNomeProducto.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditarNomeProducto.Location = new Point(704, 125);
            textBoxEditarNomeProducto.Name = "textBoxEditarNomeProducto";
            textBoxEditarNomeProducto.Size = new Size(469, 26);
            textBoxEditarNomeProducto.TabIndex = 97;
            // 
            // FormEditarProductos
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 661);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditarProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditarProductos";
            Load += FormEditarProductos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFechar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        public Label labelDataEditar;
        private Label label9;
        public ComboBox comboBoxEditarFornecedor;
        private Button buttonCancelar;
        private Button buttonGuardarEdicaoProducto;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        public ComboBox comboBoxEditarCategoria;
        public TextBox textBoxEditarDescricao;
        private Label label6;
        public TextBox textBoxEditarMarcaProducto;
        private Label label8;
        private Label label10;
        public TextBox textBoxEditarQuantidade;
        private Label label7;
        public TextBox textBoxEditarPrecoProducto;
        public TextBox textBoxEditarNomeProducto;
        private Label label11;
        private PictureBox pictureBoxFechar;
        private PictureBox pictureBox1;
        public Label labelEditar_ID;
        private Label label12;
    }
}