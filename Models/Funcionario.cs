namespace UnidosDaVilaFC.Models
{
    public class Funcionario : IFuncionario
    {
        protected string Nome { get; set; }

        public DateTime DataNascimento { get; set;}

        protected double Salario { get; set;}

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

        public virtual string Logar()
        {
            Console.WriteLine($" {GetNome()} fez login no sistema.");
            return GetNome() + "fez login no sistema.";
        }
    }
}
