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
    public partial class FormSistema : Form
    {
        #region 1


        #endregion
        public FormSistema()
        {
            InitializeComponent();
        }


        #region Métodos Gerais
        //Método para abrir formulários no PanelConteudoSistema
        public void AbrirForms(object formularios_obj)
        {
            if (this.panelConteudoSistema.Controls.Count > 0)
                this.panelConteudoSistema.Controls.RemoveAt(0);
            Form f = formularios_obj as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelConteudoSistema.Controls.Add(f);
            this.panelConteudoSistema.Tag = f;
            f.Show();
        }
        #endregion

        #region Eventos Gerais

        private void buttonCategoria_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormCategoria());
        }
        private void buttonCargos_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormCargos());
        }
        private void buttonRelatorios_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormRelatorios());
        }
        //Button Contas
        private void buttonContas_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormContas());
        }
        #endregion


    }
}
