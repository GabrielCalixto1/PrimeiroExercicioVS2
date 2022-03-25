public class Program


{

    static void Main(string[] args)
    {
        var numerosMaisUm = new List<int>();
        var numeros = new List<int>();
        var strings = new List<string>();
        for (var contador = 0; contador < 10; contador++)
        {
            numeros.Add(contador);
            numerosMaisUm.Add(contador + 10);
            strings.Add(contador.ToString());
        }
        numeros.AddRange(numerosMaisUm);
        var tentativaUm = numeros.Remove(5 + 6);

        var indexString = strings.IndexOf(Console.ReadLine());
        var indexCinco = numeros.IndexOf(int.Parse(Console.ReadLine()));
        var posicaoDoMeuNome = numeros.ElementAt(3);
        var valorNaPosicaoTres = numeros.ElementAt(3);
        var valorPar = numeros.Find(numero => numero % 2 == 0);
        var valoresPares = numeros.Where(numero => numero % 2 == 0);
        var valoresParesDois = numeros.FindAll(numero => numero % 2 == 0);21

        Console.WriteLine("Finalizou");
    }