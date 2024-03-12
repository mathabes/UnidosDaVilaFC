namespace UnidosDaVilaFC.Models
{
    public class Funcionario : IFuncionario
    {
        private string Nome { get; set; }

        protected DateTime DataNascimento { get; set;}

        private double Salario { get; set;}

        public string Nacionalidade { get; set;}

        public Funcionario(string nome, DateTime dataNascimento, double salario, string nacionalidade)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            DataNascimento = dataNascimento;
            Salario = salario;
            Nacionalidade = nacionalidade ?? throw new ArgumentNullException(nameof(nacionalidade));
        }

        public string GetNome()
        {
            return Nome;
        }

        public double GetSalario()
        {
            return Salario;
        }

        public virtual void Logar()
        {
            // função logar
        }
    }
}
