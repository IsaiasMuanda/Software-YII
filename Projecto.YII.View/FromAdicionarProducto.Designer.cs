namespace Projecto_YII.Projecto.YII.View
{
    partial class FromAdicionarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromAdicionarProducto));
            panel1 = new Panel();
            pictureBoxFechar = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            labelADD_CodProducto = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            comboBoxFornecedor = new ComboBox();
            buttonCancelarProducto = new Button();
            buttonGuardarProducto = new Button();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            comboBoxCategoria = new ComboBox();
            textBoxDescricaoProd = new TextBox();
            label6 = new Label();
            textBoxMarcaProducto = new TextBox();
            label8 = new Label();
            label10 = new Label();
            textBoxQuantidade = new TextBox();
            textBoxDataValidade = new TextBox();
            label7 = new Label();
            textBoxPrecoProducto = new TextBox();
            textBoxNomeProducto = new TextBox();
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
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1114, 53);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBoxFechar
            // 
            pictureBoxFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxFechar.Cursor = Cursors.Hand;
            pictureBoxFechar.Image = (Image)resources.GetObject("pictureBoxFechar.Image");
            pictureBoxFechar.Location = new Point(1076, 9);
            pictureBoxFechar.Name = "pictureBoxFechar";
            pictureBoxFechar.Size = new Size(25, 25);
            pictureBoxFechar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFechar.TabIndex = 44;
            pictureBoxFechar.TabStop = false;
            pictureBoxFechar.Click += pictureBoxFechar_Click;
            pictureBoxFechar.MouseEnter += pictureBoxFechar_MouseEnter;
            pictureBoxFechar.MouseLeave += pictureBoxFechar_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(458, 11);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(labelADD_CodProducto);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(comboBoxFornecedor);
            panel2.Controls.Add(buttonCancelarProducto);
            panel2.Controls.Add(buttonGuardarProducto);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(comboBoxCategoria);
            panel2.Controls.Add(textBoxDescricaoProd);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBoxMarcaProducto);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBoxQuantidade);
            panel2.Controls.Add(textBoxDataValidade);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBoxPrecoProducto);
            panel2.Controls.Add(textBoxNomeProducto);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(1114, 516);
            panel2.TabIndex = 1;
            // 
            // labelADD_CodProducto
            // 
            labelADD_CodProducto.AutoSize = true;
            labelADD_CodProducto.Location = new Point(888, 55);
            labelADD_CodProducto.Name = "labelADD_CodProducto";
            labelADD_CodProducto.Size = new Size(69, 20);
            labelADD_CodProducto.TabIndex = 79;
            labelADD_CodProducto.Text = "----------";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(824, 55);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 78;
            label11.Text = "Código";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._3521345_basket_cart_shop_shopping_icon_2;
            pictureBox1.Location = new Point(11, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 355);
            pictureBox1.TabIndex = 77;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(273, 126);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 76;
            label9.Text = "*Fornecedor";
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.BackColor = SystemColors.Control;
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(273, 162);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(221, 28);
            comboBoxFornecedor.TabIndex = 75;
            // 
            // buttonCancelarProducto
            // 
            buttonCancelarProducto.BackColor = Color.FromArgb(0, 122, 205);
            buttonCancelarProducto.Cursor = Cursors.Hand;
            buttonCancelarProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            buttonCancelarProducto.FlatStyle = FlatStyle.Flat;
            buttonCancelarProducto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelarProducto.ForeColor = Color.White;
            buttonCancelarProducto.Location = new Point(824, 422);
            buttonCancelarProducto.Name = "buttonCancelarProducto";
            buttonCancelarProducto.Size = new Size(233, 34);
            buttonCancelarProducto.TabIndex = 74;
            buttonCancelarProducto.Text = "Cancelar";
            buttonCancelarProducto.UseVisualStyleBackColor = false;
            buttonCancelarProducto.Click += buttonCancelarProducto_Click;
            // 
            // buttonGuardarProducto
            // 
            buttonGuardarProducto.BackColor = Color.FromArgb(0, 122, 205);
            buttonGuardarProducto.Cursor = Cursors.Hand;
            buttonGuardarProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            buttonGuardarProducto.FlatStyle = FlatStyle.Flat;
            buttonGuardarProducto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGuardarProducto.ForeColor = Color.White;
            buttonGuardarProducto.Location = new Point(588, 422);
            buttonGuardarProducto.Name = "buttonGuardarProducto";
            buttonGuardarProducto.Size = new Size(233, 34);
            buttonGuardarProducto.TabIndex = 73;
            buttonGuardarProducto.Text = "Guardar";
            buttonGuardarProducto.UseVisualStyleBackColor = false;
            buttonGuardarProducto.Click += buttonGuardarProducto_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(273, 397);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 72;
            label2.Text = "Quantidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(332, 219);
            label4.Name = "label4";
            label4.Size = new Size(30, 20);
            label4.TabIndex = 71;
            label4.Text = "Kzs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(273, 219);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 70;
            label3.Text = "Preço";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(273, 55);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 69;
            label5.Text = "Categoria";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.BackColor = SystemColors.Control;
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(273, 91);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(221, 28);
            comboBoxCategoria.TabIndex = 68;
            // 
            // textBoxDescricaoProd
            // 
            textBoxDescricaoProd.BorderStyle = BorderStyle.FixedSingle;
            textBoxDescricaoProd.Location = new Point(588, 250);
            textBoxDescricaoProd.Multiline = true;
            textBoxDescricaoProd.Name = "textBoxDescricaoProd";
            textBoxDescricaoProd.Size = new Size(469, 112);
            textBoxDescricaoProd.TabIndex = 67;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(588, 210);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 66;
            label6.Text = "*Descrição";
            // 
            // textBoxMarcaProducto
            // 
            textBoxMarcaProducto.BorderStyle = BorderStyle.FixedSingle;
            textBoxMarcaProducto.Location = new Point(588, 162);
            textBoxMarcaProducto.Name = "textBoxMarcaProducto";
            textBoxMarcaProducto.Size = new Size(469, 27);
            textBoxMarcaProducto.TabIndex = 65;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(588, 134);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 64;
            label8.Text = "*Marca";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(588, 55);
            label10.Name = "label10";
            label10.Size = new Size(150, 20);
            label10.TabIndex = 63;
            label10.Text = "Nome Do Producto";
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.BorderStyle = BorderStyle.FixedSingle;
            textBoxQuantidade.Location = new Point(273, 420);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(221, 27);
            textBoxQuantidade.TabIndex = 62;
            // 
            // textBoxDataValidade
            // 
            textBoxDataValidade.BorderStyle = BorderStyle.FixedSingle;
            textBoxDataValidade.Location = new Point(273, 335);
            textBoxDataValidade.Name = "textBoxDataValidade";
            textBoxDataValidade.Size = new Size(221, 27);
            textBoxDataValidade.TabIndex = 61;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(273, 295);
            label7.Name = "label7";
            label7.Size = new Size(141, 20);
            label7.TabIndex = 60;
            label7.Text = "Data De Validade";
            // 
            // textBoxPrecoProducto
            // 
            textBoxPrecoProducto.BorderStyle = BorderStyle.FixedSingle;
            textBoxPrecoProducto.Location = new Point(273, 247);
            textBoxPrecoProducto.Name = "textBoxPrecoProducto";
            textBoxPrecoProducto.Size = new Size(221, 27);
            textBoxPrecoProducto.TabIndex = 59;
            // 
            // textBoxNomeProducto
            // 
            textBoxNomeProducto.BorderStyle = BorderStyle.FixedSingle;
            textBoxNomeProducto.Location = new Point(588, 92);
            textBoxNomeProducto.Name = "textBoxNomeProducto";
            textBoxNomeProducto.Size = new Size(469, 27);
            textBoxNomeProducto.TabIndex = 58;
            // 
            // FromAdicionarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 569);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FromAdicionarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FromAdicionarProducto";
            Load += FromAdicionarProducto_Load;
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
        private Label label1;
        private Panel panel2;
        private Button buttonCancelarProducto;
        private Button buttonGuardarProducto;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        public ComboBox comboBoxCategoria;
        private Label label6;
        private TextBox textBoxMarcaProducto;
        private Label label8;
        private Label label10;
        private TextBox textBoxQuantidade;
        private TextBox textBoxDataValidade;
        private Label label7;
        private TextBox textBoxPrecoProducto;
        private TextBox textBoxNomeProducto;
        private Label label9;
        public ComboBox comboBoxFornecedor;
        private PictureBox pictureBoxFechar;
        private PictureBox pictureBox1;
        public Label labelADD_CodProducto;
        private Label label11;
        private TextBox textBoxDescricaoProd;
    }
}