using ThothEntity;
using ThothDataAccess;
using System.Collections.Generic;

namespace ThothBusiness
{
    public class UsuarioBus
    {
        public bool AlterarUsuario(Usuario usuario)
        {
            UsuarioDal usuarioDal = new UsuarioDal();
            return usuarioDal.AlterarUsuario(usuario);
        }

        public bool ExcluirUsuario(int idUsuario)
        {
            UsuarioDal usuarioDal = new UsuarioDal();
            return usuarioDal.ExcluirUsuario(idUsuario);
        }

        public int InserirUsuario(Usuario usuario)
        {
            UsuarioDal usuarioDal = new UsuarioDal();
            return usuarioDal.IncluirUsuario(usuario);
        }

        public List<Usuario> ListarUsuarios()
        {
            UsuarioDal usuarioDal = new UsuarioDal();
            return usuarioDal.ListarUsuarios();
        }

        public bool LoginExiste(string login, string operacao, int idUsuario = 0)
        {
            UsuarioDal usuarioDal = new UsuarioDal();
            bool jaExiste = usuarioDal.LoginJaExiste(login, out int id);
            if (operacao == "I")
            {
                return jaExiste;
            }
            if (operacao == "A")
            {
                if (jaExiste && id == idUsuario)
                {
                    return false;
                }
            }
            return true;
        }

        public bool NomeExiste(string nome, string operacao, int idUsuario = 0)
        {
            UsuarioDal usuarioDal = new UsuarioDal();
            bool jaExiste = usuarioDal.NomeJaExiste(nome, out int id);
            if (operacao == "I")
            {
                return jaExiste;
            }
            if (operacao == "A")
            {
                if (jaExiste && id == idUsuario)
                {
                    return false;
                }
            }
            return true;
        }

        public string ObterSenha(int idUsuario)
        {
            UsuarioDal usuarioDal = new UsuarioDal();
            return usuarioDal.ObterSenha(idUsuario);
        }

        public int ValidarLogin(string login)
        {
            UsuarioDal usuarioDal = new UsuarioDal();
            return usuarioDal.ObterIdUsuario(login);
        }

        public bool ValidarSenha(int idUsuario, string senha, out string nome)
        {
            nome = string.Empty;

            UsuarioDal usuarioDal = new UsuarioDal();
            return usuarioDal.ValidarSenha(idUsuario, senha, out nome);
        }
    }
}
