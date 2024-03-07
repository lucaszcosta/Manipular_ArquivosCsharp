class Program
{
    static void Main()
    {
        string nomeArquivo = "contas.txt";
        var numeroDeBytesLidos = -1;


        var fluxoDoArquivo = new FileStream(nomeArquivo, FileMode.Open);
        var buffer = new byte[1024]; //1kb


        
        while(numeroDeBytesLidos != 0)
        {
            numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
            EscreverBuffer(buffer);
        }


        
        
        Console.ReadLine();
    }

    static void EscreverBuffer(byte[] buffer)
    {
        foreach (var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }
    }

}
