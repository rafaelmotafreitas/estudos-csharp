using Playground;

Console.WriteLine("Digite o seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite o seu sobrenome: ");
string sobrenome = Console.ReadLine();

Console.WriteLine("Digite o seu email: ");
string email = Console.ReadLine();

Console.WriteLine("Digite o seu CPF: ");
string cpf = Console.ReadLine();

Cliente cliente = new Cliente();

cliente.Nome = nome;
cliente.Sobrenome = sobrenome;
cliente.Email = email;
cliente.CPF = cpf;

cliente.ExibirResumo();
