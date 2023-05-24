namespace Projeto_Final
{
    public class Usuario
    {
        private int Codigo { get; set; }
        private string Nome { get; set; }
        private string Email { get; set; }
        private string Senha { get; set; }
        public static string Name { get; set; }

        private string DataCadastro = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

        // Métodos
        List<Usuario> Usuarios = new List<Usuario>();

        public Usuario(int _codigo, string _nome, string _email, string _senha)
        {
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            Name = _nome;
        }
        public void Cadastar(int _codigo, string _nome, string _email, string _senha)
        {
            Console.WriteLine($"Qual será o código?");
            Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Qual será o nome?");
            Nome = Console.ReadLine()!.ToLower();

            Console.WriteLine($"Qual será o email?");
            Email = Console.ReadLine()!.ToLower();

            Console.WriteLine($"Qual será a senha?");
            Senha = Console.ReadLine()!;

            Name = Nome;
            
            Usuarios.Add(
                new Usuario(Codigo, Nome, Email, Senha)
            );
        }
        public void Deletar(int _codigo)
        {
            Usuario UsuarioARemover = Usuarios.Find(x => x.Codigo == Codigo);
            int index = Usuarios.IndexOf(UsuarioARemover);
            Usuarios.RemoveAt(index);
        }
        
    }
}