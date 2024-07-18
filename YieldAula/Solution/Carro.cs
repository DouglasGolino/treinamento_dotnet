namespace Solution
{
    public class Carro
    {
        public Carro(Guid id, int numeroDeSerie)
        {
            Id = id;
            NumeroDeSerie = numeroDeSerie;
            Console.WriteLine($"Novo Carro Gerado! NumeroDeSerie: {NumeroDeSerie}");
        }

        public Guid Id { get; private set; }

        public int NumeroDeSerie { get; private set; }

        public override string ToString() => $"Carro Id: {Id} e NumeroDeSerie: {NumeroDeSerie}";
    }
}