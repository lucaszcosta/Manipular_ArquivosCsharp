

partial class Program{
    static void UsarStreamEntrada()
    {

        using (var fluxoEntrada = Console.OpenStandardInput())
        using (var fs = new FileStream("entradaConsole.txt", FileMode.Create))
        {
            var buffer = new byte[1024]; //1kb

            while (true)
            {
                var bytesLidos = fluxoEntrada.Read(buffer, 0, buffer.Length);
                fs.Write(buffer, 0, bytesLidos);
                fs.Flush();
                

                Console.WriteLine($"Bytes lidos na console {bytesLidos}");
                
            }
        }
    }
}
