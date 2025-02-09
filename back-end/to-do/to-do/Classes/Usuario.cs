namespace to_do.Classes
{
    public class Usuario
    {
        public string usuario { get; set; }
        public string senha { get; set; }

        public Usuario(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }
    }
}
