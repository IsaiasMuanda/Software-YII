namespace Projecto_YII.Projecto.YII.View
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            panel2 = new Panel();
            buttonEntrarLogin = new Button();
            pictureBox2 = new PictureBox();
            label10 = new Label();
            textBoxNomeLogin = new TextBox();
            label1 = new Label();
            textBoxPasswordLogin = new TextBox();
            panel1 = new Panel();
            label11 = new Label();
            pictureBoxFechar = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFechar).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(buttonEntrarLogin);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBoxNomeLogin);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBoxPasswordLogin);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(974, 450);
            panel2.TabIndex = 222;
            // 
            // buttonEntrarLogin
            // 
            buttonEntrarLogin.BackColor = Color.FromArgb(0, 122, 205);
            buttonEntrarLogin.Cursor = Cursors.Hand;
            buttonEntrarLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            buttonEntrarLogin.FlatStyle = FlatStyle.Flat;
            buttonEntrarLogin.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEntrarLogin.ForeColor = Color.White;
            buttonEntrarLogin.Location = new Point(357, 343);
            buttonEntrarLogin.Name = "buttonEntrarLogin";
            buttonEntrarLogin.Size = new Size(233, 34);
            buttonEntrarLogin.TabIndex = 227;
            buttonEntrarLogin.Text = "Entrar";
            buttonEntrarLogin.UseVisualStyleBackColor = false;
            buttonEntrarLogin.Click += buttonEntrarLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._2191544_key_lock_login_secret_secure_icon_2;
            pictureBox2.Location = new Point(11, 182);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(159, 130);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 226;
            pictureBox2.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(247, 157);
            label10.Name = "label10";
            label10.Size = new Size(136, 20);
            label10.TabIndex = 222;
            label10.Text = "Nome De Usuário";
            // 
            // textBoxNomeLogin
            // 
            textBoxNomeLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxNomeLogin.Location = new Point(247, 194);
            textBoxNomeLogin.Name = "textBoxNomeLogin";
            textBoxNomeLogin.Size = new Size(469, 26);
            textBoxNomeLogin.TabIndex = 221;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(247, 242);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 223;
            label1.Text = "Palavra-Passe";
            // 
            // textBoxPasswordLogin
            // 
            textBoxPasswordLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxPasswordLogin.Location = new Point(247, 277);
            textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            textBoxPasswordLogin.PasswordChar = '*';
            textBoxPasswordLogin.Size = new Size(469, 26);
            textBoxPasswordLogin.TabIndex = 224;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 205);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(pictureBoxFechar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 56);
            panel1.TabIndex = 223;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(386, 11);
            label11.Name = "label11";
            label11.Size = new Size(156, 23);
            label11.TabIndex = 50;
            label11.Text = "Auntenticação";
            // 
            // pictureBoxFechar
            // 
            pictureBoxFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxFechar.BackgroundImageLayout = ImageLayout.None;
            pictureBoxFechar.Cursor = Cursors.Hand;
            pictureBoxFechar.Image = (Image)resources.GetObject("pictureBoxFechar.Image");
            pictureBoxFechar.Location = new Point(936, 11);
            pictureBoxFechar.Name = "pictureBoxFechar";
            pictureBoxFechar.Size = new Size(25, 25);
            pictureBoxFechar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFechar.TabIndex = 49;
            pictureBoxFechar.TabStop = false;
            pictureBoxFechar.Click += pictureBoxFechar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(974, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFechar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label10;
        private TextBox textBoxNomeLogin;
        private Label label1;
        private TextBox textBoxPasswordLogin;
        private Panel panel1;
        private PictureBox pictureBoxFechar;
        private Label label11;
        private PictureBox pictureBox2;
        private Button buttonEntrarLogin;
    }
}