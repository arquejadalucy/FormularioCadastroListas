# FormularioCadastroListas
Exercício realizado para a disciplina Desenvolvimento Web 2 do curso Bacharelado em Engenharia da Computação do IFSP Campus Piracicaba. 
Formulário de cadastro usando entidades como transferência de dados. 

Desenvolver um formulário de cadastro de usuários da seguinte forma:
- Na pasta POJO: Criar a entidade Usuário (id, nome, email, telefone, sexo, dataNascimento);
- Na pasta DAO: Criar uma classe com regras para a entidade Usuario e um método (inserirUsuarios) para armazenar os usuários em uma lista de objetos;
     -> Referências: (https://www.tutorialsteacher.com/csharp/csharp-list) ou (https://www.c-sharpcorner.com/article/c-sharp-list/).
- Na camada View: Criar uma view tipada (Usuario) com um formulário de cadastro para usuários;
- Na camada de Controle: Obter os dados do formulário através do objeto Usuario e enviar para a camada Model para ser persistida em uma lista (use o método: (inserirUsuarios);
- Apresentar os dados dos usuários em uma View chamada GridUsuarios;

-  e passar os dados para o controller via objeto e armazenar 
os dados em uma lista de objetos através de uma função na camada de modelos
