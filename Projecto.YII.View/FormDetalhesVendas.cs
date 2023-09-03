using Projecto_YII.Projecto.YII.DAO;
using Projecto_YII.Projecto.YII.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_YII.Projecto.YII.View
{
    public partial class FormDetalhesVendas : Form
    {
        public FormDetalhesVendas()
        {
            InitializeComponent();
        }



        private void pictureBoxFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxFechar_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxFechar.Size = new Size(20, 20);

        }

        private void pictureBoxFechar_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxFechar.Size = new Size(25, 25);

        }

        private void FormDetalhesVendas_Load(object sender, EventArgs e)
        {
            Repositorio repositorio_ = new Repositorio();
            repositorio_.TamanhoColunas(dataGridViewDetalhes, "Producto", 200);
            repositorio_.TamanhoColunas(dataGridViewDetalhes, "Subtotal", 260);


        }
    }
}
