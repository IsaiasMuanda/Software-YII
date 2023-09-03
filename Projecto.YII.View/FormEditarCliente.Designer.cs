namespace Projecto_YII.Projecto.YII.View
{
    partial class FormEditarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarCliente));
            pictureBoxFecharCL = new PictureBox();
            label11 = new Label();
            panel2 = new Panel();
            textBoxID_EditarCl = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            buttonCancelar = new Button();
            buttonGuardarEdicaoCl = new Button();
            label2 = new Label();
            maskedTextBoxEditarTelefoneCliente = new MaskedTextBox();
            textBoxEditarEnderecoCliente = new TextBox();
            label1 = new Label();
            label10 = new Label();
            textBoxEditarNomeCliente = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFecharCL).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxFecharCL
            // 
            pictureBoxFecharCL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxFecharCL.BackgroundImageLayout = ImageLayout.None;
            pictureBoxFecharCL.Cursor = Cursors.Hand;
            pictureBoxFecharCL.Image = (Image)resources.GetObject("pictureBoxFecharCL.Image");
            pictureBoxFecharCL.Location = new Point(861, 12);
            pictureBoxFecharCL.Name = "pictureBoxFecharCL";
            pictureBoxFecharCL.Size = new Size(25, 25);
            pictureBoxFecharCL.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFecharCL.TabIndex = 47;
            pictureBoxFecharCL.TabStop = false;
            pictureBoxFecharCL.Click += pictureBoxFecharCL_Click;
            pictureBoxFecharCL.MouseEnter += pictureBoxFecharCL_MouseEnter;
            pictureBoxFecharCL.MouseLeave += pictureBoxFecharCL_MouseLeave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(342, 12);
            label11.Name = "label11";
            label11.Size = new Size(192, 23);
            label11.TabIndex = 0;
            label11.Text = "Editar Informações";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBoxID_EditarCl);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(buttonCancelar);
            panel2.Controls.Add(buttonGuardarEdicaoCl);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(maskedTextBoxEditarTelefoneCliente);
            panel2.Controls.Add(textBoxEditarEnderecoCliente);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBoxEditarNomeCliente);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 450);
            panel2.TabIndex = 151;
            // 
            // textBoxID_EditarCl
            // 
            textBoxID_EditarCl.BackColor = SystemColors.Control;
            textBoxID_EditarCl.BorderStyle = BorderStyle.None;
            textBoxID_EditarCl.Location = new Point(584, 290);
            textBoxID_EditarCl.Name = "textBoxID_EditarCl";
            textBoxID_EditarCl.Size = new Size(125, 19);
            textBoxID_EditarCl.TabIndex = 200;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(578, 248);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 199;
            label3.Text = "Código";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(284, 264);
            pictureBox2.TabIndex = 173;
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
            buttonCancelar.Location = new Point(578, 358);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(233, 34);
            buttonCancelar.TabIndex = 172;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonGuardarEdicaoCl
            // 
            buttonGuardarEdicaoCl.BackColor = Color.FromArgb(0, 122, 205);
            buttonGuardarEdicaoCl.Cursor = Cursors.Hand;
            buttonGuardarEdicaoCl.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            buttonGuardarEdicaoCl.FlatStyle = FlatStyle.Flat;
            buttonGuardarEdicaoCl.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGuardarEdicaoCl.ForeColor = Color.White;
            buttonGuardarEdicaoCl.Location = new Point(342, 358);
            buttonGuardarEdicaoCl.Name = "buttonGuardarEdicaoCl";
            buttonGuardarEdicaoCl.Size = new Size(233, 34);
            buttonGuardarEdicaoCl.TabIndex = 171;
            buttonGuardarEdicaoCl.Text = "Confirmar";
            buttonGuardarEdicaoCl.UseVisualStyleBackColor = false;
            buttonGuardarEdicaoCl.Click += buttonGuardarEdicaoCl_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(342, 248);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 168;
            label2.Text = "Telefone";
            // 
            // maskedTextBoxEditarTelefoneCliente
            // 
            maskedTextBoxEditarTelefoneCliente.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxEditarTelefoneCliente.Location = new Point(342, 284);
            maskedTextBoxEditarTelefoneCliente.Mask = "(+244) 000-000-000";
            maskedTextBoxEditarTelefoneCliente.Name = "maskedTextBoxEditarTelefoneCliente";
            maskedTextBoxEditarTelefoneCliente.Size = new Size(135, 26);
            maskedTextBoxEditarTelefoneCliente.TabIndex = 167;
            // 
            // textBoxEditarEnderecoCliente
            // 
            textBoxEditarEnderecoCliente.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditarEnderecoCliente.Location = new Point(342, 201);
            textBoxEditarEnderecoCliente.Name = "textBoxEditarEnderecoCliente";
            textBoxEditarEnderecoCliente.Size = new Size(469, 26);
            textBoxEditarEnderecoCliente.TabIndex = 166;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(342, 161);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 165;
            label1.Text = "Endereço";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(342, 93);
            label10.Name = "label10";
            label10.Size = new Size(130, 20);
            label10.TabIndex = 164;
            label10.Text = "Nome Completo";
            // 
            // textBoxEditarNomeCliente
            // 
            textBoxEditarNomeCliente.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditarNomeCliente.Location = new Point(342, 132);
            textBoxEditarNomeCliente.Name = "textBoxEditarNomeCliente";
            textBoxEditarNomeCliente.Size = new Size(469, 26);
            textBoxEditarNomeCliente.TabIndex = 163;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 205);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBoxFecharCL);
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 47);
            panel1.TabIndex = 152;
            panel1.MouseDown += panel1_MouseDown_1;
            // 
            // FormEditarCliente
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditarCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFecharCL).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label11;
        private PictureBox pictureBoxFecharCL;
        private Panel panel2;
        private Button buttonCancelar;
        private Button buttonGuardarEdicaoCl;
        private Label label2;
        public MaskedTextBox maskedTextBoxEditarTelefoneCliente;
        public TextBox textBoxEditarEnderecoCliente;
        private Label label1;
        private Label label10;
        public TextBox textBoxEditarNomeCliente;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label3;
        public TextBox textBoxID_EditarCl;
    }
}