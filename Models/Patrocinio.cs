namespace UnidosDaVilaFC.Models
{
    public class Patrocinio
    {
        public int Id { get; set; }

        public string Marca { get; set; }

        private double Verba { get; set;}

        private DateTime PrazoContrato { get; set; }

        public Patrocinio(int id, string marca, double verba, DateTime prazoContrato)
        {
            Id = id;
            Marca = marca ?? throw new ArgumentNullException(nameof(marca));
            Verba = verba;
            PrazoContrato = prazoContrato;
        }

        public double GetVerba()
        {
            return Verba;
        }

        public DateTime GetPrazoContrato()
        {
            return PrazoContrato;
        }
    }
}
