namespace Projecto_YII.Projecto.YII.View
{
    partial class FormFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFornecedores));
            panel1 = new Panel();
            labelFornecedorID = new Label();
            label2 = new Label();
            textBoxEmailFornec = new TextBox();
            label3 = new Label();
            maskedTextBoxTelefoneFOrn = new MaskedTextBox();
            label1 = new Label();
            textBoxPesqForn = new TextBox();
            dataGridViewFornecedores = new DataGridView();
            textBoxEnderecoForn = new TextBox();
            textBoxNomeForn = new TextBox();
            buttonGuardarForn = new Button();
            buttonRemoverForn = new Button();
            buttonEditarForn = new Button();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label10 = new Label();
            pictureBoxActualizarDataGr = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFornecedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxActualizarDataGr).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBoxActualizarDataGr);
            panel1.Controls.Add(labelFornecedorID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxEmailFornec);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(maskedTextBoxTelefoneFOrn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxPesqForn);
            panel1.Controls.Add(dataGridViewFornecedores);
            panel1.Controls.Add(textBoxEnderecoForn);
            panel1.Controls.Add(textBoxNomeForn);
            panel1.Controls.Add(buttonGuardarForn);
            panel1.Controls.Add(buttonRemoverForn);
            panel1.Controls.Add(buttonEditarForn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1178, 860);
            panel1.TabIndex = 0;
            // 
            // labelFornecedorID
            // 
            labelFornecedorID.AutoSize = true;
            labelFornecedorID.Location = new Point(296, 290);
            labelFornecedorID.Name = "labelFornecedorID";
            labelFornecedorID.Size = new Size(59, 20);
            labelFornecedorID.TabIndex = 188;
            labelFornecedorID.Text = "----------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 291);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 187;
            label2.Text = "ID";
            // 
            // textBoxEmailFornec
            // 
            textBoxEmailFornec.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmailFornec.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmailFornec.Location = new Point(209, 218);
            textBoxEmailFornec.Name = "textBoxEmailFornec";
            textBoxEmailFornec.Size = new Size(272, 26);
            textBoxEmailFornec.TabIndex = 186;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 178);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 185;
            label3.Text = "Telefone";
            // 
            // maskedTextBoxTelefoneFOrn
            // 
            maskedTextBoxTelefoneFOrn.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxTelefoneFOrn.Location = new Point(12, 218);
            maskedTextBoxTelefoneFOrn.Mask = "(+244) 000-000-000";
            maskedTextBoxTelefoneFOrn.Name = "maskedTextBoxTelefoneFOrn";
            maskedTextBoxTelefoneFOrn.Size = new Size(135, 26);
            maskedTextBoxTelefoneFOrn.TabIndex = 184;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(209, 178);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 182;
            label1.Text = "Email";
            // 
            // textBoxPesqForn
            // 
            textBoxPesqForn.BorderStyle = BorderStyle.FixedSingle;
            textBoxPesqForn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPesqForn.Location = new Point(12, 342);
            textBoxPesqForn.Name = "textBoxPesqForn";
            textBoxPesqForn.Size = new Size(963, 26);
            textBoxPesqForn.TabIndex = 181;
            textBoxPesqForn.KeyPress += textBoxPesqForn_KeyPress;
            // 
            // dataGridViewFornecedores
            // 
            dataGridViewFornecedores.BackgroundColor = Color.White;
            dataGridViewFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFornecedores.Location = new Point(12, 396);
            dataGridViewFornecedores.Name = "dataGridViewFornecedores";
            dataGridViewFornecedores.RowHeadersWidth = 51;
            dataGridViewFornecedores.RowTemplate.Height = 29;
            dataGridViewFornecedores.Size = new Size(963, 415);
            dataGridViewFornecedores.TabIndex = 180;
            // 
            // textBoxEnderecoForn
            // 
            textBoxEnderecoForn.BorderStyle = BorderStyle.FixedSingle;
            textBoxEnderecoForn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEnderecoForn.Location = new Point(12, 130);
            textBoxEnderecoForn.Name = "textBoxEnderecoForn";
            textBoxEnderecoForn.Size = new Size(469, 26);
            textBoxEnderecoForn.TabIndex = 179;
            // 
            // textBoxNomeForn
            // 
            textBoxNomeForn.BorderStyle = BorderStyle.FixedSingle;
            textBoxNomeForn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNomeForn.Location = new Point(12, 46);
            textBoxNomeForn.Name = "textBoxNomeForn";
            textBoxNomeForn.Size = new Size(469, 26);
            textBoxNomeForn.TabIndex = 178;
            // 
            // buttonGuardarForn
            // 
            buttonGuardarForn.BackColor = Color.FromArgb(45, 45, 48);
            buttonGuardarForn.FlatAppearance.BorderColor = Color.Gray;
            buttonGuardarForn.FlatAppearance.MouseDownBackColor = Color.White;
            buttonGuardarForn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonGuardarForn.FlatStyle = FlatStyle.Flat;
            buttonGuardarForn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGuardarForn.ForeColor = Color.White;
            buttonGuardarForn.ImageAlign = ContentAlignment.MiddleLeft;
            buttonGuardarForn.Location = new Point(12, 291);
            buttonGuardarForn.Name = "buttonGuardarForn";
            buttonGuardarForn.Size = new Size(193, 31);
            buttonGuardarForn.TabIndex = 177;
            buttonGuardarForn.Text = "Guardar";
            buttonGuardarForn.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGuardarForn.UseVisualStyleBackColor = false;
            buttonGuardarForn.Click += buttonGuardarForn_Click;
            // 
            // buttonRemoverForn
            // 
            buttonRemoverForn.BackColor = Color.FromArgb(45, 45, 48);
            buttonRemoverForn.FlatAppearance.BorderColor = Color.Gray;
            buttonRemoverForn.FlatAppearance.MouseDownBackColor = Color.White;
            buttonRemoverForn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonRemoverForn.FlatStyle = FlatStyle.Flat;
            buttonRemoverForn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRemoverForn.ForeColor = Color.White;
            buttonRemoverForn.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRemoverForn.Location = new Point(259, 817);
            buttonRemoverForn.Name = "buttonRemoverForn";
            buttonRemoverForn.Size = new Size(219, 31);
            buttonRemoverForn.TabIndex = 176;
            buttonRemoverForn.Text = "Remover";
            buttonRemoverForn.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRemoverForn.UseVisualStyleBackColor = false;
            buttonRemoverForn.Click += buttonRemoverForn_Click;
            // 
            // buttonEditarForn
            // 
            buttonEditarForn.BackColor = Color.FromArgb(45, 45, 48);
            buttonEditarForn.FlatAppearance.BorderColor = Color.Gray;
            buttonEditarForn.FlatAppearance.MouseDownBackColor = Color.White;
            buttonEditarForn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonEditarForn.FlatStyle = FlatStyle.Flat;
            buttonEditarForn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditarForn.ForeColor = Color.White;
            buttonEditarForn.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditarForn.Location = new Point(12, 817);
            buttonEditarForn.Name = "buttonEditarForn";
            buttonEditarForn.Size = new Size(219, 31);
            buttonEditarForn.TabIndex = 175;
            buttonEditarForn.Text = "Editar";
            buttonEditarForn.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEditarForn.UseVisualStyleBackColor = false;
            buttonEditarForn.Click += buttonEditarForn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(582, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 258);
            pictureBox1.TabIndex = 173;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 93);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 172;
            label8.Text = "Endereço";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 14);
            label10.Name = "label10";
            label10.Size = new Size(168, 20);
            label10.TabIndex = 171;
            label10.Text = "Nome Do Fornecedor";
            // 
            // pictureBoxActualizarDataGr
            // 
            pictureBoxActualizarDataGr.Cursor = Cursors.Hand;
            pictureBoxActualizarDataGr.Image = (Image)resources.GetObject("pictureBoxActualizarDataGr.Image");
            pictureBoxActualizarDataGr.Location = new Point(981, 785);
            pictureBoxActualizarDataGr.Name = "pictureBoxActualizarDataGr";
            pictureBoxActualizarDataGr.Size = new Size(27, 26);
            pictureBoxActualizarDataGr.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxActualizarDataGr.TabIndex = 203;
            pictureBoxActualizarDataGr.TabStop = false;
            pictureBoxActualizarDataGr.Click += pictureBoxActualizarDataGr_Click;
            // 
            // FormFornecedores
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 860);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFornecedores";
            Text = "FormFornecedores";
            Load += FormFornecedores_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFornecedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxActualizarDataGr).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxEmailFornec;
        private Label label3;
        private MaskedTextBox maskedTextBoxTelefoneFOrn;
        private Label label1;
        private TextBox textBoxPesqForn;
        private DataGridView dataGridViewFornecedores;
        private TextBox textBoxEnderecoForn;
        private TextBox textBoxNomeForn;
        private Button buttonGuardarForn;
        private Button buttonRemoverForn;
        private Button buttonEditarForn;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label10;
        public Label labelFornecedorID;
        private Label label2;
        private PictureBox pictureBoxActualizarDataGr;
    }
}