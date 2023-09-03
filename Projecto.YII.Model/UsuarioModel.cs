using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_YII.Projecto.YII.Model
{
    public class UsuarioModel
    {
        public UsuarioModel()
        {
        }

        //Contructor para Editar Dados
        public UsuarioModel(string nome_usuario, string acesso)
        {
            this.nome_usuario = nome_usuario;
            this.acesso = acesso;
        }

        public UsuarioModel(int id_funcionario, string nome_usuario, string palavra_passe, string acesso)
        {
            this.id_funcionario = id_funcionario;
            this.nome_usuario = nome_usuario;
            this.palavra_passe = palavra_passe;
            this.acesso = acesso;
        }

        public int id_usuario { get; set; }
        public int id_funcionario { get; set; }
        public string nome_usuario { get; set; }
        public string palavra_passe { get; set; }
        public string acesso { get; set; }
    }
}
