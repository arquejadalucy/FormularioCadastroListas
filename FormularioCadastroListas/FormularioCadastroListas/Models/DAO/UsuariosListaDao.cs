using System;
using FormularioCadastroListas.Models.POJO;

namespace FormularioCadastroListas.Models.DAO
{
	public class UsuariosListaDao
	{
        protected UsuariosListaDao() { }

        private static UsuariosListaDao _listaUsuarios;

        public static UsuariosListaDao Instance
        {
            get
            {
                _listaUsuarios ??= new();
                _listaUsuarios.Lista ??= new();
                return _listaUsuarios;
            }
        }

        public List<Usuario> Lista { get; set; }

        public List<Usuario> InserirUsuario(
            string nome, string email, string telefone,
            string sexo, string dataNascimento)
        {

            long id = _listaUsuarios.Lista.Count + 1;

            Usuario usuario = new Usuario(
                id, nome, email,
                telefone, sexo, dataNascimento
            );

            _listaUsuarios.Lista.Add(usuario);
            return _listaUsuarios.Lista;
        }
	}
}

