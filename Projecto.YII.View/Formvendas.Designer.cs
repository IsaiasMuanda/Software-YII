namespace Projecto_YII.Projecto.YII.View
{
    partial class Formvendas
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
            label2 = new Label();
            comboBoxClienteVendas = new ComboBox();
            groupBox3 = new GroupBox();
            buttonRemoverCarrinho = new Button();
            label9 = new Label();
            textBoxQtdDataGV_Venda = new TextBox();
            dataGridViewCarrinhoTemp = new DataGridView();
            labelExibirTotal = new Label();
            pictureBox1 = new PictureBox();
            textBoxPesquisarProdVendas = new TextBox();
            buttonAdicionarCarrinho = new Button();
            dataGridViewVendas = new DataGridView();
            groupBox2 = new GroupBox();
            textBoxValorEntregue = new TextBox();
            label1 = new Label();
            label3 = new Label();
            buttonCancelarVenda = new Button();
            groupBox1 = new GroupBox();
            labelDataVenda = new Label();
            label6 = new Label();
            textBoxObsVenda = new TextBox();
            label4 = new Label();
            textBoxTrocoVenda = new TextBox();
            label8 = new Label();
            label5 = new Label();
            comboBoxTipoPagamento = new ComboBox();
            buttonFinalizarVenda = new Button();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrinhoTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendas).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(6, 38);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 209;
            label2.Text = "Cliente";
            // 
            // comboBoxClienteVendas
            // 
            comboBoxClienteVendas.FormattingEnabled = true;
            comboBoxClienteVendas.Location = new Point(6, 72);
            comboBoxClienteVendas.Name = "comboBoxClienteVendas";
            comboBoxClienteVendas.Size = new Size(465, 28);
            comboBoxClienteVendas.TabIndex = 208;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonRemoverCarrinho);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(textBoxQtdDataGV_Venda);
            groupBox3.Controls.Add(dataGridViewCarrinhoTemp);
            groupBox3.Controls.Add(labelExibirTotal);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(textBoxPesquisarProdVendas);
            groupBox3.Controls.Add(buttonAdicionarCarrinho);
            groupBox3.Controls.Add(dataGridViewVendas);
            groupBox3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.FromArgb(0, 122, 205);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1642, 543);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cesto De Compras";
            // 
            // buttonRemoverCarrinho
            // 
            buttonRemoverCarrinho.BackColor = Color.FromArgb(45, 45, 48);
            buttonRemoverCarrinho.FlatAppearance.BorderColor = Color.Gray;
            buttonRemoverCarrinho.FlatAppearance.MouseDownBackColor = Color.White;
            buttonRemoverCarrinho.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonRemoverCarrinho.FlatStyle = FlatStyle.Flat;
            buttonRemoverCarrinho.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRemoverCarrinho.ForeColor = Color.White;
            buttonRemoverCarrinho.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRemoverCarrinho.Location = new Point(1477, 485);
            buttonRemoverCarrinho.Name = "buttonRemoverCarrinho";
            buttonRemoverCarrinho.Size = new Size(140, 27);
            buttonRemoverCarrinho.TabIndex = 231;
            buttonRemoverCarrinho.Text = "Remover";
            buttonRemoverCarrinho.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRemoverCarrinho.UseVisualStyleBackColor = false;
            buttonRemoverCarrinho.Click += buttonRemoverCarrinho_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(1349, 81);
            label9.Name = "label9";
            label9.Size = new Size(98, 20);
            label9.TabIndex = 229;
            label9.Text = "Quantidade";
            // 
            // textBoxQtdDataGV_Venda
            // 
            textBoxQtdDataGV_Venda.BorderStyle = BorderStyle.FixedSingle;
            textBoxQtdDataGV_Venda.Location = new Point(1347, 104);
            textBoxQtdDataGV_Venda.Name = "textBoxQtdDataGV_Venda";
            textBoxQtdDataGV_Venda.Size = new Size(150, 26);
            textBoxQtdDataGV_Venda.TabIndex = 230;
            // 
            // dataGridViewCarrinhoTemp
            // 
            dataGridViewCarrinhoTemp.BackgroundColor = Color.White;
            dataGridViewCarrinhoTemp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarrinhoTemp.Location = new Point(24, 87);
            dataGridViewCarrinhoTemp.Name = "dataGridViewCarrinhoTemp";
            dataGridViewCarrinhoTemp.RowHeadersWidth = 51;
            dataGridViewCarrinhoTemp.RowTemplate.Height = 29;
            dataGridViewCarrinhoTemp.Size = new Size(1317, 162);
            dataGridViewCarrinhoTemp.TabIndex = 102;
            // 
            // labelExibirTotal
            // 
            labelExibirTotal.AutoSize = true;
            labelExibirTotal.BackColor = Color.FromArgb(0, 122, 205);
            labelExibirTotal.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelExibirTotal.ForeColor = Color.White;
            labelExibirTotal.Location = new Point(1381, 136);
            labelExibirTotal.Name = "labelExibirTotal";
            labelExibirTotal.Size = new Size(20, 21);
            labelExibirTotal.TabIndex = 101;
            labelExibirTotal.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._6372976_bag_basket_buy_cart_shop_icon_21;
            pictureBox1.Location = new Point(1347, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 338);
            pictureBox1.TabIndex = 100;
            pictureBox1.TabStop = false;
            // 
            // textBoxPesquisarProdVendas
            // 
            textBoxPesquisarProdVendas.BorderStyle = BorderStyle.FixedSingle;
            textBoxPesquisarProdVendas.Location = new Point(24, 55);
            textBoxPesquisarProdVendas.Name = "textBoxPesquisarProdVendas";
            textBoxPesquisarProdVendas.Size = new Size(1317, 26);
            textBoxPesquisarProdVendas.TabIndex = 99;
            textBoxPesquisarProdVendas.KeyPress += textBoxPesquisarProdVendas_KeyPress;
            // 
            // buttonAdicionarCarrinho
            // 
            buttonAdicionarCarrinho.BackColor = Color.FromArgb(45, 45, 48);
            buttonAdicionarCarrinho.FlatAppearance.BorderColor = Color.Gray;
            buttonAdicionarCarrinho.FlatAppearance.MouseDownBackColor = Color.White;
            buttonAdicionarCarrinho.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonAdicionarCarrinho.FlatStyle = FlatStyle.Flat;
            buttonAdicionarCarrinho.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdicionarCarrinho.ForeColor = Color.White;
            buttonAdicionarCarrinho.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdicionarCarrinho.Location = new Point(1347, 485);
            buttonAdicionarCarrinho.Name = "buttonAdicionarCarrinho";
            buttonAdicionarCarrinho.Size = new Size(124, 27);
            buttonAdicionarCarrinho.TabIndex = 213;
            buttonAdicionarCarrinho.Text = "Adicionar";
            buttonAdicionarCarrinho.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAdicionarCarrinho.UseVisualStyleBackColor = false;
            buttonAdicionarCarrinho.Click += buttonAdicionarCarrinho_Click;
            // 
            // dataGridViewVendas
            // 
            dataGridViewVendas.BackgroundColor = Color.White;
            dataGridViewVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVendas.Location = new Point(24, 98);
            dataGridViewVendas.Name = "dataGridViewVendas";
            dataGridViewVendas.RowHeadersWidth = 51;
            dataGridViewVendas.RowTemplate.Height = 29;
            dataGridViewVendas.Size = new Size(1317, 414);
            dataGridViewVendas.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxValorEntregue);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboBoxClienteVendas);
            groupBox2.Controls.Add(label3);
            groupBox2.ForeColor = Color.FromArgb(0, 122, 205);
            groupBox2.Location = new Point(12, 584);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(506, 196);
            groupBox2.TabIndex = 211;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados Do Cliente";
            // 
            // textBoxValorEntregue
            // 
            textBoxValorEntregue.BorderStyle = BorderStyle.FixedSingle;
            textBoxValorEntregue.Location = new Point(6, 135);
            textBoxValorEntregue.Name = "textBoxValorEntregue";
            textBoxValorEntregue.Size = new Size(465, 26);
            textBoxValorEntregue.TabIndex = 216;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 112);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 215;
            label1.Text = "Valor Entregue";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(213, 248);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 210;
            label3.Text = "-------------";
            // 
            // buttonCancelarVenda
            // 
            buttonCancelarVenda.BackColor = Color.FromArgb(45, 45, 48);
            buttonCancelarVenda.FlatAppearance.BorderColor = Color.Gray;
            buttonCancelarVenda.FlatAppearance.MouseDownBackColor = Color.White;
            buttonCancelarVenda.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonCancelarVenda.FlatStyle = FlatStyle.Flat;
            buttonCancelarVenda.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelarVenda.ForeColor = Color.White;
            buttonCancelarVenda.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancelarVenda.Location = new Point(253, 816);
            buttonCancelarVenda.Name = "buttonCancelarVenda";
            buttonCancelarVenda.Size = new Size(219, 31);
            buttonCancelarVenda.TabIndex = 214;
            buttonCancelarVenda.Text = "Cancelar";
            buttonCancelarVenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancelarVenda.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelDataVenda);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxObsVenda);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxTrocoVenda);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBoxTipoPagamento);
            groupBox1.ForeColor = Color.FromArgb(0, 122, 205);
            groupBox1.Location = new Point(583, 584);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(827, 196);
            groupBox1.TabIndex = 212;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Da Venda";
            // 
            // labelDataVenda
            // 
            labelDataVenda.AutoSize = true;
            labelDataVenda.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelDataVenda.ForeColor = Color.Black;
            labelDataVenda.Location = new Point(6, 141);
            labelDataVenda.Name = "labelDataVenda";
            labelDataVenda.Size = new Size(129, 20);
            labelDataVenda.TabIndex = 228;
            labelDataVenda.Text = "------------------------";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(6, 112);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 227;
            label6.Text = "Data Da Venda";
            // 
            // textBoxObsVenda
            // 
            textBoxObsVenda.BorderStyle = BorderStyle.FixedSingle;
            textBoxObsVenda.Location = new Point(399, 135);
            textBoxObsVenda.Multiline = true;
            textBoxObsVenda.Name = "textBoxObsVenda";
            textBoxObsVenda.Size = new Size(322, 32);
            textBoxObsVenda.TabIndex = 226;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(399, 112);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 225;
            label4.Text = "Observações";
            // 
            // textBoxTrocoVenda
            // 
            textBoxTrocoVenda.BorderStyle = BorderStyle.None;
            textBoxTrocoVenda.Location = new Point(399, 74);
            textBoxTrocoVenda.Name = "textBoxTrocoVenda";
            textBoxTrocoVenda.ReadOnly = true;
            textBoxTrocoVenda.Size = new Size(322, 19);
            textBoxTrocoVenda.TabIndex = 224;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(399, 38);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 223;
            label8.Text = "Troco";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(6, 38);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 222;
            label5.Text = "Tipo De Pagamento";
            // 
            // comboBoxTipoPagamento
            // 
            comboBoxTipoPagamento.FormattingEnabled = true;
            comboBoxTipoPagamento.Items.AddRange(new object[] { "Cartão", "Dinheiro" });
            comboBoxTipoPagamento.Location = new Point(6, 72);
            comboBoxTipoPagamento.Name = "comboBoxTipoPagamento";
            comboBoxTipoPagamento.Size = new Size(348, 28);
            comboBoxTipoPagamento.TabIndex = 221;
            // 
            // buttonFinalizarVenda
            // 
            buttonFinalizarVenda.BackColor = Color.FromArgb(45, 45, 48);
            buttonFinalizarVenda.FlatAppearance.BorderColor = Color.Gray;
            buttonFinalizarVenda.FlatAppearance.MouseDownBackColor = Color.White;
            buttonFinalizarVenda.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonFinalizarVenda.FlatStyle = FlatStyle.Flat;
            buttonFinalizarVenda.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFinalizarVenda.ForeColor = Color.White;
            buttonFinalizarVenda.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFinalizarVenda.Location = new Point(12, 816);
            buttonFinalizarVenda.Name = "buttonFinalizarVenda";
            buttonFinalizarVenda.Size = new Size(219, 31);
            buttonFinalizarVenda.TabIndex = 215;
            buttonFinalizarVenda.Text = "Finalizar Venda";
            buttonFinalizarVenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFinalizarVenda.UseVisualStyleBackColor = false;
            buttonFinalizarVenda.Click += buttonFinalizarVenda_Click;
            // 
            // Formvendas
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1666, 859);
            Controls.Add(buttonFinalizarVenda);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(buttonCancelarVenda);
            Controls.Add(groupBox3);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formvendas";
            Text = "Formvendas";
            Load += Formvendas_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrinhoTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendas).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private ComboBox comboBoxClienteVendas;
        private GroupBox groupBox3;
        private DataGridView dataGridViewVendas;
        private PictureBox pictureBox1;
        private TextBox textBoxPesquisarProdVendas;
        private Label labelExibirTotal;
        private GroupBox groupBox2;
        private Label label3;
        private Button buttonCancelarVenda;
        private Button buttonAdicionarCarrinho;
        private Label label1;
        private TextBox textBoxValorEntregue;
        private GroupBox groupBox1;
        private Label labelDataVenda;
        private Label label6;
        private TextBox textBoxObsVenda;
        private Label label4;
        private TextBox textBoxTrocoVenda;
        private Label label8;
        private Label label5;
        private ComboBox comboBoxTipoPagamento;
        private DataGridView dataGridViewCarrinhoTemp;
        private Label label9;
        private TextBox textBoxQtdDataGV_Venda;
        private Button buttonFinalizarVenda;
        private Button buttonRemoverCarrinho;
    }
}