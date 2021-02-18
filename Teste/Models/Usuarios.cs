namespace Teste.Models
{
    class Usuarios
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string User { get; set; }
        public string Senha { get; set; }

        // variáveis começando com P indica telas que usuário tem acesso
        public bool PSocios { get; set; }
        public bool PReceitas { get; set; }
        public bool PRelatorios { get; set; }
        // variáveis começando com F indica funções do usuário
        public bool FIncluirSocios { get; set; }
        public bool FCadastroReceitas { get; set; }
        public bool FBaixaReceitas { get; set; }
        public bool IsAdministrator { get; set; }

        public Usuarios()
        {
        }

        public Usuarios(int id, string matricula, string user, string senha, bool pSocios, bool pReceitas,
                        bool pRelatorios, bool fIncluirSocios, bool fCadastroReceitas, bool fBaixaReceitas, bool isAdministrator)
        {
            Id = id;
            Matricula = matricula;
            User = user;
            Senha = senha;
            PSocios = pSocios;
            PReceitas = pReceitas;
            PRelatorios = pRelatorios;
            FIncluirSocios = fIncluirSocios;
            FCadastroReceitas = fCadastroReceitas;
            FBaixaReceitas = fBaixaReceitas;
            IsAdministrator = isAdministrator;
        }
    }
}
