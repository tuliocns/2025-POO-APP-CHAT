public class Telegram
{
    public void EnviarMensagem(long numero, TextMessage message)
    {
        Console.WriteLine($"Enviando mensagem de texto para o número {numero}");
    }

    public void EnviarMensagem(string username, TextMessage message)
    {
        Console.WriteLine($"Enviando mensagem de texto para o usuário {username}");
    }

     public void EnviarMensagem(string numero, VideoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de vídeo para o número {numero}");
    }

     public void EnviarMensagem(string numero, PhotoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de foto para o número {numero}");
    }

     public void EnviarMensagem(string numero, FileMessage message)
    {
        Console.WriteLine($"Enviando mensagem de arquivo para o número {numero}");
    }
}