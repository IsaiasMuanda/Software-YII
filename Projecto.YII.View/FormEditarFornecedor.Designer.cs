namespace Projecto_YII.Projecto.YII.View
{
    partial class FormEditarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarFornecedor));
            panel1 = new Panel();
            pictureBoxFecharFrn = new PictureBox();
            label11 = new Label();
            panel2 = new Panel();
            labelEditarFornecedorID = new Label();
            label4 = new Label();
            label3 = new Label();
            textBoxEditarEmailFOrn = new TextBox();
            pictureBox2 = new PictureBox();
            buttonCancelar = new Button();
            buttonGuardarEdicaoForn = new Button();
            label2 = new Label();
            maskedTextBoxEditarTelefoneForn = new MaskedTextBox();
            textBoxEditarEnderecoForn = new TextBox();
            label1 = new Label();
            label10 = new Label();
            textBoxEditarNomeForn = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFecharFrn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 205);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBoxFecharFrn);
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 68);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBoxFecharFrn
            // 
            pictureBoxFecharFrn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxFecharFrn.BackgroundImageLayout = ImageLayout.None;
            pictureBoxFecharFrn.Cursor = Cursors.Hand;
            pictureBoxFecharFrn.Image = (Image)resources.GetObject("pictureBoxFecharFrn.Image");
            pictureBoxFecharFrn.Location = new Point(981, 20);
            pictureBoxFecharFrn.Name = "pictureBoxFecharFrn";
            pictureBoxFecharFrn.Size = new Size(25, 25);
            pictureBoxFecharFrn.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFecharFrn.TabIndex = 48;
            pictureBoxFecharFrn.TabStop = false;
            pictureBoxFecharFrn.Click += pictureBoxFecharCL_Click;
            pictureBoxFecharFrn.MouseEnter += pictureBoxFecharFrn_MouseEnter;
            pictureBoxFecharFrn.MouseLeave += pictureBoxFecharFrn_MouseLeave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(412, 22);
            label11.Name = "label11";
            label11.Size = new Size(192, 23);
            label11.TabIndex = 1;
            label11.Text = "Editar Informações";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(labelEditarFornecedorID);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBoxEditarEmailFOrn);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(buttonCancelar);
            panel2.Controls.Add(buttonGuardarEdicaoForn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(maskedTextBoxEditarTelefoneForn);
            panel2.Controls.Add(textBoxEditarEnderecoForn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBoxEditarNomeForn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(1019, 457);
            panel2.TabIndex = 1;
            // 
            // labelEditarFornecedorID
            // 
            labelEditarFornecedorID.AutoSize = true;
            labelEditarFornecedorID.Location = new Point(914, 261);
            labelEditarFornecedorID.Name = "labelEditarFornecedorID";
            labelEditarFornecedorID.Size = new Size(69, 20);
            labelEditarFornecedorID.TabIndex = 190;
            labelEditarFornecedorID.Text = "----------";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(867, 262);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 189;
            label4.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(545, 222);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 184;
            label3.Text = "Email";
            // 
            // textBoxEditarEmailFOrn
            // 
            textBoxEditarEmailFOrn.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditarEmailFOrn.Location = new Point(545, 261);
            textBoxEditarEmailFOrn.Name = "textBoxEditarEmailFOrn";
            textBoxEditarEmailFOrn.Size = new Size(299, 27);
            textBoxEditarEmailFOrn.TabIndex = 183;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(45, 70);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(284, 264);
            pictureBox2.TabIndex = 182;
            pictureBox2.TabStop = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(0, 122, 205);
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(611, 335);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(233, 34);
            buttonCancelar.TabIndex = 181;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonGuardarEdicaoForn
            // 
            buttonGuardarEdicaoForn.BackColor = Color.FromArgb(0, 122, 205);
            buttonGuardarEdicaoForn.Cursor = Cursors.Hand;
            buttonGuardarEdicaoForn.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            buttonGuardarEdicaoForn.FlatStyle = FlatStyle.Flat;
            buttonGuardarEdicaoForn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGuardarEdicaoForn.ForeColor = Color.White;
            buttonGuardarEdicaoForn.Location = new Point(375, 335);
            buttonGuardarEdicaoForn.Name = "buttonGuardarEdicaoForn";
            buttonGuardarEdicaoForn.Size = new Size(233, 34);
            buttonGuardarEdicaoForn.TabIndex = 180;
            buttonGuardarEdicaoForn.Text = "Confirmar";
            buttonGuardarEdicaoForn.UseVisualStyleBackColor = false;
            buttonGuardarEdicaoForn.Click += buttonGuardarEdicaoForn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(375, 225);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 179;
            label2.Text = "Telefone";
            // 
            // maskedTextBoxEditarTelefoneForn
            // 
            maskedTextBoxEditarTelefoneForn.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxEditarTelefoneForn.Location = new Point(375, 261);
            maskedTextBoxEditarTelefoneForn.Mask = "(+244) 000-000-000";
            maskedTextBoxEditarTelefoneForn.Name = "maskedTextBoxEditarTelefoneForn";
            maskedTextBoxEditarTelefoneForn.Size = new Size(135, 27);
            maskedTextBoxEditarTelefoneForn.TabIndex = 178;
            // 
            // textBoxEditarEnderecoForn
            // 
            textBoxEditarEnderecoForn.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditarEnderecoForn.Location = new Point(375, 178);
            textBoxEditarEnderecoForn.Name = "textBoxEditarEnderecoForn";
            textBoxEditarEnderecoForn.Size = new Size(469, 27);
            textBoxEditarEnderecoForn.TabIndex = 177;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(375, 138);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 176;
            label1.Text = "Endereço";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(375, 70);
            label10.Name = "label10";
            label10.Size = new Size(53, 20);
            label10.TabIndex = 175;
            label10.Text = "Nome";
            // 
            // textBoxEditarNomeForn
            // 
            textBoxEditarNomeForn.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditarNomeForn.Location = new Point(375, 109);
            textBoxEditarNomeForn.Name = "textBoxEditarNomeForn";
            textBoxEditarNomeForn.Size = new Size(469, 27);
            textBoxEditarNomeForn.TabIndex = 174;
            // 
            // FormEditarFornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 525);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditarFornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditarFornecedor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFecharFrn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button buttonCancelar;
        private Button buttonGuardarEdicaoForn;
        private Label label2;
        public MaskedTextBox maskedTextBoxEditarTelefoneForn;
        public TextBox textBoxEditarEnderecoForn;
        private Label label1;
        private Label label10;
        public TextBox textBoxEditarNomeForn;
        private Label label11;
        private PictureBox pictureBoxFecharFrn;
        private Label label3;
        public TextBox textBoxEditarEmailFOrn;
        public Label labelEditarFornecedorID;
        private Label label4;
    }
}