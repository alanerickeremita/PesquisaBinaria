namespace PesquisaBinaria
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int[] lista = { 1, 3, 5, 7, 9, 11 };

      Console.WriteLine("Digite um valor: ");
      var valor = Console.ReadLine();
      Console.WriteLine(@"A posição do valor informado no array: { 1, 3, 5, 7, 9, 11 } é: " + PesquisaBinaria(lista, Convert.ToInt32(valor)));
    }

    private static int? PesquisaBinaria(int[] lista, int valor)
    {
      var minimo = 0;
      var maximo = lista.Length;

      while (minimo <= maximo)
      {
        var meio = (maximo + minimo) / 2;
        var chute = lista[meio];

        if (chute == valor)
          return meio;
        else if (chute > valor)
          maximo = meio - 1;
        else
          minimo = meio;
      }
      return null;
    }

  }
}