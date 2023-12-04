namespace ProjetoParaEstudo.Domain.Commands.Responses
{
    public class UpdatePersonagemResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<UpdatePersonagemItemResponse> Itens { get; set; }
        public List<UpdatePersonagemSkillResponse> Skills { get; set; }

        public class UpdatePersonagemItemResponse
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
        public class UpdatePersonagemSkillResponse
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }
}
