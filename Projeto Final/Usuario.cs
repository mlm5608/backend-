namespace Projeto_Final
{
    public class Usuario
    {
        private int Codigo { get; set; }
        private string Nome { get; set; }
        private string Email { get; set; }
        private string Senha { get; set; }

        private string DataCadastro = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

        // Métodos
        List<Usuario> Usuarios = new List<Usuario>();

        public Usuario(int _codigo, string _nome, string _email, string _senha)
        {
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
        }
        public void Cadastar(int _codigo, string _nome, string _email, string _senha)
        {
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