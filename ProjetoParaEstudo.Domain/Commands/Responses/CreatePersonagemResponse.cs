namespace ProjetoParaEstudo.Domain.Commands.Responses
{
    public class CreatePersonagemResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<CreatePersonagemItemResponse> Itens { get; set; }
        public List<CreatePersonagemSkillResponse> Skills { get; set; }

        public class CreatePersonagemItemResponse
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
        public class CreatePersonagemSkillResponse
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }
}
