namespace PesquisaBinaria
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int[] lista = { 1, 3, 5, 7, 9, 11 };

      Console.WriteLine("Digite um valor: ");
      var valor = Console.ReadLine();
      var retornoPesquisa = PesquisaBinaria(lista, Convert.ToInt32(valor));

      if (retornoPesquisa.HasValue)
        Console.WriteLine(@"A posição do valor informado no array: { 1, 3, 5, 7, 9, 11 } é: " + retornoPesquisa);
      else
        Console.WriteLine(@"O valor informado: " + valor + " ,não existe no array: { 1, 3, 5, 7, 9, 11 }");
    }

    private static int? PesquisaBinaria(int[] lista, int valor)
    {
      var minimo = 0;
      var maximo = lista.Length;

      while (minimo < maximo)
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