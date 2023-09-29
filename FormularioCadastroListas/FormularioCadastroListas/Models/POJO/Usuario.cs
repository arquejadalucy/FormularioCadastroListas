using System;
namespace FormularioCadastroListas.Models.POJO
{
	public class Usuario
	{
		public long id { get; set; }
		public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string sexo { get; set; }
        public string dataNascimento { get; set; }

        public Usuario()
        {
        }

        public Usuario(
            long id, string nome,
            string email, string telefone,
            string sexo, string dataNascimento)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.sexo = sexo;
            this.dataNascimento = dataNascimento;
        }
    }
}

