using Solution;

class Program
{
    private static void Main(string[] args)
    {
        var carros = GeradorDeCarro();

        foreach (var carro in carros)
        {
            //Usando apenas os carros com NumeroDeSerie menor que 5
            if (carro.NumeroDeSerie == 5)
            {
                break;
            }

            Console.WriteLine(carro);
        }
    }

    //Criando 100 objetos do tipo Carro
    public static IEnumerable<Carro> GeradorDeCarro()
    {
        var carros = new List<Carro>();

        for (var i = 1; i <= 100; i++)
        {
            carros.Add(new Carro(Guid.NewGuid(), i));
        }

        Console.WriteLine("\r\n");

        return carros;
    }
}