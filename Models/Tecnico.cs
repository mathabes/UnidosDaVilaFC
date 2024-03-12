
namespace UnidosDaVilaFC.Models
{
    public class Tecnico : Funcionario
    {
        public int Id { get; set; }
        public int AnosExperiencia { get; set; }
        private string Estrategia { get; set; }

        public Tecnico(int id, int anosExperiencia, string estrategia, 
            string nome, DateTime dataNascimento, double salario, string nacionalidade) : base(nome, dataNascimento, salario, nacionalidade)
        {
            Id = id;
            AnosExperiencia = anosExperiencia;
            Estrategia = estrategia ?? throw new ArgumentNullException(nameof(estrategia));
        }

        public string GetEstrategia()
        {
            return Estrategia;
        }

        public override void Logar()
        {
            // logar de outra forma
        }
    }
}
