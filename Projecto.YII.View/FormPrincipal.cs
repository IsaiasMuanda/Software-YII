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
    public partial class FormPrincipal : Form
    {
        #region Instruções globais

        private System.Windows.Forms.Timer timer;

        #endregion

        public FormPrincipal()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        #region Métodos Do formulario

        //Método para apresentar dados no resumo
        private void ContarResumo()
        {
            int c = new ClienteDAO().VendasDiarias();
            int c2 = new FuncionarioDAO().ContarFuncionarios();
            int c3 = new ProductoDAO().ProductosDiarios();
            int c4 = new FornecedorDAO().ContarFornecedores();
            decimal c5 = new VendaDAO().CaixaDiaria();

            labelExibirCL.Text = c.ToString();
            labelExibirFunc.Text = c2.ToString();
            labelExibirPro.Text = c3.ToString();
            labelForncResumo.Text = c4.ToString();
            labelCaixa2.Text = c5.ToString();
        }

        #endregion

        #region Eventos Do Formulário

        /*Evento TimerTick
         * Serve para exibir a data em tempo real
         * no FormPrincipal
         */
        private void Timer_Tick(object? sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("T");
            labelDiaSemana.Text = DateTime.Now.ToString("dddd");
            labelDiaSemana.ForeColor = Color.Green;
            labelData.Text = DateTime.Now.ToString("M");
        }

        //Evento Load para carregar dados do resumo
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ContarResumo();
            dataGridViewStock.DataSource = new FormPrincipalDAO().Listar();
            Repositorio repositorio_ = new Repositorio();
            repositorio_.TamanhoColunas(dataGridViewStock, "Categoria", 200);
            repositorio_.TamanhoColunas(dataGridViewStock, "Nome Do Producto", 250);

            if (labelCaixa2.Text == "0")
            {
                labelCaixa2.Location = new Point(445, 142);
            }
            else
            {
                labelCaixa2.Location = new Point(409, 142);
            }
        }
        #endregion

    }
}
