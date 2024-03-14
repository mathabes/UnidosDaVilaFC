namespace UnidosDaVilaFC.Models
{
    public class Patrocinio
    {
        public int Id { get; set; }

        public string Logo { get; set; }

        public string Marca { get; set; }

        private double Verba { get; set;}

        public int PrazoContrato { get; set; }

        public Patrocinio(int id, string logo, string marca, double verba, int prazoContrato)
        {
            Id = id;
            Logo = logo ?? throw new ArgumentNullException(nameof(logo));
            Marca = marca ?? throw new ArgumentNullException(nameof(marca));
            Verba = verba;
            PrazoContrato = prazoContrato;
        }

        public double GetVerba()
        {
            return Verba;
        }
    }
}
