using System.Text;

partial class Program
{
    static void FileStream()
    {
        string nomeArquivo = "contas.txt";
        var numeroDeBytesLidos = -1;


        using (var fluxoDoArquivo = new FileStream(nomeArquivo, FileMode.Open))
        {
            var buffer = new byte[1024]; //1kb

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, buffer.Length);
                Console.WriteLine($"\nBites lidos: {numeroDeBytesLidos}");

                EscreverBuffer(buffer, numeroDeBytesLidos);
            }

            fluxoDoArquivo.Close();

        };




        Console.ReadLine();
    }

    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {

        var utf8 = new UTF8Encoding();
        var text = utf8.GetString(buffer, 0, bytesLidos);

        Console.Write(text);


    }

}
