namespace Projecto_YII.Projecto.YII.View
{
    partial class FormContas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContas));
            tabControlContas = new TabControl();
            tabPage1 = new TabPage();
            labelUserID = new Label();
            label3 = new Label();
            pictureBoxLimpar = new PictureBox();
            buttonRemover = new Button();
            buttonActualizar = new Button();
            label10 = new Label();
            buttonCriarConta = new Button();
            textBoxNomeUser = new TextBox();
            comboBoxAcesso = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBoxPassword = new TextBox();
            comboBoxFuncionario = new ComboBox();
            label5 = new Label();
            tabPage2 = new TabPage();
            dataGridViewUsuario = new DataGridView();
            tabControlContas.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLimpar).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuario).BeginInit();
            SuspendLayout();
            // 
            // tabControlContas
            // 
            tabControlContas.Controls.Add(tabPage1);
            tabControlContas.Controls.Add(tabPage2);
            tabControlContas.Location = new Point(28, 12);
            tabControlContas.Name = "tabControlContas";
            tabControlContas.SelectedIndex = 0;
            tabControlContas.Size = new Size(1026, 591);
            tabControlContas.TabIndex = 162;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(labelUserID);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(pictureBoxLimpar);
            tabPage1.Controls.Add(buttonRemover);
            tabPage1.Controls.Add(buttonActualizar);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(buttonCriarConta);
            tabPage1.Controls.Add(textBoxNomeUser);
            tabPage1.Controls.Add(comboBoxAcesso);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBoxPassword);
            tabPage1.Controls.Add(comboBoxFuncionario);
            tabPage1.Controls.Add(label5);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1018, 558);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Contas";
            // 
            // labelUserID
            // 
            labelUserID.AutoSize = true;
            labelUserID.Location = new Point(285, 171);
            labelUserID.Name = "labelUserID";
            labelUserID.Size = new Size(69, 20);
            labelUserID.TabIndex = 216;
            labelUserID.Text = "------------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 171);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 215;
            label3.Text = "Código:";
            // 
            // pictureBoxLimpar
            // 
            pictureBoxLimpar.Cursor = Cursors.Hand;
            pictureBoxLimpar.Image = (Image)resources.GetObject("pictureBoxLimpar.Image");
            pictureBoxLimpar.Location = new Point(650, 385);
            pictureBoxLimpar.Name = "pictureBoxLimpar";
            pictureBoxLimpar.Size = new Size(27, 26);
            pictureBoxLimpar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLimpar.TabIndex = 214;
            pictureBoxLimpar.TabStop = false;
            pictureBoxLimpar.Click += pictureBoxLimpar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.BackColor = Color.FromArgb(45, 45, 48);
            buttonRemover.FlatAppearance.BorderColor = Color.Gray;
            buttonRemover.FlatAppearance.MouseDownBackColor = Color.White;
            buttonRemover.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonRemover.FlatStyle = FlatStyle.Flat;
            buttonRemover.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRemover.ForeColor = Color.White;
            buttonRemover.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRemover.Location = new Point(450, 380);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(180, 31);
            buttonRemover.TabIndex = 213;
            buttonRemover.Text = "Remover";
            buttonRemover.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRemover.UseVisualStyleBackColor = false;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = Color.FromArgb(45, 45, 48);
            buttonActualizar.FlatAppearance.BorderColor = Color.Gray;
            buttonActualizar.FlatAppearance.MouseDownBackColor = Color.White;
            buttonActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonActualizar.FlatStyle = FlatStyle.Flat;
            buttonActualizar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonActualizar.ForeColor = Color.White;
            buttonActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonActualizar.Location = new Point(242, 380);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(180, 31);
            buttonActualizar.TabIndex = 212;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonActualizar.UseVisualStyleBackColor = false;
            buttonActualizar.Click += button2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(33, 171);
            label10.Name = "label10";
            label10.Size = new Size(136, 20);
            label10.TabIndex = 163;
            label10.Text = "Nome De Usuário";
            // 
            // buttonCriarConta
            // 
            buttonCriarConta.BackColor = Color.FromArgb(45, 45, 48);
            buttonCriarConta.FlatAppearance.BorderColor = Color.Gray;
            buttonCriarConta.FlatAppearance.MouseDownBackColor = Color.White;
            buttonCriarConta.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonCriarConta.FlatStyle = FlatStyle.Flat;
            buttonCriarConta.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCriarConta.ForeColor = Color.White;
            buttonCriarConta.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCriarConta.Location = new Point(33, 380);
            buttonCriarConta.Name = "buttonCriarConta";
            buttonCriarConta.Size = new Size(184, 31);
            buttonCriarConta.TabIndex = 170;
            buttonCriarConta.Text = "Criar Conta";
            buttonCriarConta.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCriarConta.UseVisualStyleBackColor = false;
            buttonCriarConta.Click += buttonCriarConta_Click_1;
            // 
            // textBoxNomeUser
            // 
            textBoxNomeUser.BorderStyle = BorderStyle.FixedSingle;
            textBoxNomeUser.Location = new Point(33, 208);
            textBoxNomeUser.Name = "textBoxNomeUser";
            textBoxNomeUser.Size = new Size(469, 26);
            textBoxNomeUser.TabIndex = 162;
            // 
            // comboBoxAcesso
            // 
            comboBoxAcesso.FormattingEnabled = true;
            comboBoxAcesso.Items.AddRange(new object[] { "Administrador", "Usuário" });
            comboBoxAcesso.Location = new Point(628, 291);
            comboBoxAcesso.Name = "comboBoxAcesso";
            comboBoxAcesso.Size = new Size(207, 28);
            comboBoxAcesso.TabIndex = 169;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 256);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 164;
            label1.Text = "Palavra-Passe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(628, 256);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 168;
            label2.Text = "Acesso";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Location = new Point(33, 291);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(469, 26);
            textBoxPassword.TabIndex = 165;
            // 
            // comboBoxFuncionario
            // 
            comboBoxFuncionario.FormattingEnabled = true;
            comboBoxFuncionario.Location = new Point(628, 206);
            comboBoxFuncionario.Name = "comboBoxFuncionario";
            comboBoxFuncionario.Size = new Size(207, 28);
            comboBoxFuncionario.TabIndex = 167;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(628, 171);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 166;
            label5.Text = "Funcionário";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(dataGridViewUsuario);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1018, 558);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lista De Contas";
            // 
            // dataGridViewUsuario
            // 
            dataGridViewUsuario.BackgroundColor = Color.White;
            dataGridViewUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuario.Location = new Point(40, 98);
            dataGridViewUsuario.Name = "dataGridViewUsuario";
            dataGridViewUsuario.RowHeadersWidth = 51;
            dataGridViewUsuario.RowTemplate.Height = 29;
            dataGridViewUsuario.Size = new Size(658, 421);
            dataGridViewUsuario.TabIndex = 6;
            dataGridViewUsuario.CellClick += dataGridViewUsuario_CellClick;
            // 
            // FormContas
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1221, 699);
            Controls.Add(tabControlContas);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormContas";
            Text = "FormContas";
            Load += FormContas_Load;
            tabControlContas.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLimpar).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControlContas;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox pictureBoxLimpar;
        private Button buttonRemover;
        private Button buttonActualizar;
        private Label label10;
        private Button buttonCriarConta;
        private TextBox textBoxNomeUser;
        private ComboBox comboBoxAcesso;
        private Label label1;
        private Label label2;
        private TextBox textBoxPassword;
        private ComboBox comboBoxFuncionario;
        private Label label5;
        private DataGridView dataGridViewUsuario;
        private Label labelUserID;
        private Label label3;
    }
}