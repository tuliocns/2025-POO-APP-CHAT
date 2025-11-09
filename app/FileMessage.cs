public class FileMessage
{
    public string Arquivo { get; set; }
    public string Formato { get; set; }

    public FileMessage(string arquivo, string formato)
    {
        Arquivo = arquivo;
        Formato = formato;
    }
}
