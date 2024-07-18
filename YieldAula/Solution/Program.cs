using Solution;

class Program
{
    private static void Main(string[] args)
    {
        var carros = GeradorDeCarros();

        foreach (var carro in carros)
        {
            //Usando apenas os carros com NumeroDeSerie menor que 5
            //if (carro.NumeroDeSerie == 5)
            //{
            //    break;
            //}

            Console.WriteLine(carro);
        }
    }

    //O yield return sem retorna uma unidade de alguma coisa
    //O yield return memoriza quando foi a ultima vez que você usou o yield return em seu código e então ele "volta lá"
    public static IEnumerable<Carro> GeradorDeCarros()
    {
        //var carros = new List<Carro>();
        Console.WriteLine("Passei pelo método GeradorDeCarros");
        Console.WriteLine("\r\n");

        for (var i = 1; i <= 100; i++)
        {
            if (i == 5) // Supondo que você queira parar a geração quando i for igual a 5
            {
                yield break; // Isso encerra a iteração do loop e, consequentemente, a geração de carros
            }

            //carros.Add(new Carro(Guid.NewGuid(), i));
            yield return new Carro(Guid.NewGuid(), i);
        }

        //return carros;
    }
}