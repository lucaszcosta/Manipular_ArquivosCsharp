using System.Text;

partial class Program
{
    static void Main()
    {
        var enderecoArquivo = "contas.txt";

        using(var fluxoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoArquivo);

            //var linha = leitor.ReadLine();
            //var text = leitor.ReadToEnd();

            while(!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }

        }


        Console.ReadLine();
    }


}
