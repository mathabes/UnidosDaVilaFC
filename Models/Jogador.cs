

namespace UnidosDaVilaFC.Models
{
    public class Jogador : Funcionario
    {
        public Jogador(int id, string nome, DateTime dataNascimento, double salario, string nacionalidade, 
            string posicao, string especialidade, string status) : base(nome, dataNascimento, salario, nacionalidade)
        {
            Id = id;
            Posicao = posicao ?? throw new ArgumentNullException(nameof(posicao));
            Especialidade = especialidade ?? throw new ArgumentNullException(nameof(especialidade));
            Status = status ?? throw new ArgumentNullException(nameof(status));
        }

        public int Id { get; set; }
        private string Posicao { get; set; }

        private string Especialidade { get; set; }

        public string Status { get; set; }

       

        public string GetPosicao()
        {
            return Posicao;
        }

        public string GetEspecialidade()
        {
            return Especialidade;
        }

        internal void TipoTreino()
        {
            // dps nois faz
        }


        public override void Logar()
        {
            // logar de outra forma
        }
    }
}
