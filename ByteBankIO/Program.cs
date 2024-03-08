﻿using System.Text;

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

        var utf8 = new UTF8Encoding();
        var text = utf8.GetString(buffer);
        Console.WriteLine(text);
        /*foreach (var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }*/
    }

}
