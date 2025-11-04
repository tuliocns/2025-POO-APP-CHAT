public class Facebook
{
    public void EnviarMensagem(string usuario, TextMessage message)
    {
        Console.WriteLine($"Enviando mensagem de texto para o usuário {numero}");
    }

     public void EnviarMensagem(string usuario, VideoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de vídeo para o usuário {numero}");
    }

     public void EnviarMensagem(string usuario, PhotoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de foto para o usuário {numero}");
    }

     public void EnviarMensagem(string usuario, FileMessage message)
    {
        Console.WriteLine($"Enviando mensagem de arquivo para o usuário {numero}");
    }
}