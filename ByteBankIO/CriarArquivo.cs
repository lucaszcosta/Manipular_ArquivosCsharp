using System.Text;



partial class Program
{
    static void CriarArquivo()
    {
        var enderecoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDeArquivo = new FileStream(enderecoNovoArquivo, FileMode.Create))
        {
            var contaString = "456, 7895, 4785.40, Gustavo Santos";

            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(contaString);

            fluxoDeArquivo.Write(bytes, 0, bytes.Length);

        }
    }

    static void CriarArquivoComWriter()
    {

    }


    static void TestaEscrita()
    {
        var enderecoNovoArquivo = "teste.txt";

        using (var fluxoDeArquivo = new FileStream(enderecoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            for(int i =0 ; i < 100000;  i++)
            {
                escritor.WriteLine($"Linha {i}");
                escritor.Flush();
                Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter...");
                Console.ReadLine();
            }
        }
    }



}
