public class VideoMessage
{
    public string Arquivo { get; set; }
    public string Formato { get; set; }
    public int Duracao { get; set; }

    public VideoMessage(string arquivo, string formato, int duracao)
    {
        Arquivo = arquivo;
        Formato = formato;
        Duracao = duracao;
    }
}
