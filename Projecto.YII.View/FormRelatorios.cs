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
    public partial class FormRelatorios : Form
    {
        #region Globais
        Repositorio repositorio_ = new Repositorio();
        #endregion
        public FormRelatorios()
        {
            InitializeComponent();
        }

        private void buttonRelatorioConsultar_Click(object sender, EventArgs e)
        {
            DateTime dataInicio, dataFim;
            dataInicio = DateTime.Parse(dateTimePickerInicio.Value.ToString("yyyy-MM-dd"));
            dataFim = DateTime.Parse(dateTimePickerFim.Value.ToString("yyyy-MM-dd"));

            dataGridViewRelatorios.DataSource = new VendaDAO().ListarVendaPorData(dataInicio, dataFim);
            repositorio_.TamanhoColunas(dataGridViewRelatorios, "Cliente", 200);
            repositorio_.TamanhoColunas(dataGridViewRelatorios, "Data Da Venda", 140);
            repositorio_.TamanhoColunas(dataGridViewRelatorios, "Total", 200);
            repositorio_.TamanhoColunas(dataGridViewRelatorios, "Observação", 500);
        }

        private void buttonDetalhes_Click(object sender, EventArgs e)
        {
            FormDetalhesVendas formDetalhesVendas_ = new FormDetalhesVendas();
            formDetalhesVendas_.labelDetalhesCod.Text = dataGridViewRelatorios.CurrentRow.Cells[0].Value.ToString();
            formDetalhesVendas_.labelDetalhesCL.Text = dataGridViewRelatorios.CurrentRow.Cells[1].Value.ToString();
            formDetalhesVendas_.labelDetalhesData.Text = dataGridViewRelatorios.CurrentRow.Cells[2].Value.ToString();
            formDetalhesVendas_.label9DetalhesPag.Text = dataGridViewRelatorios.CurrentRow.Cells[3].Value.ToString();
            formDetalhesVendas_.labelDetalhesTotal.Text = dataGridViewRelatorios.CurrentRow.Cells[4].Value.ToString();
            formDetalhesVendas_.labelDetalhesObs.Text = dataGridViewRelatorios.CurrentRow.Cells[5].Value.ToString();

            int i = int.Parse(dataGridViewRelatorios.CurrentRow.Cells[0].Value.ToString());

            formDetalhesVendas_.dataGridViewDetalhes.DataSource = new VendaDAO().ListarItens(i);
            formDetalhesVendas_.ShowDialog();
        }
    }
}
