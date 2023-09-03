using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_YII.Projecto.YII.Model
{
    public class Repositorio
    {
        /*Método genérico para capturar os dados selecionados em um DataGridView
         *Usado em eventos CellClick
         */
        public void Capturar(Control control, DataGridView dataGridView, int celula)
        {
            control.Text = dataGridView.CurrentRow.Cells[celula].Value.ToString();
        }

        //Método para ajustar o tamanho das colunas dos DataGridView
        public void TamanhoColunas(DataGridView dataGridView_, string n, int tamanho)
        {
            if (dataGridView_.Columns.Contains(n))
            {
                dataGridView_.Columns[n].Width = tamanho;
            }
        }
    }
}